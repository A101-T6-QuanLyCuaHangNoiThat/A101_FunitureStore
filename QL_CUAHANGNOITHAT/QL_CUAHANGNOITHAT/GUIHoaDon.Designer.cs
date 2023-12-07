namespace QL_CUAHANGNOITHAT
{
    partial class GUIHoaDon
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabHoaDon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPhieuNhap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tabHoaDon.SuspendLayout();
            this.TabPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(20, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(113, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Hoá đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(26, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 11);
            this.panel1.TabIndex = 1;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.BackColor = System.Drawing.Color.White;
            this.tabHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHoaDon.Controls.Add(this.label1);
            this.tabHoaDon.Location = new System.Drawing.Point(26, 87);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Size = new System.Drawing.Size(149, 30);
            this.tabHoaDon.TabIndex = 2;
            this.tabHoaDon.Click += new System.EventHandler(this.tabHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoá đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TabPhieuNhap
            // 
            this.TabPhieuNhap.BackColor = System.Drawing.Color.Silver;
            this.TabPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPhieuNhap.Controls.Add(this.label2);
            this.TabPhieuNhap.Location = new System.Drawing.Point(175, 87);
            this.TabPhieuNhap.Name = "TabPhieuNhap";
            this.TabPhieuNhap.Size = new System.Drawing.Size(149, 30);
            this.TabPhieuNhap.TabIndex = 2;
            this.TabPhieuNhap.Click += new System.EventHandler(this.TabPhieuNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(33, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phiếu nhập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Location = new System.Drawing.Point(26, 118);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(944, 522);
            this.pnMain.TabIndex = 3;
            // 
            // GUIHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.TabPhieuNhap);
            this.Controls.Add(this.tabHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "GUIHoaDon";
            this.Size = new System.Drawing.Size(996, 653);
            this.Load += new System.EventHandler(this.GUIHoaDon_Load);
            this.tabHoaDon.ResumeLayout(false);
            this.tabHoaDon.PerformLayout();
            this.TabPhieuNhap.ResumeLayout(false);
            this.TabPhieuNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tabHoaDon;
        private System.Windows.Forms.Panel TabPhieuNhap;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
