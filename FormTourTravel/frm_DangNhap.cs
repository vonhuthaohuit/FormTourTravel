using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Usercontrol_Edit;
using DTO;
using BLL;


namespace FormTourTravel
{
    public partial class frm_DangNhap : Form
    {
        private readonly UsersBLL usersBll;

        public frm_DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            usersBll = new UsersBLL();
            dangNhap1.Btn_DangNhapClick += DangNhap1_Btn_DangNhapClick;
        }

        private void DangNhap1_Btn_DangNhapClick(object sender, string[] e)
        {
            string username = e[0];
            string password = e[1];

            if (usersBll.kiemTraDangNhap(username, password))
            {
                long maTaiKhoan = usersBll.layMaTaiKhoan(username, password);
                long nhomQuyen = usersBll.kiemTraNhomQuyen(maTaiKhoan);

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Main frm_main = new frm_Main(nhomQuyen);
                frm_main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}