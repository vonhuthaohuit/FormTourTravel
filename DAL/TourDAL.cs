using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using MySql.Data.MySqlClient;
namespace DAL
{
	public class TourDAL
	{
		private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<object> LayDanhSachTour()
		{
			var tours = (from t in db.tours
						 join l in db.loaitours on t.maloaitour equals l.maloaitour
						 orderby t.matour
						 select new
						 {
							 t.matour,
							 t.tentour,
							 TenLoaiTour = l.tenloai,
							 t.tinhtrang,
							 t.noikhoihanh,
							 t.thoigiandi,
							 t.giatour,
							 t.makhuyenmai,
							 t.created_at,
							  // Thêm cột từ bảng khác
						 }).ToList<object>();

			return tours;
		}


		public bool ThemTour(tour tour)
		{
			if (tour != null)
			{
				db.tours.Add(tour);
				db.SaveChanges();
				return true;
			}
			return false;
		}
		public bool XoaTour(long matour)
		{
			tour tour = db.tours.Where(t => t.matour == matour).FirstOrDefault();
			if (tour != null)
			{
				db.tours.Remove(tour);
				db.SaveChanges();
				return true;
			}
			return false;
		}
		public tour LayTourTheoMa(long matour)
		{
			return db.tours.Where(t => t.matour == matour).FirstOrDefault();
		}

		public bool SuaTour(tour tour)
		{
			tour tourUpdate = db.tours.Where(t => t.matour == tour.matour).FirstOrDefault();
			if (tourUpdate != null)
			{
				tourUpdate.tentour = tour.tentour;
				tourUpdate.tinhtrang = tour.tinhtrang;
				tourUpdate.slug = tour.slug;
				tourUpdate.motatour = tour.motatour;
				tourUpdate.hinhdaidien = tour.hinhdaidien;
				tourUpdate.noikhoihanh = tour.noikhoihanh;
				tourUpdate.thoigiandi = tour.thoigiandi;
				tourUpdate.giatour = tour.giatour;
				tourUpdate.maloaitour = tour.maloaitour;
				tourUpdate.makhuyenmai = tour.makhuyenmai;
				db.SaveChanges();
				return true;
			}
			return false;
		}
		public string ngayDiTour(long matour)
		{
			string ngaydi = db.tours.Where(t => t.matour == matour).Select(t => t.thoigiandi).FirstOrDefault();
			return ngaydi;
		}
		public long LayGiaTour(long maTour)
		{
			using (var context = new ql_tourdulich_ptudtmEntities())
			{
				// Thực thi truy vấn SQL thô
				var giaTour = context.Database.SqlQuery<long>("SELECT func_giatour(@p0) AS giatour", maTour).FirstOrDefault();
				return giaTour;
			}
		}

		public bool CapNhatGiaTour(long maTour, long giaTour)
		{
			using (var context = new ql_tourdulich_ptudtmEntities())
			{
				var tour = context.tours.SingleOrDefault(t => t.matour == maTour);
				if (tour != null)
				{
					tour.giatour = giaTour;
					context.SaveChanges();
					return true;
				}
				return false;
			}
		}
		public string getTenTour(long matour)
		{
			string tentour = db.tours.Where(t => t.matour == matour).Select(t => t.tentour).FirstOrDefault();
			return tentour;
		}

		public List<DateTime> LayDanhSachNgayDi(int tourId)
		{
            var ngaydi = db.chitiettours.Where(x => x.matour == tourId).Select(x => x.ngaybatdau).ToList();
            return ngaydi;
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
