using DevExpress.XtraBars;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using static System.Threading.Thread;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System.Threading;
namespace FormTourTravel
{
	public partial class RibbonForm1 : RibbonForm
	{
		private SplashScreenManager splashScreenManager;
		public long matour { get; private set; } 
		private frm_TourDX frmTourDx;

		public RibbonForm1()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.WindowState = FormWindowState.Normal;
			this.frmTourDx = new frm_TourDX(this);
			panel.Dock = DockStyle.Fill;
			if (splashScreenManager == null)
				splashScreenManager = new SplashScreenManager(this, typeof(WaitForm1), true, true);

			if (panel == null)
			{
				panel = new PanelControl
				{
					Dock = DockStyle.Fill
				};
				this.Controls.Add(panel);
			}

		}
		public async void showFormInPanel(Form form)
		{
			try
			{
				if (!splashScreenManager.IsSplashFormVisible)
					splashScreenManager.ShowWaitForm();

				await Task.Run(() =>
				{
					Sleep(700);
				});

				if (panel.Controls.Count > 0)
				{
					foreach (Control ctrl in panel.Controls)
					{
						ctrl.Dispose();
					}
					panel.Controls.Clear();
				}

				form.TopLevel = false;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;
				form.AutoScroll = true;
				panel.AutoScroll = true;
				panel.Controls.Clear(); 
				panel.Controls.Add(form);

                panel.AutoScroll = true;
				//panel.AutoScrollPosition = new System.Drawing.Point(0, 100);
                panel.Tag = form;

				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (splashScreenManager.IsSplashFormVisible)
					splashScreenManager.CloseWaitForm();
			}
		}


		private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
		{
			try
			{
				if (ribbonControl1.SelectedPage != null && ribbonControl1.SelectedPage.Name == "ribbon_tour")
				{
					frm_TourDX frm_TourDX = new frm_TourDX(this);
					showFormInPanel(frm_TourDX);
				}
				if (!splashScreenManager.IsSplashFormVisible)
					splashScreenManager.ShowWaitForm();

				Task.Delay(700).ContinueWith(_ =>
				{
					if (splashScreenManager.IsSplashFormVisible)
						splashScreenManager.CloseWaitForm();
				}, TaskScheduler.FromCurrentSynchronizationContext());
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btn_tourr_ItemClick(object sender, ItemClickEventArgs e)
		{
			frm_TourDX frm_TourDX = new frm_TourDX(this);
			showFormInPanel(frm_TourDX);
		}

		private void btn_loaitour_ItemClick(object sender, ItemClickEventArgs e)
		{
			frm_TourTypecs frm_TourTypecs = new frm_TourTypecs();
			showFormInPanel(frm_TourTypecs);
		}
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void skinRibbonGalleryBarItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_HoaDon frm = new frm_HoaDon();
            showFormInPanel(frm);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_ThemHoaDon frm_ThemHoaDon = new frm_ThemHoaDon();
            showFormInPanel(frm_ThemHoaDon);
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_ChuanDoanTour frm_ChuanDoanTour = new frm_ChuanDoanTour();
            showFormInPanel(frm_ChuanDoanTour);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_ThongKe frm_ThongKe = new frm_ThongKe();
            showFormInPanel(frm_ThongKe);
        }

   //     private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
   //     {
			//frm_KhuyenMai frm = new frm_KhuyenMai();
   //         showFormInPanel(frm);
   //     }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_DanhGia frm = new frm_DanhGia();
			showFormInPanel(frm);
        }

        //private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frm_CapTaiKhoan frm = new frm_CapTaiKhoan();
        //    showFormInPanel(frm);
        //}

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_TaoTaiKhoan	frm = new frm_TaoTaiKhoan();
            showFormInPanel(frm);
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhomQuyen frm = new frm_NhomQuyen();
            showFormInPanel(frm);
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_HuyTour frm = new frm_HuyTour();
            showFormInPanel(frm);
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_tourDaHuy frm = new frm_tourDaHuy();
			showFormInPanel(frm);
        }
    }

}
