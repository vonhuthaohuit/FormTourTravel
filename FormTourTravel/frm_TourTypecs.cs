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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FormTourTravel
{
	public partial class frm_TourTypecs : XtraForm
	{
		private readonly BLL.TourTypeBLL tourTypeBLL = new BLL.TourTypeBLL();
		public frm_TourTypecs()
		{
			InitializeComponent();
			loadDTGV();

		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{

			if (e.Button.Properties.Caption == "Thêm")
			{
				btn_them_Click();
			}
			if (e.Button.Properties.Caption == "Sửa")
			{
				btn_sua_Click();
			}
			if (e.Button.Properties.Caption == "Xóa")
			{
				btn_xoa_Click();
			}
			if (e.Button.Properties.Caption == "Làm mới")
			{
				loadDTGV();
			}

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textEdit1.Text = row.Cells["tenloai"].Value.ToString();
			}
		}
		private void loadDTGV()
		{

			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.DataSource = tourTypeBLL.getlistTour();

		}
		private void btn_them_Click()
		{
			if (textEdit1.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				tourTypeBLL.themLoaiTour(textEdit1.Text);
				MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loadDTGV();

			}
		}
		private void btn_sua_Click()
		{
			if (textEdit1.Text == "")
			{
				MessageBox.Show("Vui lòng chọn loại tour cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				var maloaitour = dataGridView1.SelectedRows[0].Cells["maloaitour"].Value.ToString();
				var loaitour = textEdit1.Text;
				DTO.loaitour loaitour1 = new DTO.loaitour();
				loaitour1.maloaitour = long.Parse(maloaitour);
				loaitour1.tenloai = loaitour;
				tourTypeBLL.suaLoaiTour(loaitour1);
				MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loadDTGV();
			}
		}
		private void btn_xoa_Click()
		{
			if (textEdit1.Text == "")
			{
				MessageBox.Show("Vui lòng chọn loại tour cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				var maloaitour = dataGridView1.SelectedRows[0].Cells["maloaitour"].Value.ToString();
				tourTypeBLL.xoaLoaiTour(long.Parse(maloaitour));
				MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loadDTGV();
			}
		}

	}
}
