using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Drawing.Printing;

namespace FormTourTravel
{
	public partial class frm_ChiTietTour : XtraForm
	{

		private readonly TourBLL tourBLL = new TourBLL();
		private readonly DiemDuLichBLL diemDuLichBLL = new DiemDuLichBLL();
		private readonly ChiTietTourBLL chiTietTourBLL = new ChiTietTourBLL();
		private ChiTietTourBLL ChiTietTourBLL = new ChiTietTourBLL();

		private long matour;
		public frm_ChiTietTour(long matour)
		{
			InitializeComponent();
			this.CenterToScreen();
			init(matour);
			this.matour = matour;

		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Thêm")
			{
				themChiTietTour();
				LoadDTGV(this.matour);
			}
			if (e.Button.Properties.Caption == "Làm mới")
			{
				LoadDTGV(this.matour);
			}
			if (e.Button.Properties.Caption == "Sửa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					long madiadiem = long.Parse(dataGridView1.SelectedRows[0].Cells["madiemdulich"].Value.ToString());
					SuaChiTietTour(madiadiem);

				}
			}
			if (e.Button.Properties.Caption == "Xóa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết tour này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						long madiadiem = long.Parse(dataGridView1.SelectedRows[0].Cells["madiemdulich"].Value.ToString());
						bool success = chiTietTourBLL.XoaChiTietTour(this.matour, madiadiem);
						if (success)
						{
							MessageBox.Show("Xóa chi tiết tour thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadDTGV(this.matour);
						}
						else
						{
							MessageBox.Show("Xóa chi tiết tour thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

				}
			}

		}
		public void init(long matour)
		{
			LoadDTGV(matour);
			layTenTour(matour);
			LoadCBX();
		}

		private void layTenTour(long matour)
		{
			label2.Text = ChiTietTourBLL.layTenTour(matour);
		}


		private void themChiTietTour()
		{
			txt_matour.Text = matour.ToString();
			if (string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(txt_giatour.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!long.TryParse(txt_giatour.Text, out long giatour))
			{
				MessageBox.Show("Giá tour phải là số!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!DateTime.TryParse(dateTimePicker1.Text, out DateTime ngaybatdau))
			{
				MessageBox.Show("Ngày bắt đầu không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!int.TryParse(tourBLL.ngayDiTour(this.matour), out int ngayditour))
			{
				MessageBox.Show("Ngày đi tour không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DateTime ngayketthuc = ngaybatdau.AddDays(ngayditour);

			chitiettour chitiettour = new chitiettour
			{
				matour = matour,
				madiemdulich = long.Parse(cbx_diemdulich.SelectedValue.ToString()),
				ngaybatdau = ngaybatdau,
				ngayketthuc = ngayketthuc,
				giachitiettour = giatour
			};
			bool them = chiTietTourBLL.ThemChiTietTour(chitiettour);
			if (them)
			{
				tourBLL.TinhVaCapNhatGiaTour(matour);
				MessageBox.Show("Thêm chi tiết tour thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDTGV(this.matour);
			}
			else
			{
				MessageBox.Show("Thêm chi tiết tour thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SuaChiTietTour(long madiadiem)
		{
			txt_matour.Text = matour.ToString();

			if (string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(txt_giatour.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!long.TryParse(txt_giatour.Text, out long giatour))
			{
				MessageBox.Show("Giá tour phải là số!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(tourBLL.ngayDiTour(this.matour), out int ngayditour))
			{
				MessageBox.Show("Ngày đi tour không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Load existing details
			var existingChitiet = chiTietTourBLL.layChiTietTour(matour, madiadiem);

			DateTime ngaybatdau = DateTime.Parse(dateTimePicker1.Text);
			// Update only if the fields are not empty
			DateTime ngayketthuc = ngaybatdau.AddDays(ngayditour);

			chitiettour chitiettour = new chitiettour
			{
				matour = matour,
				madiemdulich = long.Parse(cbx_diemdulich.SelectedValue.ToString()),
				ngaybatdau = ngaybatdau != DateTime.MinValue ? ngaybatdau : existingChitiet.ngaybatdau,
				ngayketthuc = ngayketthuc != DateTime.MinValue ? ngayketthuc : existingChitiet.ngayketthuc,
				giachitiettour = giatour != 0 ? giatour : existingChitiet.giachitiettour
			};

			bool sua = chiTietTourBLL.SuaChiTiet(chitiettour);

			if (sua)
			{
				tourBLL.TinhVaCapNhatGiaTour(matour);
				MessageBox.Show("Sửa chi tiết tour thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDTGV(this.matour);
			}
			else
			{
				MessageBox.Show("Sửa chi tiết tour thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadCBX()
		{
			cbx_diemdulich.DataSource = diemDuLichBLL.LayDanhSachDiemDuLich();
			cbx_diemdulich.DisplayMember = "tendiemdulich";
			cbx_diemdulich.ValueMember = "madiemdulich";
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex] != null)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				if (row.Cells["ngaybatdau"].Value != DBNull.Value && row.Cells["ngaybatdau"].Value != null)
				{
					dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngaybatdau"].Value);
				}

				if (row.Cells["giachitiettour"].Value != DBNull.Value && row.Cells["giachitiettour"].Value != null)
				{
					txt_giatour.Text = row.Cells["giachitiettour"].Value.ToString();
				}

				if (row.Cells["madiemdulich"].Value != DBNull.Value && row.Cells["madiemdulich"].Value != null)
				{
					cbx_diemdulich.SelectedValue = row.Cells["madiemdulich"].Value;
				}

				txt_matour.Text = matour.ToString();
			}
		}

		private void LoadDTGV(long matour)
		{
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			var chiTietTour = ChiTietTourBLL.LayChiTietTourTheoMaTour(matour);

			if (chiTietTour == null || !chiTietTour.Any())
			{
				MessageBox.Show("Không có chi tiết tour nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				dataGridView1.DataSource = null;
				return;
			}

			dataGridView1.DataSource = chiTietTour;

			if (dataGridView1.Columns["madiemdulich"] != null)
				dataGridView1.Columns["madiemdulich"].Visible = false;

			if (dataGridView1.Columns["tentour"] != null)
				dataGridView1.Columns["tentour"].HeaderText = "Tên Tour";

			if (dataGridView1.Columns["tendiemdulich"] != null)
				dataGridView1.Columns["tendiemdulich"].HeaderText = "Tên Điểm Tour";

			if (dataGridView1.Columns["ngaybatdau"] != null)
				dataGridView1.Columns["ngaybatdau"].HeaderText = "Ngày Bắt đầu";

			if (dataGridView1.Columns["ngayketthuc"] != null)
				dataGridView1.Columns["ngayketthuc"].HeaderText = "Ngày Kết thúc";

			if (dataGridView1.Columns["giachitiettour"] != null)
			{
				dataGridView1.Columns["giachitiettour"].HeaderText = "Giá Tour";
				dataGridView1.Columns["giachitiettour"].ValueType = typeof(long);

				dataGridView1.CellFormatting += (s, e) =>
				{
					if (e.ColumnIndex == dataGridView1.Columns["giachitiettour"].Index && e.Value != null && e.Value is long giatour)
					{
						e.Value = giatour.ToString("N0");
						e.FormattingApplied = true;
					}
				};
			}
		}
	}
}
