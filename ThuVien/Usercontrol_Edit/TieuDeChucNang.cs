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
    public partial class TieuDeChucNang : UserControl
    {

        public TieuDeChucNang()
        {
            InitializeComponent();
            lbl_TieuDe.Dock = DockStyle.Fill;
            lbl_TieuDe.TextAlign = ContentAlignment.MiddleCenter;
        }

        public Label LblTieuDe
        {
            get => lbl_TieuDe;
            set => lbl_TieuDe = value;
        }
    }
}
