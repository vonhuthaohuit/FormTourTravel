using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class PhuongTienTourDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<object> GetListPhuongTienTour(long matour)
		{
			var data = db.chitietphuongtientours.Where(x => x.matour == matour).Select(x => new
			{
				x.maphuongtien,
				x.phuongtien.tenphuongtien,
				x.matour,
				x.tour.tentour,
				x.soluonghanhkhach,
				x.ghichu,
			}).ToList<object>();

			return data;
		}

		public bool AddPhuongTienTour(chitietphuongtientour phuongtien)
		{
			try
			{
				db.chitietphuongtientours.Add(phuongtien);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool UpdatePhuongTienTour(chitietphuongtientour phuongtien)
		{
			try
			{
				var phuongtienUpdate = db.chitietphuongtientours.Where(x=> x.maphuongtien == phuongtien.maphuongtien && x.matour== phuongtien.matour).FirstOrDefault();
				phuongtienUpdate.soluonghanhkhach = phuongtien.soluonghanhkhach;
				phuongtienUpdate.maphuongtien = phuongtien.maphuongtien;
				if (phuongtien.ghichu != null)
					phuongtienUpdate.ghichu = phuongtien.ghichu;
				else
					phuongtienUpdate.ghichu = "Không có";
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool DeletePhuongTienTour(long matour,long maphuongtien)
		{
			try
			{
				var phuongtien = db.chitietphuongtientours.Where(x=>x.matour == matour && x.maphuongtien == maphuongtien).FirstOrDefault();
				db.chitietphuongtientours.Remove(phuongtien);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public chitietphuongtientour GetPhuongTienTour(long matour,long maphuongtien)
		{
			return db.chitietphuongtientours.Where(x => x.matour == matour && x.maphuongtien == maphuongtien).FirstOrDefault();
		}
		public List<phuongtien> loadCBX()
		{
			return db.phuongtiens.ToList();
		}
	}
}
