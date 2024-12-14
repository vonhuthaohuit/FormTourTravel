using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTourTravel
{
    public partial class frm_tourDaHuy : Form
    {
        PhieuHuyBLL phieuHuyBLL = new PhieuHuyBLL();
        public frm_tourDaHuy()
        {
            InitializeComponent();
            loadDgv();
        }

        private void loadDgv()
        {
            dgv_phieuhuytour.DataSource = phieuHuyBLL.LayDanhSachPhieuHuy();
        }
    }
}
