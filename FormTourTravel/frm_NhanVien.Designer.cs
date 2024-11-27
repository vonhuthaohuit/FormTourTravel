namespace FormTourTravel
{
    partial class frm_NhanVien
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
            this.nhanVien1 = new ThuVien.Usercontrol_Edit.NhanVien();
            this.SuspendLayout();
            // 
            // nhanVien1
            // 
            this.nhanVien1.CboPhongBan_DataSource = null;
            this.nhanVien1.ChoGioiTinh_DataSource = null;
            this.nhanVien1.DataSourceDgvDanhSachNhanVien = null;
            this.nhanVien1.Location = new System.Drawing.Point(2, 1);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(1050, 746);
            this.nhanVien1.TabIndex = 0;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 756);
            this.Controls.Add(this.nhanVien1);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.NhanVien nhanVien1;
    }
}