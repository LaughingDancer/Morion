using app.Classes;
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
    public partial class ДобавлениеЗаказ : Form
    {
        private int productId;
        private string productName;
        private string size;
        private int quantity;
        private decimal waste;
        private decimal wastePercentage;
        private DateTime creationDate;
        private byte[] productPhoto;
        private decimal totalCost;
        private DB DB;
        public ДобавлениеЗаказ(int productId, string productName, string size, int quantity, decimal waste, decimal wastePercentage, DateTime creationDate, byte[] productPhoto)
        {
            InitializeComponent();
            DB = new DB();
            this.productId = productId;
            this.productName = productName;
            this.size = size;
            this.quantity = quantity;
            this.waste = waste;
            this.wastePercentage = wastePercentage;
            this.creationDate = creationDate;
            this.productPhoto = productPhoto;

            TextBoxProductName.Text = productName;
            TextBoxSize.Text = size;
            TextBoxQuantity.Text = quantity.ToString();
            TextBoxWaste.Text = waste.ToString("N2");
            TextBoxWastePercentage.Text = wastePercentage.ToString("N2");
            TextBoxCreationDate.Text = creationDate.ToString("dd.MM.yyyy");

            if (productPhoto != null)
            {
                using (MemoryStream ms = new MemoryStream(productPhoto))
                {
                    PictureBoxProductPhoto.Image = Image.FromStream(ms);
                }
            }

            // Расчет общей стоимости
            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            // Получение цены ткани из базы данных
            decimal fabricPrice = GetFabricPrice(productId);

            // Расчет общей стоимости
            totalCost = fabricPrice * quantity;

            // Отображение общей стоимости
            TextBoxTotalCost.Text = totalCost.ToString("N2");
        }

        private decimal GetFabricPrice(int productId)
        {
            decimal fabricPrice = 0;
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                string query = @"
                SELECT ЦенаЗаМетр 
                FROM Ткани 
                WHERE КодТкани = (SELECT КодТкани FROM Изделия WHERE КодИзделия = @ProductId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        fabricPrice = Convert.ToDecimal(result);
                    }
                }
            }
            return fabricPrice;
        }
    }
}
