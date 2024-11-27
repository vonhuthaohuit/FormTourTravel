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
    public partial class ThongTinTaiKhoan : UserControl
    {
        public event EventHandler Btn_QuenMatKhau;
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            btn_QuenMatKhau.Click += Btn_QuenMatKhau_Click;
        }

        private void Btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            Btn_QuenMatKhau?.Invoke(this, EventArgs.Empty);
        }
    }
}
