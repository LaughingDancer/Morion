using app.Classes;
using app.UserControlsOperator;
using app.UserControlsSeamstress;
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
            // Получаем название изделия
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
                    MessageBox.Show("Количество выполненных изделий должно быть неотрицательным и не превышать общее количество изделий.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное число.");
            }
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}