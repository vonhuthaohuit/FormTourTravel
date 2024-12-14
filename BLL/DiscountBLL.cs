using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DiscountBLL
    {
        private DiscountDAL discountDAL = new DiscountDAL();
        public List<khuyenmai> Laykhuyenmai()
        {
            return discountDAL.Laykhuyenmai();
        }

        public bool ThemKhuyenMai(khuyenmai km)
        {
            return discountDAL.ThemKhuyenMai(km);
        }

        public bool XoaKhuyenMai(int makhuyenmai)
        {
            return discountDAL.XoaKhuyenMai(makhuyenmai);
        }

        public bool SuaKhuyenMai(khuyenmai km)
        {
            return discountDAL.SuaKhuyenMai(km);
        }
    }
}
