using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class PhongBanBLL
    {
        private PhongBanDAL phongBanDal = new PhongBanDAL();
        public List<department> LayDanhSachPhongBan()
        {
            return phongBanDal.LayDanhSachPhongBan();
        }
    }
}
