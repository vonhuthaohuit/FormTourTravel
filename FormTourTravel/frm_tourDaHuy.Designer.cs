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
            this.maphieuhuytour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydohuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuhuytour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_phieuhuytour
            // 
            this.dgv_phieuhuytour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuhuytour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieuhuytour,
            this.tentour,
            this.lydohuy,
            this.sotienhoan,
            this.ngayhuy});
            this.dgv_phieuhuytour.Location = new System.Drawing.Point(6, 19);
            this.dgv_phieuhuytour.Name = "dgv_phieuhuytour";
            this.dgv_phieuhuytour.Size = new System.Drawing.Size(1112, 289);
            this.dgv_phieuhuytour.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_phieuhuytour);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tour đã hủy";
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
            // lydohuy
            // 
            this.lydohuy.DataPropertyName = "lydohuy";
            this.lydohuy.HeaderText = "Lý do hủy";
            this.lydohuy.Name = "lydohuy";
            this.lydohuy.Width = 300;
            // 
            // sotienhoan
            // 
            this.sotienhoan.DataPropertyName = "sotienhoan";
            this.sotienhoan.HeaderText = "Số tiền hoàn";
            this.sotienhoan.Name = "sotienhoan";
            this.sotienhoan.Width = 150;
            // 
            // ngayhuy
            // 
            this.ngayhuy.DataPropertyName = "ngayhuy";
            this.ngayhuy.HeaderText = "Ngày Hủy";
            this.ngayhuy.Name = "ngayhuy";
            this.ngayhuy.Width = 150;
            // 
            // frm_tourDaHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tourDaHuy";
            this.Text = "frm_tourDaHuy";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuhuytour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phieuhuytour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuhuytour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentour;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydohuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhuy;
    }
}