using app.Classes;
using app.UserControlsOperator;
using Guna.UI2.WinForms.Suite;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class ИзменениеИзделия : Form
    {
        private string width;
        private string sizeName;
        private int productId;
        private string length;
        private string fabricId;
        private string density;
        private int sizeId;
        private string productName;
        private DB DB;
        private byte[] selectedPhotoBytes;
        private UC_Изделия ucИзделия;
        public ИзменениеИзделия(int sizeId, string sizeName, int productId, string productName, string length, string width, string density, string fabricId, UC_Изделия ucИзделия)
        {
            InitializeComponent();
            this.sizeId = sizeId;
            this.sizeName = sizeName;
            this.productId = productId;
            this.productName = productName;
            this.length = length;
            this.width = width;
            this.density = density;
            this.fabricId = fabricId;
            DB = new DB();
            this.ucИзделия = ucИзделия;
            FillComboBoxSize();
            ComboBoxSize.Text = sizeName;
            TextBoxLength.Text = length;
            TextBoxWidth.Text = width;
            TextBoxDensity.Text = density;
            ComboBoxFabric.Text = fabricId;
            LoadProductDetails();
        }
        private void FillComboBoxSize()
        {
            string query = "SELECT DISTINCT НазваниеРазмер FROM Размеры";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComboBoxSize.Items.Add(reader["НазваниеРазмер"].ToString());
                        }
                    }
                }
            }
        }
        private void LoadProductDetails()
        {
            var productDetails = DB.GetProductDetails(productId);
            if (productDetails.Name != null)
            {
                TextBoxProduct.Text = productDetails.Name;
            }
            else
            {
                TextBoxProduct.Text = "Название не найдено";
            }
            if (productDetails.Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(productDetails.Photo))
                {
                    pictureSet.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureSet.Image = Properties.Resources.default_photo;
            }
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
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateSize()
        {
            string queryUpdateSize = "UPDATE Размеры SET НазваниеРазмер = @НазваниеРазмер, НеобходимаяДлинаТкани = @НеобходимаяДлинаТкани, НеобходимаяШиринаТкани = @НеобходимаяШиринаТкани WHERE КодРазмера = @КодРазмера";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryUpdateSize, connection))
                {
                    command.Parameters.AddWithValue("@НазваниеРазмер", ComboBoxSize.Text);
                    command.Parameters.AddWithValue("@НеобходимаяДлинаТкани", decimal.Parse(TextBoxLength.Text));
                    command.Parameters.AddWithValue("@НеобходимаяШиринаТкани", decimal.Parse(TextBoxWidth.Text));
                    command.Parameters.AddWithValue("@КодРазмера", sizeId);
                    command.ExecuteNonQuery();
                }
            }
        }
        private int GetFabricIdByName(string fabricName)
        {
            string query = "SELECT КодТкани FROM Ткани WHERE Вид = @Вид";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Вид", fabricName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Ткань с таким названием не найдена.");
                    }
                }
            }
        }
        private void UpdateProduct()
        {
            string queryUpdateProduct = "UPDATE Изделия SET НазваниеИзделия = @НазваниеИзделия, Плотность = @Плотность, КодТкани = @КодТкани WHERE КодИзделия = @КодИзделия";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryUpdateProduct, connection))
                {
                    command.Parameters.AddWithValue("@НазваниеИзделия", TextBoxProduct.Text);
                    command.Parameters.AddWithValue("@Плотность", decimal.Parse(TextBoxDensity.Text));
                    int fabricId = GetFabricIdByName(ComboBoxFabric.Text);
                    command.Parameters.AddWithValue("@КодТкани", fabricId);
                    command.Parameters.AddWithValue("@КодИзделия", productId);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void UpdatePhoto()
        {
            if (selectedPhotoBytes != null)
            {
                string queryUpPhoto = "UPDATE Изделия SET Фото = @Фото WHERE КодИзделия = @КодИзделия";
                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryUpPhoto, connection))
                    {
                        command.Parameters.AddWithValue("@Фото", selectedPhotoBytes);
                        command.Parameters.AddWithValue("@КодИзделия", productId);
                        command.ExecuteNonQuery();
                    }
                }
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
            return isValid;
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                UpdateSize();
                UpdateProduct();
                UpdatePhoto();
                MyCustomMessageBox.ShowMessage("Данные успешно обновлены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucИзделия.RefreshDataGridView();
                Close();
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
                buttonChange.PerformClick();
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
                buttonChange.PerformClick();
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
                buttonChange.PerformClick();
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
                buttonChange.PerformClick();
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
                buttonChange.PerformClick();
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
                buttonChange.PerformClick();
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