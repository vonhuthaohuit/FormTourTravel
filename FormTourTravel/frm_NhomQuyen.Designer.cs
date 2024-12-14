namespace FormTourTravel
{
    partial class frm_NhomQuyen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_manhomquyen = new System.Windows.Forms.TextBox();
            this.txt_tennhomquyen = new System.Windows.Forms.TextBox();
            this.dgv_nhomquyen = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_themnhomquyen = new System.Windows.Forms.Button();
            this.btn_xoanhomquyen = new System.Windows.Forms.Button();
            this.btn_suanhomquyen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_suaquyen = new System.Windows.Forms.Button();
            this.btn_xoaquyen = new System.Windows.Forms.Button();
            this.btn_themquyen = new System.Windows.Forms.Button();
            this.dgv_quyen = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_tenquyen = new System.Windows.Forms.TextBox();
            this.txt_maquyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhomquyen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quyen)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tennhomquyen);
            this.groupBox1.Controls.Add(this.txt_manhomquyen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm quyền";
            // 
            // txt_manhomquyen
            // 
            this.txt_manhomquyen.Enabled = false;
            this.txt_manhomquyen.Location = new System.Drawing.Point(109, 27);
            this.txt_manhomquyen.Name = "txt_manhomquyen";
            this.txt_manhomquyen.Size = new System.Drawing.Size(136, 20);
            this.txt_manhomquyen.TabIndex = 2;
            // 
            // txt_tennhomquyen
            // 
            this.txt_tennhomquyen.Location = new System.Drawing.Point(109, 64);
            this.txt_tennhomquyen.Name = "txt_tennhomquyen";
            this.txt_tennhomquyen.Size = new System.Drawing.Size(136, 20);
            this.txt_tennhomquyen.TabIndex = 3;
            // 
            // dgv_nhomquyen
            // 
            this.dgv_nhomquyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhomquyen.Location = new System.Drawing.Point(6, 19);
            this.dgv_nhomquyen.Name = "dgv_nhomquyen";
            this.dgv_nhomquyen.Size = new System.Drawing.Size(444, 222);
            this.dgv_nhomquyen.TabIndex = 1;
            this.dgv_nhomquyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhomquyen_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_suanhomquyen);
            this.groupBox2.Controls.Add(this.btn_xoanhomquyen);
            this.groupBox2.Controls.Add(this.btn_themnhomquyen);
            this.groupBox2.Location = new System.Drawing.Point(309, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_themnhomquyen
            // 
            this.btn_themnhomquyen.Location = new System.Drawing.Point(19, 19);
            this.btn_themnhomquyen.Name = "btn_themnhomquyen";
            this.btn_themnhomquyen.Size = new System.Drawing.Size(75, 23);
            this.btn_themnhomquyen.TabIndex = 0;
            this.btn_themnhomquyen.Text = "Thêm";
            this.btn_themnhomquyen.UseVisualStyleBackColor = true;
            this.btn_themnhomquyen.Click += new System.EventHandler(this.btn_themnhomquyen_Click);
            // 
            // btn_xoanhomquyen
            // 
            this.btn_xoanhomquyen.Location = new System.Drawing.Point(19, 47);
            this.btn_xoanhomquyen.Name = "btn_xoanhomquyen";
            this.btn_xoanhomquyen.Size = new System.Drawing.Size(75, 23);
            this.btn_xoanhomquyen.TabIndex = 1;
            this.btn_xoanhomquyen.Text = "Xóa";
            this.btn_xoanhomquyen.UseVisualStyleBackColor = true;
            this.btn_xoanhomquyen.Click += new System.EventHandler(this.btn_xoanhomquyen_Click);
            // 
            // btn_suanhomquyen
            // 
            this.btn_suanhomquyen.Location = new System.Drawing.Point(19, 75);
            this.btn_suanhomquyen.Name = "btn_suanhomquyen";
            this.btn_suanhomquyen.Size = new System.Drawing.Size(75, 23);
            this.btn_suanhomquyen.TabIndex = 2;
            this.btn_suanhomquyen.Text = "Cập nhật";
            this.btn_suanhomquyen.UseVisualStyleBackColor = true;
            this.btn_suanhomquyen.Click += new System.EventHandler(this.btn_suanhomquyen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_suaquyen);
            this.groupBox3.Controls.Add(this.btn_xoaquyen);
            this.groupBox3.Controls.Add(this.btn_themquyen);
            this.groupBox3.Location = new System.Drawing.Point(859, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 104);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_suaquyen
            // 
            this.btn_suaquyen.Location = new System.Drawing.Point(19, 75);
            this.btn_suaquyen.Name = "btn_suaquyen";
            this.btn_suaquyen.Size = new System.Drawing.Size(75, 23);
            this.btn_suaquyen.TabIndex = 2;
            this.btn_suaquyen.Text = "Cập nhật";
            this.btn_suaquyen.UseVisualStyleBackColor = true;
            this.btn_suaquyen.Click += new System.EventHandler(this.btn_suaquyen_Click);
            // 
            // btn_xoaquyen
            // 
            this.btn_xoaquyen.Location = new System.Drawing.Point(19, 47);
            this.btn_xoaquyen.Name = "btn_xoaquyen";
            this.btn_xoaquyen.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaquyen.TabIndex = 1;
            this.btn_xoaquyen.Text = "Xóa";
            this.btn_xoaquyen.UseVisualStyleBackColor = true;
            this.btn_xoaquyen.Click += new System.EventHandler(this.btn_xoaquyen_Click);
            // 
            // btn_themquyen
            // 
            this.btn_themquyen.Location = new System.Drawing.Point(19, 19);
            this.btn_themquyen.Name = "btn_themquyen";
            this.btn_themquyen.Size = new System.Drawing.Size(75, 23);
            this.btn_themquyen.TabIndex = 0;
            this.btn_themquyen.Text = "Thêm";
            this.btn_themquyen.UseVisualStyleBackColor = true;
            this.btn_themquyen.Click += new System.EventHandler(this.btn_themquyen_Click);
            // 
            // dgv_quyen
            // 
            this.dgv_quyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quyen.Location = new System.Drawing.Point(6, 21);
            this.dgv_quyen.Name = "dgv_quyen";
            this.dgv_quyen.Size = new System.Drawing.Size(422, 222);
            this.dgv_quyen.TabIndex = 4;
            this.dgv_quyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quyen_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_mota);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_tenquyen);
            this.groupBox4.Controls.Add(this.txt_maquyen);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(562, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 115);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quyền";
            // 
            // txt_tenquyen
            // 
            this.txt_tenquyen.Location = new System.Drawing.Point(109, 55);
            this.txt_tenquyen.Name = "txt_tenquyen";
            this.txt_tenquyen.Size = new System.Drawing.Size(136, 20);
            this.txt_tenquyen.TabIndex = 3;
            // 
            // txt_maquyen
            // 
            this.txt_maquyen.Enabled = false;
            this.txt_maquyen.Location = new System.Drawing.Point(109, 23);
            this.txt_maquyen.Name = "txt_maquyen";
            this.txt_maquyen.Size = new System.Drawing.Size(136, 20);
            this.txt_maquyen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã quyền";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(109, 84);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(136, 20);
            this.txt_mota.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_nhomquyen);
            this.groupBox5.Location = new System.Drawing.Point(12, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 249);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhóm quyền";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgv_quyen);
            this.groupBox6.Location = new System.Drawing.Point(562, 143);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 249);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách quyền";
            // 
            // frm_NhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 433);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NhomQuyen";
            this.Text = "frm_NhomQuyen";
            this.Load += new System.EventHandler(this.frm_NhomQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhomquyen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quyen)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tennhomquyen;
        private System.Windows.Forms.TextBox txt_manhomquyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nhomquyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_suanhomquyen;
        private System.Windows.Forms.Button btn_xoanhomquyen;
        private System.Windows.Forms.Button btn_themnhomquyen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_suaquyen;
        private System.Windows.Forms.Button btn_xoaquyen;
        private System.Windows.Forms.Button btn_themquyen;
        private System.Windows.Forms.DataGridView dgv_quyen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_tenquyen;
        private System.Windows.Forms.TextBox txt_maquyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}