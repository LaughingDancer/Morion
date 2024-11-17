using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                //config chart
                chart.Legend.Position = LegendPosition.Right;
                chart.Legend.Display = true;
                chart.XAxes.Display = false;
                chart.YAxes.Display = false;
                chart.Title.Text = nameChart;

                // Создаем серию данных для количества изделий по тканям
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
                MessageBox.Show("Данных не достаточно.", "Ошибка");
        }

        public void ChartBar(GunaChart chart, DataTable data, string nameChart)
        {
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();
                //Chart configuration 
                chart.Legend.Display = false;
                chart.YAxes.GridLines.Display = false;
                chart.XAxes.Display = true;
                chart.YAxes.Display = true;
                chart.Title.Text = nameChart;

                var dataset = new GunaBarDataset();
                dataset.Label = "Количество Изделий"; // Устанавливаем метку для датасета
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
                MessageBox.Show("Данных не достаточно.", "Ошибка");
        }

        public void ChartHorizontalBar(GunaChart chart, DataTable data, string nameChart)
        {
            if (checkEmpty(data))
            {
                chart.Datasets.Clear();

                //config chart
                chart.Legend.Display = true;
                chart.XAxes.Display = true;
                chart.YAxes.Display = true;
                chart.Title.Text = nameChart;

                // Создаем серию данных для количества отходов
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

                // Создаем серию данных для процента отходов
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
                MessageBox.Show("Данных не достаточно.", "Ошибка");
        }

        public void ChartPolar(GunaChart chart, DataTable data, string nameChart)
        {
            if (checkEmpty(data))
            {
                //Chart configuration  
                chart.Legend.Position = LegendPosition.Right;
                chart.XAxes.Display = false;
                chart.YAxes.Display = false;
                chart.Legend.Display = true;

                chart.Datasets.Clear();
                var dataset = new GunaPolarAreaDataset();
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
                MessageBox.Show("Данных не достаточно.", "Ошибка");
        }
    }
}
