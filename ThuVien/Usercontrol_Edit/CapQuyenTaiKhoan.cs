using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Usercontrol_Edit
{
    public partial class CapQuyenTaiKhoan : UserControl
    {
        public event EventHandler ThemClicked;
        public event EventHandler XoaClicked;
        public event EventHandler SuaClicked;
        public event EventHandler LuuClicked;
        public event EventHandler LamMoiClicked;
        public CapQuyenTaiKhoan()
        {
            InitializeComponent();
            chucNangNenCo1.ThemClicked += (s, e) => ThemClicked?.Invoke(this, e);
            chucNangNenCo1.XoaClicked += (s, e) => XoaClicked?.Invoke(this, e);
            chucNangNenCo1.SuaClicked += (s, e) => SuaClicked?.Invoke(this, e);
            chucNangNenCo1.LuuClicked += (s, e) => LuuClicked?.Invoke(this, e);
            chucNangNenCo1.LamMoiClicked += (s, e) => LamMoiClicked?.Invoke(this, e);
        }

        public object DataSourceDatagirdView
        {
            get => dgv_TaiKhoan.DataSource;
            set => dgv_TaiKhoan.DataSource = value;
        }
        public object CboTaiKhoan_DataSource
        {
            get => cbo_TaiKhoan.DataSource;
            set
            {
                cbo_TaiKhoan.DataSource = value;

                cbo_TaiKhoan.DisplayMember = "username";
                cbo_TaiKhoan.ValueMember = "id"; 
            }
        }
        public object CboNhomQuyen_DataSource
        {
            get => cbo_NhomQuyen.DataSource;
            set
            {
                cbo_NhomQuyen.DataSource = value;

                cbo_NhomQuyen.DisplayMember = "name";
                cbo_NhomQuyen.ValueMember = "id";
            }
        }
    }
}
