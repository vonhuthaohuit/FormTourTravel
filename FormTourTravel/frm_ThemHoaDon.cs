using BLL;
using DTO;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using ThuVien.Code;
using ThuVien.Usercontrol_Edit;
using System.IO;
using OfficeOpenXml;


namespace FormTourTravel
{
    public partial class frm_ThemHoaDon : Form
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        TourBLL tourBLL = new TourBLL();
        PhieuDatTourBLL phieuDatTourBLL = new PhieuDatTourBLL();
        ChiTietPhieuDatTourBLL chiTietPhieuDatTourBLL = new ChiTietPhieuDatTourBLL();
        UsersBLL usersBLL = new UsersBLL();
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

        string[] trangThaiThanhToan = { "Chưa thanh toán", "Đã thanh toán" };
        string[] phuongThucThanhToan = { "Tiền mặt", "Chuyển khoản" };

        public frm_ThemHoaDon()
        {
            InitializeComponent();
            themHoaDon1.ImportClicked += ThemHoaDon1_ImportClicked;
            themHoaDon1.ThemClicked += ThemHoaDon1_ThemClicked;
            themHoaDon1.XoaClicked += ThemHoaDon1_XoaClicked;
            themHoaDon1.SuaClicked += ThemHoaDon1_SuaClicked;
            themHoaDon1.LuuClicked += ThemHoaDon1_LuuClicked;
            themHoaDon1.LamMoiClicked += ThemHoaDon1_LamMoiClicked;
            themHoaDon1.cbo_Tour_select += ThemHoaDon1_cbo_Tour_select;
            themHoaDon1.dgv_Add += ThemHoaDon1_dgv_Add;
            themHoaDon1.cbo_Tour_select += ThemHoaDon1_cbo_Tour_select1;
            themHoaDon1.dgv_CellValidating += ThemHoaDon1_dgv_CellValidating;
            
            //themHoaDon1.dgv_CellValueChanged += ThemHoaDon1_dgv_CellValueChanged;
        }

        private void ThemHoaDon1_ExportClicked(object sender, EventArgs e)
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


