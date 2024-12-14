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


	}
}
