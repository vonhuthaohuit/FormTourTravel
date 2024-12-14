namespace FormTourTravel
{
	partial class frm_ChiTietTour
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
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_matour = new System.Windows.Forms.TextBox();
			this.txt_giatour = new System.Windows.Forms.TextBox();
			this.cbx_diemdulich = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			windowsUIButtonImageOptions1.ImageUri.Uri = "New;Size32x32;GrayScaled";
			windowsUIButtonImageOptions2.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
			windowsUIButtonImageOptions3.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
			windowsUIButtonImageOptions4.ImageUri.Uri = "Refresh;Size32x32;GrayScaled";
			this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm mới", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanel.EnableImageTransparency = true;
			this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 583);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 74);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 74);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(1336, 74);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(49, 188);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1055, 282);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(45, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Chi tiết tour:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(155, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dateTimePicker1.Location = new System.Drawing.Point(743, 143);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(293, 28);
			this.dateTimePicker1.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(740, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 21);
			this.label3.TabIndex = 12;
			this.label3.Text = "Ngày bắt đầu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(442, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Giá tour";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(45, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 21);
			this.label5.TabIndex = 14;
			this.label5.Text = "Điểm du lich";
			// 
			// txt_matour
			// 
			this.txt_matour.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_matour.Location = new System.Drawing.Point(995, 82);
			this.txt_matour.Name = "txt_matour";
			this.txt_matour.Size = new System.Drawing.Size(129, 28);
			this.txt_matour.TabIndex = 10;
			this.txt_matour.Visible = false;
			// 
			// txt_giatour
			// 
			this.txt_giatour.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_giatour.Location = new System.Drawing.Point(446, 143);
			this.txt_giatour.Name = "txt_giatour";
			this.txt_giatour.Size = new System.Drawing.Size(221, 28);
			this.txt_giatour.TabIndex = 11;
			// 
			// cbx_diemdulich
			// 
			this.cbx_diemdulich.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbx_diemdulich.FormattingEnabled = true;
			this.cbx_diemdulich.Location = new System.Drawing.Point(49, 142);
			this.cbx_diemdulich.Name = "cbx_diemdulich";
			this.cbx_diemdulich.Size = new System.Drawing.Size(292, 29);
			this.cbx_diemdulich.TabIndex = 9;
			// 
			// frm_ChiTietTour
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1336, 657);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_matour);
			this.Controls.Add(this.txt_giatour);
			this.Controls.Add(this.cbx_diemdulich);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_ChiTietTour";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_matour;
		private System.Windows.Forms.TextBox txt_giatour;
		private System.Windows.Forms.ComboBox cbx_diemdulich;
	}
}