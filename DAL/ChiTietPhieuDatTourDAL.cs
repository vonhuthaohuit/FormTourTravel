using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuDatTourDAL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<chitietphieudattour> LayDanhSachChiTietPhieuDatTour()
        {
            List<chitietphieudattour> chitietphieudattours = db.chitietphieudattours.ToList();
            return chitietphieudattours;
        }
        public chitietphieudattour TaoChiTietPhieuDatTour(int makhachhang, int maphieudattour, double gia, int makhachhangDaiDien)
        {
            try
            {
                var chiTiet = new chitietphieudattour
                {
                    makhachhang = makhachhang,
                    maphieudattour = maphieudattour,
                    chitietsotiendat = gia,
                    nguoidat = makhachhangDaiDien.ToString()
                };
                db.chitietphieudattours.Add(chiTiet);
                return chiTiet;
            }
            catch
            {
                return null;

            }
        }
    }
}
