namespace FormTourTravel
{
    partial class frm_tourDaHuy
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
            this.dgv_phieuhuytour = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieuhuytour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoidaidien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydohuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuhuytour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_phieuhuytour
            // 
            this.dgv_phieuhuytour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuhuytour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieuhuytour,
            this.tentour,
            this.nguoidaidien,
            this.lydohuy,
            this.sotienhoan,
            this.ngayhuy});
            this.dgv_phieuhuytour.Location = new System.Drawing.Point(6, 19);
            this.dgv_phieuhuytour.Name = "dgv_phieuhuytour";
            this.dgv_phieuhuytour.Size = new System.Drawing.Size(1268, 263);
            this.dgv_phieuhuytour.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_phieuhuytour);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tour đã hủy";
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Location = new System.Drawing.Point(336, 32);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.Size = new System.Drawing.Size(75, 23);
            this.btn_xuatexcel.TabIndex = 3;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // cbo_thang
            // 
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Location = new System.Drawing.Point(57, 32);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(159, 21);
            this.cbo_thang.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_loc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_thang);
            this.groupBox2.Controls.Add(this.btn_xuatexcel);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(244, 31);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_loc.TabIndex = 6;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maphieuhuytour";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu hủy";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tentour";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên tour";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nguoidaidien";
            this.dataGridViewTextBoxColumn3.HeaderText = "Người hủy";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lydohuy";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lý do hủy";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sotienhoan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số tiền hoàn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 170;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ngayhuy";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày Hủy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // maphieuhuytour
            // 
            this.maphieuhuytour.DataPropertyName = "maphieuhuytour";
            this.maphieuhuytour.HeaderText = "Mã phiếu hủy";
            this.maphieuhuytour.Name = "maphieuhuytour";
            // 
            // tentour
            // 
            this.tentour.DataPropertyName = "tentour";
            this.tentour.HeaderText = "Tên tour";
            this.tentour.Name = "tentour";
            this.tentour.Width = 400;
            // 
            // nguoidaidien
            // 
            this.nguoidaidien.DataPropertyName = "nguoidaidien";
            this.nguoidaidien.HeaderText = "Người hủy";
            this.nguoidaidien.Name = "nguoidaidien";
            this.nguoidaidien.Width = 170;
            // 
            // lydohuy
            // 
            this.lydohuy.DataPropertyName = "lydohuy";
            this.lydohuy.HeaderText = "Lý do hủy";
            this.lydohuy.Name = "lydohuy";
            this.lydohuy.Width = 250;
            // 
            // sotienhoan
            // 
            this.sotienhoan.DataPropertyName = "sotienhoan";
            this.sotienhoan.HeaderText = "Số tiền hoàn";
            this.sotienhoan.Name = "sotienhoan";
            this.sotienhoan.Width = 170;
            // 
            // ngayhuy
            // 
            this.ngayhuy.DataPropertyName = "ngayhuy";
            this.ngayhuy.HeaderText = "Ngày Hủy";
            this.ngayhuy.Name = "ngayhuy";
            this.ngayhuy.Width = 170;
            // 
            // frm_tourDaHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tourDaHuy";
            this.Text = "frm_tourDaHuy";
            this.Load += new System.EventHandler(this.frm_tourDaHuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuhuytour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phieuhuytour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.ComboBox cbo_thang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuhuytour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentour;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoidaidien;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydohuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}