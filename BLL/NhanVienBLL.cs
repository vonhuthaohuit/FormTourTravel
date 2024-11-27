using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nhanVienDal = new NhanVienDAL();

        public List<staff> LayDanhSachNhanVien()
        {
            return nhanVienDal.LayDanhSachNhanVien();
        }
    }
}
