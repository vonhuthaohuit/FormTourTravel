namespace ThuVien.Usercontrol_Edit
{
    partial class TieuDeChucNang
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
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(84, 0);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(753, 65);
            this.lbl_TieuDe.TabIndex = 0;
            this.lbl_TieuDe.Text = "Tiêu đề";
            // 
            // TieuDeChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_TieuDe);
            this.Name = "TieuDeChucNang";
            this.Size = new System.Drawing.Size(840, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TieuDe;
    }
}
