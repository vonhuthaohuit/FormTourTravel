using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class KhuyenMaiDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		public List<khuyenmai> layDanhSachKhuyenMai()
		{
			List<khuyenmai> danhSachKM = new List<khuyenmai>();
			danhSachKM = db.khuyenmais.ToList();
			return danhSachKM;
		}
	}
}
