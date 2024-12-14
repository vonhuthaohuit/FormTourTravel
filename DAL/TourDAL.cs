using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class TourDAL
	{
		private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<tour> LayDanhSachTour()
		{
			return db.tours.ToList();
		}
		public List<DateTime> LayDanhSachNgayDi(int tourId)
		{
            var ngaydi = db.chitiettours.Where(x => x.matour == tourId).Select(x => x.ngaybatdau).ToList();
            return ngaydi;
        }
	}

		public List<dynamic> LayTourDaDat()
		{
            var tours = (from ct in db.chitietphieudattours
                         join pd in db.phieudattours on ct.maphieudattour equals pd.maphieudattour
                         join t in db.tours on pd.matour equals t.matour
                         join hd in db.hoadons on pd.maphieudattour equals hd.maphieudattour
                         where pd.trangthaidattour == "Đã thanh toán"
                         select new
                         {
                             matour = t.matour,
                             tentour = t.tentour,
                             giatour = t.giatour,
                             thoigiandi = t.thoigiandi,
                             ngaybatdau = pd.ngaybatdau,
                             ngaydattour = pd.ngaydattour,
                             trangthaidattour = pd.trangthaidattour,
                             nguoidaidien = hd.nguoidaidien,

                         }).ToList();

            return tours.Cast<dynamic>().ToList();
        }

        public List<dynamic> TimKiemHoaDonVaPhieuDat(string nguoiDaiDien, DateTime? ngayDatTour)
        {
            DateTime? ngayBatDau = ngayDatTour?.Date; // Ngày bắt đầu (bỏ thời gian)
            DateTime? ngayKetThuc = ngayDatTour?.Date.AddDays(1); // Ngày kết thúc (ngày tiếp theo)

            var tours = (from ct in db.chitietphieudattours
                         join pd in db.phieudattours on ct.maphieudattour equals pd.maphieudattour
                         join t in db.tours on pd.matour equals t.matour
                         join hd in db.hoadons on pd.maphieudattour equals hd.maphieudattour
                         where pd.trangthaidattour == "Đã thanh toán"
                               && (string.IsNullOrEmpty(nguoiDaiDien) || hd.nguoidaidien.Contains(nguoiDaiDien)) // Lọc theo người đại diện
                               && (!ngayBatDau.HasValue || (pd.ngaydattour >= ngayBatDau && pd.ngaydattour < ngayKetThuc)) // Lọc theo phạm vi ngày
                         select new
                         {
                             MaTour = t.matour,
                             TenTour = t.tentour,
                             GiaTour = t.giatour,
                             ThoiGianDi = t.thoigiandi,
                             NgayBatDau = pd.ngaybatdau,
                             NgayDatTour = pd.ngaydattour,
                             TrangThaiDatTour = pd.trangthaidattour,
                             NguoiDaiDien = hd.nguoidaidien
                         }).ToList();

            return tours.Cast<dynamic>().ToList();
        }

        public bool HuyTour(int matour, string nguoidaidien, DateTime ngaydattour)
        {
            var phieudattour = (from pd in db.phieudattours
                                join hd in db.hoadons on pd.maphieudattour equals hd.maphieudattour
                                where pd.matour == matour
                                      && hd.nguoidaidien == nguoidaidien
                                      && pd.ngaydattour == ngaydattour
                                select pd).FirstOrDefault();

            if (phieudattour != null)
            {
                phieudattour.trangthaidattour = "Đã hủy";
                db.SaveChanges();

                var phieuHuy = new phieuhuytour
                {
                    lydohuy = "Khách hàng yêu cầu hủy tour",
                    ngayhuy = DateTime.Now
                };
                db.phieuhuytours.Add(phieuHuy);
                db.SaveChanges();

                var hoaDon = db.hoadons.FirstOrDefault(hd => hd.maphieudattour == phieudattour.maphieudattour);

                if (hoaDon != null)
                {
                    hoaDon.maphieuhuytour = phieuHuy.maphieuhuytour;
                    db.SaveChanges();
                }

                var tour = (from t in db.tours
                            join pd in db.phieudattours on t.matour equals pd.matour
                            where pd.maphieudattour == phieudattour.maphieudattour
                            select new
                            {
                                t.giatour,
                                pd.ngaybatdau
                            }).FirstOrDefault();

                if (tour != null)
                {
                    var ngayBatDau = tour.ngaybatdau;
                    var ngayHuy = DateTime.Now;

                    int soNgayTruocBatDau = (ngayBatDau.Value - ngayHuy).Days;
                    double phanTramHoanTien;

                    if (soNgayTruocBatDau > 30)
                    {
                        phanTramHoanTien = 1.0;
                    }
                    else if (soNgayTruocBatDau >= 16)
                    {
                        phanTramHoanTien = 0.7;
                    }
                    else if (soNgayTruocBatDau >= 8)
                    {
                        phanTramHoanTien = 0.3;
                    }
                    else if (soNgayTruocBatDau >= 4)
                    {
                        phanTramHoanTien = 0.1;
                    }
                    else
                    {
                        phanTramHoanTien = 0.0;
                    }

                    decimal soTienHoan = (decimal)(tour.giatour * phanTramHoanTien);

                    phieuHuy.sotienhoan = soTienHoan;
                    db.SaveChanges();

                    return true;
                }
            }

            return false;
        }
    }
}
