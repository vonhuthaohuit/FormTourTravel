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

namespace FormTourTravel
{
    public partial class frm_HuyTour : Form
    {
        TourBLL tourBLL = new TourBLL();
        public frm_HuyTour()
        {
            InitializeComponent();
            loadDGV();
        }

        private void loadDGV()
        {
            dgv_huytour.DataSource = tourBLL.LayTourDaDat();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string nguoiDaiDien = txt_nguoidaidien.Text; 
            DateTime? ngayDatTour = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : (DateTime?)null;

            var tours = tourBLL.TimKiemHoaDonVaPhieuDat(nguoiDaiDien, ngayDatTour);

            if (tours.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tour");
            }
            else
            {
                dgv_huytour.DataSource = tours;
            }

        }

        private void dgv_huytour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            int matour = Convert.ToInt32(dgv_huytour.CurrentRow.Cells["matour"].Value);
            string nguoidaidien = dgv_huytour.CurrentRow.Cells["nguoidaidien"].Value.ToString();
            DateTime? ngaydattour = Convert.ToDateTime(dgv_huytour.CurrentRow.Cells["ngaydattour"].Value);

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn hủy tour không?",
                                                "Xác nhận hủy tour",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (tourBLL.HuyTour(matour, nguoidaidien, ngaydattour.Value))
                {
                    MessageBox.Show("Hủy tour thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Hủy tour thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
