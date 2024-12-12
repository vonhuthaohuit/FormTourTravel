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
    }
}
