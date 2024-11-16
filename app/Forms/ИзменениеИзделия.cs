using app.Classes;
using app.UserControls;
using app.UserControlsOperator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Убедитесь, что ComboBoxSize заполнен данными
            FillComboBoxSize();

            // Установите значение sizeName в ComboBoxSize
            ComboBoxSize.Text = sizeName;

            TextBoxLength.Text = length;
            TextBoxWidth.Text = width;
            TextBoxDensity.Text = density;
            ComboBoxFabric.Text = fabricId;

            LoadProductDetails();
        }
        private void FillComboBoxSize()
        {
            // Заполните ComboBoxSize данными из базы данных
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
                TextBoxProduct.Text = productDetails.Name; // Устанавливаем название изделия
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
                    int fabricId = GetFabricIdByName(ComboBoxFabric.Text); // Получаем код ткани по его названию
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateProduct();
            UpdatePhoto();

            MyCustomMessageBox.ShowMessage("Данные успешно обновлены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucИзделия.RefreshDataGridView();
            Close();
        }
    }
}
