using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DanhGiaDAL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<danhgia> LayDanhSachDanhGia()
        {
            // Bước 1: Kết nối bảng danhgias với khachhangs
            var danhSachKhachHang = (from dg in db.danhgias
                                     join kh in db.khachhangs on dg.makhachhang equals kh.makhachhang
                                     select new
                                     {
                                         madanhgia = dg.madanhgia,
                                         noidung = dg.noidung,
                                         tinhtrang = dg.tinhtrang,
                                         diemdanhgia = dg.diemdanhgia,
                                         hotenKhachHang = kh.hoten,
                                         matour = dg.matour,
                                         created_at = dg.created_at,
                                         updated_at = dg.updated_at
                                     }).ToList();

            // Bước 2: Kết nối kết quả danhSachKhachHang với bảng tours
            var danhSach = (from dgkh in danhSachKhachHang
                            join t in db.tours on Convert.ToInt32(dgkh.matour) equals t.matour
                            select new
                            {
                                madanhgia = dgkh.madanhgia,
                                noidung = dgkh.noidung,
                                tinhtrang = dgkh.tinhtrang,
                                diemdanhgia = dgkh.diemdanhgia,
                                hotenKhachHang = dgkh.hotenKhachHang,
                                tentour = t.tentour,
                                created_at = dgkh.created_at,
                                updated_at = dgkh.updated_at
                            }).ToList();

            // Bước 3: Chuyển đổi kết quả thành đối tượng danhgia
            var result = danhSach.Select(d => new danhgia
            {
                madanhgia = d.madanhgia,
                noidung = d.noidung,
                tinhtrang = d.tinhtrang,
                hotenKhachHang = d.hotenKhachHang,
                tentour = d.tentour,
                diemdanhgia = d.diemdanhgia,
                created_at = d.created_at,
                updated_at = d.updated_at
            }).ToList();

            // Bước 4: Trả về kết quả
            return result;
        }

        public bool LuuTinhTrang(int tinhtrang, int madanhgia)
        {
            var danhGia = db.danhgias.Find(madanhgia);
            if (danhGia == null)
                return false;

            danhGia.tinhtrang = tinhtrang;
            return db.SaveChanges() > 0;
        }

        public bool XoaDanhGia(int madanhgia)
        {
            var danhGia = db.danhgias.Find(madanhgia);
            if (danhGia == null)
                return false;
            db.danhgias.Remove(danhGia);
            return db.SaveChanges() > 0;
        }
    }
}
