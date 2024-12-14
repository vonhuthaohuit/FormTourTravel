using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
	public class ChiTietTourBLL
	{
		private readonly ChiTietTourDAL chiTietTourDAL = new ChiTietTourDAL();
		public List<object> LayChiTietTourTheoMaTour(long matour)
		{
			return chiTietTourDAL.LayChiTietTourTheoMaTour(matour);
		
		}
		public string layTenTour(long matour)
		{
			return chiTietTourDAL.layTenTour(matour);
		}
		public bool ThemChiTietTour(chitiettour chiTietTour)
		{
			return chiTietTourDAL.ThemChiTietTour(chiTietTour);
		}
		public chitiettour layChiTietTour(long matour, long madiemdulich)
		{
			return chiTietTourDAL.layChiTietTour(matour, madiemdulich);
		}
		public bool XoaChiTietTour(long matour, long madiemdulich)
		{
			return chiTietTourDAL.XoaChiTiet(matour, madiemdulich);
		}
		public bool SuaChiTiet(chitiettour chiTietTour)
		{
			return chiTietTourDAL.SuaChiTiet(chiTietTour);
		}
	}
}
