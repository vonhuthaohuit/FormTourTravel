namespace FormTourTravel
{
    partial class frm_CapTaiKhoan
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
            this.capQuyenTaiKhoan1 = new ThuVien.Usercontrol_Edit.CapQuyenTaiKhoan();
            this.SuspendLayout();
            // 
            // capQuyenTaiKhoan1
            // 
            this.capQuyenTaiKhoan1.CboNhomQuyen_DataSource = null;
            this.capQuyenTaiKhoan1.CboTaiKhoan_DataSource = null;
            this.capQuyenTaiKhoan1.DataSourceDatagirdView = null;
            this.capQuyenTaiKhoan1.Location = new System.Drawing.Point(2, -2);
            this.capQuyenTaiKhoan1.Name = "capQuyenTaiKhoan1";
            this.capQuyenTaiKhoan1.Size = new System.Drawing.Size(1182, 540);
            this.capQuyenTaiKhoan1.TabIndex = 0;
            // 
            // frm_CapTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 493);
            this.Controls.Add(this.capQuyenTaiKhoan1);
            this.Name = "frm_CapTaiKhoan";
            this.Text = "frm_CapTaiKhoan";
            this.ResumeLayout(false);

        }

        #endregion

        private ThuVien.Usercontrol_Edit.CapQuyenTaiKhoan capQuyenTaiKhoan1;
    }
}