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

            capQuyenTaiKhoan1.ThemClicked += CapQuyenTaiKhoan1_ThemClicked;
            capQuyenTaiKhoan1.XoaClicked += CapQuyenTaiKhoan1_XoaClicked;
            capQuyenTaiKhoan1.SuaClicked += CapQuyenTaiKhoan1_SuaClicked;
            capQuyenTaiKhoan1.LuuClicked += CapQuyenTaiKhoan1_LuuClicked;
            this.Load += Frm_CapTaiKhoan_Load;
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
