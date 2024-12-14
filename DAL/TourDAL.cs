using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class TourDAL
	{
		private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<tour> LayDanhSachTour()
		{
			return db.tours.ToList();
		}
		public List<DateTime> LayDanhSachNgayDi(int tourId)
		{
            var ngaydi = db.chitiettours.Where(x => x.matour == tourId).Select(x => x.ngaybatdau).ToList();
            return ngaydi;
        }
	}
}
