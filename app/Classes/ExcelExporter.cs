using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Classes
{
    internal class ExcelExporter
    {
        public void ExportExcel(DataGridView myGrid)
        {
            if (myGrid == null || myGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Данные для экспорта не обнаружены.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            var excelWorkbook = excelApp.Workbooks.Add();
            var excelWorksheet = excelWorkbook.Sheets[1];

            try
            {
                int colIndex = 1;
                for (int j = 0; j < myGrid.Columns.Count; j++)
                {
                    if (myGrid.Columns[j].Name != "DeleteColumn" && myGrid.Columns[j].Name != "EditColumn") // Игнорируем столбцы "Удалить" и "EditColumn"
                    {
                        excelWorksheet.Cells[1, colIndex] = myGrid.Columns[j].HeaderText;
                        colIndex++;
                    }
                }

                int rowIndex = 2;
                for (int i = 0; i < myGrid.Rows.Count; i++)
                {
                    colIndex = 1;
                    for (int j = 0; j < myGrid.Columns.Count; j++)
                    {
                        if (myGrid.Columns[j].Name != "DeleteColumn" && myGrid.Columns[j].Name != "EditColumn") // Игнорируем столбцы "Удалить" и "EditColumn"
                        {
                            excelWorksheet.Cells[rowIndex, colIndex] = myGrid[j, i].Value?.ToString();
                            colIndex++;
                        }
                    }
                    rowIndex++;
                }

                // Добавляем цвет фона для заголовков
                excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[1, colIndex - 1]].Interior.Color = System.Drawing.Color.FromArgb(91, 161, 153);

                // Добавляем границы для всей таблицы
                excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[rowIndex - 1, colIndex - 1]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                // Автоподбор ширины столбцов
                excelWorksheet.Columns.AutoFit();

                // Делаем Excel видимым
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при экспорте: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Marshal.ReleaseComObject(excelWorksheet);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
