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

namespace FormTourTravel
{
    public partial class frm_NhanVien : Form
    {
        private NhanVienBLL nhanVienBll = new NhanVienBLL();
        private PhongBanBLL phongBanBll = new PhongBanBLL();
        private string[] gioiTinhArray = new string[] {"Nam", "Nữ", "Không xác định", "Khác"};
        public frm_NhanVien()
        {
            InitializeComponent();
        }
    }
}
