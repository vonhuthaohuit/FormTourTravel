namespace FormTourTravel
{
	partial class frm_TourTypecs
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
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 507);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 74);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 74);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(1081, 74);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(58, 188);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(927, 233);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(317, 104);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new System.Drawing.Size(388, 22);
			this.textEdit1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(199, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Loại Tour: ";
			// 
			// frm_TourTypecs
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 581);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textEdit1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_TourTypecs";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private System.Windows.Forms.Label label1;
	}
}