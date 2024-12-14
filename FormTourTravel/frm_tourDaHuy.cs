using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ThuVien;

namespace FormTourTravel
{
    public partial class frm_tourDaHuy : Form
    {
        PhieuHuyBLL phieuHuyBLL = new PhieuHuyBLL();
        public frm_tourDaHuy()
        {
            InitializeComponent();
            loadDgv();
            loadCboThang();
        }

        private void loadDgv()
        {
            dgv_phieuhuytour.DataSource = phieuHuyBLL.LayDanhSachPhieuHuy();
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            ThuVien.Code.ExportExcel exportExcel = new ThuVien.Code.ExportExcel();
            exportExcel.ExportToExcelWithHeader(dgv_phieuhuytour, "Các tour đã hủy");
        }

        private void loadCboThang()
        {
            var thangList = new List<string>
            {
                "Tháng 1",
                "Tháng 2",
                "Tháng 3",
                "Tháng 4",
                "Tháng 5",
                "Tháng 6",
                "Tháng 7",
                "Tháng 8",
                "Tháng 9",
                "Tháng 10",
                "Tháng 11",
                "Tháng 12"
            };
            cbo_thang.DataSource = thangList;
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = cbo_thang.SelectedIndex + 1;
                
                dgv_phieuhuytour.DataSource = phieuHuyBLL.LayDanhSachPhieuHuyTheoThang(thang);
                if(dgv_phieuhuytour.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tìm thấy " + dgv_phieuhuytour.Rows.Count + " kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void frm_tourDaHuy_Load(object sender, EventArgs e)
        {

        }
    }
}
