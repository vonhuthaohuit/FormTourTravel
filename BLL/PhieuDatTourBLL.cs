using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhieuDatTourBLL
    {
        PhieuDatTourDAL phieuDatTourDAL = new DAL.PhieuDatTourDAL();
        public List<phieudattour> LayTatCaPhieuDatTour()
        {
            return phieuDatTourDAL.LayDanhSachPhieuDatTour();
        }

        public phieudattour TaoPhieuDatTour(int tourId, string nguoiDaiDien, double tongTienPhieuDatTour, int soluong, string trangThaiThanhToan, DateTime ngayDatTour, DateTime ngaykhoihanh)
        {
            try
            {
                return phieuDatTourDAL.TaoPhieuDatTour(tourId, nguoiDaiDien, tongTienPhieuDatTour, soluong, trangThaiThanhToan, ngayDatTour, ngaykhoihanh);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SuaPhieuDatTour(phieudattour phieuDatTour)
        {
            try
            {
                phieuDatTourDAL.SuaPhieuDatTour(phieuDatTour);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaPhieuDatTour(string ma)
        {
            try
            {
                phieuDatTourDAL.XoaPhieuDatTour(ma);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
