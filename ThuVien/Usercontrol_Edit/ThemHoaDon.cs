using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ThuVien.Code;
using System.IO;
using OfficeOpenXml;

namespace ThuVien.Usercontrol_Edit
{
    public partial class ThemHoaDon : UserControl
    {
        public event EventHandler ThemClicked;
        public event EventHandler XoaClicked;
        public event EventHandler SuaClicked;
        public event EventHandler LuuClicked;
        public event EventHandler LamMoiClicked;
        public event EventHandler ImportClicked;
        public event EventHandler ExportClicked;
        public event EventHandler cbo_Tour_select;
        public event EventHandler dgv_Add;
        public event EventHandler<DataGridViewCellEventArgs> dgv_CellValueChanged;
        public event EventHandler<DataGridViewCellValidatingEventArgs> dgv_CellValidating;
        public ThemHoaDon()
        {
            InitializeComponent();
            SetupDataGridView();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            chucNangNenCo1.ThemClicked += (s, e) => ThemClicked?.Invoke(this, e);
            chucNangNenCo1.XoaClicked += (s, e) => XoaClicked?.Invoke(this, e);
            chucNangNenCo1.SuaClicked += (s, e) => SuaClicked?.Invoke(this, e);
            chucNangNenCo1.LuuClicked += (s, e) => LuuClicked?.Invoke(this, e);
            chucNangNenCo1.LamMoiClicked += (s, e) => LamMoiClicked?.Invoke(this, e);
            ExportClicked += (s, e) => ExportClicked?.Invoke(this, e);
            dgv_DanhSachKhachHangDiTour.CellClick += Dgv_DanhSachKhachHangDiTour_CellClick;
            dgv_DanhSachKhachHangDiTour.CellValueChanged += Dgv_DanhSachKhachHangDiTour_CellValueChanged;
            dgv_DanhSachKhachHangDiTour.RowsAdded += (s, e) =>
            {
                dgv_Add?.Invoke(this, EventArgs.Empty);
            };
            dgv_DanhSachKhachHangDiTour.CellValueChanged += (s, e) =>
            {
                dgv_CellValueChanged?.Invoke(this, e);
            };
            dgv_DanhSachKhachHangDiTour.CellValidating += (s, e) =>
            {
                dgv_CellValidating?.Invoke(this, e);
            };

            cbo_Tour.SelectedIndexChanged += (s, e)  => cbo_Tour_select?.Invoke(this, e);
            chucNangNenCo1.UpdateButtonState(true, true, false, false, true);
            txt_TongSoNguoiDi.Enabled = false;
            txt_TongSoTien.Enabled = false;
        }
        private void SetupDataGridView()
        {
            dgv_DanhSachKhachHangDiTour.AutoGenerateColumns = true;
        }
        private void AddCalendarColumn()
        {
            int oldIndex = dgv_DanhSachKhachHangDiTour.Columns["Ngày sinh"]?.Index ?? -1;

            if (oldIndex != -1)
            {
                dgv_DanhSachKhachHangDiTour.Columns.Remove("Ngày sinh");
            }

            var calendarColumn = new DataGridViewCalendarColumn
            {
                HeaderText = "Ngày sinh",
                Name = "Ngày sinh",
                DataPropertyName = "Ngày sinh", 
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            if (oldIndex != -1 && oldIndex < dgv_DanhSachKhachHangDiTour.Columns.Count)
            {
                dgv_DanhSachKhachHangDiTour.Columns.Insert(oldIndex, calendarColumn);
            }
            else
            {
                dgv_DanhSachKhachHangDiTour.Columns.Add(calendarColumn);
            }

            dgv_DanhSachKhachHangDiTour.Refresh();
        }

        public void xoaDong()
        {
            if (dgv_DanhSachKhachHangDiTour.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_DanhSachKhachHangDiTour.SelectedRows[0];

                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa dòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    dgv_DanhSachKhachHangDiTour.Rows.RemoveAt(selectedRow.Index);

                    MessageBox.Show("Dòng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dòng nào được chọn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Dgv_DanhSachKhachHangDiTour_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //var nguoidaidien = dgv_DanhSachKhachHangDiTour.Rows[e.RowIndex].Cells["nguoidaidien"].Value;
            //dgv_DanhSachKhachHangDiTour.Rows[e.RowIndex].Cells["nguoidaidien"].Value = nguoidaidien != null ? nguoidaidien.ToString() : "";

            //var diachidonvi = dgv_DanhSachKhachHangDiTour.Rows[e.RowIndex].Cells["diachidonvi"].Value;
            //dgv_DanhSachKhachHangDiTour.Rows[e.RowIndex].Cells["diachidonvi"].Value = diachidonvi != null ? diachidonvi.ToString() : "";

            //var masothue = dgv_DanhSachKhachHangDiTour.Rows[e.RowIndex].Cells["masothue"].Value;
            //dgv_DanhSachKhachHangDiTour.Rows[e.RowIndex].Cells["masothue"].Value = masothue != null ? masothue.ToString() : "";
        }

        private void Dgv_DanhSachKhachHangDiTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
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
        public string tenDonVi
        {
            get => txt_TenDonVi.Text;
            set => txt_TenDonVi.Text = value;
        }
        public string tongSoNguoiDiTour
        {
            get => txt_TongSoNguoiDi.Text;
            set => txt_TongSoNguoiDi.Text = value;
        }
        public string tongTien
        {
            get => txt_TongSoTien.Text;
            set => txt_TongSoTien.Text = value;
        }



        public object DataSourceDatagirdView
        {
            get => dgv_DanhSachKhachHangDiTour.DataSource;
            set
            {
                dgv_DanhSachKhachHangDiTour.DataSource = value;
                AddCalendarColumn();
            }
        }
        public int SelectedRowIndex
        {
            get
            {
                if (dgv_DanhSachKhachHangDiTour.CurrentRow != null)
                {
                    return dgv_DanhSachKhachHangDiTour.CurrentRow.Index;
                }
                return -1;
            }
        }
        public DataGridView GetDgv_DanhSachKhachHangDiTour()
        {
            return dgv_DanhSachKhachHangDiTour;
        }

        public DataGridViewRow SelectedRow
        {
            get
            {
                if (dgv_DanhSachKhachHangDiTour.CurrentRow != null)
                {
                    return dgv_DanhSachKhachHangDiTour.CurrentRow;
                }
                return null;
            }
        }
        public object CboTour_DataSource
        {
            get => cbo_Tour.DataSource;
            set
            {
                cbo_Tour.DataSource = value;

                cbo_Tour.DisplayMember = "tentour";
                cbo_Tour.ValueMember = "matour";
            }
        }
        public object CboNgayDi_DataSource
        {
            get => cbo_NgayDi.DataSource;
            set
            {
                cbo_NgayDi.DataSource = value;

                cbo_NgayDi.DisplayMember = "ngaybatdau";
                cbo_NgayDi.ValueMember = "matour";
            }
        }

        public object CboPhuongThucThanhToan_DataSource
        {
            get => cbo_PhuongThucThanhToan.DataSource;
            set
            {
                cbo_PhuongThucThanhToan.DataSource = value;

                cbo_PhuongThucThanhToan.DisplayMember = "name";
                cbo_PhuongThucThanhToan.ValueMember = "id";
            }
        }
        public object CboTrangThaiThanhToan_DataSource
        {
            get => cbo_TrangThaiThanhToan.DataSource;
            set
            {
                cbo_TrangThaiThanhToan.DataSource = value;

                cbo_TrangThaiThanhToan.DisplayMember = "name";
                cbo_TrangThaiThanhToan.ValueMember = "id";
            }
        }
        public object CboNguoiDaiDien_DataSource
        {
            get => cbo_NguoiDaiDien.DataSource;
            set
            {
                cbo_NguoiDaiDien.DataSource = value;

                cbo_NguoiDaiDien.DisplayMember = "email";
                cbo_NguoiDaiDien.ValueMember = "makhachhang";
            }
        }
        public string CboTour_SelectedValue
        {
            get => cbo_Tour.SelectedValue.ToString();
            set
            {
                cbo_Tour.SelectedValue = value;
            }
        }
        public DateTime CboNgayDi_SelectedValue
        {
            get => Convert.ToDateTime(cbo_NgayDi.SelectedValue);
            set
            {
                cbo_NgayDi.SelectedValue = value;
            }
        }
        public string CboPhuongThucThanhToan_SelectedValue
        {
            get => cbo_PhuongThucThanhToan.SelectedValue.ToString();
            set
            {
                cbo_PhuongThucThanhToan.SelectedValue = value;
            }
        }
        public string CboTrangThaiThanhToan_SelectedValue
        {
            get => cbo_TrangThaiThanhToan.SelectedValue.ToString();
            set
            {
                cbo_TrangThaiThanhToan.SelectedValue = value;
            }
        }
        public string CboNguoiDaiDien_SelectedValue
        {
            get => cbo_NguoiDaiDien.SelectedValue.ToString();
            set
            {
                cbo_NguoiDaiDien.SelectedValue = value;
            }
        }
        public string CboNguoiDaiDien_SelectedText
        {
            get => cbo_NguoiDaiDien.Text;
            set
            {
                cbo_NguoiDaiDien.Text = value;
            }
        }

        public List<khachhang> GetDataFromDataGridView()
        {
            List<khachhang> dataList = new List<khachhang>();

            foreach (DataGridViewRow row in dgv_DanhSachKhachHangDiTour.Rows)
            {
                if (!row.IsNewRow)
                {
                    string ten = row.Cells["Họ Tên"].Value?.ToString();
                    string diaChi = row.Cells["Địa Chỉ"].Value?.ToString();
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells["Ngày Sinh"].Value);
                    string soDienThoai = row.Cells["Số Điện Thoại"].Value?.ToString();
                    string cccd = row.Cells["CCCD"].Value?.ToString();
                    string gioiTinh = row.Cells["Giới Tính"].Value?.ToString();
                    string loaiKhachHang = layLoaiKhachHang(TinhTuoi(ngaySinh));
                    int maLoaiKhachHang = 0;
                    if (loaiKhachHang.Equals("Người lớn"))
                    {
                        maLoaiKhachHang = 1;
                    }
                    else if (loaiKhachHang.Equals("Trẻ em"))
                    {
                        maLoaiKhachHang = 2;
                    }
                    else
                    {
                        maLoaiKhachHang = 3;
                    }
                    dataList.Add(new khachhang { hoten = ten, diachi = diaChi, ngaysinh = ngaySinh, sodienthoai = soDienThoai, cccd = cccd, gioitinh = gioiTinh, maloaikhachhang = maLoaiKhachHang });
                }
            }

            return dataList;
        }
        public int TinhTuoi(DateTime ngaySinh)
        {
            DateTime now = DateTime.Now;

            int age = now.Year - ngaySinh.Year;

            if (ngaySinh.Date > now.AddYears(-age).Date)
            {
                age--;
            }

            return age;
        }

        public string layLoaiKhachHang(int tuoi)
        {
            string loaiKhachHang = "";
            if (tuoi < 5)
            {
                loaiKhachHang = "Trẻ em (Dưới 5 tuổi)";
            }
            else if (tuoi >= 5 && tuoi <= 18)
            {
                loaiKhachHang = "Trẻ em";
            }
            else
            {
                loaiKhachHang = "Người lớn";
            }
            return loaiKhachHang;
        }

        public void SetDataSource(object dataSource)
        {
            dgv_DanhSachKhachHangDiTour.DataSource = dataSource;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            saveFileDialog.Title = "Lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Danh sách khách hàng");

                    worksheet.Cells[1, 1].Value = "Họ tên";
                    worksheet.Cells[1, 2].Value = "CCCD";
                    worksheet.Cells[1, 3].Value = "Số điện thoại";
                    worksheet.Cells[1, 4].Value = "Địa chỉ";
                    worksheet.Cells[1, 5].Value = "Giới tính";
                    worksheet.Cells[1, 6].Value = "Ngày sinh";
                    worksheet.Cells[1, 7].Value = "Loại khách hàng";
                    worksheet.Cells[1, 8].Value = "Giá";

                    package.Save();
                    MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            ImportClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
