using app.Classes;
using app.UserControls;
using app.UserControlsOperator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ДобавлениеИзделия(UC_Изделия ucИзделия)
        {
            InitializeComponent();
            this.ucИзделия = ucИзделия;
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

            if (!validator.ValidateFirstName(TextBoxProduct.Text))
            {
                MessageBox.Show("Некорректное значение для Названия Изделия.");
                isValid = false;
            }

            if (!decimal.TryParse(TextBoxDensity.Text, out _))
            {
                MessageBox.Show("Некорректное значение для Плотности.");
                isValid = false;
            }

            if (!decimal.TryParse(TextBoxLength.Text, out _))
            {
                MessageBox.Show("Некорректное значение для Необходимой Длины Ткани.");
                isValid = false;
            }

            if (!decimal.TryParse(TextBoxWidth.Text, out _))
            {
                MessageBox.Show("Некорректное значение для Необходимой Ширины Ткани.");
                isValid = false;
            }

            return isValid;
        }
        private void SaveProduct()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                // Выбор кода ткани в зависимости от выбора пользователя
                string selectFabricQuery = "SELECT TOP 1 КодТкани FROM Ткани WHERE Вид = @Вид";
                using (SqlCommand selectCommand = new SqlCommand(selectFabricQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Вид", ComboBoxFabric.SelectedItem.ToString());
                    int fabricId = Convert.ToInt32(selectCommand.ExecuteScalar());

                    // Преобразование строковых значений в числовые
                    decimal density = decimal.Parse(TextBoxDensity.Text);
                    decimal requiredLength = decimal.Parse(TextBoxLength.Text);
                    decimal requiredWidth = decimal.Parse(TextBoxWidth.Text);

                    // Вставка данных в таблицу Изделия
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

                        // Вставка данных в таблицу Размеры
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
                MessageBox.Show("Изделие успешно добавлено!");
                ucИзделия.RefreshDataGridView();
                this.Close();
            }
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
