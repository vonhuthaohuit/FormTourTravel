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
using ThuVien.Usercontrol_Edit;

namespace FormTourTravel
{
	public partial class frm_CapTaiKhoan : Form
	{
		private UsersBLL usersBll = new UsersBLL();
		private RoleBLL roleBll = new RoleBLL();
		public frm_CapTaiKhoan()
		{
			InitializeComponent();

            //capQuyenTaiKhoan1.ThemClicked += CapQuyenTaiKhoan1_ThemClicked;
            //capQuyenTaiKhoan1.XoaClicked += CapQuyenTaiKhoan1_XoaClicked;
            //capQuyenTaiKhoan1.SuaClicked += CapQuyenTaiKhoan1_SuaClicked;
            //capQuyenTaiKhoan1.LuuClicked += CapQuyenTaiKhoan1_LuuClicked;
            capQuyenTaiKhoan1.XoaClicked += CapQuyenTaiKhoan1_XoaClicked1;
            capQuyenTaiKhoan1.ThemClicked += CapQuyenTaiKhoan1_ThemClicked1;
            capQuyenTaiKhoan1.SuaClicked += CapQuyenTaiKhoan1_SuaClicked1;
			this.Load += Frm_CapTaiKhoan_Load;
		}

        private void CapQuyenTaiKhoan1_SuaClicked1(object sender, string[] e)
        {
            try
            {
                string mataikhoan = e[0];
                string tentaikhoan = e[1];
                string email = e[2];
                string matkhau = e[3];
                string trangthai = e[4];
                string manhomquyen = e[5];

                user user = new user()
                {
                    mataikhoan = Convert.ToInt32(mataikhoan),
                    tentaikhoan = tentaikhoan,
                    email = email,
                    matkhau = matkhau,
                    trangthai = trangthai,
                    manhomquyen = Convert.ToInt32(manhomquyen)
                };

                if (usersBll.SuaUser(user))
                {
                    MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void CapQuyenTaiKhoan1_ThemClicked1(object sender, string[] e)
        {
            try
            {
                string tentaikhoan = e[0];
                string email = e[1];
                string matkhau = e[2];
                string trangthai = e[3];
                string manhomquyen = e[4];

                user user = new user()
                {
                    tentaikhoan = tentaikhoan,
                    email = email,
                    matkhau = matkhau,
                    trangthai = trangthai,
                    manhomquyen = Convert.ToInt32(manhomquyen)
                };

                if (usersBll.ThemUser(user))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void CapQuyenTaiKhoan1_XoaClicked1(object sender, string[] e)
        {
            try
            {
                string mataikhoan = e[0];
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa tài khoản này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (usersBll.XoaUser(Convert.ToInt32(mataikhoan)))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void loadDGV()
        {
            capQuyenTaiKhoan1.DataSourceDatagirdView = usersBll.LayTatCaUser();
        }

        private void Frm_CapTaiKhoan_Load(object sender, EventArgs e)
		{
			capQuyenTaiKhoan1.DataSourceDatagirdView = usersBll.LayTatCaUser();
			capQuyenTaiKhoan1.CboTaiKhoan_DataSource = usersBll.LayTatCaUser();
			capQuyenTaiKhoan1.CboNhomQuyen_DataSource = roleBll.LayNhomQuyen();
		}

		private void CapQuyenTaiKhoan1_LuuClicked(object sender, EventArgs e)
		{

		}

		private void CapQuyenTaiKhoan1_SuaClicked(object sender, EventArgs e)
		{

		}

		private void CapQuyenTaiKhoan1_XoaClicked(object sender, EventArgs e)
		{

		}

		private void CapQuyenTaiKhoan1_ThemClicked(object sender, EventArgs e)
		{

		}
	}
}
