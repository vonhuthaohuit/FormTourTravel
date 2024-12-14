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
using Google.Protobuf.WellKnownTypes;

namespace FormTourTravel
{
    public partial class frm_DanhGia : XtraForm
    {
        private DanhGiaBLL danhGiaBLL = new DanhGiaBLL();
        public frm_DanhGia()
        {
            InitializeComponent();
            LoadDGV();
            loadCboTrangThai();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            //if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
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

        private void LoadDGV()
        {
            dgv_DanhGia.DataSource = danhGiaBLL.LayDanhSachDanhGia();

            if (dgv_DanhGia.Columns.Contains("makhachhang"))
            {
                dgv_DanhGia.Columns["makhachhang"].Visible = false;
            }
            if(dgv_DanhGia.Columns.Contains("tour"))
            {
                dgv_DanhGia.Columns["tour"].Visible = false;
            }
            if (dgv_DanhGia.Columns.Contains("khachhang"))
            {
                dgv_DanhGia.Columns["khachhang"].Visible = false;
            }
            if (dgv_DanhGia.Columns.Contains("matour"))
            {
                dgv_DanhGia.Columns["matour"].Visible = false;
            }
            dgv_DanhGia.CellFormatting += dgv_DanhGia_CellFormatting;
        }

        private void dgv_DanhGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DanhGia.Columns[e.ColumnIndex].Name == "tinhtrang")
            {
                if (e.Value != null && e.Value is int)
                {
                    int value = (int)e.Value;
                    e.Value = value == 0 ? "Ẩn" : "Hiển thị";
                    e.FormattingApplied = true;
                }
            }
        }

        private void loadCboTrangThai()
        {
            var trangThaiList = new List<string>
            {
                "Ẩn",
                "Hiển thị"
            };
            cbo_trangthai.DataSource = trangThaiList;
        }

        private void dgv_DanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var tinhtrangValue = dgv_DanhGia.Rows[e.RowIndex].Cells["tinhtrang"].Value;

                if (tinhtrangValue != null)
                {
                    string displayValue = tinhtrangValue.ToString() == "0" ? "Ẩn" : "Hiển thị";
                    cbo_trangthai.Text = displayValue;
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int tinhtrang = cbo_trangthai.Text == "Ẩn" ? 0 : 1;
            int madanhgia = Convert.ToInt32(dgv_DanhGia.CurrentRow.Cells["madanhgia"].Value);

            if (danhGiaBLL.LuuTinhTrang(tinhtrang, madanhgia))
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int madanhgia = Convert.ToInt32(dgv_DanhGia.CurrentRow.Cells["madanhgia"].Value);

            if (danhGiaBLL.XoaDanhGia(madanhgia))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
