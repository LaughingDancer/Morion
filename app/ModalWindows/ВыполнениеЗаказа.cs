using app.Classes;
using app.UserControlsSeamstress;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class ВыполнениеЗаказа : Form
    {
        public int КодЗаказа { get; set; }
        public int КоличествоИзделий { get; set; }
        public int КоличествоВыполненных { get; set; }
        private string НазваниеИзделия;
        private DB DB;
        private UC_ЗаказыШвея ucЗаказыШвея;
        public ВыполнениеЗаказа(int кодЗаказа, int количествоИзделий, int количествоВыполненных, UC_ЗаказыШвея ucЗаказыШвея)
        {
            InitializeComponent();
            DB = new DB();
            КодЗаказа = кодЗаказа;
            КоличествоИзделий = количествоИзделий;
            КоличествоВыполненных = количествоВыполненных;
            this.ucЗаказыШвея = ucЗаказыШвея;
            НазваниеИзделия = GetProductName(кодЗаказа);
            UpdateOrderInfoLabel();
        }
        private string GetProductName(int кодЗаказа)
        {
            string productName = string.Empty;
            string query = @"
SELECT 
    Изделия.НазваниеИзделия 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
WHERE 
    Заказы.КодЗаказа = @КодЗаказа";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@КодЗаказа", кодЗаказа);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    productName = reader.GetString(0);
                }
                reader.Close();
            }
            return productName;
        }
        private void UpdateOrderInfoLabel()
        {
            int осталосьВыполнить = КоличествоИзделий - КоличествоВыполненных;
            labelOrderInfo.Text = $"Заказ №{КодЗаказа} на изделие: {НазваниеИзделия}\nОсталось выполнить: {осталосьВыполнить}";
            labelOrderInfo.TextAlignment = ContentAlignment.MiddleCenter;
        }
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxCompleted.Text, out int дополнительноВыполнено))
            {
                if (дополнительноВыполнено <= 0)
                {
                    MyCustomMessageBox.ShowMessage("Количество выполненных изделий должно быть положительным числом.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int новыйКоличествоВыполненных = КоличествоВыполненных + дополнительноВыполнено;

                if (новыйКоличествоВыполненных >= 0 && новыйКоличествоВыполненных <= КоличествоИзделий)
                {
                    using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                    {
                        connection.Open();
                        string query = "UPDATE Заказы SET КоличествоВыполненных = @КоличествоВыполненных WHERE КодЗаказа = @КодЗаказа";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@КоличествоВыполненных", новыйКоличествоВыполненных);
                        command.Parameters.AddWithValue("@КодЗаказа", КодЗаказа);
                        command.ExecuteNonQuery();
                    }
                    this.DialogResult = DialogResult.OK;
                    ucЗаказыШвея.RefreshDataGridView();
                    this.Close();
                }
                else
                {
                    MyCustomMessageBox.ShowMessage("Количество выполненных изделий должно быть неотрицательным и не превышать общее количество изделий.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, введите корректное число.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxCompleted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonConfirm.PerformClick();
                e.Handled = true;
            }
        }
    }
}