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
	}
}
