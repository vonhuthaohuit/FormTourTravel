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
    public partial class HoaDon : UserControl
    {
        public event EventHandler ThemClicked;
        public event EventHandler XoaClicked;
        public event EventHandler SuaClicked;
        public event EventHandler LuuClicked;
        public event EventHandler LamMoiClicked;
        public event EventHandler<DataGridViewCellEventArgs> dgv_CellClick;

        public HoaDon()
        {
            InitializeComponent();
            chucNangNenCo1.ThemClicked += (s, e) => ThemClicked?.Invoke(this, e);
            chucNangNenCo1.XoaClicked += (s, e) => XoaClicked?.Invoke(this, e);
            chucNangNenCo1.SuaClicked += (s, e) => SuaClicked?.Invoke(this, e);
            chucNangNenCo1.LuuClicked += (s, e) => LuuClicked?.Invoke(this, e);
            chucNangNenCo1.LamMoiClicked += (s, e) => LamMoiClicked?.Invoke(this, e);
            dgv_HoaDon.CellClick += (s, e) => dgv_CellClick?.Invoke(this, e);
            dgv_HoaDon.CellClick += Dgv_HoaDon_CellClick;
            dgv_HoaDon.CellValueChanged += Dgv_HoaDon_CellValueChanged;
        }

        private void Dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var row = dgv_HoaDon.Rows[e.RowIndex];
                txt_TenDonVi.Text = row.Cells["tendonvi"].Value?.ToString() ?? "";
                txt_TongSoTien.Text = row.Cells["tongsotien"].Value?.ToString() ?? "";
                txt_NguoiDaiDien.Text = row.Cells["nguoidaidien"].Value?.ToString() ?? "";
                txt_DiaChiDonVi.Text = row.Cells["diachidonvi"].Value?.ToString() ?? "";
                txt_MaSoThue.Text = row.Cells["masothue"].Value?.ToString() ?? "";
                cbo_PhuongThucThanhToan.Text = row.Cells["phuongthucthanhtoan"].Value?.ToString() ?? "";
                cbo_TrangThaiThanhToan.Text = row.Cells["trangthaithanhtoan"].Value?.ToString() ?? "";
            }
        }

        private void Dgv_HoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var nguoidaidien = dgv_HoaDon.Rows[e.RowIndex].Cells["nguoidaidien"].Value;
            dgv_HoaDon.Rows[e.RowIndex].Cells["nguoidaidien"].Value = nguoidaidien != null ? nguoidaidien.ToString() : "";

            var diachidonvi = dgv_HoaDon.Rows[e.RowIndex].Cells["diachidonvi"].Value;
            dgv_HoaDon.Rows[e.RowIndex].Cells["diachidonvi"].Value = diachidonvi != null ? diachidonvi.ToString() : "";

            var masothue = dgv_HoaDon.Rows[e.RowIndex].Cells["masothue"].Value;
            dgv_HoaDon.Rows[e.RowIndex].Cells["masothue"].Value = masothue != null ? masothue.ToString() : "";

            var phuongthucthanhtoan = dgv_HoaDon.Rows[e.RowIndex].Cells["phuongthucthanhtoan"].Value;
            dgv_HoaDon.Rows[e.RowIndex].Cells["phuongthucthanhtoan"].Value = phuongthucthanhtoan != null ? phuongthucthanhtoan.ToString() : "";

            var trangthaithanhtoan = dgv_HoaDon.Rows[e.RowIndex].Cells["trangthaithanhtoan"].Value;
            dgv_HoaDon.Rows[e.RowIndex].Cells["trangthaithanhtoan"].Value = trangthaithanhtoan != null ? trangthaithanhtoan.ToString() : "";
        }

        public string NguoiDaiDien
        {
            get => txt_NguoiDaiDien.Text;
            set => txt_NguoiDaiDien.Text = value;
        }
        public string DiaChiDonVi
        {
            get => txt_DiaChiDonVi.Text;
            set => txt_DiaChiDonVi.Text = value;
        }
        public string MaSoThue
        {
            get => txt_MaSoThue.Text;
            set => txt_MaSoThue.Text = value;
        }
        public string TongSoNguoiDiTour
        {
            get => txt_TongSoNguoiDi.Text;
            set => txt_TongSoNguoiDi.Text = value;
        }
        public object DataSourceDatagirdView
        {
            get => dgv_HoaDon.DataSource;
            set => dgv_HoaDon.DataSource = value;
        }
        public int SelectedRowIndex
        {
            get
            {
                if (dgv_HoaDon.CurrentRow != null)
                {
                    return dgv_HoaDon.CurrentRow.Index;
                }
                return -1;
            }
        }

        public DataGridViewRow SelectedRow
        {
            get
            {
                if (dgv_HoaDon.CurrentRow != null)
                {
                    return dgv_HoaDon.CurrentRow;
                }
                return null;
            }
        }
        public object CboPhuongThucThanhToan_DataSource
        {
            get => cbo_PhuongThucThanhToan.DataSource;
            set
            {
                cbo_PhuongThucThanhToan.DataSource = value;

                cbo_PhuongThucThanhToan.DisplayMember = "name";
            }
        }
        public object CboTrangThaiThanhToan_DataSource
        {
            get => cbo_TrangThaiThanhToan.DataSource;
            set
            {
                cbo_TrangThaiThanhToan.DataSource = value;

                cbo_TrangThaiThanhToan.DisplayMember = "name";
            }
        }
    }
}
