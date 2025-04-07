using app.Classes;
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
        public void SetSelectedBrigade(int brigadeId)
        {
            foreach (DataRowView item in BrigadesComboBox.Items)
            {
                if (Convert.ToInt32(item["КодБригады"]) == brigadeId)
                {
                    BrigadesComboBox.SelectedItem = item;
                    break;
                }
            }
        }
        private void LoadBrigades()
        {
            try
            {
                string query = "SELECT КодБригады, НазваниеБригады FROM Бригады";
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    dt.Load(command.ExecuteReader());
                }

                // Добавьте строку "Выберите Бригаду"
                DataRow row = dt.NewRow();
                row["КодБригады"] = -1; // Используйте -1 или другое значение, которое не может быть КодБригады
                row["НазваниеБригады"] = "Выберите Бригаду";
                dt.Rows.InsertAt(row, 0);

                BrigadesComboBox.DisplayMember = "НазваниеБригады";
                BrigadesComboBox.ValueMember = "КодБригады";
                BrigadesComboBox.DataSource = dt;

                // Установите выбранное значение по умолчанию
                BrigadesComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки бригад: {ex.Message}");
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
                MessageBox.Show("Пожалуйста, выберите бригаду");
                return;
            }

            SelectedBrigadeId = (int)BrigadesComboBox.SelectedValue;
            onConfirm?.Invoke();
            this.Close();
        }
    }
}
