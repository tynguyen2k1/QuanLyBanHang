namespace QuanLyBanHang
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpk_End = new System.Windows.Forms.DateTimePicker();
            this.dtpk_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataCTHD = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.TEN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Giam_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_Mua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mACTHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(822, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 39);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã HĐ : ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTimKiem.Location = new System.Drawing.Point(246, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 25);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 25);
            this.textBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1190, 42);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Hoá Đơn Bán";
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
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.dtpk_End);
            this.panel3.Controls.Add(this.dtpk_Start);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLoc);
            this.panel3.Location = new System.Drawing.Point(24, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 36);
            this.panel3.TabIndex = 5;
            // 
            // dtpk_End
            // 
            this.dtpk_End.Location = new System.Drawing.Point(346, 6);
            this.dtpk_End.Name = "dtpk_End";
            this.dtpk_End.Size = new System.Drawing.Size(216, 25);
            this.dtpk_End.TabIndex = 13;
            // 
            // dtpk_Start
            // 
            this.dtpk_Start.Location = new System.Drawing.Point(44, 5);
            this.dtpk_Start.Name = "dtpk_Start";
            this.dtpk_Start.Size = new System.Drawing.Size(225, 25);
            this.dtpk_Start.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "End :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start : ";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Blue;
            this.btnLoc.ForeColor = System.Drawing.Color.Snow;
            this.btnLoc.Location = new System.Drawing.Point(602, 5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(93, 27);
            this.btnLoc.TabIndex = 9;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(24, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mã  hoá đơn  : 30243324932";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dataCTHD);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(711, 211);
            this.panel5.TabIndex = 17;
            // 
            // dataCTHD
            // 
            this.dataCTHD.AutoGenerateColumns = false;
            this.dataCTHD.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACTHDDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.gIABANDataGridViewTextBoxColumn,
            this.Giam_gia,
            this.SL_Mua,
            this.tHANHTIENDataGridViewTextBoxColumn,
            this.mAHDDataGridViewTextBoxColumn1});
            this.dataCTHD.DataSource = this.cTHOADONBindingSource;
            this.dataCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCTHD.Location = new System.Drawing.Point(0, 22);
            this.dataCTHD.Name = "dataCTHD";
            this.dataCTHD.Size = new System.Drawing.Size(711, 189);
            this.dataCTHD.TabIndex = 1;
            this.dataCTHD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTHD_CellEndEdit);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(711, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thông Tin Sản Phẩm Mua";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(741, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 211);
            this.panel4.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ngày Mua : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tổng Tiền :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Tổng Tiền :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(133, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Số điện Thoại : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(133, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 18);
            this.label17.TabIndex = 21;
            this.label17.Text = "Tên Khách Hàng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ngày Mua : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "Tổng Tiền :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tổng Tiền :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số điện Thoại : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên Khách Hàng :";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(389, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thông Tin Khách Hàng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Green;
            this.button6.Location = new System.Drawing.Point(9, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 27);
            this.button6.TabIndex = 15;
            this.button6.Text = "Sửa hoá đơn";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(129, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 27);
            this.button4.TabIndex = 13;
            this.button4.Text = "Xoá hoá đơn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(259, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "In hoá đơn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataHoaDon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(25, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 280);
            this.panel1.TabIndex = 18;
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AutoGenerateColumns = false;
            this.dataHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_HD,
            this.mANVDataGridViewTextBoxColumn,
            this.nGAYBANDataGridViewTextBoxColumn,
            this.tONGTIENDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.TEN_KH});
            this.dataHoaDon.DataSource = this.hOADONBindingSource;
            this.dataHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHoaDon.Location = new System.Drawing.Point(0, 22);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.Size = new System.Drawing.Size(1136, 258);
            this.dataHoaDon.TabIndex = 16;
            this.dataHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDon_CellClick);
            // 
            // TEN_KH
            // 
            this.TEN_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_KH.DataPropertyName = "TEN_KH";
            this.TEN_KH.FillWeight = 70F;
            this.TEN_KH.HeaderText = "Tên Khách Hàng";
            this.TEN_KH.Name = "TEN_KH";
            this.TEN_KH.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1136, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Danh Sách Hoá Đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Location = new System.Drawing.Point(25, 368);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1135, 36);
            this.panel6.TabIndex = 19;
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Green;
            this.button8.Location = new System.Drawing.Point(474, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(204, 27);
            this.button8.TabIndex = 13;
            this.button8.Text = "Sẵp Xếp Theo Ngày";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 27);
            this.button5.TabIndex = 12;
            this.button5.Text = "Tạo Hoá Đơn Mới";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(236, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sắp Xếp Theo Tổng Tiền";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(705, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chọn Tất Cả";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Green;
            this.btnXoa.Location = new System.Drawing.Point(925, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 27);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá Thư Mục Đã Chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // Giam_gia
            // 
            this.Giam_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Giam_gia.DataPropertyName = "GIAM_GIA";
            this.Giam_gia.FillWeight = 30F;
            this.Giam_gia.HeaderText = "Giảm(%)";
            this.Giam_gia.Name = "Giam_gia";
            this.Giam_gia.ReadOnly = true;
            // 
            // SL_Mua
            // 
            this.SL_Mua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL_Mua.DataPropertyName = "SO_LUONG";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SL_Mua.DefaultCellStyle = dataGridViewCellStyle2;
            this.SL_Mua.FillWeight = 40F;
            this.SL_Mua.HeaderText = "SL Mua";
            this.SL_Mua.Name = "SL_Mua";
            // 
            // MA_HD
            // 
            this.MA_HD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MA_HD.DataPropertyName = "MA_HD";
            this.MA_HD.FillWeight = 25F;
            this.MA_HD.HeaderText = "Mã HD";
            this.MA_HD.Name = "MA_HD";
            this.MA_HD.ReadOnly = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MA_NV";
            this.mANVDataGridViewTextBoxColumn.FillWeight = 25F;
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYBANDataGridViewTextBoxColumn
            // 
            this.nGAYBANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYBANDataGridViewTextBoxColumn.DataPropertyName = "NGAY_BAN";
            this.nGAYBANDataGridViewTextBoxColumn.FillWeight = 65F;
            this.nGAYBANDataGridViewTextBoxColumn.HeaderText = "Ngày Bán";
            this.nGAYBANDataGridViewTextBoxColumn.Name = "nGAYBANDataGridViewTextBoxColumn";
            this.nGAYBANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tONGTIENDataGridViewTextBoxColumn
            // 
            this.tONGTIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tONGTIENDataGridViewTextBoxColumn.DataPropertyName = "TONG_TIEN";
            this.tONGTIENDataGridViewTextBoxColumn.FillWeight = 65F;
            this.tONGTIENDataGridViewTextBoxColumn.HeaderText = "Tổng Tiền";
            this.tONGTIENDataGridViewTextBoxColumn.Name = "tONGTIENDataGridViewTextBoxColumn";
            this.tONGTIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MA_KH";
            this.mAKHDataGridViewTextBoxColumn.FillWeight = 25F;
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(Entity.HOA_DON);
            // 
            // mACTHDDataGridViewTextBoxColumn
            // 
            this.mACTHDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mACTHDDataGridViewTextBoxColumn.DataPropertyName = "MA_CTHD";
            this.mACTHDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.mACTHDDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.mACTHDDataGridViewTextBoxColumn.Name = "mACTHDDataGridViewTextBoxColumn";
            this.mACTHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MA_SP";
            this.mASPDataGridViewTextBoxColumn.FillWeight = 50F;
            this.mASPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            this.mASPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIABANDataGridViewTextBoxColumn
            // 
            this.gIABANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIABANDataGridViewTextBoxColumn.DataPropertyName = "GIA_BAN";
            this.gIABANDataGridViewTextBoxColumn.FillWeight = 80F;
            this.gIABANDataGridViewTextBoxColumn.HeaderText = "Gía bán";
            this.gIABANDataGridViewTextBoxColumn.Name = "gIABANDataGridViewTextBoxColumn";
            this.gIABANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANH_TIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.FillWeight = 80F;
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            this.tHANHTIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAHDDataGridViewTextBoxColumn1
            // 
            this.mAHDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mAHDDataGridViewTextBoxColumn1.DataPropertyName = "MA_HD";
            this.mAHDDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.mAHDDataGridViewTextBoxColumn1.HeaderText = "MA_HD";
            this.mAHDDataGridViewTextBoxColumn1.Name = "mAHDDataGridViewTextBoxColumn1";
            // 
            // cTHOADONBindingSource
            // 
            this.cTHOADONBindingSource.DataSource = typeof(Entity.CT_HOA_DON);
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1190, 657);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 690);
            this.Name = "frmHoaDon";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dtpk_End;
        private System.Windows.Forms.DateTimePicker dtpk_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataCTHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private System.Windows.Forms.BindingSource cTHOADONBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACTHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giam_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_Mua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn1;
    }
}