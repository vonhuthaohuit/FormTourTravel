using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        HoaDonDAL HoaDonDAL = new HoaDonDAL();
        public List<hoadon> LayDanhSachHoaDon()
        {
            return HoaDonDAL.LayDanhSachHoaDon();
        }
        public void TaoHoaDon(hoadon hd, phieudattour phieudattour)
        {
            HoaDonDAL.TaoHoaDon(hd, phieudattour);
        }
        public void XoaHoaDon(int id)
        {
            HoaDonDAL.XoaHoaDon(id);
        }
        public void SuaHoaDon(hoadon hd)
        {
            HoaDonDAL.SuaHoaDon(hd);
        }
        public void LuuHoaDon(List<hoadon> hoadons)
        {
            HoaDonDAL.LuuHoaDon(hoadons);
        }
    }
}
