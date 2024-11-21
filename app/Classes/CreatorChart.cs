using Guna.Charts.WinForms;
using System;
using System.Windows.Forms;
using System.Data;
namespace app.Classes
{
    internal class CreatorChart
    {
        public bool checkEmpty(DataTable dataTable)
        {
            return dataTable.Rows.Count > 0;
        }

        public void ChartPie(GunaChart chart, DataTable data, string nameChart)
        {
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();
                chart.Legend.Position = LegendPosition.Right;
                chart.Legend.Display = true;
                chart.XAxes.Display = false;
                chart.YAxes.Display = false;
                chart.Title.Text = nameChart;
                var datasetТканей = new GunaPieDataset();
                datasetТканей.Label = "Количество Изделий по Тканям";
                foreach (DataRow row in data.Rows)
                {
                    datasetТканей.DataPoints.Add(
                        Convert.ToString(row["ВидТкани"]),
                        Convert.ToDouble(row["КоличествоИзделий"])
                    );
                }
                chart.Datasets.Add(datasetТканей);
            }
            else
            MyCustomMessageBox.ShowMessage("Данных не достаточно.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ChartBar(GunaChart chart, DataTable data, string nameChart)
        {
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();
                chart.Legend.Display = false;
                chart.YAxes.GridLines.Display = false;
                chart.XAxes.Display = true;
                chart.YAxes.Display = true;
                chart.Title.Text = nameChart;
                var dataset = new GunaBarDataset();
                dataset.Label = "Количество Изделий";
                foreach (DataRow row in data.Rows)
                {
                    dataset.DataPoints.Add(
                        Convert.ToString(row["НазваниеИзделия"]),
                        Convert.ToDouble(row["КоличествоИзделий"])
                    );
                }
                chart.Datasets.Add(dataset);
            }
            else
                MyCustomMessageBox.ShowMessage("Данных не достаточно.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ChartHorizontalBar(GunaChart chart, DataTable data, string nameChart)
        {
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();
                chart.Legend.Display = true;
                chart.XAxes.Display = true;
                chart.YAxes.Display = true;
                chart.Title.Text = nameChart;
                var datasetОтходов = new GunaHorizontalBarDataset();
                datasetОтходов.Label = "Количество Отходов";
                foreach (DataRow row in data.Rows)
                {
                    datasetОтходов.DataPoints.Add(
                        Convert.ToString(row["НазваниеИзделия"]),
                        Convert.ToDouble(row["КоличествоОтходов"])
                    );
                }
                chart.Datasets.Add(datasetОтходов);
                var datasetПроцентОтходов = new GunaHorizontalBarDataset();
                datasetПроцентОтходов.Label = "Процент Отходов";
                foreach (DataRow row in data.Rows)
                {
                    datasetПроцентОтходов.DataPoints.Add(
                        Convert.ToString(row["НазваниеИзделия"]),
                        Convert.ToDouble(row["ПроцентОтходов"])
                    );
                }
                chart.Datasets.Add(datasetПроцентОтходов);
            }
            else
                MyCustomMessageBox.ShowMessage("Данных не достаточно.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
