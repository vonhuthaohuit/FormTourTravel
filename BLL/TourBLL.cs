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
}
