using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class KhachSanTourDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<object> GetListKhachSanTour(long matour)
		{
			var data = db.chitietkhachsantours.Where(x => x.matour == matour).Select(x => new
			{
				x.makhachsan,
				x.khachsan.tenkhachsan,
				x.matour,
				x.tour.tentour,
				x.vitriphong,
				x.succhua,
			}).ToList<object>();

			return data;
		}

		public bool AddKhachSanTour(chitietkhachsantour khachsan)
		{
			try
			{
				db.chitietkhachsantours.Add(khachsan);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool UpdateKhachSanTour(chitietkhachsantour khachsan)
		{
			try
			{
				var khachSanUpdate = db.chitietkhachsantours.Where(x => x.makhachsan == khachsan.makhachsan && x.matour == khachsan.matour).FirstOrDefault();

				khachSanUpdate.vitriphong = khachsan.vitriphong;
				khachSanUpdate.succhua = khachsan.succhua;
				
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool DeleteKhachSanTour(long matour, long makhachsan)
		{
			try
			{
				var phuongtien = db.chitietkhachsantours.Where(x => x.matour == matour && x.makhachsan == makhachsan).FirstOrDefault();
				db.chitietkhachsantours.Remove(phuongtien);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public chitietkhachsantour GetKhachSanTour(long matour, long makhachsan)
		{
			return db.chitietkhachsantours.Where(x => x.matour == matour && x.makhachsan == makhachsan).FirstOrDefault();
		}
		public List<khachsan> loadCBX()
		{
			return db.khachsans.ToList();
		}
	}
}
