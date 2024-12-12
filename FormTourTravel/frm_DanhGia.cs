using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace FormTourTravel
{
    public partial class frm_DanhGia : XtraForm
    {
        private DanhGiaBLL danhGiaBLL = new DanhGiaBLL();
        public frm_DanhGia()
        {
            InitializeComponent();

            gridControl.DataSource = GetDataSource();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
        }
        public BindingList<danhgia> GetDataSource()
        {
            BindingList<danhgia> result = new BindingList<danhgia>();
            danhGiaBLL.LayDanhSachDanhGia().ForEach(x => result.Add(x));

            return result;
        }
        
        private void labelControl_Click(object sender, EventArgs e)
        {

        }
    }
}
