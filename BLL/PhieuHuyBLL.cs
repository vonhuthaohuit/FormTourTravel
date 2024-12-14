using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuHuyBLL
    {
        private DAL.PhieuHuyDAL phieuHuyDAL = new DAL.PhieuHuyDAL();
        public List<dynamic> LayDanhSachPhieuHuy()
        {
            return phieuHuyDAL.LayDanhSachPhieuHuy();
        }

        public List<dynamic> LayDanhSachPhieuHuyTheoThang(int thang)
        {
            return phieuHuyDAL.LayDanhSachPhieuHuyTheoThang(thang);
        }
    }
}
