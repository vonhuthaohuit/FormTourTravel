namespace FormTourTravel
{
    partial class frm_ThongTinTaiKhoan
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
            this.thongTinCaNhan1 = new ThuVien.Usercontrol_Edit.ThongTinCaNhan();
            this.thongTinTaiKhoan1 = new ThuVien.Usercontrol_Edit.ThongTinTaiKhoan();
            this.SuspendLayout();
            // 
            // thongTinCaNhan1
            // 
            this.thongTinCaNhan1.Location = new System.Drawing.Point(399, 12);
            this.thongTinCaNhan1.Name = "thongTinCaNhan1";
            this.thongTinCaNhan1.Size = new System.Drawing.Size(548, 532);
            this.thongTinCaNhan1.TabIndex = 1;
            // 
            // thongTinTaiKhoan1
            // 
            this.thongTinTaiKhoan1.Location = new System.Drawing.Point(12, 12);
            this.thongTinTaiKhoan1.Name = "thongTinTaiKhoan1";
            this.thongTinTaiKhoan1.Size = new System.Drawing.Size(381, 533);
            this.thongTinTaiKhoan1.TabIndex = 0;
            // 
            // frm_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 556);
            this.Controls.Add(this.thongTinCaNhan1);
            this.Controls.Add(this.thongTinTaiKhoan1);
            this.Name = "frm_ThongTinTaiKhoan";
            this.Text = "frm_ThongTinTaiKhoan";
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.ThongTinTaiKhoan thongTinTaiKhoan1;
        private ThuVien.Usercontrol_Edit.ThongTinCaNhan thongTinCaNhan1;
    }
}