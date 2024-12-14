namespace FormTourTravel
{
	partial class frm_ChuongTrinhTour
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
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_ngay = new System.Windows.Forms.MaskedTextBox();
			this.txt_tieude = new System.Windows.Forms.TextBox();
			this.txt_mota = new DevExpress.XtraEditors.MemoEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_mota.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// windowsUIButtonPanel
			// 
			this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
			this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			windowsUIButtonImageOptions5.ImageUri.Uri = "New;Size32x32;GrayScaled";
			windowsUIButtonImageOptions6.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
			windowsUIButtonImageOptions7.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
			windowsUIButtonImageOptions8.ImageUri.Uri = "Refresh;Size32x32;GrayScaled";
			this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm mới", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanel.EnableImageTransparency = true;
			this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 512);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 74);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 74);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(1354, 74);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(56, 257);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1164, 196);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(718, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 21);
			this.label3.TabIndex = 11;
			this.label3.Text = "Ngày";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(52, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 21);
			this.label2.TabIndex = 12;
			this.label2.Text = "Mô tả tour";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(51, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Tiêu đề";
			// 
			// txt_ngay
			// 
			this.txt_ngay.Location = new System.Drawing.Point(722, 105);
			this.txt_ngay.Name = "txt_ngay";
			this.txt_ngay.Size = new System.Drawing.Size(497, 23);
			this.txt_ngay.TabIndex = 8;
			// 
			// txt_tieude
			// 
			this.txt_tieude.Location = new System.Drawing.Point(55, 105);
			this.txt_tieude.Name = "txt_tieude";
			this.txt_tieude.Size = new System.Drawing.Size(460, 23);
			this.txt_tieude.TabIndex = 7;
			// 
			// txt_mota
			// 
			this.txt_mota.Location = new System.Drawing.Point(56, 163);
			this.txt_mota.Name = "txt_mota";
			this.txt_mota.Size = new System.Drawing.Size(459, 88);
			this.txt_mota.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(53, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 18);
			this.label4.TabIndex = 14;
			this.label4.Text = "Chương trình tour: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(207, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 18);
			this.label5.TabIndex = 15;
			this.label5.Text = "label5";
			// 
			// frm_ChuongTrinhTour
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1354, 586);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_mota);
			this.Controls.Add(this.txt_ngay);
			this.Controls.Add(this.txt_tieude);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_ChuongTrinhTour";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_mota.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.MemoEdit txt_mota;
		private System.Windows.Forms.MaskedTextBox txt_ngay;
		private System.Windows.Forms.TextBox txt_tieude;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}