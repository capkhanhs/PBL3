namespace PBL.View
{
    partial class ChinhSua_ThemSanPham_Admin
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
            this.pn_SanPham = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_SanPham
            // 
            this.pn_SanPham.Location = new System.Drawing.Point(-2, -1);
            this.pn_SanPham.Name = "pn_SanPham";
            this.pn_SanPham.Size = new System.Drawing.Size(1143, 617);
            this.pn_SanPham.TabIndex = 0;
            // 
            // ChinhSua_ThemSanPham_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 612);
            this.Controls.Add(this.pn_SanPham);
            this.Name = "ChinhSua_ThemSanPham_Admin";
            this.Text = "ChinhSua_ThemSanPham_Admin";
            this.Load += new System.EventHandler(this.ChinhSua_ThemSanPham_Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_SanPham;
    }
}