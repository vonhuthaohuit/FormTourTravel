using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class KhuyenMaiBLL
	{
		private KhuyenMaiDAL khuyenMaiDAL = new KhuyenMaiDAL();
		public List<khuyenmai> layDanhSachKhuyenMai()
		{
			return khuyenMaiDAL.layDanhSachKhuyenMai();
		}
	}
}