        private void ThemHoaDon1_ImportClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Chọn file Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(path))
                {
                    DataTable dt = ReadExcelFile(path);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        themHoaDon1.DataSourceDatagirdView = dt; 
                    }
                    else
                    {
                        MessageBox.Show("Không thể đọc dữ liệu từ file Excel.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public DataTable ReadExcelFile(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var dt = new DataTable();

                bool hasHeader = true;
                var startRow = hasHeader ? 2 : 1;

                if (hasHeader)
                {
                    foreach (var headerCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        dt.Columns.Add(headerCell.Text);
                    }
                }
                dt.Columns.Add("Loại khách hàng", typeof(string));
                dt.Columns.Add("Giá", typeof(double));


                var selectedValue = Convert.ToInt32(themHoaDon1.CboTour_SelectedValue.ToString());
                var tour = db.tours.FirstOrDefault(t => t.matour == selectedValue);
                if (tour == null)
                {
                    MessageBox.Show("Không tìm thấy tour với mã đã chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                var mucApDungGia = db.loaikhachhangs.Select(x => x.mucapdunggia).ToArray();

                for (int rowNum = startRow; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var row = dt.NewRow();
                    for (int colNum = 1; colNum <= worksheet.Dimension.End.Column; colNum++)
                    {
                        row[colNum - 1] = worksheet.Cells[rowNum, colNum].Text;
                    }

                    var valueA = row["Ngày sinh"]?.ToString();
                    var tuoi = TinhTuoi(Convert.ToDateTime(valueA));
                    var loaiKhachHang = layLoaiKhachHang(tuoi);

                    double gia = tour.giatour;

                    if (mucApDungGia != null)
                    {
                        if (loaiKhachHang == "Người lớn")
                        {
                            gia = gia - (gia * (mucApDungGia[0] / 100.0));
                        }
                        else if (loaiKhachHang == "Trẻ em")
                        {
                            gia = gia - (gia * (mucApDungGia[1] / 100.0));
                        }
                        else
                        {
                            gia = gia - (gia * (mucApDungGia[2] / 100.0));
                        }
                    }
                    gia = Math.Floor(gia);
                    row["Loại khách hàng"] = loaiKhachHang;
                    row["Giá"] = gia;

                    dt.Rows.Add(row);
                }

                double tongTien = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongTien += Convert.ToDouble(row["Giá"]);
                }

                themHoaDon1.tongTien = tongTien.ToString();
                themHoaDon1.tongSoNguoiDiTour = (dt.Rows.Count).ToString();
                return dt;
            }
        }






        private void ThemHoaDon1_dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            var columnName = dgv.Columns[e.ColumnIndex].Name;
            var newValue = e.FormattedValue?.ToString()?.Trim();

            if (columnName == "Ngày sinh")
            {
                if (!DateTime.TryParse(newValue, out _))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (columnName == "CCCD")
            {
                if (string.IsNullOrEmpty(newValue) || newValue.Length < 9 || newValue.Length > 12 || !newValue.All(char.IsDigit))
                {
                    MessageBox.Show("CCCD phải là số và có độ dài từ 9 đến 12 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (columnName == "Số điện thoại")
            {
                if (string.IsNullOrEmpty(newValue) || newValue.Length != 10 || !newValue.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 số và không chứa ký tự khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void ThemHoaDon1_cbo_Tour_select1(object sender, EventArgs e)
        {
            var dgv = themHoaDon1.GetDgv_DanhSachKhachHangDiTour();
            var selectedValue = Convert.ToInt32(themHoaDon1.CboTour_SelectedValue.ToString());
            var tour = db.tours.Where(t => t.matour == selectedValue).FirstOrDefault();

            if (tour != null)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var loaiKhachHang = row.Cells["Loại khách hàng"].Value?.ToString();
                        double gia = tour.giatour;

                        var mucApDungGia = db.loaikhachhangs
                                              .Select(x => x.mucapdunggia)
                                              .ToArray();

                        if (mucApDungGia != null)
                        {
                            if (loaiKhachHang == "Người lớn")
                            {
                                gia = gia - (gia * (mucApDungGia[0] / 100.0));
                            }
                            else if (loaiKhachHang == "Trẻ em")
                            {
                                gia = gia - (gia * (mucApDungGia[1] / 100.0));
                            }
                            else
                            {
                                gia = gia - (gia * (mucApDungGia[2] / 100.0));
                            }
                            gia = Math.Floor(gia);
                            row.Cells["Giá"].Value = gia;
                        }
                    }
                }

                double tongTien = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        tongTien += Convert.ToDouble(row.Cells["Giá"].Value);
                    }
                }
                themHoaDon1.tongTien = tongTien.ToString();
            }
        }

        private void ThemHoaDon1_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var userControl = sender as ThemHoaDon;

            if (userControl != null)
            {
                var dgv = userControl.GetDgv_DanhSachKhachHangDiTour();

                var changedRow = dgv.Rows[e.RowIndex];
                var changedColumn = dgv.Columns[e.ColumnIndex];
                themHoaDon1.tongSoNguoiDiTour = (dgv.Rows.Count - 1).ToString();
                if (changedColumn.Name == "Ngày sinh")
                {
                    var valueA = changedRow.Cells["Ngày sinh"].Value?.ToString();
                    var tuoi = TinhTuoi(Convert.ToDateTime(valueA));
                    var loaiKhachHang = layLoaiKhachHang(tuoi);
                    changedRow.Cells["Loại khách hàng"].Value = loaiKhachHang;

                    var selectedValue = Convert.ToInt32(userControl.CboTour_SelectedValue.ToString());
                    var tour = db.tours.Where(t => t.matour == selectedValue).FirstOrDefault();
                    var mucApDungGia = db.loaikhachhangs
                                      .Select(x => x.mucapdunggia)
                                      .ToArray();
                    double gia = tour.giatour;
                    if (loaiKhachHang.Equals("Người lớn"))
                    {
                        gia = gia - (gia * (mucApDungGia[0] / 100.0));
                    }
                    else if (loaiKhachHang.Equals("Trẻ em"))
                    {
                        gia = gia - (gia * (mucApDungGia[1] / 100.0));
                    }
                    else
                    {
                        gia = gia - (gia * (mucApDungGia[2] / 100.0));
                    }
                    gia = Math.Floor(gia);
                    changedRow.Cells["Giá"].Value = gia;
                    double tongTien = 0;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var giaCellValue = row.Cells["Giá"].Value;
                            if (giaCellValue != null && double.TryParse(giaCellValue.ToString(), out double giaValue))
                            {
                                tongTien += giaValue;
                            }
                        }
                    }

                    themHoaDon1.tongTien = tongTien.ToString();
                }

            }
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

        private void ThemHoaDon1_dgv_Add(object sender, EventArgs e)
        {
            //var userControl = sender as ThemHoaDon;
            //int[] mucApDungGia = db.loaikhachhangs
            //                  .Select(x => x.mucapdunggia)
            //                  .ToArray();
            //if (userControl != null)
            //{
            //    int selectedValue = Convert.ToInt32(userControl.CboTour_SelectedValue.ToString());
            //    tour tour = db.tours.Where(t => t.matour == selectedValue).FirstOrDefault();
            //    var data = themHoaDon1.GetDataFromDataGridView(tour.giatour, mucApDungGia);

            //    if (data != null)
            //    {
            //    }
            //}
        }


        private void ThemHoaDon1_cbo_Tour_select(object sender, EventArgs e)
        {
            var selectedMaTour = Convert.ToInt32(themHoaDon1.CboTour_SelectedValue);

            loadCboNgayDi();
        }

        private void ThemHoaDon1_LamMoiClicked(object sender, EventArgs e)
        {
            themHoaDon1.tenDonVi = "";
            themHoaDon1.DiaChiDonVi = "";
            themHoaDon1.MaSoThue = "";
            themHoaDon1.tongSoNguoiDiTour = "";
            themHoaDon1.tongTien = "";
            LoadData();

        }


        private void ThemHoaDon1_LuuClicked(object sender, EventArgs e)
        {

        }

        private void ThemHoaDon1_SuaClicked(object sender, EventArgs e)
        {

        }

        private void ThemHoaDon1_XoaClicked(object sender, EventArgs e)
        {
            themHoaDon1.xoaDong();
        }
        public string catChuoiEmail(string email)
        {
            int atIndex = email.IndexOf('@');

            if (atIndex > 0)
            {
                string partBeforeAt = email.Substring(0, atIndex);
                return partBeforeAt;
            }
            Random rd = new Random(10000);
            return "nguoidung" + rd;
        }
        private void ThemHoaDon1_ThemClicked(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    int maKhachHang = Convert.ToInt32(themHoaDon1.CboNguoiDaiDien_SelectedValue);
                    khachhang khachhangNew = db.khachhangs.Where(kh => kh.makhachhang == maKhachHang).FirstOrDefault();
                    user taiKhoan = db.users.Where(u => u.mataikhoan == khachhangNew.mataikhoan).FirstOrDefault();
                    if (taiKhoan == null)
                    {
                        var userKH = usersBLL.TaoTaiKhoanNguoiDaiDien(catChuoiEmail(themHoaDon1.CboNguoiDaiDien_SelectedText), themHoaDon1.CboNguoiDaiDien_SelectedText);
                        taiKhoan = db.users.Where(u => u.mataikhoan == userKH.mataikhoan).FirstOrDefault();
                        MessageBox.Show($"Tạo tài khoản người đại diện thành công. Tên tài khoản: {taiKhoan.tentaikhoan}, Mật khẩu: {taiKhoan.matkhau}",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    }

                    int[] mucApDungGia = db.loaikhachhangs
                              .Select(x => x.mucapdunggia)
                              .ToArray();
                    int selectedValue = Convert.ToInt32(themHoaDon1.CboTour_SelectedValue.ToString());
                    tour tour = db.tours.Where(t => t.matour == selectedValue).FirstOrDefault();
                    List<khachhang> danhSachKhachHangDiTour = themHoaDon1.GetDataFromDataGridView();
                    string phuongThucThanhToan = themHoaDon1.CboPhuongThucThanhToan_SelectedValue;
                    string trangThaiThanhToan = themHoaDon1.CboTrangThaiThanhToan_SelectedValue;


                    string userName = taiKhoan.tentaikhoan;
                    string email = taiKhoan.email;
                    // Kiểm tra dữ liệu trong DataGridView
                    if (danhSachKhachHangDiTour.Count == 0)
                    {
                        MessageBox.Show("Danh sách khách hàng đi tour không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo danh sách khách hàng đi tour
                    double tongTienPhieuDatTour = 0;
                    List<int> maKhachHangs = new List<int>();
                    foreach (var tdTicket in danhSachKhachHangDiTour)
                    {
                        var khachHangDiTour = new khachhang
                        {
                            hoten = tdTicket.hoten,
                            ngaysinh = tdTicket.ngaysinh,
                            gioitinh = tdTicket.gioitinh,
                            maloaikhachhang = Convert.ToInt32(tdTicket.maloaikhachhang)
                        };
                        db.khachhangs.Add(khachHangDiTour);
                        db.SaveChanges();

                        double gia = 0;
                        double giaTour = tour.giatour;

                        if (tdTicket.maloaikhachhang == 0)
                        {
                            gia = giaTour - (giaTour * (mucApDungGia[0] / 100));
                        }
                        else if (tdTicket.maloaikhachhang == 1)
                        {
                            gia = giaTour - (giaTour * (mucApDungGia[1] / 100));
                        }
                        else
                        {
                            gia = giaTour - (giaTour * (mucApDungGia[2] / 100));
                        }
                        tongTienPhieuDatTour += gia;
                        maKhachHangs.Add(Convert.ToInt32(khachHangDiTour.makhachhang));
                    }

                    // Tạo phiếu đặt tour
                    int tourId = Convert.ToInt32(themHoaDon1.CboTour_SelectedValue);
                    DateTime ngayKhoiHanh = Convert.ToDateTime(themHoaDon1.CboNgayDi_SelectedValue);
                    var phieuDatTour = phieuDatTourBLL.TaoPhieuDatTour(tourId, khachhangNew.hoten, tongTienPhieuDatTour, danhSachKhachHangDiTour.Count, "Đang chờ", DateTime.Now, ngayKhoiHanh);
                    if (phieuDatTour == null)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Tạo phiếu đặt tour thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tạo chi tiết phiếu đặt tour
                    for (int i = 0; i < danhSachKhachHangDiTour.Count; i++)
                    {
                        var tdTicket = danhSachKhachHangDiTour[i];
                        double gia = 0;
                        double giaTour = tour.giatour;

                        if (tdTicket.maloaikhachhang == 0)
                        {
                            gia = giaTour - (giaTour * (mucApDungGia[0] / 100));
                        }
                        else if (tdTicket.maloaikhachhang.Equals("Trẻ em (Từ 5 đến 18 tuổi)"))
                        {
                            gia = giaTour - (giaTour * (mucApDungGia[1] / 100));
                        }
                        else
                        {
                            gia = giaTour - (giaTour * (mucApDungGia[2] / 100));
                        }
                        if (!chiTietPhieuDatTourBLL.TaoChiTietPhieuDatTour((int)maKhachHangs[i], (int)phieuDatTour.maphieudattour, gia, Convert.ToInt32(khachhangNew.makhachhang)))
                        {
                            transaction.Rollback();
                            MessageBox.Show("Tạo chi tiết phiếu đặt tour thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Tạo hóa đơn
                    var thongTinNguoiDaiDien = new
                    {
                        nguoidaidien = khachhangNew.hoten,
                        tendonvi = themHoaDon1.tenDonVi ?? null,
                        diachidonvi = themHoaDon1.DiaChiDonVi ?? null,
                        masothue = themHoaDon1.MaSoThue ?? null,
                    };

                    var hoaDon = new hoadon
                    {
                        maphieudattour = phieuDatTour.maphieudattour,
                        tongsotien = tongTienPhieuDatTour,
                        phuongthucthanhtoan = "Tiền mặt",
                        trangthaithanhtoan = "Đã thanh toán",
                        nguoidaidien = thongTinNguoiDaiDien.nguoidaidien,
                        tendonvi = thongTinNguoiDaiDien.tendonvi,
                        diachidonvi = thongTinNguoiDaiDien.diachidonvi,
                        masothue = thongTinNguoiDaiDien.masothue,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    db.hoadons.Add(hoaDon);
                    db.SaveChanges();

                    transaction.Commit();
                    MessageBox.Show("Tạo hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_ThemHoaDon_Load(object sender, EventArgs e)
        {
            loadCboNguoiDaiDien();
            loadCboTour();
            loadCboTrangThaiThanhToan();
            loadCboPhuongThucThanhToan();
            LoadData();
            themHoaDon1.dgv_CellValueChanged += ThemHoaDon1_dgv_CellValueChanged;
        }
        public void loadCboNguoiDaiDien()
        {
            themHoaDon1.CboNguoiDaiDien_DataSource = khachHangBLL.LayKhachHangCoTaiKhoan();
        }
        public void loadCboTour()
        {
            themHoaDon1.CboTour_DataSource = tourBLL.LayDanhSachTour();
        }
        public void loadCboNgayDi()
        {
            themHoaDon1.CboNgayDi_DataSource = null;
            themHoaDon1.CboNgayDi_DataSource = tourBLL.LayDanhSachNgayDi(Convert.ToInt32(themHoaDon1.CboTour_SelectedValue));
        }
        public void loadCboTrangThaiThanhToan()
        {
            themHoaDon1.CboTrangThaiThanhToan_DataSource = trangThaiThanhToan;
        }
        public void loadCboPhuongThucThanhToan()
        {
            themHoaDon1.CboPhuongThucThanhToan_DataSource = phuongThucThanhToan;
        }
        public void LoadData()
        {
            var table = new DataTable();
            table.Columns.Add("Họ tên", typeof(string));
            table.Columns.Add("CCCD", typeof(string));
            table.Columns.Add("Số điện thoại", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Giới tính", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("Loại khách hàng", typeof(string));
            table.Columns.Add("Giá", typeof(decimal));
            themHoaDon1.DataSourceDatagirdView = table;
        }


    }
}
