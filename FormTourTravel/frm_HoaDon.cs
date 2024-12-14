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
using DTO;
using ThuVien.Usercontrol_Edit;

namespace FormTourTravel
{
    public partial class frm_HoaDon : Form
    {
        private HoaDonBLL hoaDonBll = new HoaDonBLL();
        string[] trangThaiThanhToan = { "Chưa thanh toán", "Đã thanh toán" };
        string[] phuongThucThanhToan = { "Tiền mặt", "Chuyển khoản" };
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public frm_HoaDon()
        {
            InitializeComponent();

            hoaDon1.ThemClicked += HoaDonControl1_ThemClicked;
            hoaDon1.XoaClicked += HoaDonControl1_XoaClicked;
            hoaDon1.SuaClicked += HoaDonControl1_SuaClicked;
            hoaDon1.LuuClicked += HoaDonControl1_LuuClicked;
            hoaDon1.LamMoiClicked += HoaDon1_LamMoiClicked;
            hoaDon1.dgv_CellClick += HoaDon1_dgv_CellClick; 
            this.Load += Frm_HoaDon_Load;
        }

        private void HoaDon1_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (hoaDon1.DataSourceDatagirdView is List<hoadon> hoaDonList)
            {
                int selectedRowIndex = e.RowIndex;
                var selectedHoaDon = hoaDonList[selectedRowIndex];

                int maHoaDon = selectedHoaDon.mahoadon;

                int? maPhieuDatTour = (int?)db.hoadons
                            .Where(hd => hd.mahoadon == maHoaDon)
                            .Select(hd => hd.maphieudattour)
                            .FirstOrDefault();

                if (maPhieuDatTour.HasValue)
                {
                    int tongSoNguoiDiTour = db.chitietphieudattours
                        .Where(ct => ct.maphieudattour == maPhieuDatTour.Value)
                        .Count();
                    hoaDon1.TongSoNguoiDiTour = tongSoNguoiDiTour.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu đặt tour.");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không phải là DataTable.");
            }
        }




        private void HoaDon1_LamMoiClicked(object sender, EventArgs e)
        {
            try
            {
                List<hoadon> hoadons = new List<hoadon>();
                hoadons = hoaDon1.DataSourceDatagirdView as List<hoadon>;
                hoaDonBll.LuuHoaDon(hoadons);
                hoaDon1.DataSourceDatagirdView = hoaDonBll.LayDanhSachHoaDon();

                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            loadCboTrangThaiThanhToan();
            loadCboPhuongThucThanhToan();
            hoaDon1.DataSourceDatagirdView = hoaDonBll.LayDanhSachHoaDon();
        }
        public void loadCboTrangThaiThanhToan()
        {
            hoaDon1.CboTrangThaiThanhToan_DataSource = trangThaiThanhToan;
        }
        public void loadCboPhuongThucThanhToan()
        {
            hoaDon1.CboPhuongThucThanhToan_DataSource = phuongThucThanhToan;
        }

        private void HoaDonControl1_LuuClicked(object sender, EventArgs e)
        {
            try
            {
                hoaDon1.DataSourceDatagirdView = hoaDonBll.LayDanhSachHoaDon();
            }
            catch
            {
                MessageBox.Show("Chức năng đang cập nhật");
            }
        }

        private void HoaDonControl1_SuaClicked(object sender, EventArgs e)
        {
            if (hoaDon1.DataSourceDatagirdView is DataTable dataSource && hoaDon1.SelectedRowIndex >= 0)
            {
                var row = dataSource.Rows[hoaDon1.SelectedRowIndex];

                row["nguoidaidien"] = hoaDon1.NguoiDaiDien;
                row["diachidonvi"] = hoaDon1.DiaChiDonVi;
                row["masothue"] = hoaDon1.MaSoThue;

                try
                {
                    var updatedHoaDon = new hoadon
                    {
                        nguoidaidien = row["nguoidaidien"].ToString(),
                        diachidonvi = row["diachidonvi"].ToString(),
                        masothue = row["masothue"].ToString(),
                        phuongthucthanhtoan = row["phuongthucthanhtoan"].ToString(),
                        trangthaithanhtoan = row["trangthaithanhtoan"].ToString(),
                    };

                    hoaDonBll.SuaHoaDon(updatedHoaDon);

                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hoaDon1.DataSourceDatagirdView = hoaDonBll.LayDanhSachHoaDon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void HoaDonControl1_XoaClicked(object sender, EventArgs e)
        {
            if (hoaDon1.DataSourceDatagirdView is List<hoadon> danhSachHoaDon && hoaDon1.SelectedRowIndex >= 0)
            {
                var hoaDon = danhSachHoaDon[hoaDon1.SelectedRowIndex];
                int hoaDonId = hoaDon.mahoadon;

                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        hoaDonBll.XoaHoaDon(hoaDonId);

                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        hoaDon1.DataSourceDatagirdView = hoaDonBll.LayDanhSachHoaDon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void HoaDonControl1_ThemClicked(object sender, EventArgs e)
        {
            frm_ThemHoaDon formThemHoaDon = new frm_ThemHoaDon();
            formThemHoaDon.ShowDialog();
        }
    }
}
