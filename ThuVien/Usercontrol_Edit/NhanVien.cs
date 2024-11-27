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
    public partial class NhanVien : UserControl
    {
        public event EventHandler ThemClicked;
        public event EventHandler XoaClicked;
        public event EventHandler SuaClicked;
        public event EventHandler LuuClicked;
        public event EventHandler LamMoiClicked;
        public NhanVien()
        {
            InitializeComponent();
            chucNangNenCo1.ThemClicked += (s, e) => ThemClicked?.Invoke(this, e);
            chucNangNenCo1.XoaClicked += (s, e) => XoaClicked?.Invoke(this, e);
            chucNangNenCo1.SuaClicked += (s, e) => SuaClicked?.Invoke(this, e);
            chucNangNenCo1.LuuClicked += (s, e) => LuuClicked?.Invoke(this, e);
            chucNangNenCo1.LamMoiClicked += (s, e) => LamMoiClicked?.Invoke(this, e);
        }

        public object DataSourceDgvDanhSachNhanVien
        {
            get => dgv_DanhSachNhanVien.DataSource;
            set => dgv_DanhSachNhanVien.DataSource = value;
        }
        public object ChoGioiTinh_DataSource
        {
            get => cbo_GioiTinh.DataSource;
            set
            {
                cbo_GioiTinh.DataSource = value;

                cbo_GioiTinh.DisplayMember = "gioitinh";
                cbo_GioiTinh.ValueMember = "id";
            }
        }
        public object CboPhongBan_DataSource
        {
            get => cbo_PhongBan.DataSource;
            set
            {
                cbo_PhongBan.DataSource = value;

                cbo_PhongBan.DisplayMember = "name";
                cbo_PhongBan.ValueMember = "id";
            }
        }
    }
}
