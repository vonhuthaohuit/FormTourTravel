using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public class ChuongTrinhTourDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<object> GetListChuongTrinhTour(long matour)
		{
			return db.chuongtrinhtours.Where(x => x.matour == matour).Select(x => new
			{
				x.machuongtrinhtour,
				x.tieude,
				x.ngay,
				x.mota,
				x.created_at

			}).ToList<object>();
		}
		public bool AddChuongTrinhTour(chuongtrinhtour chuongtrinhtour)
		{
			try
			{
				db.chuongtrinhtours.Add(chuongtrinhtour);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}
		public bool UpdateChuongTrinhTour(chuongtrinhtour chuongtrinhtour) 
		{
			try
			{
				var chuongtrinhtourUpdate = db.chuongtrinhtours.Find(chuongtrinhtour.machuongtrinhtour);
				chuongtrinhtourUpdate.tieude = chuongtrinhtour.tieude;
				chuongtrinhtourUpdate.ngay = chuongtrinhtour.ngay;
				chuongtrinhtourUpdate.mota = chuongtrinhtour.mota;
				chuongtrinhtourUpdate.matour = chuongtrinhtour.matour;
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}


		}
		public bool DeleteChuongTrinhTour(long id)
		{
			try
			{
				var chuongtrinhtour = db.chuongtrinhtours.Find(id);
				db.chuongtrinhtours.Remove(chuongtrinhtour);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public chuongtrinhtour GetChuongTrinhTour(long id)
		{
			return db.chuongtrinhtours.Find(id);
		}
		
	}
}
