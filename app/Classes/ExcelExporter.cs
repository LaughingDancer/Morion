using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace app.Classes
{
    internal class ExcelExporter
    {
        public void ExportExcel(DataGridView myGrid)
        {
            if (myGrid == null || myGrid.Rows.Count <= 0)
            {
                MyCustomMessageBox.ShowMessage("Данные для экспорта не обнаружены.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (myGrid.Columns[j].Name != "DeleteColumn" && myGrid.Columns[j].Name != "EditColumn")
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
                        if (myGrid.Columns[j].Name != "DeleteColumn" && myGrid.Columns[j].Name != "EditColumn")
                        {
                            excelWorksheet.Cells[rowIndex, colIndex] = myGrid[j, i].Value?.ToString();
                            colIndex++;
                        }
                    }
                    rowIndex++;
                }
                excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[1, colIndex - 1]].Interior.Color = System.Drawing.Color.FromArgb(91, 161, 153);
                excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[rowIndex - 1, colIndex - 1]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                excelWorksheet.Columns.AutoFit();
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage($"Произошла ошибка при экспорте: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
