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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuyDM = new System.Windows.Forms.Button();
            this.btnTimKiemDM = new System.Windows.Forms.Button();
            this.txtMa_DM_TK = new System.Windows.Forms.TextBox();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSapXepDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhMuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTenDM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaDM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(917, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtTenDM
            // 
            this.txtTenDM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenDM.Location = new System.Drawing.Point(628, 24);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.ReadOnly = true;
            this.txtTenDM.Size = new System.Drawing.Size(248, 25);
            this.txtTenDM.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên Danh Mục :";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(173, 24);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(235, 25);
            this.txtMaDM.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Danh Mục : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataDanhMuc);
            this.panel1.Location = new System.Drawing.Point(24, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 419);
            this.panel1.TabIndex = 1;
            // 
            // dataDanhMuc
            // 
            this.dataDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDanhMuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dataDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDanhMuc.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dataDanhMuc.Name = "dataDanhMuc";
            this.dataDanhMuc.ReadOnly = true;
            this.dataDanhMuc.Size = new System.Drawing.Size(917, 419);
            this.dataDanhMuc.TabIndex = 9;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Danh Mục";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên Danh Mục";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnHuyDM);
            this.panel2.Controls.Add(this.btnTimKiemDM);
            this.panel2.Controls.Add(this.txtMa_DM_TK);
            this.panel2.Controls.Add(this.btnSuaDM);
            this.panel2.Controls.Add(this.btnXoaDM);
            this.panel2.Controls.Add(this.btnSapXepDM);
            this.panel2.Controls.Add(this.btnThemDM);
            this.panel2.Location = new System.Drawing.Point(24, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnHuyDM
            // 
            this.btnHuyDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHuyDM.Location = new System.Drawing.Point(396, 3);
            this.btnHuyDM.Name = "btnHuyDM";
            this.btnHuyDM.Size = new System.Drawing.Size(93, 30);
            this.btnHuyDM.TabIndex = 8;
            this.btnHuyDM.Text = "Huỷ";
            this.btnHuyDM.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemDM
            // 
            this.btnTimKiemDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTimKiemDM.Location = new System.Drawing.Point(822, 6);
            this.btnTimKiemDM.Name = "btnTimKiemDM";
            this.btnTimKiemDM.Size = new System.Drawing.Size(93, 25);
            this.btnTimKiemDM.TabIndex = 7;
            this.btnTimKiemDM.Text = "Tìm Kiếm";
            this.btnTimKiemDM.UseVisualStyleBackColor = true;
            // 
            // txtMa_DM_TK
            // 
            this.txtMa_DM_TK.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa_DM_TK.Location = new System.Drawing.Point(628, 6);
            this.txtMa_DM_TK.Name = "txtMa_DM_TK";
            this.txtMa_DM_TK.Size = new System.Drawing.Size(188, 25);
            this.txtMa_DM_TK.TabIndex = 6;
            this.txtMa_DM_TK.Text = "Nhập tên danh mục muốn tìm";
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSuaDM.Location = new System.Drawing.Point(99, 3);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(93, 30);
            this.btnSuaDM.TabIndex = 3;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoaDM.Location = new System.Drawing.Point(198, 3);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(93, 30);
            this.btnXoaDM.TabIndex = 2;
            this.btnXoaDM.Text = "Xoá";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            // 
            // btnSapXepDM
            // 
            this.btnSapXepDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSapXepDM.Location = new System.Drawing.Point(297, 3);
            this.btnSapXepDM.Name = "btnSapXepDM";
            this.btnSapXepDM.Size = new System.Drawing.Size(93, 30);
            this.btnSapXepDM.TabIndex = 1;
            this.btnSapXepDM.Text = "Sắp Xếp";
            this.btnSapXepDM.UseVisualStyleBackColor = true;
            // 
            // btnThemDM
            // 
            this.btnThemDM.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThemDM.Location = new System.Drawing.Point(0, 3);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(93, 30);
            this.btnThemDM.TabIndex = 0;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
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
            // frmDanhMuc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(971, 611);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhMuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataDanhMuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiemDM;
        private System.Windows.Forms.TextBox txtMa_DM_TK;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSapXepDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnHuyDM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}