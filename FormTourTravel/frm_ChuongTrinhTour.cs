using BLL;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DTO;

namespace FormTourTravel
{
	public partial class frm_ChuongTrinhTour : XtraForm
	{
		private long matour;
		private ChuongTrinhTourBLL chuongTrinhTourBLL = new ChuongTrinhTourBLL();
		private TourBLL tourBLL = new TourBLL();
		public frm_ChuongTrinhTour(long matour)
		{
			InitializeComponent();
			this.matour = matour;
			loadChuongTrinhTour();
			this.CenterToScreen();
			this.Text = "Chương trình tour";
		}
		public bool loadChuongTrinhTour()
		{
			try
			{
				string tentour = tourBLL.getTenTour(matour);
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				var listChuongTrinhTour = chuongTrinhTourBLL.GetListChuongTrinh(matour);
				dataGridView1.DataSource = listChuongTrinhTour;
				label5.Text = tentour;
				if (listChuongTrinhTour.Count == 0)
				{
					MessageBox.Show("Không có chương trình tour nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Thêm")
			{
				addChuongTrinhTour();
			}
			if (e.Button.Properties.Caption == "Sửa")
			{
				if (dataGridView1.SelectedRows.Count == 0)
				{
					MessageBox.Show("Vui lòng chọn chương trình tour cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					var row = dataGridView1.SelectedRows[0];
					long id = long.Parse(row.Cells["machuongtrinhtour"].Value.ToString());
					suaCTTour(id);
				}
			}
			if (e.Button.Properties.Caption == "Xóa")
			{
				if (dataGridView1.SelectedRows.Count == 0)
				{
					MessageBox.Show("Vui lòng chọn chương trình tour cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					var row = dataGridView1.SelectedRows[0];
					long id = long.Parse(row.Cells["machuongtrinhtour"].Value.ToString());
					if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						var result = chuongTrinhTourBLL.DeleteChuongTrinhTour(id);
						if (result)
						{
							MessageBox.Show("Xóa chương trình tour thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							loadChuongTrinhTour();
						}
						else
						{
							MessageBox.Show("Xóa chương trình tour thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
			if (e.Button.Properties.Caption == "Làm mới")
			{
				loadChuongTrinhTour();
			}
		}
		private void addChuongTrinhTour()
		{

			string matour = this.matour.ToString();
			string tieude = txt_tieude.Text;
			string mota = txt_mota.Text;
			string ngay = txt_ngay.Text;

			if (string.IsNullOrEmpty(tieude) || string.IsNullOrEmpty(mota) || string.IsNullOrEmpty(ngay))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				chuongtrinhtour chuongtrinhtour = new chuongtrinhtour()
				{
					matour = long.Parse(matour),
					tieude = tieude,
					mota = mota,
					ngay = ngay,
				};
				var result = chuongTrinhTourBLL.AddChuongTrinhTour(chuongtrinhtour);
				if (result)
				{
					MessageBox.Show("Thêm chương trình tour thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loadChuongTrinhTour();
				}
				else
				{
					MessageBox.Show("Thêm chương trình tour thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		private void suaCTTour(long id)
		{
			string matour = this.matour.ToString();
			string tieude = txt_tieude.Text;
			string mota = txt_mota.Text;
			string ngay = txt_ngay.Text;
			if (string.IsNullOrEmpty(tieude) || string.IsNullOrEmpty(mota) || string.IsNullOrEmpty(ngay))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				chuongtrinhtour chuongtrinhtour = new chuongtrinhtour()
				{
					machuongtrinhtour = id,
					matour = long.Parse(matour),
					tieude = tieude,
					mota = mota,
					ngay = ngay,
				};
				var result = chuongTrinhTourBLL.UpdateChuongTrinhTour(chuongtrinhtour);
				if (result)
				{
					MessageBox.Show("Sửa chương trình tour thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loadChuongTrinhTour();
				}
				else
				{
					MessageBox.Show("Sửa chương trình tour thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex] != null)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				if (row.Cells["tieude"].Value != DBNull.Value && row.Cells["tieude"].Value != null)
				{
					txt_tieude.Text = row.Cells["tieude"].Value.ToString();
				}
				if (row.Cells["mota"].Value != DBNull.Value && row.Cells["mota"].Value != null)
				{
					txt_mota.Text = row.Cells["mota"].Value.ToString();
				}
				if (row.Cells["ngay"].Value != DBNull.Value && row.Cells["ngay"].Value != null)
				{
					txt_ngay.Text = row.Cells["ngay"].Value.ToString();
				}
			}
		}
	}
}
