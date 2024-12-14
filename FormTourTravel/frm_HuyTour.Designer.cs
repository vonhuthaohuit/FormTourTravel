namespace FormTourTravel
{
    partial class frm_HuyTour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_huytour = new System.Windows.Forms.DataGridView();
            this.btn_huy = new System.Windows.Forms.Button();
            this.matour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoidaidien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydattour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaidattour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nguoidaidien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huytour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_huy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_huytour);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 350);
            this.panel2.TabIndex = 1;
            // 
            // dgv_huytour
            // 
            this.dgv_huytour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_huytour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matour,
            this.tentour,
            this.giatour,
            this.nguoidaidien,
            this.ngaydattour,
            this.ngaybatdau,
            this.thoigiandi,
            this.trangthaidattour});
            this.dgv_huytour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_huytour.Location = new System.Drawing.Point(0, 0);
            this.dgv_huytour.Name = "dgv_huytour";
            this.dgv_huytour.Size = new System.Drawing.Size(1135, 350);
            this.dgv_huytour.TabIndex = 0;
            this.dgv_huytour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_huytour_CellClick);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(535, 47);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Hủy tour";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // matour
            // 
            this.matour.DataPropertyName = "matour";
            this.matour.HeaderText = "Mã tour";
            this.matour.Name = "matour";
            // 
            // tentour
            // 
            this.tentour.DataPropertyName = "tentour";
            this.tentour.HeaderText = "Tên tour";
            this.tentour.Name = "tentour";
            this.tentour.Width = 300;
            // 
            // giatour
            // 
            this.giatour.DataPropertyName = "giatour";
            this.giatour.HeaderText = "Giá tour";
            this.giatour.Name = "giatour";
            // 
            // nguoidaidien
            // 
            this.nguoidaidien.DataPropertyName = "nguoidaidien";
            this.nguoidaidien.HeaderText = "Người đặt";
            this.nguoidaidien.Name = "nguoidaidien";
            this.nguoidaidien.Width = 150;
            // 
            // ngaydattour
            // 
            this.ngaydattour.DataPropertyName = "ngaydattour";
            this.ngaydattour.HeaderText = "Ngày đặt";
            this.ngaydattour.Name = "ngaydattour";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.Name = "ngaybatdau";
            // 
            // thoigiandi
            // 
            this.thoigiandi.DataPropertyName = "thoigiandi";
            this.thoigiandi.HeaderText = "Thời gian đi (ngày)";
            this.thoigiandi.Name = "thoigiandi";
            this.thoigiandi.Width = 150;
            // 
            // trangthaidattour
            // 
            this.trangthaidattour.DataPropertyName = "trangthaidattour";
            this.trangthaidattour.HeaderText = "Trạng thái đặt tour";
            this.trangthaidattour.Name = "trangthaidattour";
            this.trangthaidattour.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nguoidaidien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người đặt";
            // 
            // txt_nguoidaidien
            // 
            this.txt_nguoidaidien.Location = new System.Drawing.Point(79, 31);
            this.txt_nguoidaidien.Name = "txt_nguoidaidien";
            this.txt_nguoidaidien.Size = new System.Drawing.Size(128, 20);
            this.txt_nguoidaidien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày đặt";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(444, 48);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // frm_HuyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_HuyTour";
            this.Text = "frm_HuyTour";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huytour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.DataGridView dgv_huytour;
        private System.Windows.Forms.DataGridViewTextBoxColumn matour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentour;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoidaidien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydattour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaidattour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nguoidaidien;
    }
}