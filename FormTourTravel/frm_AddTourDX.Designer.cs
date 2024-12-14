namespace FormTourTravel
{
	partial class frm_AddTourDX
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddTourDX));
			this.txt_tentour = new DevExpress.XtraEditors.TextEdit();
			this.txt_thoigiandi = new DevExpress.XtraEditors.TextEdit();
			this.txt_noikhoihanh = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txt_hinhdaidien = new DevExpress.XtraEditors.TextEdit();
			this.txt_motatour = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
			this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
			this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
			this.cbx_maloaitour = new System.Windows.Forms.ComboBox();
			this.cbx_makhuyenmai = new System.Windows.Forms.ComboBox();
			this.txt_matour = new DevExpress.XtraEditors.TextEdit();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.txt_tentour.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_thoigiandi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_noikhoihanh.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_hinhdaidien.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_motatour.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_matour.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_tentour
			// 
			this.txt_tentour.Location = new System.Drawing.Point(72, 98);
			this.txt_tentour.Name = "txt_tentour";
			this.txt_tentour.Size = new System.Drawing.Size(279, 22);
			this.txt_tentour.TabIndex = 0;
			// 
			// txt_thoigiandi
			// 
			this.txt_thoigiandi.Location = new System.Drawing.Point(72, 288);
			this.txt_thoigiandi.Name = "txt_thoigiandi";
			this.txt_thoigiandi.Size = new System.Drawing.Size(279, 22);
			this.txt_thoigiandi.TabIndex = 2;
			this.txt_thoigiandi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thoigiandi_KeyPress);
			// 
			// txt_noikhoihanh
			// 
			this.txt_noikhoihanh.Location = new System.Drawing.Point(470, 53);
			this.txt_noikhoihanh.Name = "txt_noikhoihanh";
			this.txt_noikhoihanh.Size = new System.Drawing.Size(305, 22);
			this.txt_noikhoihanh.TabIndex = 4;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(72, 67);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(63, 21);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Tên tour";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(72, 127);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(77, 21);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Mô tả tour";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(72, 261);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(87, 21);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Thời gian đi";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(466, 307);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(83, 18);
			this.labelControl4.TabIndex = 1;
			this.labelControl4.Text = "Hình đại diện";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(470, 22);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(100, 21);
			this.labelControl5.TabIndex = 1;
			this.labelControl5.Text = "Nơi khởi hành";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(464, 342);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Chọn hình";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// txt_hinhdaidien
			// 
			this.txt_hinhdaidien.Enabled = false;
			this.txt_hinhdaidien.Location = new System.Drawing.Point(577, 343);
			this.txt_hinhdaidien.Name = "txt_hinhdaidien";
			this.txt_hinhdaidien.Size = new System.Drawing.Size(184, 22);
			this.txt_hinhdaidien.TabIndex = 4;
			// 
			// txt_motatour
			// 
			this.txt_motatour.Location = new System.Drawing.Point(72, 154);
			this.txt_motatour.Name = "txt_motatour";
			this.txt_motatour.Size = new System.Drawing.Size(279, 101);
			this.txt_motatour.TabIndex = 1;
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(470, 126);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(88, 21);
			this.labelControl6.TabIndex = 1;
			this.labelControl6.Text = "Mã loại tour";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(471, 230);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(111, 21);
			this.labelControl7.TabIndex = 1;
			this.labelControl7.Text = "Mã khuyến mãi";
			// 
			// btn_luu
			// 
			this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
			this.btn_luu.Location = new System.Drawing.Point(223, 477);
			this.btn_luu.Name = "btn_luu";
			this.btn_luu.Size = new System.Drawing.Size(96, 46);
			this.btn_luu.TabIndex = 7;
			this.btn_luu.Text = "Thêm";
			this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
			this.btn_sua.Location = new System.Drawing.Point(351, 477);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(100, 46);
			this.btn_sua.TabIndex = 7;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_dong
			// 
			this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
			this.btn_dong.Location = new System.Drawing.Point(471, 477);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(111, 46);
			this.btn_dong.TabIndex = 7;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// cbx_maloaitour
			// 
			this.cbx_maloaitour.FormattingEnabled = true;
			this.cbx_maloaitour.Location = new System.Drawing.Point(470, 153);
			this.cbx_maloaitour.Name = "cbx_maloaitour";
			this.cbx_maloaitour.Size = new System.Drawing.Size(305, 24);
			this.cbx_maloaitour.TabIndex = 6;
			// 
			// cbx_makhuyenmai
			// 
			this.cbx_makhuyenmai.FormattingEnabled = true;
			this.cbx_makhuyenmai.Location = new System.Drawing.Point(470, 257);
			this.cbx_makhuyenmai.Name = "cbx_makhuyenmai";
			this.cbx_makhuyenmai.Size = new System.Drawing.Size(305, 24);
			this.cbx_makhuyenmai.TabIndex = 7;
			// 
			// txt_matour
			// 
			this.txt_matour.Enabled = false;
			this.txt_matour.Location = new System.Drawing.Point(72, 36);
			this.txt_matour.Name = "txt_matour";
			this.txt_matour.Size = new System.Drawing.Size(279, 22);
			this.txt_matour.TabIndex = 0;
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(72, 5);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(57, 21);
			this.labelControl8.TabIndex = 1;
			this.labelControl8.Text = "Mã tour";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(131, 316);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 155);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frm_AddTourDX
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 591);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cbx_makhuyenmai);
			this.Controls.Add(this.cbx_maloaitour);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_luu);
			this.Controls.Add(this.txt_motatour);
			this.Controls.Add(this.txt_hinhdaidien);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txt_noikhoihanh);
			this.Controls.Add(this.txt_thoigiandi);
			this.Controls.Add(this.txt_matour);
			this.Controls.Add(this.txt_tentour);
			this.Name = "frm_AddTourDX";
			this.Text = "frm_AddTourDX";
			((System.ComponentModel.ISupportInitialize)(this.txt_tentour.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_thoigiandi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_noikhoihanh.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_hinhdaidien.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_motatour.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_matour.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txt_tentour;
		private DevExpress.XtraEditors.TextEdit txt_thoigiandi;
		private DevExpress.XtraEditors.TextEdit txt_noikhoihanh;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private DevExpress.XtraEditors.TextEdit txt_hinhdaidien;
		private DevExpress.XtraEditors.MemoEdit txt_motatour;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SimpleButton btn_luu;
		private DevExpress.XtraEditors.SimpleButton btn_sua;
		private DevExpress.XtraEditors.SimpleButton btn_dong;
		private System.Windows.Forms.ComboBox cbx_maloaitour;
		private System.Windows.Forms.ComboBox cbx_makhuyenmai;
		private DevExpress.XtraEditors.TextEdit txt_matour;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}