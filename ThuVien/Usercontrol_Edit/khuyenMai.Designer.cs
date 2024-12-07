namespace ThuVien.Usercontrol_Edit
{
    partial class khuyenMai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.txt_phantramgiam = new System.Windows.Forms.TextBox();
            this.dgv_KhuyenMai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txt_makhuyenmai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.makhuyenmai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phantramgiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhuyenMai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phần trăm giảm";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.AccessibleDescription = "";
            this.ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybatdau.Location = new System.Drawing.Point(113, 45);
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Size = new System.Drawing.Size(200, 20);
            this.ngaybatdau.TabIndex = 3;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayketthuc.Location = new System.Drawing.Point(113, 94);
            this.ngayketthuc.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Size = new System.Drawing.Size(200, 20);
            this.ngayketthuc.TabIndex = 4;
            this.ngayketthuc.Value = new System.DateTime(2024, 12, 7, 15, 32, 0, 0);
            // 
            // txt_phantramgiam
            // 
            this.txt_phantramgiam.Location = new System.Drawing.Point(113, 145);
            this.txt_phantramgiam.Name = "txt_phantramgiam";
            this.txt_phantramgiam.Size = new System.Drawing.Size(200, 20);
            this.txt_phantramgiam.TabIndex = 5;
            // 
            // dgv_KhuyenMai
            // 
            this.dgv_KhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhuyenmai,
            this.thoigianbatdau,
            this.thoigianketthuc,
            this.phantramgiam});
            this.dgv_KhuyenMai.Location = new System.Drawing.Point(6, 19);
            this.dgv_KhuyenMai.Name = "dgv_KhuyenMai";
            this.dgv_KhuyenMai.Size = new System.Drawing.Size(439, 192);
            this.dgv_KhuyenMai.TabIndex = 6;
            this.dgv_KhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhuyenMai_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_KhuyenMai);
            this.groupBox1.Location = new System.Drawing.Point(14, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 219);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khuyến mãi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(345, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(23, 92);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(23, 57);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(23, 22);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_makhuyenmai
            // 
            this.txt_makhuyenmai.Enabled = false;
            this.txt_makhuyenmai.Location = new System.Drawing.Point(113, 3);
            this.txt_makhuyenmai.Name = "txt_makhuyenmai";
            this.txt_makhuyenmai.Size = new System.Drawing.Size(200, 20);
            this.txt_makhuyenmai.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phần trăm giảm";
            // 
            // makhuyenmai
            // 
            this.makhuyenmai.DataPropertyName = "makhuyenmai";
            this.makhuyenmai.HeaderText = "Mã KM";
            this.makhuyenmai.Name = "makhuyenmai";
            this.makhuyenmai.Width = 70;
            // 
            // thoigianbatdau
            // 
            this.thoigianbatdau.DataPropertyName = "thoigianbatdau";
            this.thoigianbatdau.HeaderText = "Ngày bắt đầu";
            this.thoigianbatdau.Name = "thoigianbatdau";
            // 
            // thoigianketthuc
            // 
            this.thoigianketthuc.DataPropertyName = "thoigianketthuc";
            this.thoigianketthuc.HeaderText = "Ngày kết thúc";
            this.thoigianketthuc.Name = "thoigianketthuc";
            // 
            // phantramgiam
            // 
            this.phantramgiam.DataPropertyName = "phantramgiam";
            this.phantramgiam.HeaderText = "Phần trăm giảm";
            this.phantramgiam.Name = "phantramgiam";
            this.phantramgiam.Width = 130;
            // 
            // khuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_makhuyenmai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_phantramgiam);
            this.Controls.Add(this.ngayketthuc);
            this.Controls.Add(this.ngaybatdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "khuyenMai";
            this.Size = new System.Drawing.Size(482, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhuyenMai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ngayketthuc;
        private System.Windows.Forms.TextBox txt_phantramgiam;
        private System.Windows.Forms.DateTimePicker ngaybatdau;
        private System.Windows.Forms.DataGridView dgv_KhuyenMai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_makhuyenmai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phantramgiam;
    }
}
