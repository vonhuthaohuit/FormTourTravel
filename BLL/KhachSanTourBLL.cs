using DAL;
using DTO;
using System;
using System.Collections.Generic;


namespace BLL
{
	public class KhachSanTourBLL
	{
		private readonly KhachSanTourDAL khachSanTourDAL = new KhachSanTourDAL();
		public List<object> GetListKhachSanTour(long matour)
		{
			return khachSanTourDAL.GetListKhachSanTour(matour);
		}
		public bool AddKhachSanTour(chitietkhachsantour khachsan)
		{
			return khachSanTourDAL.AddKhachSanTour(khachsan);
		}
		public bool UpdateKhachSanTour(chitietkhachsantour khachsan)
		{
			return khachSanTourDAL.UpdateKhachSanTour(khachsan);
		}
		public bool DeleteKhachSanTour(long matour, long makhachsan)
		{
			return khachSanTourDAL.DeleteKhachSanTour(matour, makhachsan);
		}
		public List<khachsan> GetListKhachSan()
		{
			return khachSanTourDAL.loadCBX();
		}
		public chitietkhachsantour GetKhachSanTour(long matour, long makhachsan)
		{
			return khachSanTourDAL.GetKhachSanTour(matour, makhachsan);
		}
	}
}
