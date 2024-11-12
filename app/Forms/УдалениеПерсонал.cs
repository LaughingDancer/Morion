using app.Classes;
using app.UserControls;
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
    public partial class УдалениеПерсонал : Form
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private DB DB;
        private UC_Персонал ucПерсонал;
        public УдалениеПерсонал(int employeeId, string firstName, string lastName, UC_Персонал ucПерсонал)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ucПерсонал = ucПерсонал;
            DB = new DB();

            labelEmployeeInfo.Text = $"{lastName} {firstName}";
            labelEmployeeInfo.TextAlignment = ContentAlignment.MiddleCenter;
            labelEmployeeInfo.Location = new Point(
                (this.ClientSize.Width - labelEmployeeInfo.Width) / 2,
                (this.ClientSize.Height - labelEmployeeInfo.Height) / 2);
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            DialogResult result = MyCustomMessageBox.ShowMessage("Вы уверены, что хотите уволить сотрудника?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string queryDeleteEmployee = "DELETE FROM Сотрудники WHERE КодСотрудника = @КодСотрудника";
                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryDeleteEmployee, connection))
                    {
                        command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                        command.ExecuteNonQuery();
                    }
                }
                ucПерсонал.RefreshDataGridView();
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
