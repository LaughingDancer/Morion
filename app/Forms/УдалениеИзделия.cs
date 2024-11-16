using app.Classes;
using app.UserControls;
using app.UserControlsOperator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class УдалениеИзделия : Form
    {
        private DB DB;
        private UC_Изделия ucИзделия;
        private int productId;
        private string productName;
        public УдалениеИзделия(int productId, string productName, UC_Изделия ucИзделия)
        {
            InitializeComponent();
            this.ucИзделия = ucИзделия;
            this.productId = productId;
            this.productName = productName;
            DB = new DB();

            labelEmployeeInfo.Text = $"{productName}";
            labelEmployeeInfo.TextAlignment = ContentAlignment.MiddleCenter;
            labelEmployeeInfo.Location = new Point(
                (this.ClientSize.Width - labelEmployeeInfo.Width) / 2,
                (this.ClientSize.Height - labelEmployeeInfo.Height) / 2);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct(productId);
            MessageBox.Show("Изделие успешно удалено!");
            ucИзделия.RefreshDataGridView();
            this.Close();
        }
        private void DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();

                // Удаление связанных записей в таблице Размеры
                string deleteSizesQuery = "DELETE FROM Размеры WHERE КодИзделия = @КодИзделия";
                using (SqlCommand deleteSizesCommand = new SqlCommand(deleteSizesQuery, connection))
                {
                    deleteSizesCommand.Parameters.AddWithValue("@КодИзделия", productId);
                    deleteSizesCommand.ExecuteNonQuery();
                }

                // Удаление изделия
                string deleteProductQuery = "DELETE FROM Изделия WHERE КодИзделия = @КодИзделия";
                using (SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, connection))
                {
                    deleteProductCommand.Parameters.AddWithValue("@КодИзделия", productId);
                    deleteProductCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
