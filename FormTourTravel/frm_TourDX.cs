using BLL;
using DevExpress.XtraEditors;
using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FormTourTravel
{
	public partial class frm_TourDX : XtraForm
	{
		private RibbonForm1 ribbonForm1;
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		private TourBLL tourBLL = new TourBLL();
		public frm_TourDX(RibbonForm1 ribbonForm)
		{
			InitializeComponent();
			ribbonForm1 = ribbonForm;
			GetDataSource();
			dataGridView1.Dock = DockStyle.Fill;
		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Thêm")
			{
				frm_AddTourDX frm = new frm_AddTourDX();
				frm.ShowDialog();
			}
			if (e.Button.Properties.Caption == "Sửa")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					var matour = dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString();
					frm_AddTourDX frm = new frm_AddTourDX(long.Parse(matour));
					frm.ShowDialog();
				}
				else
				{
					MessageBox.Show("Vui lòng chọn tour cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			if (e.Button.Properties.Caption == "Xóa")
			{

				if (dataGridView1.SelectedRows.Count > 0)
				{
					var matour = dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString();

					var result = MessageBox.Show(
						"Bạn có chắc chắn muốn xóa tour này không?",
						"Xác nhận",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);
					if (result == DialogResult.Yes)
					{
						// Xóa tour
						tourBLL.XoaTour(long.Parse(matour));
						GetDataSource();
					}
				}
				else
				{
					MessageBox.Show("Vui lòng chọn tour cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

			}
			if (e.Button.Properties.Caption == "Làm mới")
			{
				GetDataSource();
			}
			if (e.Button.Properties.Caption == "Chi tiết tour")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					long matour = long.Parse(dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString());
					frm_ChiTietTour frmChiTietTour = new frm_ChiTietTour(matour);
					ribbonForm1.showFormInPanel(frmChiTietTour);

				}
				else
				{
					MessageBox.Show("Vui lòng chọn tour cần xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}


			if (e.Button.Properties.Caption == "Print")
			{
				
			}
			if (e.Button.Properties.Caption == "Chương trình tour")
			{
				long matour = 0;

				if (dataGridView1.SelectedRows.Count > 0)
				{
					matour = long.Parse(dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString());
				}
				else
				{
					MessageBox.Show("Bạn chưa chọn tour nào, sẽ hiển thị mặc định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				var chuongTrinhTourBLL = new ChuongTrinhTourBLL();
				var listChuongTrinhTour = chuongTrinhTourBLL.GetListChuongTrinh(matour);
				frm_ChuongTrinhTour frm = new frm_ChuongTrinhTour(matour);
				ribbonForm1.showFormInPanel(frm);
			}
			if (e.Button.Properties.Caption == "Phương tiện")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					var matour = dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString();
					frm_PhuongTienTour frm = new frm_PhuongTienTour(long.Parse(matour));
					ribbonForm1.showFormInPanel(frm);
				}
				else
				{
					MessageBox.Show("Vui lòng chọn tour cần xem phương tiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			if (e.Button.Properties.Caption == "Khách sạn")
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					var matour = dataGridView1.SelectedRows[0].Cells["matour"].Value.ToString();
					frm_KhachSanTour frm = new frm_KhachSanTour(long.Parse(matour));
					ribbonForm1.showFormInPanel(frm);
				}
				else
				{
					MessageBox.Show("Vui lòng chọn tour cần xem khách sạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

		}

		public void GetDataSource()
		{
			List<object> danhSachTour = tourBLL.LayDanhSachTour();
			danhSachTour = danhSachTour.Distinct().ToList();
			dataGridView1.DataSource = danhSachTour;
			dataGridView1.AutoGenerateColumns = false;

			dataGridView1.Columns["matour"].HeaderText = "Mã Tour";
			dataGridView1.Columns["tentour"].HeaderText = "Tên Tour";
			dataGridView1.Columns["tinhtrang"].HeaderText = "Tình Trạng";
			dataGridView1.Columns["noikhoihanh"].HeaderText = "Nơi Khởi Hành";
			dataGridView1.Columns["thoigiandi"].HeaderText = "Thời Gian Đi";
			dataGridView1.Columns["giatour"].HeaderText = "Giá Tour";
			dataGridView1.Columns["TenLoaiTour"].HeaderText = "Loại Tour";
			dataGridView1.Columns["makhuyenmai"].HeaderText = "Khuyến Mãi (%)";
			dataGridView1.Columns["created_at"].HeaderText = "Ngày Tạo";
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
		public Dictionary<string, object> getSelectData()
		{
			var selectedData = new Dictionary<string, object>();

			if (dataGridView1.Rows.Count == 0)
			{
				throw new InvalidOperationException("DataGridView is empty. No data to select.");
			}

			if (dataGridView1.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridView1.SelectedRows[0];


				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					var columnName = dataGridView1.Columns[cell.ColumnIndex].Name;
					selectedData[columnName] = cell.Value; 
				}
			}
			else
			{
				throw new InvalidOperationException("No row is selected.");
			}

			return selectedData;
		}


	}
}
