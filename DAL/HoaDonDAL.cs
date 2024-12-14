using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonDAL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<hoadon> LayDanhSachHoaDon()
        {
            var hoaDonsEntity = db.hoadons
                .Where(hd => hd.is_delete == 0)
                .OrderByDescending(hd => hd.mahoadon)
                .ToList();

            var hoaDons = hoaDonsEntity.Select(hd => new hoadon
            {
                mahoadon = hd.mahoadon,
                nguoidaidien = hd.nguoidaidien,
                tongsotien = hd.tongsotien,
                trangthaithanhtoan = hd.trangthaithanhtoan,
                phuongthucthanhtoan = hd.phuongthucthanhtoan,
                masothue = hd.masothue,
                tendonvi = hd.tendonvi,
                diachidonvi = hd.diachidonvi,
                maphieuhuytour = hd.maphieuhuytour,
                maphieudattour = hd.maphieudattour,
            }).ToList();

            return hoaDons;
        }

        public hoadon LayHoaDon(int id)
        {
            try
            {
                hoadon hd = new hoadon();
                hd = db.hoadons.Where(t => t.mahoadon == id).FirstOrDefault();
                return hd;
            }
            catch
            {

                return null;
            }
        }
        public hoadon TaoHoaDon(hoadon hoadon, phieudattour phieudattour)
        {
            try
            {
                hoadon.maphieudattour = phieudattour.maphieudattour;
                hoadon.phuongthucthanhtoan = "Thanh toán trực tiếp";
                hoadon.tongsotien = phieudattour.tongtienphieudattour;
                hoadon.created_at = DateTime.Now;
                hoadon.updated_at = DateTime.Now;
                db.hoadons.Add(hoadon);
                db.SaveChanges();
                return hoadon;
            }
            catch
            {
                return null;
            }
        }
        public bool XoaHoaDon(int id)
        {
            try
            {
                hoadon hd = db.hoadons.Where(t => t.mahoadon == id).FirstOrDefault();
                hd.is_delete = 1;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaHoaDon(hoadon hoadon)
        {
            try
            {
                hoadon hd = db.hoadons.Where(t => t.mahoadon == hoadon.mahoadon).FirstOrDefault();
                hd.trangthaithanhtoan = hoadon.trangthaithanhtoan;
                hd.phuongthucthanhtoan = hoadon.phuongthucthanhtoan;
                hd.masothue = hoadon.masothue;
                hd.tendonvi = hoadon.tendonvi;
                hd.diachidonvi = hoadon.diachidonvi;
                hd.nguoidaidien = hoadon.nguoidaidien;
                hd.maphieuhuytour = hoadon.maphieuhuytour;
                hd.maphieudattour = hoadon.maphieudattour;
                hd.is_delete = hoadon.is_delete;
                hd.updated_at = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool LuuHoaDon(List<hoadon> hoadons)
        {
            try
            {
                foreach (hoadon hd in hoadons)
                {
                    hoadon hd1 = db.hoadons.Where(t => t.mahoadon == hd.mahoadon).FirstOrDefault();
                    hd1.trangthaithanhtoan = hd.trangthaithanhtoan;
                    hd1.phuongthucthanhtoan = hd.phuongthucthanhtoan;
                    hd1.masothue = hd.masothue;
                    hd1.tendonvi = hd.tendonvi;
                    hd1.diachidonvi = hd.diachidonvi;
                    hd1.nguoidaidien = hd.nguoidaidien;
                    hd1.maphieuhuytour = hd.maphieuhuytour;
                    hd1.maphieudattour = hd.maphieudattour;
                    hd1.is_delete = hd.is_delete;
                    hd1.updated_at = DateTime.Now;
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
