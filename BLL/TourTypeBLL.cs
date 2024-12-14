using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TourTypeBLL
    {
        private TourTypeDAL tourTypeDAL = new TourTypeDAL();
        public List<loaitour> layDanhSachLoaiTour()
        {
            return tourTypeDAL.layDanhSachLoaiTour();
        }
		public List<object> getlistTour()
		{
			return tourTypeDAL.getlistTour();
		}
		public bool themLoaiTour(string tenloai)
		{
			return tourTypeDAL.themLoaiTour(tenloai);
		}
		public bool xoaLoaiTour(long maloaitour)
		{
			return tourTypeDAL.xoaLoaiTour(maloaitour);
		}
		public bool suaLoaiTour(loaitour loaitour)
		{
			return tourTypeDAL.suaLoaiTour(loaitour);
		}
	}
}
