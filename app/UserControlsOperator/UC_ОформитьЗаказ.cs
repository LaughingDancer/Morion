using app.Classes;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace app.UserControlsOperator
{
    public partial class UC_ОформитьЗаказ : UserControl
    {
        private bool FDDComboBoxSizes1 = true;
        private bool FDDComboBoxFabric1 = true;
        private DB DB;
        private int employeeId;
        public UC_ОформитьЗаказ(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            DB = new DB();
            ComboBoxSizes1.Items.Insert(0, "Размер");
            ComboBoxSizes1.SelectedIndex = 0;
            ComboBoxFabric1.Items.Insert(0, "Ткань");
            ComboBoxFabric1.SelectedIndex = 0;
        }
        private void ComboBoxSizes1_DropDown(object sender, EventArgs e)
        {
            if (FDDComboBoxSizes1 && ComboBoxSizes1.Items.Count > 0)
            {
                ComboBoxSizes1.Items.RemoveAt(0);
                FDDComboBoxSizes1 = false;
            }
        }
        private void ComboBoxSizes1_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBoxSizes1.SelectedIndex == -1)
            {
                ComboBoxSizes1.Items.Insert(0, "Размер");
                ComboBoxSizes1.SelectedIndex = 0;
                FDDComboBoxSizes1 = true;
            }
        }
        private void ComboBoxFabric1_DropDown(object sender, EventArgs e)
        {
            if (FDDComboBoxFabric1 && ComboBoxFabric1.Items.Count > 0)
            {
                ComboBoxFabric1.Items.RemoveAt(0);
                FDDComboBoxFabric1 = false;
            }
        }
        private void ComboBoxFabric1_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBoxFabric1.SelectedIndex == -1)
            {
                ComboBoxFabric1.Items.Insert(0, "Ткань");
                ComboBoxFabric1.SelectedIndex = 0;
                FDDComboBoxFabric1 = true;
            }
        }
        private void ButtonOrderСalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBoxLenght1.Text, out double длинаТкани) || !double.TryParse(TextBoxWidth1.Text, out double ширинаТкани) || !double.TryParse(TextBoxAmountFabric1.Text, out double количествоТкани))
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, введите корректные числовые значения для длины, ширины и количества ткани.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (длинаТкани <= 0 || ширинаТкани <= 0 || количествоТкани <= 0)
            {
                MyCustomMessageBox.ShowMessage("Длина, ширина и количество ткани должны быть положительными числами.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ComboBoxFabric1.SelectedItem == null || ComboBoxFabric1.SelectedItem.ToString() == "Ткань")
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, выберите тип ткани.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ComboBoxSizes1.SelectedItem == null || ComboBoxSizes1.SelectedItem.ToString() == "Размер")
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, выберите размер изделия.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Получение данных из полей
            string типТкани = ComboBoxFabric1.SelectedItem.ToString();
            string размерИзделия = ComboBoxSizes1.SelectedItem.ToString();

            // Подключение и выполнение хранимой процедуры
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                SqlCommand command = new SqlCommand("CalculateOptimization", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@длина", длинаТкани);
                command.Parameters.AddWithValue("@ширина", ширинаТкани);
                command.Parameters.AddWithValue("@количество", количествоТкани);
                command.Parameters.AddWithValue("@типТкани", типТкани);
                command.Parameters.AddWithValue("@размерИзделия", размерИзделия);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                foreach (DataRow row in resultTable.Rows)
                {
                    // Форматируем количество отходов и процент отходов с двумя знаками после запятой
                    row["КоличествоОтходов"] = Convert.ToDecimal(row["КоличествоОтходов"]).ToString("N2");
                    row["ПроцентОтходов"] = Convert.ToDecimal(row["ПроцентОтходов"]).ToString("N2");
                }
                DataGridViewOptimizationOptions.DataSource = resultTable;
            }
        }
        private void DataGridViewOptimizationOptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Убедитесь, что нажата строка, а не заголовок столбца
                if (e.RowIndex >= 0)
                {
                    // Получение данных выбранной строки
                    DataGridViewRow row = DataGridViewOptimizationOptions.Rows[e.RowIndex];
                    // Извлечение данных из строки
                    string изделие = row.Cells["Изделие"].Value.ToString();
                    string размер = row.Cells["Размер"].Value.ToString();
                    int количествоИзделий = Convert.ToInt32(row.Cells["КоличествоИзделий"].Value);
                    decimal количествоОтходов = Convert.ToDecimal(row.Cells["КоличествоОтходов"].Value);
                    decimal процентОтходов = Convert.ToDecimal(row.Cells["ПроцентОтходов"].Value);
                    DateTime датаСоздания = DateTime.Now;
                    // Получение данных о ткани из текстовых полей
                    double длинаТкани = double.Parse(TextBoxLenght1.Text);
                    double ширинаТкани = double.Parse(TextBoxWidth1.Text);
                    double количествоТкани = double.Parse(TextBoxAmountFabric1.Text);
                    string типТкани = ComboBoxFabric1.SelectedItem.ToString();
                    // Расчет общей стоимости
                    decimal общаяСтоимость = CalculateTotalCost(типТкани, количествоИзделий);
                    // Отображение окна подтверждения с общей стоимостью
                    DialogResult dialogResult = MyCustomMessageBox.ShowMessage($"Хотите добавить этот вариант оптимизации? Общая стоимость: {общаяСтоимость:N2}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                        {
                            connection.Open();
                            // 1. Вставка новой ткани в таблицу Ткани
                            string insertFabricQuery = @"
                    INSERT INTO Ткани (Вид, Длина, Ширина, Количество)
                    VALUES (@ТипТкани, @ДлинаТкани, @ШиринаТкани, @КоличествоТкани);
                    SELECT SCOPE_IDENTITY();";
                            SqlCommand insertFabricCommand = new SqlCommand(insertFabricQuery, connection);
                            insertFabricCommand.Parameters.AddWithValue("@ТипТкани", типТкани);
                            insertFabricCommand.Parameters.AddWithValue("@ДлинаТкани", длинаТкани);
                            insertFabricCommand.Parameters.AddWithValue("@ШиринаТкани", ширинаТкани);
                            insertFabricCommand.Parameters.AddWithValue("@КоличествоТкани", количествоТкани);
                            // Получение ID вставленной ткани
                            int кодТкани = Convert.ToInt32(insertFabricCommand.ExecuteScalar());
                            // 2. Вставка данных в таблицу ВариантыОптимизации с использованием кода новой ткани
                            string insertOptimizationQuery = @"
                    INSERT INTO ВариантыОптимизации 
                    (КодСотрудника, КодТкани, КодИзделия, КодРазмера, КоличествоИзделий, КоличествоОтходов, ПроцентОтходов, ДатаСоздания) 
                    VALUES 
                    (@КодСотрудника, @КодТкани, 
                     (SELECT TOP 1 КодИзделия FROM Изделия WHERE НазваниеИзделия = @Изделие), 
                     (SELECT TOP 1 КодРазмера FROM Размеры WHERE НазваниеРазмер = @Размер), 
                     @КоличествоИзделий, @КоличествоОтходов, @ПроцентОтходов, @ДатаСоздания);
                    SELECT SCOPE_IDENTITY();";
                            SqlCommand insertOptimizationCommand = new SqlCommand(insertOptimizationQuery, connection);
                            insertOptimizationCommand.Parameters.AddWithValue("@КодСотрудника", employeeId);
                            insertOptimizationCommand.Parameters.AddWithValue("@КодТкани", кодТкани);
                            insertOptimizationCommand.Parameters.AddWithValue("@Изделие", изделие);
                            insertOptimizationCommand.Parameters.AddWithValue("@Размер", размер);
                            insertOptimizationCommand.Parameters.AddWithValue("@КоличествоИзделий", количествоИзделий);
                            insertOptimizationCommand.Parameters.AddWithValue("@КоличествоОтходов", количествоОтходов);
                            insertOptimizationCommand.Parameters.AddWithValue("@ПроцентОтходов", процентОтходов);
                            insertOptimizationCommand.Parameters.AddWithValue("@ДатаСоздания", датаСоздания);
                            // Получение ID вставленного варианта оптимизации
                            int кодОптимизации = Convert.ToInt32(insertOptimizationCommand.ExecuteScalar());
                            // 3. Вставка данных в таблицу Заказы
                            string insertOrderQuery = @"
                    INSERT INTO Заказы (КодОптимизации, ОбщаяСтоимость, КоличествоВыполненных)
                    VALUES (@КодОптимизации, @ОбщаяСтоимость, @КоличествоВыполненных)";
                            SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
                            insertOrderCommand.Parameters.AddWithValue("@КодОптимизации", кодОптимизации);
                            insertOrderCommand.Parameters.AddWithValue("@ОбщаяСтоимость", общаяСтоимость);
                            insertOrderCommand.Parameters.AddWithValue("@КоличествоВыполненных", 0);
                            insertOrderCommand.ExecuteNonQuery();
                            MyCustomMessageBox.ShowMessage("Вариант оптимизации и заказ успешно добавлены в базу данных.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    else
                    {
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage($"Ошибка: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal CalculateTotalCost(string типТкани, int количествоИзделий)
        {
            decimal fabricPrice = 0;
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                string query = @"
            SELECT ЦенаЗаМетр 
            FROM Ткани 
            WHERE Вид = @ТипТкани";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ТипТкани", типТкани);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        fabricPrice = Convert.ToDecimal(result);
                    }
                }
            }
            return fabricPrice * количествоИзделий;
        }
        private void ButtonClearProduct_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            TextBoxLenght1.Text = string.Empty;
            TextBoxWidth1.Text = string.Empty;
            TextBoxAmountFabric1.Text = string.Empty;
            ComboBoxSizes1.Items.Insert(0, "Размер");
            ComboBoxSizes1.SelectedIndex = 0;
            FDDComboBoxSizes1 = true;
            ComboBoxFabric1.Items.Insert(0, "Ткань");
            ComboBoxFabric1.SelectedIndex = 0;
            FDDComboBoxFabric1 = true;
            DataGridViewOptimizationOptions.DataSource = null;
            DataGridViewOptimizationOptions.Rows.Clear();
        }
        private void TextBoxLenght1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TextBoxWidth1.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ButtonOrderСalculate.PerformClick();
                e.Handled = true;
            }
        }
        private void TextBoxWidth1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                TextBoxLenght1.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                TextBoxAmountFabric1.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ButtonOrderСalculate.PerformClick();
                e.Handled = true;
            }
        }
        private void TextBoxAmountFabric1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                TextBoxWidth1.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                ComboBoxFabric1.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ButtonOrderСalculate.PerformClick();
                e.Handled = true;
            }
        }
        private void ComboBoxFabric1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                TextBoxAmountFabric1.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                ComboBoxSizes1.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ButtonOrderСalculate.PerformClick();
                e.Handled = true;
            }
        }
        private void ComboBoxSizes1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ComboBoxFabric1.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ButtonOrderСalculate.PerformClick();
                e.Handled = true;
            }
        }
        private void ComboBoxFabric1_Enter(object sender, EventArgs e)
        {
            ComboBoxFabric1.DroppedDown = true;
        }
        private void ComboBoxSizes1_Enter(object sender, EventArgs e)
        {
            ComboBoxSizes1.DroppedDown = true;
        }
    }
}