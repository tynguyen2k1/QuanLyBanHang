namespace QuanLyBanHang
{
    partial class frmNhanVien
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
            this.dtpk_nvl = new System.Windows.Forms.DateTimePicker();
            this.Txt_MK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rd_ql = new System.Windows.Forms.RadioButton();
            this.rd_nv = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMucLuong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa_nv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_SX = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_CHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOI_TINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_VL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAI_KHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUC_VU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANG_THAI = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lb_trang = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpk_nvl);
            this.groupBox1.Controls.Add(this.Txt_MK);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMucLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMa_nv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1162, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // dtpk_nvl
            // 
            this.dtpk_nvl.CustomFormat = "1/1/1900";
            this.dtpk_nvl.Location = new System.Drawing.Point(756, 49);
            this.dtpk_nvl.Name = "dtpk_nvl";
            this.dtpk_nvl.Size = new System.Drawing.Size(273, 25);
            this.dtpk_nvl.TabIndex = 7;
            this.dtpk_nvl.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Txt_MK
            // 
            this.Txt_MK.Location = new System.Drawing.Point(756, 104);
            this.Txt_MK.Name = "Txt_MK";
            this.Txt_MK.PasswordChar = '*';
            this.Txt_MK.Size = new System.Drawing.Size(273, 25);
            this.Txt_MK.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mật Khẩu :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(756, 22);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(273, 25);
            this.txtSDT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ngày Vào Làm";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Location = new System.Drawing.Point(265, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rd_ql);
            this.panel4.Controls.Add(this.rd_nv);
            this.panel4.Location = new System.Drawing.Point(756, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 26);
            this.panel4.TabIndex = 22;
            // 
            // rd_ql
            // 
            this.rd_ql.AccessibleName = "chuc_vu";
            this.rd_ql.AutoSize = true;
            this.rd_ql.Location = new System.Drawing.Point(165, 3);
            this.rd_ql.Name = "rd_ql";
            this.rd_ql.Size = new System.Drawing.Size(78, 22);
            this.rd_ql.TabIndex = 12;
            this.rd_ql.TabStop = true;
            this.rd_ql.Text = "Quản Lý";
            this.rd_ql.UseVisualStyleBackColor = true;
            // 
            // rd_nv
            // 
            this.rd_nv.AccessibleName = "chuc_vu";
            this.rd_nv.AutoSize = true;
            this.rd_nv.Location = new System.Drawing.Point(3, 3);
            this.rd_nv.Name = "rd_nv";
            this.rd_nv.Size = new System.Drawing.Size(156, 22);
            this.rd_nv.TabIndex = 10;
            this.rd_nv.TabStop = true;
            this.rd_nv.Text = "Nhân Viên Bán Hàng";
            this.rd_nv.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_Nu);
            this.panel3.Controls.Add(this.rd_Nam);
            this.panel3.Location = new System.Drawing.Point(265, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 26);
            this.panel3.TabIndex = 21;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AccessibleName = "gioi_tinh";
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(74, 3);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(47, 22);
            this.rd_Nu.TabIndex = 5;
            this.rd_Nu.TabStop = true;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = false;
            // 
            // rd_Nam
            // 
            this.rd_Nam.AccessibleName = "gioi_tinh";
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Location = new System.Drawing.Point(3, 3);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(56, 22);
            this.rd_Nam.TabIndex = 4;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // txtTK
            // 
            this.txtTK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTK.Location = new System.Drawing.Point(756, 77);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(273, 25);
            this.txtTK.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Chức Vụ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDiaChi.Location = new System.Drawing.Point(265, 80);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(273, 25);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Địa Chỉ : ";
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.AutoSize = true;
            this.txtMucLuong.Location = new System.Drawing.Point(613, 80);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(79, 18);
            this.txtMucLuong.TabIndex = 15;
            this.txtMucLuong.Text = "Tài Khoản :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số Điện Thoại :";
            // 
            // txtMa_nv
            // 
            this.txtMa_nv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMa_nv.Location = new System.Drawing.Point(265, 25);
            this.txtMa_nv.Name = "txtMa_nv";
            this.txtMa_nv.Size = new System.Drawing.Size(273, 25);
            this.txtMa_nv.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã Nhân Viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giới Tính : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên Nhân Viên :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(265, 52);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(273, 25);
            this.txtTenNV.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_SX);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Location = new System.Drawing.Point(24, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 63);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(0, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1162, 33);
            this.label10.TabIndex = 10;
            this.label10.Text = "Danh Sách Nhân Viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnHuy
            // 
            this.btnHuy.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHuy.Location = new System.Drawing.Point(971, 0);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(171, 30);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTimKiem.Location = new System.Drawing.Point(782, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(183, 30);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Location = new System.Drawing.Point(208, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(183, 30);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Xoa.Location = new System.Drawing.Point(404, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(184, 30);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xoá (Nghỉ Việc)";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_SX
            // 
            this.btn_SX.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SX.Location = new System.Drawing.Point(594, 0);
            this.btn_SX.Name = "btn_SX";
            this.btn_SX.Size = new System.Drawing.Size(182, 30);
            this.btn_SX.TabIndex = 16;
            this.btn_SX.Text = "Sắp Xếp (Ma_Nv Giảm) ";
            this.btn_SX.UseVisualStyleBackColor = true;
            this.btn_SX.Click += new System.EventHandler(this.btn_SX_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Them.Location = new System.Drawing.Point(10, 0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(192, 30);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1216, 42);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Nhân Viên";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(8, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 30);
            this.button7.TabIndex = 4;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataSource = typeof(Entity.NHAN_VIEN);
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNext.Location = new System.Drawing.Point(991, 611);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 30);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrev.Location = new System.Drawing.Point(21, 611);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(192, 30);
            this.btnPrev.TabIndex = 36;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataNhanVien);
            this.panel1.Location = new System.Drawing.Point(21, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 292);
            this.panel1.TabIndex = 34;
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AutoGenerateColumns = false;
            this.dataNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NV,
            this.TEN_NV,
            this.SDT,
            this.DIA_CHI,
            this.GIOI_TINH,
            this.NGAY_VL,
            this.EMAIL,
            this.TAI_KHOAN,
            this.CHUC_VU,
            this.TRANG_THAI});
            this.dataNhanVien.DataSource = this.nHANVIENBindingSource;
            this.dataNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNhanVien.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.ReadOnly = true;
            this.dataNhanVien.Size = new System.Drawing.Size(1162, 292);
            this.dataNhanVien.TabIndex = 20;
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellClick);
            this.dataNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellContentClick);
            this.dataNhanVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellDoubleClick);
            // 
            // MA_NV
            // 
            this.MA_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MA_NV.DataPropertyName = "MA_NV";
            this.MA_NV.FillWeight = 110F;
            this.MA_NV.HeaderText = "Mã NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.ReadOnly = true;
            // 
            // TEN_NV
            // 
            this.TEN_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_NV.DataPropertyName = "TEN_NV";
            this.TEN_NV.FillWeight = 130F;
            this.TEN_NV.HeaderText = "Tên NV";
            this.TEN_NV.Name = "TEN_NV";
            this.TEN_NV.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 80F;
            this.SDT.HeaderText = "SDT";
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
            // GIOI_TINH
            // 
            this.GIOI_TINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOI_TINH.DataPropertyName = "GIOI_TINH";
            this.GIOI_TINH.FillWeight = 50F;
            this.GIOI_TINH.HeaderText = "Giới Tính";
            this.GIOI_TINH.Name = "GIOI_TINH";
            this.GIOI_TINH.ReadOnly = true;
            // 
            // NGAY_VL
            // 
            this.NGAY_VL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAY_VL.DataPropertyName = "NGAY_VL";
            this.NGAY_VL.FillWeight = 70F;
            this.NGAY_VL.HeaderText = "Ngày VL";
            this.NGAY_VL.Name = "NGAY_VL";
            this.NGAY_VL.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // TAI_KHOAN
            // 
            this.TAI_KHOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TAI_KHOAN.DataPropertyName = "TAI_KHOAN";
            this.TAI_KHOAN.HeaderText = "Tài Khoản";
            this.TAI_KHOAN.Name = "TAI_KHOAN";
            this.TAI_KHOAN.ReadOnly = true;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CHUC_VU.DataPropertyName = "CHUC_VU";
            this.CHUC_VU.FillWeight = 80F;
            this.CHUC_VU.HeaderText = "Chức Vụ";
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.ReadOnly = true;
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANG_THAI.DataPropertyName = "TRANG_THAI";
            this.TRANG_THAI.FillWeight = 80F;
            this.TRANG_THAI.HeaderText = "Trạng Thái";
            this.TRANG_THAI.Name = "TRANG_THAI";
            this.TRANG_THAI.ReadOnly = true;
            this.TRANG_THAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TRANG_THAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lb_trang
            // 
            this.lb_trang.AutoSize = true;
            this.lb_trang.Location = new System.Drawing.Point(581, 615);
            this.lb_trang.Name = "lb_trang";
            this.lb_trang.Size = new System.Drawing.Size(0, 18);
            this.lb_trang.TabIndex = 38;
            // 
            // frmNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1216, 673);
            this.Controls.Add(this.lb_trang);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 690);
            this.Name = "frmNhanVien";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMa_nv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMucLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_SX;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rd_ql;
        private System.Windows.Forms.RadioButton rd_nv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.TextBox Txt_MK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpk_nvl;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_CHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOI_TINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_VL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAI_KHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUC_VU;
        private System.Windows.Forms.DataGridViewButtonColumn TRANG_THAI;
        private System.Windows.Forms.Label lb_trang;
    }
}