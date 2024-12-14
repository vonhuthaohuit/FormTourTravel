namespace FormTourTravel
{
    partial class frm_ChuanDoanTour
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
            this.dgv_ChuanDoan = new System.Windows.Forms.DataGridView();
            this.btn_HuanLuyen = new System.Windows.Forms.Button();
            this.btn_KiemThu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GiaTour = new System.Windows.Forms.TextBox();
            this.txt_GiaTourGiam = new System.Windows.Forms.TextBox();
            this.txt_TongKhachHangDiTour = new System.Windows.Forms.TextBox();
            this.txt_KhuyenMai = new System.Windows.Forms.TextBox();
            this.txt_NoiKhoiHanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TongSoTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_MaTour = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChuanDoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ChuanDoan
            // 
            this.dgv_ChuanDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChuanDoan.Location = new System.Drawing.Point(12, 12);
            this.dgv_ChuanDoan.Name = "dgv_ChuanDoan";
            this.dgv_ChuanDoan.RowHeadersWidth = 51;
            this.dgv_ChuanDoan.RowTemplate.Height = 24;
            this.dgv_ChuanDoan.Size = new System.Drawing.Size(1468, 524);
            this.dgv_ChuanDoan.TabIndex = 0;
            // 
            // btn_HuanLuyen
            // 
            this.btn_HuanLuyen.Location = new System.Drawing.Point(796, 559);
            this.btn_HuanLuyen.Name = "btn_HuanLuyen";
            this.btn_HuanLuyen.Size = new System.Drawing.Size(119, 41);
            this.btn_HuanLuyen.TabIndex = 1;
            this.btn_HuanLuyen.Text = "Huấn luyện";
            this.btn_HuanLuyen.UseVisualStyleBackColor = true;
            // 
            // btn_KiemThu
            // 
            this.btn_KiemThu.Location = new System.Drawing.Point(969, 559);
            this.btn_KiemThu.Name = "btn_KiemThu";
            this.btn_KiemThu.Size = new System.Drawing.Size(114, 41);
            this.btn_KiemThu.TabIndex = 2;
            this.btn_KiemThu.Text = "Kiểm Thử";
            this.btn_KiemThu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_KetQua);
            this.groupBox1.Location = new System.Drawing.Point(1120, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Location = new System.Drawing.Point(32, 52);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(54, 16);
            this.lbl_KetQua.TabIndex = 0;
            this.lbl_KetQua.Text = "Kết Quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Tour Giảm";
            // 
            // txt_GiaTour
            // 
            this.txt_GiaTour.Location = new System.Drawing.Point(166, 605);
            this.txt_GiaTour.Name = "txt_GiaTour";
            this.txt_GiaTour.Size = new System.Drawing.Size(201, 22);
            this.txt_GiaTour.TabIndex = 11;
            // 
            // txt_GiaTourGiam
            // 
            this.txt_GiaTourGiam.Location = new System.Drawing.Point(166, 658);
            this.txt_GiaTourGiam.Name = "txt_GiaTourGiam";
            this.txt_GiaTourGiam.Size = new System.Drawing.Size(201, 22);
            this.txt_GiaTourGiam.TabIndex = 12;
            // 
            // txt_TongKhachHangDiTour
            // 
            this.txt_TongKhachHangDiTour.Location = new System.Drawing.Point(562, 664);
            this.txt_TongKhachHangDiTour.Name = "txt_TongKhachHangDiTour";
            this.txt_TongKhachHangDiTour.Size = new System.Drawing.Size(201, 22);
            this.txt_TongKhachHangDiTour.TabIndex = 18;
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.Location = new System.Drawing.Point(562, 611);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.Size = new System.Drawing.Size(201, 22);
            this.txt_KhuyenMai.TabIndex = 17;
            // 
            // txt_NoiKhoiHanh
            // 
            this.txt_NoiKhoiHanh.Location = new System.Drawing.Point(562, 559);
            this.txt_NoiKhoiHanh.Name = "txt_NoiKhoiHanh";
            this.txt_NoiKhoiHanh.Size = new System.Drawing.Size(201, 22);
            this.txt_NoiKhoiHanh.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tổng khách hàng đi tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Khuyến mãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nơi khởi hành";
            // 
            // txt_TongSoTien
            // 
            this.txt_TongSoTien.Location = new System.Drawing.Point(562, 715);
            this.txt_TongSoTien.Name = "txt_TongSoTien";
            this.txt_TongSoTien.Size = new System.Drawing.Size(201, 22);
            this.txt_TongSoTien.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng số tiền";
            // 
            // cbo_MaTour
            // 
            this.cbo_MaTour.FormattingEnabled = true;
            this.cbo_MaTour.Location = new System.Drawing.Point(166, 556);
            this.cbo_MaTour.Name = "cbo_MaTour";
            this.cbo_MaTour.Size = new System.Drawing.Size(201, 24);
            this.cbo_MaTour.TabIndex = 21;
            // 
            // frm_ChuanDoanTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 740);
            this.Controls.Add(this.cbo_MaTour);
            this.Controls.Add(this.txt_TongSoTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TongKhachHangDiTour);
            this.Controls.Add(this.txt_KhuyenMai);
            this.Controls.Add(this.txt_NoiKhoiHanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_GiaTourGiam);
            this.Controls.Add(this.txt_GiaTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_KiemThu);
            this.Controls.Add(this.btn_HuanLuyen);
            this.Controls.Add(this.dgv_ChuanDoan);
            this.Name = "frm_ChuanDoanTour";
            this.Text = "frm_ChuanDoanTour";
            this.Load += new System.EventHandler(this.frm_ChuanDoanTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChuanDoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_HuanLuyen;
        private System.Windows.Forms.Button btn_KiemThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.DataGridView dgv_ChuanDoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GiaTour;
        private System.Windows.Forms.TextBox txt_GiaTourGiam;
        private System.Windows.Forms.TextBox txt_TongKhachHangDiTour;
        private System.Windows.Forms.TextBox txt_KhuyenMai;
        private System.Windows.Forms.TextBox txt_NoiKhoiHanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TongSoTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_MaTour;
    }
}