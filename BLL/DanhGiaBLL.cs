using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DanhGiaBLL
    {
        private DanhGiaDAL danhGiaDAL = new DanhGiaDAL();
        public List<danhgia> LayDanhSachDanhGia()
        {
            return danhGiaDAL.LayDanhSachDanhGia();
        }

        public bool LuuTinhTrang(int tinhtrang, int madanhgia)
        {
            return danhGiaDAL.LuuTinhTrang(tinhtrang, madanhgia);
        }

        public bool XoaDanhGia(int madanhgia)
        {
            return danhGiaDAL.XoaDanhGia(madanhgia);
        }
    }
}
