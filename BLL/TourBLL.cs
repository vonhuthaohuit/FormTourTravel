using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
	public class TourBLL
	{
		private TourDAL tourDAL = new TourDAL();
		public List<object> LayDanhSachTour()
		{
			return tourDAL.LayDanhSachTour();
		}
		public bool ThemTour(tour tour)
		{
			return tourDAL.ThemTour(tour);
		}
		public bool XoaTour(long matour)
		{
			return tourDAL.XoaTour(matour);
		}
		public tour LayTourTheoMa(long matour)
		{
			return tourDAL.LayTourTheoMa(matour);
		}
		public bool SuaTour(tour tour)
		{
			return tourDAL.SuaTour(tour);
		}
		public string ngayDiTour(long matour)
		{
			return tourDAL.ngayDiTour(matour);
		}
		public bool TinhVaCapNhatGiaTour(long maTour)
		{
			try
			{
				// Gọi hàm để lấy giá tour
				long giaTour = tourDAL.LayGiaTour(maTour);
				return tourDAL.CapNhatGiaTour(maTour, giaTour);
			}
			catch (Exception ex)
			{
				throw new Exception($"Lỗi khi tính và cập nhật giá tour: {ex.Message}");
			}
		}
		public string getTenTour(long matour)
		{
			return tourDAL.getTenTour(matour);
		}

	}
}
