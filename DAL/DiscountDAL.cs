using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DiscountDAL
    {
        private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<khuyenmai> Laykhuyenmai()
        {
            return db.khuyenmais.ToList();
        }

        public bool ThemKhuyenMai(khuyenmai km)
        {
            db.khuyenmais.Add(km);
            return db.SaveChanges() > 0;
        }

        public bool XoaKhuyenMai(int makhuyenmai)
        {
            khuyenmai km = db.khuyenmais.Find(makhuyenmai);
            db.khuyenmais.Remove(km);
            return db.SaveChanges() > 0;
        }

        public bool SuaKhuyenMai(khuyenmai km)
        {
            khuyenmai khuyenmai = db.khuyenmais.Find(km.makhuyenmai);
            khuyenmai.thoigianbatdau = km.thoigianbatdau;
            khuyenmai.thoigianketthuc = km.thoigianketthuc;
            khuyenmai.phantramgiam = km.phantramgiam;
            return db.SaveChanges() > 0;
        }
    }
}
