namespace FormTourTravel
{
    partial class frm_DangNhap
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
            this.dangNhap1 = new ThuVien.Usercontrol_Edit.DangNhap();
            this.SuspendLayout();
            // 
            // dangNhap1
            // 
            this.dangNhap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dangNhap1.Location = new System.Drawing.Point(0, 0);
            this.dangNhap1.Name = "dangNhap1";
            this.dangNhap1.Size = new System.Drawing.Size(885, 433);
            this.dangNhap1.TabIndex = 0;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 433);
            this.Controls.Add(this.dangNhap1);
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.DangNhap dangNhap1;
    }
}