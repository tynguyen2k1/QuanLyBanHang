﻿namespace QuanLyBanHang
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Ma_KH = new System.Windows.Forms.TextBox();
            this.dtpk_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_sap_xep = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dataKhachHang = new System.Windows.Forms.DataGridView();
            this.MA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_CHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_SINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btn_quay_lai = new System.Windows.Forms.Button();
            this.txt_search_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search_dia_chi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_search_sdt = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Ma_Kh_search = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ma_Kh_search)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Ma_KH);
            this.groupBox1.Controls.Add(this.dtpk_ngay_sinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.rd_nu);
            this.groupBox1.Controls.Add(this.rd_nam);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenkh);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(764, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mã Khách Hàng :";
            // 
            // txt_Ma_KH
            // 
            this.txt_Ma_KH.Location = new System.Drawing.Point(161, 29);
            this.txt_Ma_KH.Name = "txt_Ma_KH";
            this.txt_Ma_KH.ReadOnly = true;
            this.txt_Ma_KH.Size = new System.Drawing.Size(223, 25);
            this.txt_Ma_KH.TabIndex = 26;
            // 
            // dtpk_ngay_sinh
            // 
            this.dtpk_ngay_sinh.Location = new System.Drawing.Point(499, 98);
            this.dtpk_ngay_sinh.Name = "dtpk_ngay_sinh";
            this.dtpk_ngay_sinh.Size = new System.Drawing.Size(228, 25);
            this.dtpk_ngay_sinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày Sinh : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btn_sap_xep);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(34, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 37);
            this.panel2.TabIndex = 22;
            // 
            // btnHuy
            // 
            this.btnHuy.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHuy.Location = new System.Drawing.Point(558, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 30);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Edit.Location = new System.Drawing.Point(127, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(135, 30);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(268, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_sap_xep
            // 
            this.btn_sap_xep.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_sap_xep.Location = new System.Drawing.Point(411, 3);
            this.btn_sap_xep.Name = "btn_sap_xep";
            this.btn_sap_xep.Size = new System.Drawing.Size(141, 30);
            this.btn_sap_xep.TabIndex = 10;
            this.btn_sap_xep.Text = "Sắp Xếp (Mã Desc)";
            this.btn_sap_xep.UseVisualStyleBackColor = true;
            this.btn_sap_xep.Click += new System.EventHandler(this.btn_sap_xep_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Location = new System.Drawing.Point(5, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Location = new System.Drawing.Point(229, 97);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(47, 22);
            this.rd_nu.TabIndex = 6;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Checked = true;
            this.rd_nam.Location = new System.Drawing.Point(161, 97);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(56, 22);
            this.rd_nam.TabIndex = 5;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.Location = new System.Drawing.Point(499, 29);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 25);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Địa chỉ : ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(499, 62);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 25);
            this.txtSDT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "SĐT : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới Tính : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Khách Hàng :";
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(161, 63);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(223, 25);
            this.txtTenkh.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dataKhachHang);
            this.panel1.Location = new System.Drawing.Point(24, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 355);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1090, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Danh Sách Khách Hàng";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKhachHang.AutoGenerateColumns = false;
            this.dataKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_KH,
            this.TEN_KH,
            this.SDT,
            this.DIA_CHI,
            this.NGAY_SINH,
            this.Gioi_Tinh});
            this.dataKhachHang.DataSource = this.kHACHHANGBindingSource;
            this.dataKhachHang.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataKhachHang.Location = new System.Drawing.Point(0, 24);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.ReadOnly = true;
            this.dataKhachHang.Size = new System.Drawing.Size(1090, 328);
            this.dataKhachHang.TabIndex = 17;
            this.dataKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKhachHang_CellClick);
            // 
            // MA_KH
            // 
            this.MA_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MA_KH.DataPropertyName = "MA_KH";
            this.MA_KH.HeaderText = "Mã Khách Hàng";
            this.MA_KH.Name = "MA_KH";
            this.MA_KH.ReadOnly = true;
            // 
            // TEN_KH
            // 
            this.TEN_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_KH.DataPropertyName = "TEN_KH";
            this.TEN_KH.HeaderText = "Tên Khách Hàng";
            this.TEN_KH.Name = "TEN_KH";
            this.TEN_KH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DIA_CHI
            // 
            this.DIA_CHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIA_CHI.DataPropertyName = "DIA_CHI";
            this.DIA_CHI.HeaderText = "Địa Chỉ";
            this.DIA_CHI.Name = "DIA_CHI";
            this.DIA_CHI.ReadOnly = true;
            // 
            // NGAY_SINH
            // 
            this.NGAY_SINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAY_SINH.DataPropertyName = "NGAY_SINH";
            this.NGAY_SINH.HeaderText = "Ngày Sinh";
            this.NGAY_SINH.Name = "NGAY_SINH";
            this.NGAY_SINH.ReadOnly = true;
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
            this.Gioi_Tinh.HeaderText = "Giới Tính";
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            this.Gioi_Tinh.ReadOnly = true;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataSource = typeof(Entity.KHACH_HANG);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1144, 42);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Khách Hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_quay_lai
            // 
            this.btn_quay_lai.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quay_lai.Location = new System.Drawing.Point(8, 9);
            this.btn_quay_lai.Name = "btn_quay_lai";
            this.btn_quay_lai.Size = new System.Drawing.Size(44, 30);
            this.btn_quay_lai.TabIndex = 4;
            this.btn_quay_lai.Text = "<<";
            this.btn_quay_lai.UseVisualStyleBackColor = true;
            this.btn_quay_lai.Click += new System.EventHandler(this.btn_quay_lai_Click);
            // 
            // txt_search_ten
            // 
            this.txt_search_ten.Location = new System.Drawing.Point(93, 60);
            this.txt_search_ten.Name = "txt_search_ten";
            this.txt_search_ten.Size = new System.Drawing.Size(190, 25);
            this.txt_search_ten.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã :";
            // 
            // txt_search_dia_chi
            // 
            this.txt_search_dia_chi.Location = new System.Drawing.Point(93, 129);
            this.txt_search_dia_chi.Name = "txt_search_dia_chi";
            this.txt_search_dia_chi.Size = new System.Drawing.Size(190, 25);
            this.txt_search_dia_chi.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "SĐT :";
            // 
            // txt_search_sdt
            // 
            this.txt_search_sdt.Location = new System.Drawing.Point(93, 95);
            this.txt_search_sdt.Name = "txt_search_sdt";
            this.txt_search_sdt.Size = new System.Drawing.Size(190, 25);
            this.txt_search_sdt.TabIndex = 14;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Search.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Search.Location = new System.Drawing.Point(28, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(255, 30);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Ma_Kh_search
            // 
            this.Ma_Kh_search.Location = new System.Drawing.Point(93, 27);
            this.Ma_Kh_search.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Ma_Kh_search.Name = "Ma_Kh_search";
            this.Ma_Kh_search.Size = new System.Drawing.Size(190, 25);
            this.Ma_Kh_search.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Ma_Kh_search);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_search_sdt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_search_dia_chi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_search_ten);
            this.groupBox2.Location = new System.Drawing.Point(811, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Thông Tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên :";
            // 
            // btn_Prev
            // 
            this.btn_Prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Prev.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Prev.Location = new System.Drawing.Point(28, 615);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(116, 30);
            this.btn_Prev.TabIndex = 8;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_next.Location = new System.Drawing.Point(995, 615);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(116, 30);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1144, 651);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_quay_lai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 690);
            this.Name = "frmKhachHang";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ma_Kh_search)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_quay_lai;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_sap_xep;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpk_ngay_sinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_CHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_SINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txt_Ma_KH;
        public System.Windows.Forms.TextBox txt_search_ten;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_search_dia_chi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search_sdt;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.NumericUpDown Ma_Kh_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_next;
    }
}