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
            this.cbo_nhomquyen = new System.Windows.Forms.ComboBox();
            this.cbo_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_MaTaiKhoan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_trangthai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_nhomquyen);
            this.groupBox1.Controls.Add(this.cbo_TaiKhoan);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.lbl_MatKhau);
            this.groupBox1.Controls.Add(this.txt_tendangnhap);
            this.groupBox1.Controls.Add(this.lbl_TenDangNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_TenNhanVien);
            this.groupBox1.Controls.Add(this.lbl_MaTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(229, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp quyền tài khoản";
            // 
            // cbo_nhomquyen
            // 
            this.cbo_nhomquyen.FormattingEnabled = true;
            this.cbo_nhomquyen.Location = new System.Drawing.Point(105, 222);
            this.cbo_nhomquyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_nhomquyen.Name = "cbo_nhomquyen";
            this.cbo_nhomquyen.Size = new System.Drawing.Size(102, 21);
            this.cbo_nhomquyen.TabIndex = 11;
            // 
            // cbo_TaiKhoan
            // 
            this.cbo_TaiKhoan.FormattingEnabled = true;
            this.cbo_TaiKhoan.Location = new System.Drawing.Point(105, 21);
            this.cbo_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_TaiKhoan.Name = "cbo_TaiKhoan";
            this.cbo_TaiKhoan.Size = new System.Drawing.Size(102, 21);
            this.cbo_TaiKhoan.TabIndex = 10;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(105, 153);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(102, 20);
            this.txt_matkhau.TabIndex = 9;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(18, 156);
            this.lbl_MatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(52, 13);
            this.lbl_MatKhau.TabIndex = 8;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(105, 85);
            this.txt_tendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(102, 20);
            this.txt_tendangnhap.TabIndex = 7;
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(18, 88);
            this.lbl_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(81, 13);
            this.lbl_TenDangNhap.TabIndex = 6;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhóm quyền";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(18, 57);
            this.lbl_TenNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(76, 13);
            this.lbl_TenNhanVien.TabIndex = 2;
            this.lbl_TenNhanVien.Text = "Tên nhân viên";
            // 
            // lbl_MaTaiKhoan
            // 
            this.lbl_MaTaiKhoan.AutoSize = true;
            this.lbl_MaTaiKhoan.Location = new System.Drawing.Point(18, 25);
            this.lbl_MaTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaTaiKhoan.Name = "lbl_MaTaiKhoan";
            this.lbl_MaTaiKhoan.Size = new System.Drawing.Size(69, 13);
            this.lbl_MaTaiKhoan.TabIndex = 0;
            this.lbl_MaTaiKhoan.Text = "Mã tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_TaiKhoan);
            this.groupBox2.Location = new System.Drawing.Point(251, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(880, 392);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(4, 17);
            this.dgv_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(872, 371);
            this.dgv_TaiKhoan.TabIndex = 0;
            this.dgv_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(10, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(24, 96);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(24, 61);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(87, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(24, 26);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(87, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(105, 119);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(102, 20);
            this.txt_email.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trạng thái";
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.Location = new System.Drawing.Point(105, 188);
            this.cbo_trangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(102, 21);
            this.cbo_trangthai.TabIndex = 15;
            // 
            // CapQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CapQuyenTaiKhoan";
            this.Size = new System.Drawing.Size(1133, 399);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MaTaiKhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.ComboBox cbo_TaiKhoan;
        private System.Windows.Forms.ComboBox cbo_nhomquyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_trangthai;
        private System.Windows.Forms.Label label2;
    }
}
