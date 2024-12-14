using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DiemDuLichDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<diemdulich> LayDanhSachDiemDuLich()
		{
			return db.diemduliches.ToList();
		}
	}
}
