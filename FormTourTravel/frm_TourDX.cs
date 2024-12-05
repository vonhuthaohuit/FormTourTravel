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
using BLL;
using DevExpress.XtraGrid.Views.Grid;
namespace FormTourTravel
{
	public partial class frm_TourDX : XtraForm
	{
		private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
		private TourBLL tourBLL = new TourBLL();
		public frm_TourDX()
		{
			InitializeComponent();

			gridControl.DataSource = GetDataSource();

		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
		}
		public BindingList<tour> GetDataSource()
		{
			BindingList<tour> result = new BindingList<tour>();
			tourBLL.LayDanhSachTour().ForEach(x => result.Add(x));
			GridView gridView = gridControl.MainView as GridView;
			if (gridView != null)
			{
				// Kiểm tra xem cột có tồn tại hay không trước khi thao tác
				//if (gridView.Columns["chitietkhachsantours"] != null)
				//{
				gridView.Columns["chitietkhachsantours"].Visible = false;
				//}

				// Tương tự cho các cột khác
				// if (gridView.Columns["chitietphuongtientours"] != null) { ... }
			}

			return result;
		}
	}
}
