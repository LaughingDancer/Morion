using app.Classes;
using app.ModalWindows;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace app.UserControlsOperator
{
    public partial class UC_ОформитьЗаказ : UserControl
    {
        private bool FDDComboBoxFabric1 = true;
        private DB DB;
        private int employeeId;
        public UC_ОформитьЗаказ(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            DB = new DB();
            ComboBoxFabric1.Items.Insert(0, "Ткань");
            ComboBoxFabric1.SelectedIndex = 0;
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
            string типТкани = ComboBoxFabric1.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                SqlCommand command = new SqlCommand("CalculateOptimization", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@длина", длинаТкани);
                command.Parameters.AddWithValue("@ширина", ширинаТкани);
                command.Parameters.AddWithValue("@количество", количествоТкани);
                command.Parameters.AddWithValue("@типТкани", типТкани);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                foreach (DataRow row in resultTable.Rows)
                {
                    row["КоличествоОтходов"] = Convert.ToDecimal(row["КоличествоОтходов"]).ToString("N2");
                    row["ПроцентОтходов"] = Convert.ToDecimal(row["ПроцентОтходов"]).ToString("N2");
                }
                DataGridViewOptimizationOptions.DataSource = resultTable;
                if (DataGridViewOptimizationOptions.Columns.Count > 0)
                {
                    DataGridViewOptimizationOptions.Columns["Изделие"].HeaderText = "Изделие";
                    DataGridViewOptimizationOptions.Columns["Размер"].HeaderText = "Размер";
                    DataGridViewOptimizationOptions.Columns["КоличествоИзделий"].HeaderText = "Количество (шт)";
                    DataGridViewOptimizationOptions.Columns["КоличествоОтходов"].HeaderText = "Отходы (м)";
                    DataGridViewOptimizationOptions.Columns["ПроцентОтходов"].HeaderText = "Отходы (%)";
                    DataGridViewOptimizationOptions.Columns["ДатаСоздания"].HeaderText = "Дата Создания";
                }
            }
        }
        private void DataGridViewOptimizationOptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DataGridViewOptimizationOptions.Rows[e.RowIndex];
                    string изделие = row.Cells["Изделие"].Value.ToString();
                    string размер = row.Cells["Размер"].Value.ToString();
                    int количествоИзделий = Convert.ToInt32(row.Cells["КоличествоИзделий"].Value);
                    decimal количествоОтходов = Convert.ToDecimal(row.Cells["КоличествоОтходов"].Value);
                    decimal процентОтходов = Convert.ToDecimal(row.Cells["ПроцентОтходов"].Value);
                    string типТкани = ComboBoxFabric1.SelectedItem.ToString();
                    double длинаТкани = double.Parse(TextBoxLenght1.Text);
                    double ширинаТкани = double.Parse(TextBoxWidth1.Text);
                    double количествоТкани = double.Parse(TextBoxAmountFabric1.Text);
                    decimal общаяСтоимость = CalculateTotalCost(типТкани, количествоИзделий);
                    string orderInfo = $"Изделие: {изделие}\n" +
                  $"Размер: {размер}\n" +
                  $"Количество: {количествоИзделий}\n" +
                  $"Ткань: {типТкани}\n" +
                  $"Общая стоимость: {общаяСтоимость:N2} руб.";
                    ДобавитьЗаказ orderForm = new ДобавитьЗаказ(orderInfo, () =>
                    {
                        CompleteOrder(
                            employeeId,
                            типТкани,
                            длинаТкани,
                            ширинаТкани,
                            количествоТкани,
                            изделие,
                            размер,
                            количествоИзделий,
                            количествоОтходов,
                            процентОтходов,
                            общаяСтоимость
                        );
                    });

                    orderForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage($"Ошибка: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CompleteOrder(
    int employeeId,
    string типТкани,
    double длинаТкани,
    double ширинаТкани,
    double количествоТкани,
    string изделие,
    string размер,
    int количествоИзделий,
    decimal количествоОтходов,
    decimal процентОтходов,
    decimal общаяСтоимость)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
                {
                    connection.Open();
                    string insertFabricQuery = @"INSERT INTO Ткани (Вид, Длина, Ширина, Количество) VALUES (@ТипТкани, @ДлинаТкани, @ШиринаТкани, @КоличествоТкани); SELECT SCOPE_IDENTITY();";
                    SqlCommand insertFabricCommand = new SqlCommand(insertFabricQuery, connection);
                    insertFabricCommand.Parameters.AddWithValue("@ТипТкани", типТкани);
                    insertFabricCommand.Parameters.AddWithValue("@ДлинаТкани", длинаТкани);
                    insertFabricCommand.Parameters.AddWithValue("@ШиринаТкани", ширинаТкани);
                    insertFabricCommand.Parameters.AddWithValue("@КоличествоТкани", количествоТкани);
                    int кодТкани = Convert.ToInt32(insertFabricCommand.ExecuteScalar());
                    string insertOptimizationQuery = @"INSERT INTO ВариантыОптимизации (КодСотрудника, КодТкани, КодИзделия, КодРазмера, КоличествоИзделий, КоличествоОтходов, ПроцентОтходов, ДатаСоздания) VALUES (@КодСотрудника, @КодТкани, (SELECT TOP 1 КодИзделия FROM Изделия WHERE НазваниеИзделия = @Изделие), (SELECT TOP 1 КодРазмера FROM Размеры WHERE НазваниеРазмер = @Размер), @КоличествоИзделий, @КоличествоОтходов, @ПроцентОтходов, GETDATE()); SELECT SCOPE_IDENTITY();";
                    SqlCommand insertOptimizationCommand = new SqlCommand(insertOptimizationQuery, connection);
                    insertOptimizationCommand.Parameters.AddWithValue("@КодСотрудника", employeeId);
                    insertOptimizationCommand.Parameters.AddWithValue("@КодТкани", кодТкани);
                    insertOptimizationCommand.Parameters.AddWithValue("@Изделие", изделие);
                    insertOptimizationCommand.Parameters.AddWithValue("@Размер", размер);
                    insertOptimizationCommand.Parameters.AddWithValue("@КоличествоИзделий", количествоИзделий);
                    insertOptimizationCommand.Parameters.AddWithValue("@КоличествоОтходов", количествоОтходов);
                    insertOptimizationCommand.Parameters.AddWithValue("@ПроцентОтходов", процентОтходов);
                    int кодОптимизации = Convert.ToInt32(insertOptimizationCommand.ExecuteScalar());
                    string insertOrderQuery = @"INSERT INTO Заказы (КодОптимизации, ОбщаяСтоимость, КоличествоВыполненных, КодБригады) VALUES (@КодОптимизации, @ОбщаяСтоимость, 0, @КодБригады)";
                    SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
                    insertOrderCommand.Parameters.AddWithValue("@КодОптимизации", кодОптимизации);
                    insertOrderCommand.Parameters.AddWithValue("@ОбщаяСтоимость", общаяСтоимость);
                    insertOrderCommand.Parameters.AddWithValue("@КодБригады", ДобавитьЗаказ.SelectedBrigadeId);
                    insertOrderCommand.ExecuteNonQuery();
                    MyCustomMessageBox.ShowMessage("Заказ успешно оформлен!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage($"Ошибка при оформлении заказа: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static decimal CalculateTotalCost(string типТкани, int количествоИзделий)
        {
            decimal fabricPrice = 0;
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                string query = @"SELECT ЦенаЗаМетр FROM Ткани WHERE Вид = @ТипТкани";
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
    }
}