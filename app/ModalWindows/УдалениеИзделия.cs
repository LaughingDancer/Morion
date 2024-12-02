using app.Classes;
using app.UserControlsOperator;
using System;
using System.Data.SqlClient;
using System.Drawing;
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
            DialogResult result = MyCustomMessageBox.ShowMessage("Вы уверены, что хотите удалить изделие?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteProduct(productId);
                ucИзделия.RefreshDataGridView();
                this.Close();
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Действие отменено.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                string deleteSizesQuery = "DELETE FROM Размеры WHERE КодИзделия = @КодИзделия";
                using (SqlCommand deleteSizesCommand = new SqlCommand(deleteSizesQuery, connection))
                {
                    deleteSizesCommand.Parameters.AddWithValue("@КодИзделия", productId);
                    deleteSizesCommand.ExecuteNonQuery();
                }
                string deleteProductQuery = "DELETE FROM Изделия WHERE КодИзделия = @КодИзделия";
                using (SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, connection))
                {
                    deleteProductCommand.Parameters.AddWithValue("@КодИзделия", productId);
                    deleteProductCommand.ExecuteNonQuery();
                }
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
