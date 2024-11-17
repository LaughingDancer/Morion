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
using Guna.Charts.WinForms;
using Guna.Charts.Interfaces;

namespace app.UserControlsStatistics
{
    public partial class UC_Статистика : UserControl
    {
        private DB DB;
        private CreatorChart creatorChart;
        public UC_Статистика()
        {
            InitializeComponent();
            DB = new DB();
            creatorChart = new CreatorChart();
        }

        private void UC_Статистика_Load(object sender, EventArgs e)
        {
            DataTable dataTable = DB.GetOptimizationData();
            creatorChart.ChartBar(gunaChart1, dataTable, "Статистика Заказанных Изделий");
        }

        private void ButtonChartPie_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DB.GetOptimizationData();
            creatorChart.ChartHorizontalBar(gunaChart1, dataTable, "Статистика Отходов");
        }

        private void ButtonChartBar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DB.GetOptimizationData();
            creatorChart.ChartBar(gunaChart1, dataTable, "Статистика Заказанных Изделий");
        }

        private void ButtonChartPie_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = DB.GetChartFabric();
            creatorChart.ChartPie(gunaChart1, dataTable, "Статистика Использования Тканей");
        }
    }
}