using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace DAL
{
	public class ChiTietTourDAL
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

		public List<object> LayChiTietTourTheoMaTour(long matour)
		{
			var chiTietTour = db.chitiettours
								.Join(db.diemduliches,
									  ct => ct.madiemdulich,
									  d => d.madiemdulich,
									  (ct, d) => new { ct, d })
								.Join(db.tours,
									  ct_d => ct_d.ct.matour,
									  t => t.matour,
									  (ct_d, t) => new { ct_d.ct, ct_d.d, t })
								.Where(result => result.ct.matour == matour)
								.Select(result => new
								{
									result.d.madiemdulich,
									result.ct.ngaybatdau,
									result.ct.ngayketthuc,
									result.ct.giachitiettour,
									result.t.tentour,
									result.d.tendiemdulich,
								})
								.ToList<object>();

			return chiTietTour;
		}
		public string layTenTour(long matour)
		{
			var tentour = db.tours
							.Where(t => t.matour == matour)
							.Select(t => t.tentour)
							.FirstOrDefault();
			return tentour;
		}
		public bool ThemChiTietTour(chitiettour chiTietTour)
		{
			try
			{
				db.chitiettours.Add(chiTietTour);
				db.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public chitiettour layChiTietTour(long matour, long madiemdulich)
		{
			var chiTietTour = db.chitiettours
								.Where(ct => ct.matour == matour && ct.madiemdulich == madiemdulich)
								.FirstOrDefault();
			return chiTietTour;
		}
		public bool SuaChiTiet(chitiettour chitiettour)
		{
			try
			{
				// Tìm thực thể hiện tại dựa trên khóa chính
				var chiTietTour = db.chitiettours
									.Where(ct => ct.matour == chitiettour.matour && ct.madiemdulich == chitiettour.madiemdulich)
									.FirstOrDefault();

				if (chiTietTour == null)
				{
					return false; // Không tìm thấy thực thể để sửa
				}

				// Kiểm tra nếu thuộc tính 'ngaybatdau' bị thay đổi
				if (chiTietTour.ngaybatdau != chitiettour.ngaybatdau)
				{
					// Xóa thực thể cũ
					db.chitiettours.Remove(chiTietTour);

					// Thêm thực thể mới với giá trị được cập nhật
					db.chitiettours.Add(chitiettour);
				}
				else
				{
					// Chỉ cập nhật các thuộc tính khác
					chiTietTour.ngayketthuc = chitiettour.ngayketthuc;
					chiTietTour.giachitiettour = chitiettour.giachitiettour;
				}

				db.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool XoaChiTiet(long matour, long madiemdulich)
		{
			try
			{
				var chiTietTour = db.chitiettours
									.Where(ct => ct.matour == matour && ct.madiemdulich == madiemdulich)
									.FirstOrDefault();
				db.chitiettours.Remove(chiTietTour);
				db.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
