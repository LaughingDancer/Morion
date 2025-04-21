using app.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace app.ModalWindows
{
    public partial class ДобавитьЗаказ : Form
    {
        public static int SelectedBrigadeId { get; private set; }
        private Action onConfirm;
        private DB DB;
        public ДобавитьЗаказ(string orderInfo, Action onConfirm)
        {
            InitializeComponent();
            DB = new DB();
            this.onConfirm = onConfirm;
            labelOrderInfo.Text = orderInfo;
            LoadBrigades();
        }
        private void LoadBrigades()
        {
            try
            {
                string query = "SELECT КодБригады, НазваниеБригады FROM Бригады";
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    dt.Load(command.ExecuteReader());
                }
                DataRow row = dt.NewRow();
                row["КодБригады"] = -1;
                row["НазваниеБригады"] = "Выберите Бригаду";
                dt.Rows.InsertAt(row, 0);

                BrigadesComboBox.DisplayMember = "НазваниеБригады";
                BrigadesComboBox.ValueMember = "КодБригады";
                BrigadesComboBox.DataSource = dt;
                BrigadesComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage($"Ошибка загрузки бригад: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (BrigadesComboBox.SelectedValue == null || (int)BrigadesComboBox.SelectedValue == -1)
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, выберите бригаду", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SelectedBrigadeId = (int)BrigadesComboBox.SelectedValue;
            onConfirm?.Invoke();
            this.Close();
        }
    }
}
