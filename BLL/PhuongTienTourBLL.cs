using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class PhuongTienTourBLL
	{
		private readonly PhuongTienTourDAL phuongTienTourDAL = new PhuongTienTourDAL();
		public List<object> GetListPhuongTienTour(long matour)
		{
			return phuongTienTourDAL.GetListPhuongTienTour(matour);
		}
		public bool AddPhuongTienTour(chitietphuongtientour phuongtien)
		{
			return phuongTienTourDAL.AddPhuongTienTour(phuongtien);
		}
		public bool UpdatePhuongTienTour(chitietphuongtientour phuongtien)
		{
			return phuongTienTourDAL.UpdatePhuongTienTour(phuongtien);
		}
		public bool DeletePhuongTienTour(long matour, long maphuongtien)
		{
			return phuongTienTourDAL.DeletePhuongTienTour(matour, maphuongtien);
		}
		public List<phuongtien> GetListPhuongTien()
		{
			return phuongTienTourDAL.loadCBX();
		}
		public chitietphuongtientour GetPhuongTienTour(long matour,long maphuongtientour)
		{
			return phuongTienTourDAL.GetPhuongTienTour(matour,maphuongtientour);
		}




	}
}
