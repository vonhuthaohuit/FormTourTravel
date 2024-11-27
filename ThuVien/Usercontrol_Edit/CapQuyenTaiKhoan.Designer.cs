namespace ThuVien.Usercontrol_Edit
{
    partial class CapQuyenTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_NhomQuyen = new System.Windows.Forms.ComboBox();
            this.cbo_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_MaTaiKhoan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.chucNangNenCo1 = new ThuVien.Usercontrol_Edit.ChucNangNenCo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_NhomQuyen);
            this.groupBox1.Controls.Add(this.cbo_TaiKhoan);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.lbl_MatKhau);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.lbl_TenDangNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_TenNhanVien);
            this.groupBox1.Controls.Add(this.lbl_MaTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(35, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp quyền tài khoản";
            // 
            // cbo_NhomQuyen
            // 
            this.cbo_NhomQuyen.FormattingEnabled = true;
            this.cbo_NhomQuyen.Location = new System.Drawing.Point(527, 151);
            this.cbo_NhomQuyen.Name = "cbo_NhomQuyen";
            this.cbo_NhomQuyen.Size = new System.Drawing.Size(134, 24);
            this.cbo_NhomQuyen.TabIndex = 11;
            // 
            // cbo_TaiKhoan
            // 
            this.cbo_TaiKhoan.FormattingEnabled = true;
            this.cbo_TaiKhoan.Location = new System.Drawing.Point(172, 38);
            this.cbo_TaiKhoan.Name = "cbo_TaiKhoan";
            this.cbo_TaiKhoan.Size = new System.Drawing.Size(134, 24);
            this.cbo_TaiKhoan.TabIndex = 10;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(527, 89);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(134, 22);
            this.txt_MatKhau.TabIndex = 9;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(405, 89);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(66, 17);
            this.lbl_MatKhau.TabIndex = 8;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(527, 38);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(134, 22);
            this.txt_TenDangNhap.TabIndex = 7;
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(405, 38);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(105, 17);
            this.lbl_TenDangNhap.TabIndex = 6;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhóm quyền";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(56, 91);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(99, 17);
            this.lbl_TenNhanVien.TabIndex = 2;
            this.lbl_TenNhanVien.Text = "Tên nhân viên";
            // 
            // lbl_MaTaiKhoan
            // 
            this.lbl_MaTaiKhoan.AutoSize = true;
            this.lbl_MaTaiKhoan.Location = new System.Drawing.Point(56, 40);
            this.lbl_MaTaiKhoan.Name = "lbl_MaTaiKhoan";
            this.lbl_MaTaiKhoan.Size = new System.Drawing.Size(89, 17);
            this.lbl_MaTaiKhoan.TabIndex = 0;
            this.lbl_MaTaiKhoan.Text = "Mã tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_TaiKhoan);
            this.groupBox2.Location = new System.Drawing.Point(35, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 399);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(6, 21);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(990, 372);
            this.dgv_TaiKhoan.TabIndex = 0;
            // 
            // chucNangNenCo1
            // 
            this.chucNangNenCo1.Location = new System.Drawing.Point(715, 45);
            this.chucNangNenCo1.Name = "chucNangNenCo1";
            this.chucNangNenCo1.Size = new System.Drawing.Size(316, 242);
            this.chucNangNenCo1.TabIndex = 4;
            // 
            // CapQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chucNangNenCo1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CapQuyenTaiKhoan";
            this.Size = new System.Drawing.Size(1057, 705);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MaTaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.ComboBox cbo_TaiKhoan;
        private System.Windows.Forms.ComboBox cbo_NhomQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private ChucNangNenCo chucNangNenCo1;
    }
}
