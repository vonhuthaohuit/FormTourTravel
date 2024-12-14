using DevExpress.XtraBars;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using static System.Threading.Thread;
using DevExpress.XtraBars.Ribbon;

namespace FormTourTravel
{
	public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private SplashScreenManager splashScreenManager;

		public RibbonForm1()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.WindowState = FormWindowState.Normal;

			// Khởi tạo SplashScreenManager
			if (splashScreenManager == null)
				splashScreenManager = new SplashScreenManager(this, typeof(WaitForm1), true, true);

			// Gắn sự kiện SelectedPageChanged cho RibbonControl
			// ribbonControl1.SelectedPageChanged += ribbonControl_SelectedPageChanged;
		}

		/// <summary>
		/// Hiển thị một form bên trong panel với WaitForm
		/// </summary>
		/// <param name="form">Form cần hiển thị</param>
		/// 
		private async void showFormInPanel(Form form)
		{
			try
			{
				if (!splashScreenManager.IsSplashFormVisible)
					splashScreenManager.ShowWaitForm();
				await Task.Run(() =>
				{
					Sleep(1000);
				});

				form.TopLevel = false;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;

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

		/// <summary>
		/// Xử lý khi nhấn vào nút Tour trong RibbonControl
		/// </summary>


		/// <summary>
		/// Hiển thị WaitForm khi chuyển đổi tab trên RibbonControl
		/// </summary>
		private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
		{
			try
			{
				// Hiển thị WaitForm
				if (!splashScreenManager.IsSplashFormVisible)
					splashScreenManager.ShowWaitForm();

				Task.Delay(1000).ContinueWith(_ =>
				{
					// Đóng WaitForm
					if (splashScreenManager.IsSplashFormVisible)
						splashScreenManager.CloseWaitForm();
				}, TaskScheduler.FromCurrentSynchronizationContext());
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btn_tour_ItemClick(object sender, ItemClickEventArgs e)
		{
			frm_TourDX frm = new frm_TourDX();
			showFormInPanel(frm);
		}

		private void btn_loaitour_ItemClick(object sender, ItemClickEventArgs e)
		{
			frm_TourTypecs frm = new frm_TourTypecs();
			showFormInPanel(frm);
		}

		private void panel_Paint(object sender, PaintEventArgs e)
		{

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
    }
}
