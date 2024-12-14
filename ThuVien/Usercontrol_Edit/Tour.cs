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
namespace ThuVien.Usercontrol_Edit
{
	public partial class Tour : XtraUserControl
	{
		public event EventHandler ThemClicked;
		public event EventHandler XoaClicked;
		public event EventHandler SuaClicked;
		public event EventHandler LammoiClicked;
		public Tour()
		{
			InitializeComponent();

		
		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "New")
			{
				
			}
			if (e.Button.Properties.Caption == "Delete")
			{
				XoaClicked?.Invoke(this, e);
			}
			if (e.Button.Properties.Caption == "Edit")
			{
				SuaClicked?.Invoke(this, e);
			}
		}

		public void load()
		{
			
			dataGridView1.AutoGenerateColumns = false;

			// Đặt tiêu đề cho các cột
			dataGridView1.Columns["matour"].HeaderText = "Mã Tour";
			dataGridView1.Columns["tentour"].HeaderText = "Tên Tour";
			dataGridView1.Columns["tinhtrang"].HeaderText = "Tình Trạng";
			dataGridView1.Columns["noikhoihanh"].HeaderText = "Nơi Khởi Hành";
			dataGridView1.Columns["thoigiandi"].HeaderText = "Thời Gian Đi";
			dataGridView1.Columns["giatour"].HeaderText = "Giá Tour";
			dataGridView1.Columns["TenLoaiTour"].HeaderText = "Loại Tour";
			dataGridView1.Columns["makhuyenmai"].HeaderText = "Khuyến Mãi (%)";
			dataGridView1.Columns["created_at"].HeaderText = "Ngày Tạo";

			// Đặt AutoSizeColumnsMode cho tất cả các cột để lắp đầy DataGridView
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Định dạng cột "tinhtrang"
			if (dataGridView1.Columns["tinhtrang"] != null)
			{
				dataGridView1.Columns["tinhtrang"].ValueType = typeof(sbyte);
				dataGridView1.CellFormatting += (s, e) =>
				{
					if (e.ColumnIndex == dataGridView1.Columns["tinhtrang"].Index && e.Value != null)
					{
						sbyte tinhtrang = (sbyte)e.Value;
						e.Value = tinhtrang == 1 ? "Hoạt động" : "Không hoạt động";
						e.FormattingApplied = true;
					}
				};
			}

			// Định dạng cột "giatour"
			if (dataGridView1.Columns["giatour"] != null)
			{
				dataGridView1.Columns["giatour"].ValueType = typeof(long);
				dataGridView1.CellFormatting += (s, e) =>
				{
					if (e.ColumnIndex == dataGridView1.Columns["giatour"].Index && e.Value != null)
					{
						long giatour = (long)e.Value;
						e.Value = giatour.ToString("N0");  // Hiển thị giá tour theo định dạng số
						e.FormattingApplied = true;
					}
				};
			}

			// Định dạng cột "makhuyenmai"

		}

		public object DataSourceDatagirdView
		{
			get => dataGridView1.DataSource;
			set => dataGridView1.DataSource = value;
		}
		// tôi muốn xóa dòng này
		public DataGridViewRow GetSelectedRow()
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				return dataGridView1.SelectedRows[0];
			}
			return null;
		}
		public void DeleteSelectedRow()
		{
			var selectedRow = GetSelectedRow();
			if (selectedRow != null)
			{
				// Xóa dòng khỏi DataGridView
				dataGridView1.Rows.Remove(selectedRow);
			}
		}



	}
}
