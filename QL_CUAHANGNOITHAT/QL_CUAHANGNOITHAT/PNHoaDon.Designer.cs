namespace QL_CUAHANGNOITHAT
{
    partial class PNHoaDon
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
            this.dtHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetTinhTrang = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdTTFalse = new System.Windows.Forms.RadioButton();
            this.rdTTTrue = new System.Windows.Forms.RadioButton();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnCreateHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtHoaDon
            // 
            this.dtHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHoaDon.Location = new System.Drawing.Point(3, 3);
            this.dtHoaDon.Name = "dtHoaDon";
            this.dtHoaDon.Size = new System.Drawing.Size(488, 516);
            this.dtHoaDon.TabIndex = 1;
            this.dtHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHoaDon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateHoaDon);
            this.groupBox1.Controls.Add(this.btnSetTinhTrang);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.tbnShow);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(497, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 516);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn";
            // 
            // btnSetTinhTrang
            // 
            this.btnSetTinhTrang.Location = new System.Drawing.Point(268, 458);
            this.btnSetTinhTrang.Name = "btnSetTinhTrang";
            this.btnSetTinhTrang.Size = new System.Drawing.Size(170, 23);
            this.btnSetTinhTrang.TabIndex = 6;
            this.btnSetTinhTrang.Text = "Giao hàng";
            this.btnSetTinhTrang.UseVisualStyleBackColor = true;
            this.btnSetTinhTrang.Click += new System.EventHandler(this.btnSetTinhTrang_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(363, 487);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbnShow
            // 
            this.tbnShow.Location = new System.Drawing.Point(268, 487);
            this.tbnShow.Name = "tbnShow";
            this.tbnShow.Size = new System.Drawing.Size(75, 23);
            this.tbnShow.TabIndex = 4;
            this.tbnShow.Text = "Xem chi tiết";
            this.tbnShow.UseVisualStyleBackColor = true;
            this.tbnShow.Click += new System.EventHandler(this.tbnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdTTFalse);
            this.panel1.Controls.Add(this.rdTTTrue);
            this.panel1.Location = new System.Drawing.Point(163, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 103);
            this.panel1.TabIndex = 3;
            // 
            // rdTTFalse
            // 
            this.rdTTFalse.AutoSize = true;
            this.rdTTFalse.Location = new System.Drawing.Point(16, 45);
            this.rdTTFalse.Name = "rdTTFalse";
            this.rdTTFalse.Size = new System.Drawing.Size(73, 17);
            this.rdTTFalse.TabIndex = 1;
            this.rdTTFalse.TabStop = true;
            this.rdTTFalse.Text = "Chưa giao";
            this.rdTTFalse.UseVisualStyleBackColor = true;
            // 
            // rdTTTrue
            // 
            this.rdTTTrue.AutoSize = true;
            this.rdTTTrue.Location = new System.Drawing.Point(107, 45);
            this.rdTTTrue.Name = "rdTTTrue";
            this.rdTTTrue.Size = new System.Drawing.Size(62, 17);
            this.rdTTTrue.TabIndex = 0;
            this.rdTTTrue.TabStop = true;
            this.rdTTTrue.Text = "Đã giao";
            this.rdTTTrue.UseVisualStyleBackColor = true;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.CustomFormat = "DD/MM/yyyy";
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLap.Location = new System.Drawing.Point(163, 74);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(206, 20);
            this.txtNgayLap.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(163, 336);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(206, 20);
            this.txtTongTien.TabIndex = 1;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(163, 151);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(206, 20);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(163, 114);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(206, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(163, 39);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(206, 20);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình trạng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày lập : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(118, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Đã giao";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Chưa giao";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnCreateHoaDon
            // 
            this.btnCreateHoaDon.Location = new System.Drawing.Point(24, 487);
            this.btnCreateHoaDon.Name = "btnCreateHoaDon";
            this.btnCreateHoaDon.Size = new System.Drawing.Size(174, 23);
            this.btnCreateHoaDon.TabIndex = 7;
            this.btnCreateHoaDon.Text = "Tạo hoá đơn";
            this.btnCreateHoaDon.UseVisualStyleBackColor = true;
            this.btnCreateHoaDon.Click += new System.EventHandler(this.btnCreateHoaDon_Click);
            // 
            // PNHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtHoaDon);
            this.Name = "PNHoaDon";
            this.Size = new System.Drawing.Size(944, 522);
            this.Load += new System.EventHandler(this.PNHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button tbnShow;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdTTFalse;
        private System.Windows.Forms.RadioButton rdTTTrue;
        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnSetTinhTrang;
        private System.Windows.Forms.Button btnCreateHoaDon;
    }
}
