namespace FormTourTravel
{
    partial class frm_HoaDon
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
            this.hoaDon1 = new ThuVien.Usercontrol_Edit.HoaDon();
            this.SuspendLayout();
            // 
            // hoaDon1
            // 
            this.hoaDon1.AutoScroll = true;
            this.hoaDon1.DataSourceDatagirdView = null;
            this.hoaDon1.DiaChiDonVi = "";
            this.hoaDon1.Location = new System.Drawing.Point(12, 12);
            this.hoaDon1.MaSoThue = "";
            this.hoaDon1.Name = "hoaDon1";
            this.hoaDon1.NguoiDaiDien = "";
            this.hoaDon1.Size = new System.Drawing.Size(1324, 771);
            this.hoaDon1.TabIndex = 0;

            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1352, 779);
            this.Controls.Add(this.hoaDon1);
            this.Name = "frm_HoaDon";
            this.Text = "frm_HoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.HoaDon hoaDon1;
    }
}