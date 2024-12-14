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
		public List<tour> LayDanhSachTour()
		{
			return tourDAL.LayDanhSachTour();
		}
		public List<DateTime> LayDanhSachNgayDi(int tourId)
        {
            return tourDAL.LayDanhSachNgayDi(tourId);
        }
    }

        public List<dynamic> LayTourDaDat()
        {
            return tourDAL.LayTourDaDat();
        }

		public List<dynamic> TimKiemHoaDonVaPhieuDat(string nguoiDaiDien, DateTime? ngayDatTour)
		{
            return tourDAL.TimKiemHoaDonVaPhieuDat(nguoiDaiDien, ngayDatTour);
        }

		public bool HuyTour(int matour, string nguoidaidien, DateTime ngaydattour)
		{
            return tourDAL.HuyTour(matour, nguoidaidien, ngaydattour);
        }
    }
}
