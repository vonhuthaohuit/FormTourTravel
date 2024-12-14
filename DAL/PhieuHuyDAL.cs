using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuHuyDAL
    {
        private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

        public List<dynamic> LayDanhSachPhieuHuy()
        {
            var danhSachPhieuHuy = (from ph in db.phieuhuytours
                                    join hd in db.hoadons on ph.maphieuhuytour equals hd.maphieuhuytour
                                    join pd in db.phieudattours on hd.maphieudattour equals pd.maphieudattour
                                    join t in db.tours on pd.matour equals t.matour
                                    select new
                                    {
                                        MaPhieuHuyTour = ph.maphieuhuytour,
                                        SoTienHoan = ph.sotienhoan,
                                        LyDoHuy = ph.lydohuy,
                                        NgayHuy = ph.ngayhuy,
                                        TenTour = t.tentour
                                    }).ToList();

            return danhSachPhieuHuy.Cast<dynamic>().ToList();
        }
    }
}
