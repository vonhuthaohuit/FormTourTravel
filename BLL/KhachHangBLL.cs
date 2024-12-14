using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        DAL.KhachHangDAL khachHangDAL = new DAL.KhachHangDAL();
        public List<khachhang> LayTatCaKhachHang()
        {
            return khachHangDAL.LayTatCaKhachHang();
        }

        public khachhang LayKhachHangTheoMa(string ma)
        {
            return khachHangDAL.LayKhachHangTheoMa(ma);
        }

        public khachhang ThemKhachHangDaiDien(int maTaiKhoan, string hoTen, string cccd, string soDienThoai, DateTime ngaySinh)
        {
            try
            {
                var khachhang1 = khachHangDAL.ThemKhachHangDaiDien(maTaiKhoan, hoTen, cccd, soDienThoai, ngaySinh);
                return khachhang1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SuaKhachHang(khachhang khachHang)
        {
            try
            {
                khachHangDAL.SuaKhachHang(khachHang);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaKhachHang(string ma)
        {
            try
            {
                khachHangDAL.XoaKhachHang(ma);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<dynamic> LayKhachHangCoTaiKhoan()
        {
            return khachHangDAL.LayKhachHangCoTaiKhoan();
        }
    }
}
