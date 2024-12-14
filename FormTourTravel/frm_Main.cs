using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormTourTravel
{
    public partial class frm_Main : Form
    {
        // 900, 500 size mỗi panel
        public long NhomQuyen { get; set; }

        public frm_Main(long nhomQuyen)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.WindowState = FormWindowState.Normal;

            this.NhomQuyen = nhomQuyen;
            PhanQuyenChoTaiKhoan();
        }

        private void PhanQuyenChoTaiKhoan()
        {
            if (NhomQuyen == 1)
            {
                EnableMenuItems(true);
            }
            else if (NhomQuyen == 2)
            {
                EnableMenuItems(true); 

                menuMain.Items["phânCôngNhânViênToolStripMenuItem"].Enabled = false;

                if (menuMain.Items["tàiKhoảnToolStripMenuItem"] is ToolStripMenuItem taiKhoanMenuItem)
                {
                    taiKhoanMenuItem.DropDownItems["cấpTàiKhoảnToolStripMenuItem"].Enabled = false;
                }
            }
        }

        public void ShowFormInPanel(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);
            childForm.Show();
        }

        private void EnableMenuItems(bool enable)
        {
            foreach (ToolStripMenuItem item in menuMain.Items)
            {
                item.Enabled = enable;
            }
        }


        private void cấpTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_CapTaiKhoan frmCapTaiKhoan = new frm_CapTaiKhoan();
            //ShowFormInPanel(frmCapTaiKhoan);
            //tieuDeChucNang1.LblTieuDe.Text = "Cấp Tài Khoản";
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinTaiKhoan frmThongTinTaiKhoan = new frm_ThongTinTaiKhoan();
            ShowFormInPanel(frmThongTinTaiKhoan);
            tieuDeChucNang1.LblTieuDe.Text = "Thông tin tài khoản";
        }
    }
}
