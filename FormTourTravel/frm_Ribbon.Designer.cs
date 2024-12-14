namespace FormTourTravel
{
    partial class frm_Ribbon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ribbon));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_HoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_TaoHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChuanDoanTour = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tour = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_LoaiTour = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_TaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Tour = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Tour = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_LoaiTour = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_KhachHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Blog = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_NhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_KhuyenMai = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_HoaDon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_HoaDon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_ThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_ThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_ChuanDoanTour = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_ChuanDoanTour = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(46);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem_HoaDon,
            this.barButtonItem_TaoHoaDon,
            this.barButtonItem_ThongKe,
            this.barButtonItem_ChuanDoanTour,
            this.barButtonItem_Tour,
            this.barButtonItem_LoaiTour});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 515;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_TaiKhoan,
            this.ribbonPage_Tour,
            this.ribbonPage_KhachHang,
            this.ribbonPage_Blog,
            this.ribbonPage_NhanVien,
            this.ribbonPage_KhuyenMai,
            this.ribbonPage_HoaDon,
            this.ribbonPage_ThongKe,
            this.ribbonPage_ChuanDoanTour});
            this.ribbon.Size = new System.Drawing.Size(1488, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem_HoaDon
            // 
            this.barButtonItem_HoaDon.Caption = "Danh sách hoá đơn";
            this.barButtonItem_HoaDon.Id = 2;
            this.barButtonItem_HoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_HoaDon.ImageOptions.Image")));
            this.barButtonItem_HoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_HoaDon.ImageOptions.LargeImage")));
            this.barButtonItem_HoaDon.Name = "barButtonItem_HoaDon";
            this.barButtonItem_HoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_HoaDon_ItemClick);
            // 
            // barButtonItem_TaoHoaDon
            // 
            this.barButtonItem_TaoHoaDon.Caption = "Tạo hoá đơn";
            this.barButtonItem_TaoHoaDon.Id = 3;
            this.barButtonItem_TaoHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_TaoHoaDon.ImageOptions.Image")));
            this.barButtonItem_TaoHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_TaoHoaDon.ImageOptions.LargeImage")));
            this.barButtonItem_TaoHoaDon.Name = "barButtonItem_TaoHoaDon";
            this.barButtonItem_TaoHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_TaoHoaDon_ItemClick);
            // 
            // barButtonItem_ThongKe
            // 
            this.barButtonItem_ThongKe.Caption = "Thống kê";
            this.barButtonItem_ThongKe.Id = 4;
            this.barButtonItem_ThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ThongKe.ImageOptions.Image")));
            this.barButtonItem_ThongKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ThongKe.ImageOptions.LargeImage")));
            this.barButtonItem_ThongKe.Name = "barButtonItem_ThongKe";
            this.barButtonItem_ThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ThongKe_ItemClick);
            // 
            // barButtonItem_ChuanDoanTour
            // 
            this.barButtonItem_ChuanDoanTour.Caption = "Chuẩn đoán tour";
            this.barButtonItem_ChuanDoanTour.Id = 5;
            this.barButtonItem_ChuanDoanTour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChuanDoanTour.ImageOptions.Image")));
            this.barButtonItem_ChuanDoanTour.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChuanDoanTour.ImageOptions.LargeImage")));
            this.barButtonItem_ChuanDoanTour.Name = "barButtonItem_ChuanDoanTour";
            this.barButtonItem_ChuanDoanTour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChuanDoanTour_ItemClick);
            // 
            // barButtonItem_Tour
            // 
            this.barButtonItem_Tour.Caption = "Tour";
            this.barButtonItem_Tour.Id = 6;
            this.barButtonItem_Tour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Tour.ImageOptions.Image")));
            this.barButtonItem_Tour.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Tour.ImageOptions.LargeImage")));
            this.barButtonItem_Tour.Name = "barButtonItem_Tour";
            this.barButtonItem_Tour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Tour_ItemClick);
            // 
            // barButtonItem_LoaiTour
            // 
            this.barButtonItem_LoaiTour.Caption = "Loại Tour";
            this.barButtonItem_LoaiTour.Id = 7;
            this.barButtonItem_LoaiTour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_LoaiTour.ImageOptions.Image")));
            this.barButtonItem_LoaiTour.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_LoaiTour.ImageOptions.LargeImage")));
            this.barButtonItem_LoaiTour.Name = "barButtonItem_LoaiTour";
            this.barButtonItem_LoaiTour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_LoaiTour_ItemClick);
            // 
            // ribbonPage_TaiKhoan
            // 
            this.ribbonPage_TaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage_TaiKhoan.Name = "ribbonPage_TaiKhoan";
            this.ribbonPage_TaiKhoan.Text = "Tài Khoản";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage_Tour
            // 
            this.ribbonPage_Tour.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Tour,
            this.ribbonPageGroup_LoaiTour});
            this.ribbonPage_Tour.Name = "ribbonPage_Tour";
            this.ribbonPage_Tour.Text = "Tour";
            // 
            // ribbonPageGroup_Tour
            // 
            this.ribbonPageGroup_Tour.ItemLinks.Add(this.barButtonItem_Tour);
            this.ribbonPageGroup_Tour.Name = "ribbonPageGroup_Tour";
            this.ribbonPageGroup_Tour.Text = "Tour";
            // 
            // ribbonPageGroup_LoaiTour
            // 
            this.ribbonPageGroup_LoaiTour.ItemLinks.Add(this.barButtonItem_LoaiTour);
            this.ribbonPageGroup_LoaiTour.Name = "ribbonPageGroup_LoaiTour";
            this.ribbonPageGroup_LoaiTour.Text = "Loại Tour";
            // 
            // ribbonPage_KhachHang
            // 
            this.ribbonPage_KhachHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage_KhachHang.Name = "ribbonPage_KhachHang";
            this.ribbonPage_KhachHang.Text = "Khách hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage_Blog
            // 
            this.ribbonPage_Blog.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage_Blog.Name = "ribbonPage_Blog";
            this.ribbonPage_Blog.Text = "Blog";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage_NhanVien
            // 
            this.ribbonPage_NhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage_NhanVien.Name = "ribbonPage_NhanVien";
            this.ribbonPage_NhanVien.Text = "Nhân Viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage_KhuyenMai
            // 
            this.ribbonPage_KhuyenMai.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage_KhuyenMai.Name = "ribbonPage_KhuyenMai";
            this.ribbonPage_KhuyenMai.Text = "Khuyến mãi";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage_HoaDon
            // 
            this.ribbonPage_HoaDon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_HoaDon});
            this.ribbonPage_HoaDon.Name = "ribbonPage_HoaDon";
            this.ribbonPage_HoaDon.Text = "Hoá đơn";
            // 
            // ribbonPageGroup_HoaDon
            // 
            this.ribbonPageGroup_HoaDon.AllowTextClipping = false;
            this.ribbonPageGroup_HoaDon.ItemLinks.Add(this.barButtonItem_HoaDon);
            this.ribbonPageGroup_HoaDon.ItemLinks.Add(this.barButtonItem_TaoHoaDon);
            this.ribbonPageGroup_HoaDon.Name = "ribbonPageGroup_HoaDon";
            this.ribbonPageGroup_HoaDon.Text = "Hoá đơn";
            // 
            // ribbonPage_ThongKe
            // 
            this.ribbonPage_ThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_ThongKe});
            this.ribbonPage_ThongKe.Name = "ribbonPage_ThongKe";
            this.ribbonPage_ThongKe.Text = "Thống kê";
            // 
            // ribbonPageGroup_ThongKe
            // 
            this.ribbonPageGroup_ThongKe.AllowTextClipping = false;
            this.ribbonPageGroup_ThongKe.ItemLinks.Add(this.barButtonItem_ThongKe);
            this.ribbonPageGroup_ThongKe.Name = "ribbonPageGroup_ThongKe";
            this.ribbonPageGroup_ThongKe.Text = "Thống kê";
            // 
            // ribbonPage_ChuanDoanTour
            // 
            this.ribbonPage_ChuanDoanTour.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_ChuanDoanTour});
            this.ribbonPage_ChuanDoanTour.Name = "ribbonPage_ChuanDoanTour";
            this.ribbonPage_ChuanDoanTour.Text = "Chuẩn đoán tour";
            // 
            // ribbonPageGroup_ChuanDoanTour
            // 
            this.ribbonPageGroup_ChuanDoanTour.ItemLinks.Add(this.barButtonItem_ChuanDoanTour);
            this.ribbonPageGroup_ChuanDoanTour.Name = "ribbonPageGroup_ChuanDoanTour";
            this.ribbonPageGroup_ChuanDoanTour.Text = "Chuẩn đoán tour";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 757);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1488, 30);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 200);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1476, 550);
            this.panel.TabIndex = 2;
            // 
            // frm_Ribbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 787);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frm_Ribbon";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frm_Ribbon";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_TaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_KhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Blog;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_NhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Tour;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Tour;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_KhuyenMai;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_HoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_HoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_ThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_ThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_ChuanDoanTour;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_ChuanDoanTour;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_HoaDon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_TaoHoaDon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ThongKe;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChuanDoanTour;
		private DevExpress.XtraBars.BarButtonItem barButtonItem_Tour;
		private DevExpress.XtraBars.BarButtonItem barButtonItem_LoaiTour;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_LoaiTour;
	}
}