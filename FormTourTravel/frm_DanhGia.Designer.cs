namespace FormTourTravel
{
    partial class frm_DanhGia
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
        ///
        private void InitializeComponent()
        {
            this.dgv_DanhGia = new System.Windows.Forms.DataGridView();
            this.madanhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemdanhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhGia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhGia
            // 
            this.dgv_DanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madanhgia,
            this.matour,
            this.noidung,
            this.diemdanhgia,
            this.makhachhang,
            this.tinhtrang,
            this.created_at,
            this.updated_at});
            this.dgv_DanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhGia.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DanhGia.Name = "dgv_DanhGia";
            this.dgv_DanhGia.RowHeadersWidth = 51;
            this.dgv_DanhGia.RowTemplate.Height = 24;
            this.dgv_DanhGia.Size = new System.Drawing.Size(784, 478);
            this.dgv_DanhGia.TabIndex = 6;
            this.dgv_DanhGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhGia_CellClick);
            // 
            // madanhgia
            // 
            this.madanhgia.DataPropertyName = "madanhgia";
            this.madanhgia.HeaderText = "Mã đánh giá";
            this.madanhgia.Name = "madanhgia";
            // 
            // matour
            // 
            this.matour.DataPropertyName = "tentour";
            this.matour.HeaderText = "Tour";
            this.matour.Name = "matour";
            this.matour.Width = 400;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Nội dung";
            this.noidung.Name = "noidung";
            this.noidung.Width = 500;
            // 
            // diemdanhgia
            // 
            this.diemdanhgia.DataPropertyName = "diemdanhgia";
            this.diemdanhgia.HeaderText = "Điểm đánh giá";
            this.diemdanhgia.Name = "diemdanhgia";
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "hotenKhachHang";
            this.makhachhang.HeaderText = "Khách hàng";
            this.makhachhang.Name = "makhachhang";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Ngày tạo";
            this.created_at.Name = "created_at";
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Ngày cập nhật";
            this.updated_at.Name = "updated_at";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_luu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_trangthai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 83);
            this.panel1.TabIndex = 7;
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.Location = new System.Drawing.Point(201, 32);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(234, 21);
            this.cbo_trangthai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tình trạng hoạt động của bình luận";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(472, 30);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(567, 30);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_DanhGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 478);
            this.panel2.TabIndex = 8;
            // 
            // frm_DanhGia
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DanhGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhGia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn madanhgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn matour;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemdanhgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_trangthai;
        private System.Windows.Forms.Panel panel2;
    }
}