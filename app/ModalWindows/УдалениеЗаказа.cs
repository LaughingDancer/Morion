using app.Classes;
using app.UserControlsOperator;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class УдалениеЗаказа : Form
    {
        private int orderId;
        private string productName;
        private UC_Заказы ucДеталиЗаказов;
        private DB DB;
        public УдалениеЗаказа(int orderId, string productName, UC_Заказы ucДеталиЗаказов)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.productName = productName;
            this.ucДеталиЗаказов = ucДеталиЗаказов;
            DB = new DB();
            labelOrderInfo.Text = $"Заказ №{orderId} на изделие: {productName}";
            labelOrderInfo.TextAlignment = ContentAlignment.MiddleCenter;
            labelOrderInfo.Location = new Point(
                (this.ClientSize.Width - labelOrderInfo.Width) / 2,
                (this.ClientSize.Height - labelOrderInfo.Height) / 2);
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MyCustomMessageBox.ShowMessage("Вы уверены, что хотите удалить заказ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string queryDeleteOrder = "DELETE FROM Заказы WHERE КодЗаказа = @КодЗаказа";
                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryDeleteOrder, connection))
                    {
                        command.Parameters.AddWithValue("@КодЗаказа", orderId);
                        command.ExecuteNonQuery();
                    }
                }
                ucДеталиЗаказов.RefreshDataGridView();
                Close();
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Действие отменено.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
