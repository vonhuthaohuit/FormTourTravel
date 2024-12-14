using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class TourTypeDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public TourTypeDAL() { }

		public List<loaitour> layDanhSachLoaiTour()
		{
			return db.loaitours.ToList();
		}
		public List<object> getlistTour()
		{
			var loaitours = db.loaitours.Select(lt => new
			{
				lt.maloaitour,
				lt.tenloai
			}).ToList<object>();
			return loaitours;
		}
		public bool themLoaiTour(string tenloai)
		{
			try
			{
				loaitour loaitour = new loaitour();
				loaitour.tenloai = tenloai;
				db.loaitours.Add(loaitour);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception($"Lỗi khi thêm loại tour: {ex.Message}");
			}
		}
		public bool xoaLoaiTour(long maloaitour)
		{
			try
			{
				loaitour loaitour = db.loaitours.Find(maloaitour);
				db.loaitours.Remove(loaitour);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception($"Lỗi khi xóa loại tour: {ex.Message}");
			}
		}
		public bool suaLoaiTour(loaitour loaitour)
		{
			try
			{
				loaitour loaitourUpdate = db.loaitours.Find(loaitour.maloaitour);
				loaitourUpdate.tenloai = loaitour.tenloai;
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception($"Lỗi khi sửa loại tour: {ex.Message}");
			}
		}
	}
}
