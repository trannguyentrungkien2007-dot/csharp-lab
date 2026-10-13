namespace CourseRegistrationApp
{
    partial class Form1
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
            this.grBThongtinhocvien = new System.Windows.Forms.GroupBox();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.grBThongtinkhoahoc = new System.Windows.Forms.GroupBox();
            this.lblMacDinh = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grBThongtinhocvien.SuspendLayout();
            this.grBThongtinkhoahoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // grBThongtinhocvien
            // 
            this.grBThongtinhocvien.Controls.Add(this.chkNhanEmail);
            this.grBThongtinhocvien.Controls.Add(this.dtpNgaySinh);
            this.grBThongtinhocvien.Controls.Add(this.txtSoDienThoai);
            this.grBThongtinhocvien.Controls.Add(this.label3);
            this.grBThongtinhocvien.Controls.Add(this.label2);
            this.grBThongtinhocvien.Controls.Add(this.label1);
            this.grBThongtinhocvien.Controls.Add(this.txtHoTen);
            this.grBThongtinhocvien.Location = new System.Drawing.Point(55, 45);
            this.grBThongtinhocvien.Name = "grBThongtinhocvien";
            this.grBThongtinhocvien.Size = new System.Drawing.Size(581, 334);
            this.grBThongtinhocvien.TabIndex = 0;
            this.grBThongtinhocvien.TabStop = false;
            this.grBThongtinhocvien.Text = "Thông tin học viên";
            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(190, 218);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(190, 24);
            this.chkNhanEmail.TabIndex = 6;
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            this.chkNhanEmail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(190, 165);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(294, 26);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(190, 100);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(294, 26);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập họ tên học viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(190, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(294, 26);
            this.txtHoTen.TabIndex = 0;
            // 
            // grBThongtinkhoahoc
            // 
            this.grBThongtinkhoahoc.Controls.Add(this.lblMacDinh);
            this.grBThongtinkhoahoc.Controls.Add(this.lblTongTien);
            this.grBThongtinkhoahoc.Controls.Add(this.label6);
            this.grBThongtinkhoahoc.Controls.Add(this.numSoThang);
            this.grBThongtinkhoahoc.Controls.Add(this.radOffline);
            this.grBThongtinkhoahoc.Controls.Add(this.radOnline);
            this.grBThongtinkhoahoc.Controls.Add(this.label5);
            this.grBThongtinkhoahoc.Controls.Add(this.label4);
            this.grBThongtinkhoahoc.Controls.Add(this.cboKhoaHoc);
            this.grBThongtinkhoahoc.Location = new System.Drawing.Point(60, 466);
            this.grBThongtinkhoahoc.Name = "grBThongtinkhoahoc";
            this.grBThongtinkhoahoc.Size = new System.Drawing.Size(575, 318);
            this.grBThongtinkhoahoc.TabIndex = 1;
            this.grBThongtinkhoahoc.TabStop = false;
            this.grBThongtinkhoahoc.Text = "Thông tin khóa học";
            // 
            // lblMacDinh
            // 
            this.lblMacDinh.AutoSize = true;
            this.lblMacDinh.Location = new System.Drawing.Point(224, 236);
            this.lblMacDinh.Name = "lblMacDinh";
            this.lblMacDinh.Size = new System.Drawing.Size(56, 20);
            this.lblMacDinh.TabIndex = 10;
            this.lblMacDinh.Text = "0 VNĐ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(24, 234);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(154, 20);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "Hiển thị tổng học phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số tháng đăng ký";
            // 
            // numSoThang
            // 
            this.numSoThang.Location = new System.Drawing.Point(198, 190);
            this.numSoThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSoThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(280, 26);
            this.numSoThang.TabIndex = 7;
            this.numSoThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radOffline
            // 
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(186, 135);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(163, 24);
            this.radOffline.TabIndex = 6;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Hình thức trực tiếp";
            this.radOffline.UseVisualStyleBackColor = true;
            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(186, 95);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(148, 24);
            this.radOnline.TabIndex = 5;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Hình thức online";
            this.radOnline.UseVisualStyleBackColor = true;
            this.radOnline.CheckedChanged += new System.EventHandler(this.radOnline_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chọn hình thức học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chọn khóa học";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(186, 52);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(294, 28);
            this.cboKhoaHoc.TabIndex = 0;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(740, 167);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(163, 69);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Xử lý đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(740, 339);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(163, 69);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Xóa dữ liệu";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(740, 518);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 77);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(814, 739);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 950);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grBThongtinkhoahoc);
            this.Controls.Add(this.grBThongtinhocvien);
            this.Name = "Form1";
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBThongtinhocvien.ResumeLayout(false);
            this.grBThongtinhocvien.PerformLayout();
            this.grBThongtinkhoahoc.ResumeLayout(false);
            this.grBThongtinkhoahoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBThongtinhocvien;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox grBThongtinkhoahoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMacDinh;
    }
}

