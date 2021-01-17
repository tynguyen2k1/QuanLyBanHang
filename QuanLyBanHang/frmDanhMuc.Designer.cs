namespace QuanLyBanHang
{
    partial class frmDanhMuc
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSapXepDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lb_trang = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.Ma_DM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANG_THAI = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dANHMUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_list_dm_xoa = new System.Windows.Forms.Button();
            this.btn_xoa_list = new System.Windows.Forms.Button();
            this.btn_chon_all = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnSuaDM);
            this.groupBox1.Controls.Add(this.btnXoaDM);
            this.groupBox1.Controls.Add(this.btnSapXepDM);
            this.groupBox1.Controls.Add(this.btnThemDM);
            this.groupBox1.Controls.Add(this.txtTenDM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaDM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(911, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // btn_Huy
            // 
            this.btn_Huy.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Huy.Location = new System.Drawing.Point(755, 128);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(146, 30);
            this.btn_Huy.TabIndex = 23;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTimKiem.Location = new System.Drawing.Point(621, 128);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 30);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSuaDM.Location = new System.Drawing.Point(148, 128);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(130, 30);
            this.btnSuaDM.TabIndex = 21;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click_1);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoaDM.Location = new System.Drawing.Point(284, 128);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(138, 30);
            this.btnXoaDM.TabIndex = 20;
            this.btnXoaDM.Text = "Xoá";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click_1);
            // 
            // btnSapXepDM
            // 
            this.btnSapXepDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSapXepDM.Location = new System.Drawing.Point(428, 128);
            this.btnSapXepDM.Name = "btnSapXepDM";
            this.btnSapXepDM.Size = new System.Drawing.Size(187, 30);
            this.btnSapXepDM.TabIndex = 19;
            this.btnSapXepDM.Text = "Sắp Xếp (MaDM desc)";
            this.btnSapXepDM.UseVisualStyleBackColor = true;
            this.btnSapXepDM.Click += new System.EventHandler(this.btnSapXepDM_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThemDM.Location = new System.Drawing.Point(9, 128);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(133, 30);
            this.btnThemDM.TabIndex = 18;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click_1);
            // 
            // txtTenDM
            // 
            this.txtTenDM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenDM.Location = new System.Drawing.Point(346, 56);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(292, 25);
            this.txtTenDM.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên Danh Mục :";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(346, 88);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(292, 25);
            this.txtMoTa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mô Tả :";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(346, 25);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(292, 25);
            this.txtMaDM.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Danh Mục : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.dgvDanhMuc);
            this.panel1.Location = new System.Drawing.Point(24, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 324);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.lb_trang);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 36);
            this.panel2.TabIndex = 14;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(3, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(102, 33);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lb_trang
            // 
            this.lb_trang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_trang.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trang.ForeColor = System.Drawing.Color.Red;
            this.lb_trang.Location = new System.Drawing.Point(478, 9);
            this.lb_trang.Name = "lb_trang";
            this.lb_trang.Size = new System.Drawing.Size(17, 15);
            this.lb_trang.TabIndex = 13;
            this.lb_trang.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(799, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 32);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lb_title
            // 
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_title.Location = new System.Drawing.Point(0, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(910, 26);
            this.lb_title.TabIndex = 10;
            this.lb_title.Text = "Danh Sách Danh Mục";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhMuc.AutoGenerateColumns = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_DM,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TRANG_THAI});
            this.dgvDanhMuc.DataSource = this.dANHMUCBindingSource;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDanhMuc.Location = new System.Drawing.Point(3, 29);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.Size = new System.Drawing.Size(910, 250);
            this.dgvDanhMuc.TabIndex = 9;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            this.dgvDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellContentClick);
            this.dgvDanhMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDanhMuc_KeyDown);
            // 
            // Ma_DM
            // 
            this.Ma_DM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_DM.DataPropertyName = "Ma_DM";
            this.Ma_DM.FillWeight = 54.24525F;
            this.Ma_DM.HeaderText = "Ma_DM";
            this.Ma_DM.Name = "Ma_DM";
            this.Ma_DM.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_DM";
            this.dataGridViewTextBoxColumn2.FillWeight = 93.8274F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Danh Mục";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MO_TA";
            this.dataGridViewTextBoxColumn3.FillWeight = 93.8274F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mô Tả";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANG_THAI.DataPropertyName = "TRANG_THAI";
            this.TRANG_THAI.FillWeight = 52.26236F;
            this.TRANG_THAI.HeaderText = "TRANG_THAI";
            this.TRANG_THAI.Name = "TRANG_THAI";
            this.TRANG_THAI.ReadOnly = true;
            // 
            // dANHMUCBindingSource
            // 
            this.dANHMUCBindingSource.DataSource = typeof(Entity.DANH_MUC);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(964, 42);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Danh Mục";
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(27, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dữ phím Ctrl => click vào dòng muốn xoá";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btn_list_dm_xoa);
            this.panel3.Controls.Add(this.btn_xoa_list);
            this.panel3.Controls.Add(this.btn_chon_all);
            this.panel3.Location = new System.Drawing.Point(24, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 36);
            this.panel3.TabIndex = 15;
            // 
            // btn_list_dm_xoa
            // 
            this.btn_list_dm_xoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_list_dm_xoa.Location = new System.Drawing.Point(339, 3);
            this.btn_list_dm_xoa.Name = "btn_list_dm_xoa";
            this.btn_list_dm_xoa.Size = new System.Drawing.Size(183, 30);
            this.btn_list_dm_xoa.TabIndex = 27;
            this.btn_list_dm_xoa.Text = "Các Danh Mục Đã Xoá";
            this.btn_list_dm_xoa.UseVisualStyleBackColor = true;
            this.btn_list_dm_xoa.Click += new System.EventHandler(this.btn_list_dm_xoa_Click);
            // 
            // btn_xoa_list
            // 
            this.btn_xoa_list.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_xoa_list.Location = new System.Drawing.Point(171, 3);
            this.btn_xoa_list.Name = "btn_xoa_list";
            this.btn_xoa_list.Size = new System.Drawing.Size(162, 30);
            this.btn_xoa_list.TabIndex = 26;
            this.btn_xoa_list.Text = "Xoá Mục Đã Chọn ";
            this.btn_xoa_list.UseVisualStyleBackColor = true;
            this.btn_xoa_list.Click += new System.EventHandler(this.btn_xoa_list_Click);
            // 
            // btn_chon_all
            // 
            this.btn_chon_all.AutoSize = true;
            this.btn_chon_all.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_chon_all.Location = new System.Drawing.Point(3, 3);
            this.btn_chon_all.Name = "btn_chon_all";
            this.btn_chon_all.Size = new System.Drawing.Size(162, 30);
            this.btn_chon_all.TabIndex = 25;
            this.btn_chon_all.Text = "Chọn Tất Cả";
            this.btn_chon_all.UseVisualStyleBackColor = true;
            this.btn_chon_all.Click += new System.EventHandler(this.btn_chon_all_Click);
            // 
            // frmDanhMuc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 650);
            this.Name = "frmDanhMuc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dANHMUCBindingSource;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSapXepDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn TRANG_THAI;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lb_trang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_list_dm_xoa;
        private System.Windows.Forms.Button btn_xoa_list;
        private System.Windows.Forms.Button btn_chon_all;
    }
}