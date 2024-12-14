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


	}
}
