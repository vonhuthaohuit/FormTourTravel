using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace FormTourTravel
{
    public partial class frm_KhuyenMai : Form
    {
        private DiscountBLL khuyenMaiBll = new DiscountBLL();
        public frm_KhuyenMai()
        {
            InitializeComponent();
            this.Load += Frm_KhuyenMai_Load;
            khuyenMai1.ThemClicked += KhuyenMai1_ThemClicked;
            khuyenMai1.XoaClicked += KhuyenMai1_XoaClicked;
            khuyenMai1.SuaClicked += KhuyenMai1_SuaClicked;
        }

        private void KhuyenMai1_SuaClicked(object sender, string[] e)
        {
            try
            {
                int maKhuyenMai = Convert.ToInt32(e[0]);
                string thoigianbatdau = e[1];
                string thoigianketthuc = e[2];
                string phantramgiam = e[3];

                khuyenmai km = new khuyenmai()
                {
                    makhuyenmai = maKhuyenMai,
                    thoigianbatdau = Convert.ToDateTime(thoigianbatdau),
                    thoigianketthuc = Convert.ToDateTime(thoigianketthuc),
                    phantramgiam = Convert.ToInt32(phantramgiam)
                };

                if (khuyenMaiBll.SuaKhuyenMai(km))
                {
                    MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa khuyến mãi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void KhuyenMai1_XoaClicked(object sender, string[] e)
        {
            try
            {
                int maKhuyenMai = Convert.ToInt32(e[0]);
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khuyến mãi này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (khuyenMaiBll.XoaKhuyenMai(maKhuyenMai))
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khuyến mãi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void KhuyenMai1_ThemClicked(object sender, string[] e)
        {
            try
            {
                string thoigianbatdau = e[0];
                string thoigianketthuc = e[1];
                string phantramgiam = e[2];

                khuyenmai km = new khuyenmai()
                {
                    thoigianbatdau = Convert.ToDateTime(thoigianbatdau),
                    thoigianketthuc = Convert.ToDateTime(thoigianketthuc),
                    phantramgiam = Convert.ToInt32(phantramgiam)
                };

                if (khuyenMaiBll.ThemKhuyenMai(km))
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm khuyến mãi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");

            }
        }
        private void Frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            khuyenMai1.DataSourceDatagirdView = khuyenMaiBll.Laykhuyenmai();
        }
    }
}
