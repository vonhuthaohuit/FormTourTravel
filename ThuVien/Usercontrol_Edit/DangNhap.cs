using System;
using System.Windows.Forms;

namespace ThuVien.Usercontrol_Edit
{
    public partial class DangNhap : UserControl
    {
        public event EventHandler<string[]> Btn_DangNhapClick; // Truyền username và password qua event

        public DangNhap()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btn_DangNhap.Click += Btn_DangNhap_Click;
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            TextBox txtUsername = this.Controls["txt_Username"] as TextBox;
            TextBox txtPassword = this.Controls["txt_Password"] as TextBox;

            if (txtUsername != null && txtPassword != null)
            {
                string userName = txtUsername.Text;
                string passWord = txtPassword.Text;

                Btn_DangNhapClick?.Invoke(this, new string[] { userName, passWord });
            }
            else
            {
                MessageBox.Show("Không tìm thấy TextBox `txt_Username` hoặc `txt_Password`.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}