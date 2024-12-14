using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
	public class ChuongTrinhTourBLL
	{
		private readonly ChuongTrinhTourDAL chuongTrinhTourDAL = new ChuongTrinhTourDAL();
		public List<object> GetListChuongTrinh(long matour)
		{
			return chuongTrinhTourDAL.GetListChuongTrinhTour(matour);
		}
		public bool AddChuongTrinhTour(chuongtrinhtour chuongtrinhtour)
		{
			return chuongTrinhTourDAL.AddChuongTrinhTour(chuongtrinhtour);
		}
		public bool UpdateChuongTrinhTour(chuongtrinhtour chuongtrinhtour)
		{
			return chuongTrinhTourDAL.UpdateChuongTrinhTour(chuongtrinhtour);
		}
		public bool DeleteChuongTrinhTour(long id)
		{
			return chuongTrinhTourDAL.DeleteChuongTrinhTour(id);
		}
		public chuongtrinhtour GetChuongTrinhTour(long id)
		{
			return chuongTrinhTourDAL.GetChuongTrinhTour(id);
		}
	}
}
