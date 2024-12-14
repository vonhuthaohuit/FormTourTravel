using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<khachhang> LayTatCaKhachHang()
        {
            return db.khachhangs.ToList();
        }

        public khachhang LayKhachHangTheoMa(string ma)
        {
            return db.khachhangs.Find(ma);
        }

        public khachhang ThemKhachHang(khachhang khachHang)
        {
            var khachhang1 = db.khachhangs.Add(khachHang);
            db.SaveChanges();
            return khachhang1;
        }

        public void SuaKhachHang(khachhang khachHang)
        {
            var khachHangSua = db.khachhangs.Find(khachHang.makhachhang);
            khachHangSua.hoten = khachHang.hoten;
            khachHangSua.diachi = khachHang.diachi;
            khachHangSua.sodienthoai = khachHang.sodienthoai;
            db.SaveChanges();
        }

        public void XoaKhachHang(string ma)
        {
            var khachHang = db.khachhangs.Find(ma);
            db.khachhangs.Remove(khachHang);
            db.SaveChanges();
        }
        public List<dynamic> LayKhachHangCoTaiKhoan()
        {
            var result = (from kh in db.khachhangs
                          join user in db.users on kh.mataikhoan equals user.mataikhoan
                          where kh.mataikhoan != null
                          select new
                          {
                              MaKhachHang = kh.makhachhang,
                              Email = user.email
                          }).ToList();

            return result.Cast<dynamic>().ToList();
        }
        public khachhang ThemKhachHangDaiDien(int maTaiKhoan, string hoTen, string cccd, string soDienThoai, DateTime ngaySinh)
        {
            var khachHang = new khachhang
            {
                hoten = hoTen,
                cccd = cccd,
                sodienthoai = soDienThoai,
                ngaysinh = ngaySinh,
                mataikhoan = maTaiKhoan
            };
            var khachHang1 = db.khachhangs.Add(khachHang);
            db.SaveChanges();
            return khachHang1;
        }
    }
}
