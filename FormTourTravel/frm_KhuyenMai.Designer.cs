namespace FormTourTravel
{
    partial class frm_KhuyenMai
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
            this.khuyenMai1 = new ThuVien.Usercontrol_Edit.khuyenMai();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // khuyenMai1
            // 
            this.khuyenMai1.DataSourceDatagirdView = null;
            this.khuyenMai1.Location = new System.Drawing.Point(12, 12);
            this.khuyenMai1.Name = "khuyenMai1";
            this.khuyenMai1.Size = new System.Drawing.Size(482, 437);
            this.khuyenMai1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::FormTourTravel.Properties.Resources.hinh_dai_dien_dang_nhap;
            this.pictureBox1.Location = new System.Drawing.Point(500, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 440);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.khuyenMai1);
            this.Name = "frm_KhuyenMai";
            this.Text = "frm_KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.khuyenMai khuyenMai1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}