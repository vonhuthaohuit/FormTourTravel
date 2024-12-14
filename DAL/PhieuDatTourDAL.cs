using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDatTourDAL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<phieudattour> LayDanhSachPhieuDatTour()
        {
            return db.phieudattours.ToList();
        }
        public phieudattour TaoPhieuDatTour(int tourId, string nguoiDaiDien ,double tongTienPhieuDatTour, int soluong, string trangThaiThanhToan, DateTime ngayDatTour, DateTime ngaykhoihanh)
        {
            var phieuDatTour = db.phieudattours.Add(new phieudattour
            {
                matour = tourId,
                nguoidaidien = nguoiDaiDien,
                tongtienphieudattour = tongTienPhieuDatTour,
                tongsoluong = soluong,
                trangthaidattour = trangThaiThanhToan,
                ngaybatdau = ngayDatTour,
                ngaydattour = ngaykhoihanh
            });
            db.SaveChanges();
            return phieuDatTour;
        }
        public void SuaPhieuDatTour(phieudattour pdt)
        {
            var pdtSua = db.phieudattours.Find(pdt.maphieudattour);
            pdtSua.matour = pdt.matour;
            pdtSua.ngaydattour = pdt.ngaydattour;
            db.SaveChanges();
        }
        public void XoaPhieuDatTour(string ma)
        {
            var pdt = db.phieudattours.Find(ma);
            db.phieudattours.Remove(pdt);
            db.SaveChanges();
        }

    }
}
