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
                try
                {
                    using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();

                        try
                        {
                            // 1. Проверяем статус текущего заказа
                            string checkStatusQuery = "SELECT Статус FROM Заказы WHERE КодЗаказа = @КодЗаказа";
                            string status;

                            using (SqlCommand command = new SqlCommand(checkStatusQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@КодЗаказа", orderId);
                                status = command.ExecuteScalar()?.ToString();
                            }

                            if (status != "Выполнено")
                            {
                                MyCustomMessageBox.ShowMessage("Можно удалять только выполненные заказы!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // 2. Проверяем, все ли заказы с этим вариантом оптимизации выполнены
                            string checkRelatedOrdersQuery = @"
                        SELECT COUNT(*) 
                        FROM Заказы z
                        JOIN ВариантыОптимизации vo ON z.КодОптимизации = vo.КодОптимизации
                        WHERE vo.КодОптимизации = (
                            SELECT КодОптимизации 
                            FROM Заказы 
                            WHERE КодЗаказа = @КодЗаказа
                        )
                        AND z.Статус != 'Выполнено'";

                            int unfinishedCount;
                            using (SqlCommand command = new SqlCommand(checkRelatedOrdersQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@КодЗаказа", orderId);
                                unfinishedCount = Convert.ToInt32(command.ExecuteScalar());
                            }

                            if (unfinishedCount > 0)
                            {
                                MyCustomMessageBox.ShowMessage("Нельзя удалить заказ, пока есть невыполненные заказы с этим вариантом оптимизации!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // 3. Удаляем заказ (триггеры сами удалят вариант оптимизации и ткань при необходимости)
                            string deleteOrderQuery = "DELETE FROM Заказы WHERE КодЗаказа = @КодЗаказа";
                            using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@КодЗаказа", orderId);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            ucДеталиЗаказов.RefreshDataGridView();
                            MyCustomMessageBox.ShowMessage("Заказ успешно удален!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MyCustomMessageBox.ShowMessage($"Ошибка при удалении заказа: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MyCustomMessageBox.ShowMessage($"Ошибка подключения к базе данных: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Close();
                }
            }
        }
    }
}