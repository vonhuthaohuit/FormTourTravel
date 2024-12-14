using BLL;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DTO;
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

namespace FormTourTravel
{
	public partial class frm_PhuongTienTour : XtraForm
	{
		private PhuongTienTourBLL phuongTienTourBLL = new PhuongTienTourBLL();
		private TourBLL tourBLL = new TourBLL();

		private long matour;
		public frm_PhuongTienTour(long matour)
		{
			InitializeComponent();
			this.matour = matour;
			init(matour);
		}
		private void init(long matour)
		{
			this.matour = matour;
			this.CenterToScreen();
			loadDTGV(matour);
			loadCBX();
			this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				cbx_xe.SelectedValue = row.Cells["maphuongtien"].Value;
				txt_soluong.Text = row.Cells["soluonghanhkhach"].Value.ToString();
				txt_ghichu.Text = row.Cells["ghichu"].Value.ToString();
			}
		}

		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Thêm")
			{
				long.TryParse(cbx_xe.SelectedValue.ToString(), out long maphuongtien);
				addPhuongTienTour(maphuongtien);
				loadDTGV(matour);
			}
			if (e.Button.Properties.Caption == "Làm mới")
			{
				loadDTGV(matour);
			}
			if (e.Button.Properties.Caption == "Xóa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					long maphuongtien = long.Parse(dataGridView1.SelectedRows[0].Cells["maphuongtien"].Value.ToString());
					long matour = long.Parse(dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString());

					if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa phương tiện này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (phuongTienTourBLL.DeletePhuongTienTour(matour, maphuongtien))
						{
							XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							loadDTGV(matour);
						}
						else
						{
							XtraMessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else
				{
					XtraMessageBox.Show("Vui lòng chọn phương tiện cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			if (e.Button.Properties.Caption == "Sửa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					long id = long.Parse(dataGridView1.SelectedRows[0].Cells["maphuongtien"].Value.ToString());

					suaPhuongTienTour(id);
					loadDTGV(matour);
				}
				else
				{
					XtraMessageBox.Show("Vui lòng chọn phương tiện cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		private void loadDTGV(long matour)
		{
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			// sắp xếp cột đầu tiên giảm dầm
			
			var listPhuongTienTour = phuongTienTourBLL.GetListPhuongTienTour(matour);
			dataGridView1.DataSource = listPhuongTienTour;
			if (dataGridView1.Rows.Count > 0)
			{
				dataGridView1.Columns["maphuongtien"].Visible = false;
				dataGridView1.Columns["matour"].Visible = false;
			}
			if (listPhuongTienTour.Count == 0)
			{
				MessageBox.Show("Không có phương tiện nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void cbx_xe_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_xe.SelectedIndex != -1)
			{
				if (cbx_xe.SelectedValue != null && long.TryParse(cbx_xe.SelectedValue.ToString(), out long maphuongtien))
				{
					if (maphuongtien >= 1)
					{
						long soluong = phuongTienTourBLL.GetListPhuongTien()
							.FirstOrDefault(x => x.maphuongtien == maphuongtien)?.sochongoi ?? 0;
						txt_soluong.Text = soluong.ToString();
					}
					else
					{
						txt_soluong.Text = "0";
					}
				}
				else
				{
					txt_soluong.Text = "0";
				}
			}
		}


		private void loadCBX()
		{
			var phuongTiens = phuongTienTourBLL.GetListPhuongTien();
			phuongTiens.Insert(0, new phuongtien { maphuongtien = -1, tenphuongtien = "-- Chọn phương tiện --" });

			cbx_xe.DataSource = phuongTiens;
			cbx_xe.DisplayMember = "tenphuongtien";
			cbx_xe.ValueMember = "maphuongtien";
			cbx_xe.SelectedIndex = 0;
		}



		private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void addPhuongTienTour(long maphuongtien)
		{
			try
			{
				if (string.IsNullOrEmpty(txt_ghichu.Text) || string.IsNullOrEmpty(txt_soluong.Text))
				{
					XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (!long.TryParse(txt_soluong.Text, out long soluong) || soluong <= 0)
					{
						XtraMessageBox.Show("Số lượng phải là số dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					string ghichu = txt_ghichu.Text;

					chitietphuongtientour chitietphuongtientour = new chitietphuongtientour
					{
						matour = matour,
						maphuongtien = maphuongtien,
						soluonghanhkhach = soluong,
						ghichu = ghichu
					};
					bool updateResult = phuongTienTourBLL.AddPhuongTienTour(chitietphuongtientour);
					if (updateResult)
					{

						tourBLL.TinhVaCapNhatGiaTour(matour);
						XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						loadDTGV(matour);
					}
					else
					{
						XtraMessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void suaPhuongTienTour(long maphuongtien)
		{
			try
			{
				if (string.IsNullOrEmpty(txt_soluong.Text))
				{
					XtraMessageBox.Show("Vui lòng số ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (!long.TryParse(txt_soluong.Text, out long soluong) || soluong <= 0)
					{
						XtraMessageBox.Show("Số lượng phải là số dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					string ghichu = txt_ghichu.Text;
					if (string.IsNullOrEmpty(ghichu))
					{
						ghichu = "";
					}

					chitietphuongtientour chitietphuongtientour = new chitietphuongtientour
					{
						matour = matour,
						maphuongtien = maphuongtien,
						soluonghanhkhach = soluong,
						ghichu = ghichu
					};

					var result = phuongTienTourBLL.UpdatePhuongTienTour(chitietphuongtientour);
					if (result)
					{
						tourBLL.TinhVaCapNhatGiaTour(matour);
						XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}
					else
					{
						XtraMessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
