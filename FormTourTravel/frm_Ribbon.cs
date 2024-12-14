using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using static System.Threading.Thread;
using DevExpress.XtraBars.Ribbon;

namespace FormTourTravel
{
    public partial class frm_Ribbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private SplashScreenManager splashScreenManager;

        public frm_Ribbon()
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
        }
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
        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                if (!splashScreenManager.IsSplashFormVisible)
                    splashScreenManager.ShowWaitForm();

                Task.Delay(1000).ContinueWith(_ =>
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

        private void barButtonItem_HoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_HoaDon frm_HoaDon = new frm_HoaDon();
            showFormInPanel(frm_HoaDon);
        }

        private void barButtonItem_TaoHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThemHoaDon frm_ThemHoaDon = new frm_ThemHoaDon();
            frm_ThemHoaDon.ShowDialog();
        }

        private void barButtonItem_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThongKe frm_ThongKe = new frm_ThongKe();
            showFormInPanel(frm_ThongKe);
        }

        private void barButtonItem_ChuanDoanTour_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ChuanDoanTour frm_ChuanDoanTour = new frm_ChuanDoanTour();
            showFormInPanel(frm_ChuanDoanTour);
        }
    }
}