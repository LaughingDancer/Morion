using app.Classes;
using app.UserControlsOperator;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace app.Forms
{
    public partial class ДобавлениеИзделия : Form
    {
        private byte[] selectedPhotoBytes;
        private DB DB;
        private string con = @"Data Source=MAKSIMN;Initial Catalog=Морион;Integrated Security=True";
        private UC_Изделия ucИзделия;
        private bool FDDComboBoxSize = true;
        private bool FDDComboBoxFabric = true;
        public ДобавлениеИзделия(UC_Изделия ucИзделия)
        {
            InitializeComponent();
            this.ucИзделия = ucИзделия;
            ComboBoxSize.Items.Insert(0, "Размер");
            ComboBoxSize.SelectedIndex = 0;
            ComboBoxFabric.Items.Insert(0, "Ткань");
            ComboBoxFabric.SelectedIndex = 0;
        }
        private void pictureSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                pictureSet.Image = Image.FromFile(selectedFile);
                selectedPhotoBytes = File.ReadAllBytes(selectedFile);
            }
        }
        private bool ValidateInput()
        {
            ValidationData.Validation validator = new ValidationData.Validation();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(TextBoxProduct.Text))
            {
                MyCustomMessageBox.ShowMessage("Название Изделия не может быть пустым.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (!validator.ValidateFirstName(TextBoxProduct.Text))
            {
                MyCustomMessageBox.ShowMessage("Некорректное значение для Названия Изделия.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TextBoxDensity.Text))
            {
                MyCustomMessageBox.ShowMessage("Плотность не может быть пустой.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (!decimal.TryParse(TextBoxDensity.Text, out decimal density))
            {
                MyCustomMessageBox.ShowMessage("Некорректное значение для Плотности.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (density <= 0)
            {
                MyCustomMessageBox.ShowMessage("Плотность должна быть положительным числом.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TextBoxLength.Text))
            {
                MyCustomMessageBox.ShowMessage("Необходимая Длина Ткани не может быть пустой.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (!decimal.TryParse(TextBoxLength.Text, out decimal length))
            {
                MyCustomMessageBox.ShowMessage("Некорректное значение для Необходимой Длины Ткани.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (length <= 0)
            {
                MyCustomMessageBox.ShowMessage("Необходимая Длина Ткани должна быть положительным числом.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TextBoxWidth.Text))
            {
                MyCustomMessageBox.ShowMessage("Необходимая Ширина Ткани не может быть пустой.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (!decimal.TryParse(TextBoxWidth.Text, out decimal width))
            {
                MyCustomMessageBox.ShowMessage("Некорректное значение для Необходимой Ширины Ткани.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (width <= 0)
            {
                MyCustomMessageBox.ShowMessage("Необходимая Ширина Ткани должна быть положительным числом.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (ComboBoxFabric.SelectedItem == null || ComboBoxFabric.SelectedItem.ToString() == "Ткань")
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, выберите тип ткани.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (ComboBoxSize.SelectedItem == null || ComboBoxSize.SelectedItem.ToString() == "Размер")
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, выберите размер изделия.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (selectedPhotoBytes == null || selectedPhotoBytes.Length == 0)
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, загрузите фотографию изделия.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            return isValid;
        }
        private void SaveProduct()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                string selectFabricQuery = "SELECT TOP 1 КодТкани FROM Ткани WHERE Вид = @Вид";
                using (SqlCommand selectCommand = new SqlCommand(selectFabricQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Вид", ComboBoxFabric.SelectedItem.ToString());
                    int fabricId = Convert.ToInt32(selectCommand.ExecuteScalar());
                    decimal density = decimal.Parse(TextBoxDensity.Text);
                    decimal requiredLength = decimal.Parse(TextBoxLength.Text);
                    decimal requiredWidth = decimal.Parse(TextBoxWidth.Text);
                    string insertProductQuery = "INSERT INTO Изделия (НазваниеИзделия, Плотность, КодТкани, Фото) " +
                                                "VALUES (@НазваниеИзделия, @Плотность, @КодТкани, @Фото); " +
                                                "SELECT SCOPE_IDENTITY();";
                    using (SqlCommand productCommand = new SqlCommand(insertProductQuery, connection))
                    {
                        productCommand.Parameters.AddWithValue("@НазваниеИзделия", TextBoxProduct.Text);
                        productCommand.Parameters.AddWithValue("@Плотность", density);
                        productCommand.Parameters.AddWithValue("@КодТкани", fabricId);
                        productCommand.Parameters.AddWithValue("@Фото", selectedPhotoBytes);
                        int productId = Convert.ToInt32(productCommand.ExecuteScalar());
                        string insertSizeQuery = "INSERT INTO Размеры (НазваниеРазмер, КодИзделия, НеобходимаяДлинаТкани, НеобходимаяШиринаТкани) " +
                                                 "VALUES (@НазваниеРазмер, @КодИзделия, @НеобходимаяДлинаТкани, @НеобходимаяШиринаТкани);";
                        using (SqlCommand sizeCommand = new SqlCommand(insertSizeQuery, connection))
                        {
                            sizeCommand.Parameters.AddWithValue("@НазваниеРазмер", ComboBoxSize.SelectedItem.ToString());
                            sizeCommand.Parameters.AddWithValue("@КодИзделия", productId);
                            sizeCommand.Parameters.AddWithValue("@НеобходимаяДлинаТкани", requiredLength);
                            sizeCommand.Parameters.AddWithValue("@НеобходимаяШиринаТкани", requiredWidth);
                            sizeCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveProduct();
                MyCustomMessageBox.ShowMessage("Изделие успешно добавлено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucИзделия.RefreshDataGridView();
                this.Close();
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ComboBoxSize_DropDown(object sender, EventArgs e)
        {
            if (FDDComboBoxSize && ComboBoxSize.Items.Count > 0)
            {
                ComboBoxSize.Items.RemoveAt(0);
                FDDComboBoxSize = false;
            }
        }
        private void ComboBoxSize_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBoxSize.SelectedIndex == -1)
            {
                ComboBoxSize.Items.Insert(0, "Размер");
                ComboBoxSize.SelectedIndex = 0;
                FDDComboBoxSize = true;
            }
        }
        private void ComboBoxFabric_DropDown(object sender, EventArgs e)
        {
            if (FDDComboBoxFabric && ComboBoxFabric.Items.Count > 0)
            {
                ComboBoxFabric.Items.RemoveAt(0);
                FDDComboBoxFabric = false;
            }
        }
        private void ComboBoxFabric_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBoxFabric.SelectedIndex == -1)
            {
                ComboBoxFabric.Items.Insert(0, "Ткань");
                ComboBoxFabric.SelectedIndex = 0;
                FDDComboBoxFabric = true;
            }
        }
        private void TextBoxProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ComboBoxSize.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void ComboBoxSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TextBoxProduct.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                TextBoxLength.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void TextBoxLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ComboBoxSize.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                TextBoxWidth.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void TextBoxWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TextBoxLength.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                TextBoxDensity.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void TextBoxDensity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TextBoxWidth.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                ComboBoxFabric.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void ComboBoxFabric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TextBoxDensity.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void ComboBoxSize_Enter(object sender, EventArgs e)
        {
            ComboBoxSize.DroppedDown = true;
        }
        private void ComboBoxFabric_Enter(object sender, EventArgs e)
        {
            ComboBoxFabric.DroppedDown = true;
        }
    }
}