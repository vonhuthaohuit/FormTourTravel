namespace FormTourTravel
{
    partial class frm_ThemHoaDon
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
            this.themHoaDon1 = new ThuVien.Usercontrol_Edit.ThemHoaDon();
            this.SuspendLayout();
            // 
            // themHoaDon1
            // 
            this.themHoaDon1.CboNgayDi_DataSource = null;
            this.themHoaDon1.CboNgayDi_SelectedValue = new System.DateTime(((long)(0)));
            this.themHoaDon1.CboNguoiDaiDien_DataSource = null;
            this.themHoaDon1.CboNguoiDaiDien_SelectedText = "";
            this.themHoaDon1.CboPhuongThucThanhToan_DataSource = null;
            this.themHoaDon1.CboTour_DataSource = null;
            this.themHoaDon1.CboTrangThaiThanhToan_DataSource = null;
            this.themHoaDon1.DataSourceDatagirdView = null;
            this.themHoaDon1.DiaChiDonVi = "";
            this.themHoaDon1.Location = new System.Drawing.Point(3, 12);
            this.themHoaDon1.MaSoThue = "";
            this.themHoaDon1.Name = "themHoaDon1";
            this.themHoaDon1.Size = new System.Drawing.Size(1344, 776);
            this.themHoaDon1.TabIndex = 0;
            this.themHoaDon1.tenDonVi = "";
            this.themHoaDon1.tongSoNguoiDiTour = "";
            this.themHoaDon1.tongTien = "";
            // 
            // frm_ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 798);
            this.Controls.Add(this.themHoaDon1);
            this.Name = "frm_ThemHoaDon";
            this.Text = "frm_ThemHoaDon";
            this.Load += new System.EventHandler(this.frm_ThemHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.ThemHoaDon themHoaDon1;
    }
}