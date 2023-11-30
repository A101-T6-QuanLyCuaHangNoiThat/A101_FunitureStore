namespace QL_CUAHANGNOITHAT
{
    partial class GUISanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtSP = new System.Windows.Forms.DataGridView();
            this.btnfind = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDSP = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(26, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 11);
            this.panel1.TabIndex = 1;
            // 
            // dtSP
            // 
            this.dtSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSP.Location = new System.Drawing.Point(26, 140);
            this.dtSP.Name = "dtSP";
            this.dtSP.Size = new System.Drawing.Size(487, 497);
            this.dtSP.TabIndex = 2;
            this.dtSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSP_CellClick);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(910, 49);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 44);
            this.btnfind.TabIndex = 4;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtfind);
            this.panel2.Location = new System.Drawing.Point(636, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 44);
            this.panel2.TabIndex = 5;
            // 
            // txtfind
            // 
            this.txtfind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfind.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtfind.Location = new System.Drawing.Point(13, 12);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(252, 20);
            this.txtfind.TabIndex = 6;
            this.txtfind.Text = "Nhập vào sản phẩm cần tìm";
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            this.txtfind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfind_KeyDown);
            this.txtfind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtfind_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDSP);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtNhaCungCap);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(519, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 497);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // IDSP
            // 
            this.IDSP.AutoSize = true;
            this.IDSP.Location = new System.Drawing.Point(410, 16);
            this.IDSP.Name = "IDSP";
            this.IDSP.Size = new System.Drawing.Size(35, 13);
            this.IDSP.TabIndex = 5;
            this.IDSP.Text = "label6";
            this.IDSP.Visible = false;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(245, 283);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(109, 23);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Xoá sản phẩm";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(130, 283);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(109, 23);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Sửa sản phẩm";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(16, 283);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Thêm sản phẩm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 204);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(326, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Location = new System.Drawing.Point(98, 162);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(326, 20);
            this.txtNhaCungCap.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(95, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 40);
            this.panel3.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hết hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Còn hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(65, 58);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(359, 20);
            this.txtTenSanPham.TabIndex = 1;
            this.txtTenSanPham.TextChanged += new System.EventHandler(this.txtTenSanPham_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Loại sản phẩm :";
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Location = new System.Drawing.Point(147, 109);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(133, 21);
            this.cbLoaiSanPham.TabIndex = 8;
            this.cbLoaiSanPham.SelectedValueChanged += new System.EventHandler(this.cbLoaiSanPham_SelectedValueChanged);
            // 
            // GUISanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbLoaiSanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.dtSP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GUISanPham";
            this.Size = new System.Drawing.Size(996, 653);
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtSP;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label IDSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
    }
}
