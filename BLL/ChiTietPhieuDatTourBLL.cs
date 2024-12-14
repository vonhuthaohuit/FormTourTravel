using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ChiTietPhieuDatTourBLL
    {
        public List<chitietphieudattour> LayDanhSachChiTietPhieuDatTour()
        {
            ChiTietPhieuDatTourDAL dal = new ChiTietPhieuDatTourDAL();
            return dal.LayDanhSachChiTietPhieuDatTour();
        }
        public bool TaoChiTietPhieuDatTour(int makhachhang, int maphieudattour, double gia, int makhachhangDaiDien)
        {
            try
            {
                ChiTietPhieuDatTourDAL dal = new ChiTietPhieuDatTourDAL();
                dal.TaoChiTietPhieuDatTour(makhachhang, maphieudattour, gia, makhachhangDaiDien);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
