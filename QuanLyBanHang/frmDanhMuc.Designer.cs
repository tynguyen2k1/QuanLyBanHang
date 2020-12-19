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
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.Ma_DM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSapXepDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemMaSP = new System.Windows.Forms.Button();
            this.btnTimKiemTenSP = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dANHMUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyDM);
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
            this.groupBox1.Size = new System.Drawing.Size(682, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(241, 97);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(292, 25);
            this.txtMoTa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mô Tả :";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(241, 34);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(292, 25);
            this.txtMaDM.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 37);
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
            this.panel1.Controls.Add(this.dgvDanhMuc);
            this.panel1.Location = new System.Drawing.Point(24, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 324);
            this.panel1.TabIndex = 1;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AutoGenerateColumns = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_DM,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvDanhMuc.DataSource = this.dANHMUCBindingSource;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.Size = new System.Drawing.Size(917, 324);
            this.dgvDanhMuc.TabIndex = 9;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            this.dgvDanhMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDanhMuc_KeyDown);
            // 
            // Ma_DM
            // 
            this.Ma_DM.DataPropertyName = "Ma_DM";
            this.Ma_DM.FillWeight = 82.08121F;
            this.Ma_DM.HeaderText = "Ma_DM";
            this.Ma_DM.Name = "Ma_DM";
            this.Ma_DM.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(971, 42);
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
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(24, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xoá Mục Đã Chọn ";
            this.button1.UseVisualStyleBackColor = true;
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
            // txtTenDM
            // 
            this.txtTenDM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenDM.Location = new System.Drawing.Point(241, 65);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(292, 25);
            this.txtTenDM.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên Danh Mục :";
            // 
            // btnHuyDM
            // 
            this.btnHuyDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHuyDM.Location = new System.Drawing.Point(497, 128);
            this.btnHuyDM.Name = "btnHuyDM";
            this.btnHuyDM.Size = new System.Drawing.Size(93, 30);
            this.btnHuyDM.TabIndex = 22;
            this.btnHuyDM.Text = "Huỷ";
            this.btnHuyDM.UseVisualStyleBackColor = true;
            this.btnHuyDM.Click += new System.EventHandler(this.btnHuyDM_Click_1);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSuaDM.Location = new System.Drawing.Point(200, 128);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(93, 30);
            this.btnSuaDM.TabIndex = 21;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click_1);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoaDM.Location = new System.Drawing.Point(299, 128);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(93, 30);
            this.btnXoaDM.TabIndex = 20;
            this.btnXoaDM.Text = "Xoá";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click_1);
            // 
            // btnSapXepDM
            // 
            this.btnSapXepDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSapXepDM.Location = new System.Drawing.Point(398, 128);
            this.btnSapXepDM.Name = "btnSapXepDM";
            this.btnSapXepDM.Size = new System.Drawing.Size(93, 30);
            this.btnSapXepDM.TabIndex = 19;
            this.btnSapXepDM.Text = "Sắp Xếp";
            this.btnSapXepDM.UseVisualStyleBackColor = true;
            // 
            // btnThemDM
            // 
            this.btnThemDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThemDM.Location = new System.Drawing.Point(101, 128);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(93, 30);
            this.btnThemDM.TabIndex = 18;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemTenSP);
            this.groupBox2.Controls.Add(this.btnTimKiemMaSP);
            this.groupBox2.Location = new System.Drawing.Point(727, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 168);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTimKiemMaSP
            // 
            this.btnTimKiemMaSP.Location = new System.Drawing.Point(31, 32);
            this.btnTimKiemMaSP.Name = "btnTimKiemMaSP";
            this.btnTimKiemMaSP.Size = new System.Drawing.Size(156, 27);
            this.btnTimKiemMaSP.TabIndex = 0;
            this.btnTimKiemMaSP.Text = "Tìm Kiếm Theo Mã";
            this.btnTimKiemMaSP.UseVisualStyleBackColor = true;
            this.btnTimKiemMaSP.Click += new System.EventHandler(this.btnTimKiemMaSP_Click);
            // 
            // btnTimKiemTenSP
            // 
            this.btnTimKiemTenSP.Location = new System.Drawing.Point(31, 68);
            this.btnTimKiemTenSP.Name = "btnTimKiemTenSP";
            this.btnTimKiemTenSP.Size = new System.Drawing.Size(156, 27);
            this.btnTimKiemTenSP.TabIndex = 1;
            this.btnTimKiemTenSP.Text = "Tìm Kiếm Theo Tên";
            this.btnTimKiemTenSP.UseVisualStyleBackColor = true;
            this.btnTimKiemTenSP.Click += new System.EventHandler(this.btnTimKiemTenSP_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_DM";
            this.dataGridViewTextBoxColumn2.FillWeight = 82.08121F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Danh Mục";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MO_TA";
            this.dataGridViewTextBoxColumn3.FillWeight = 82.08121F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mô Tả";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dANHMUCBindingSource
            // 
            this.dANHMUCBindingSource.DataSource = typeof(Entity.DANH_MUC);
            // 
            // frmDanhMuc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(971, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSapXepDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemTenSP;
        private System.Windows.Forms.Button btnTimKiemMaSP;
    }
}