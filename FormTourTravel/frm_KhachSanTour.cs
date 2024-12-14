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
namespace FormTourTravel
{
	public partial class frm_KhachSanTour : XtraForm
	{
		private KhachSanTourBLL khachSanTourBLL = new KhachSanTourBLL();
		private TourBLL tourBLL = new TourBLL();
		private long matour;
		public frm_KhachSanTour(long matour)
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
		}
		private void loadDTGV(long matour)
		{
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			var result = khachSanTourBLL.GetListKhachSanTour(matour);
			dataGridView1.DataSource = result;
			if (dataGridView1.Rows.Count > 0)
			{
				dataGridView1.Columns["makhachsan"].Visible = false;
				dataGridView1.Columns["matour"].Visible = false;
			}


		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Thêm")
			{
				btn_them_Click();
				loadDTGV(matour);
			}
			if (e.Button.Properties.Caption == "Sửa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					// Lấy mã tour từ dòng được chọn
					long makhachsan = long.Parse(dataGridView1.SelectedRows[0].Cells["makhachsan"].Value.ToString());
					btn_sua_Click(makhachsan);
					loadDTGV(matour);
				}
				else
				{
					MessageBox.Show("Vui lòng chọn khách sạn cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			if (e.Button.Properties.Caption == "Xóa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					// Lấy mã tour từ dòng được chọn
					var makhachsan = dataGridView1.SelectedRows[0].Cells["makhachsan"].Value.ToString();
					// Xác nhận xóa
					var result = MessageBox.Show(
						"Bạn có chắc chắn muốn xóa khách sạn này không?",
						"Xác nhận",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);
					if (result == DialogResult.Yes)
					{
						// Xóa tour
						khachSanTourBLL.DeleteKhachSanTour(matour, long.Parse(makhachsan));
						tourBLL.TinhVaCapNhatGiaTour(matour);
						loadDTGV(matour);
					}
				}
				else
				{
					MessageBox.Show("Vui lòng chọn khách sạn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			if (e.Button.Properties.Caption == "Làm mới")
			{
				loadDTGV(matour);
			}
		}
		private void loadCBX()
		{
			var khachSan = khachSanTourBLL.GetListKhachSan();
			khachSan.Insert(0, new khachsan { makhachsan = -1, tenkhachsan = "-- Chọn khách sạn --" });
			cbx_khachsan.DataSource = khachSan;
			cbx_khachsan.DisplayMember = "tenkhachsan";
			cbx_khachsan.ValueMember = "makhachsan";
			cbx_khachsan.SelectedIndex = 0;
		}
		private void txt_succhua_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		private bool checkNull(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			return true;
		}
		private void btn_them_Click()
		{
			string vitriphong = txt_vitriphong.Text;
			string succhua = txt_succhua.Text;
			if (!checkNull(vitriphong) || !checkNull(succhua) || cbx_khachsan.SelectedIndex == -1)
			{
				XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				chitietkhachsantour khachSanTour = new chitietkhachsantour();
				khachSanTour.matour = matour;
				khachSanTour.makhachsan = long.Parse(cbx_khachsan.SelectedValue.ToString());
				khachSanTour.succhua = long.Parse(succhua);
				khachSanTour.vitriphong = vitriphong;

				if (khachSanTourBLL.AddKhachSanTour(khachSanTour))
				{
					tourBLL.TinhVaCapNhatGiaTour(matour);
					XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				}
				else
				{
					XtraMessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

		}

		private void btn_sua_Click(long makhachsan)
		{
			string vitriphong = txt_vitriphong.Text;
			string succhua = txt_succhua.Text;
			if (!checkNull(vitriphong) || !checkNull(succhua) || cbx_khachsan.SelectedIndex == -1)
			{
				XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				chitietkhachsantour khachSanTour = new chitietkhachsantour();
				khachSanTour.matour = matour;
				khachSanTour.makhachsan = makhachsan;
				khachSanTour.succhua = long.Parse(succhua);
				khachSanTour.vitriphong = vitriphong;
				if (khachSanTourBLL.UpdateKhachSanTour(khachSanTour))
				{
					tourBLL.TinhVaCapNhatGiaTour(matour);
					XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				}
				else
				{
					XtraMessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex] != null)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				txt_vitriphong.Text = row.Cells["vitriphong"].Value.ToString();
				txt_succhua.Text = row.Cells["succhua"].Value.ToString();
				cbx_khachsan.SelectedValue = row.Cells["makhachsan"].Value;
			}
		}
	}
}
