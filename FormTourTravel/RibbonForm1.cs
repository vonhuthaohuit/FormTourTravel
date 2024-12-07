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

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
			frm_KhuyenMai frm = new frm_KhuyenMai();
            showFormInPanel(frm);
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
