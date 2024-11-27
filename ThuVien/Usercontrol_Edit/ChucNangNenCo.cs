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
    public partial class ChucNangNenCo : UserControl
    {
        public event EventHandler ThemClicked;
        public event EventHandler XoaClicked;
        public event EventHandler SuaClicked;
        public event EventHandler LuuClicked;
        public event EventHandler ThoatClicked;
        public event EventHandler LamMoiClicked;
        public ChucNangNenCo()
        {
            InitializeComponent();
            btn_Them.Click += Btn_Them_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Luu.Click += Btn_Luu_Click;
            btn_Thoat.Click += Btn_Thoat_Click;
            btn_clear.Click += Btn_clear_Click;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            LamMoiClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            ThoatClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            LuuClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            SuaClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaClicked?.Invoke(this, EventArgs.Empty);
        }

        public void Btn_Them_Click(object sender, EventArgs e)
        {
            ThemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
