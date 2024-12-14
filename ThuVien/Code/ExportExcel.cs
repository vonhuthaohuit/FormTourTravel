using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ThuVien.Code
{
    public class ExportExcel
    {
        public void ExportToExcelWithHeader(DataGridView dgv, string headerTitle)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "DanhSach";

                worksheet.Cells[1, 1] = headerTitle;
                Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv.Columns.Count]];
                headerRange.Merge();
                headerRange.Font.Size = 16;
                headerRange.Font.Bold = true;
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[2, i + 1] = dgv.Columns[i].HeaderText;
                    worksheet.Cells[2, i + 1].Font.Bold = true;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 3, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                Excel.Range usedRange = worksheet.UsedRange;
                usedRange.Columns.AutoFit();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Lưu file Excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo");
                }

                workbook.Close(false, Type.Missing, Type.Missing);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xuất Excel: " + ex.Message, "Lỗi");
            }
        }
    }
}
