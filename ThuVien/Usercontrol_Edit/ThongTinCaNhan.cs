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
    public partial class ThongTinCaNhan : UserControl
    {
        public event EventHandler Btn_Luu;
        public ThongTinCaNhan()
        {
            InitializeComponent();
            btn_Luu.Click += Btn_Luu_Click;
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            Btn_Luu(this, EventArgs.Empty);
        }
    }
}
