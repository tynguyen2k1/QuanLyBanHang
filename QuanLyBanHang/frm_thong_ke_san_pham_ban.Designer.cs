namespace QuanLyBanHang
{
    partial class frm_thong_ke_san_pham_ban
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_trang = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.data_thong_ke = new System.Windows.Forms.DataGridView();
            this.MA_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG_SL_BAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_CON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.number_date = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.number_year = new System.Windows.Forms.NumericUpDown();
            this.lb_err_nam = new System.Windows.Forms.Label();
            this.btn_san_pham_ton = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma_sp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thong_ke)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_year)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1084, 93);
            this.label9.TabIndex = 35;
            this.label9.Text = "Thống Kê Sản Phẩm Bán";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lb_trang);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_prev);
            this.panel1.Controls.Add(this.data_thong_ke);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Location = new System.Drawing.Point(354, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 475);
            this.panel1.TabIndex = 36;
            // 
            // lb_trang
            // 
            this.lb_trang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_trang.AutoSize = true;
            this.lb_trang.Location = new System.Drawing.Point(351, 450);
            this.lb_trang.Name = "lb_trang";
            this.lb_trang.Size = new System.Drawing.Size(15, 18);
            this.lb_trang.TabIndex = 4;
            this.lb_trang.Text = "0";
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Location = new System.Drawing.Point(583, 445);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(119, 23);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(5, 445);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(119, 23);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // data_thong_ke
            // 
            this.data_thong_ke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_thong_ke.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_thong_ke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_thong_ke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_SP,
            this.TEN_SP,
            this.TONG_SL_BAN,
            this.SL_CON});
            this.data_thong_ke.GridColor = System.Drawing.SystemColors.ControlLight;
            this.data_thong_ke.Location = new System.Drawing.Point(5, 32);
            this.data_thong_ke.Name = "data_thong_ke";
            this.data_thong_ke.Size = new System.Drawing.Size(697, 407);
            this.data_thong_ke.TabIndex = 1;
            // 
            // MA_SP
            // 
            this.MA_SP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MA_SP.DataPropertyName = "MA_SP";
            this.MA_SP.HeaderText = "Mã Sản Phẩm";
            this.MA_SP.Name = "MA_SP";
            // 
            // TEN_SP
            // 
            this.TEN_SP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_SP.DataPropertyName = "TEN_SP";
            this.TEN_SP.HeaderText = "Tên Sản Phẩm";
            this.TEN_SP.Name = "TEN_SP";
            // 
            // TONG_SL_BAN
            // 
            this.TONG_SL_BAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONG_SL_BAN.DataPropertyName = "TONG_SL_BAN";
            this.TONG_SL_BAN.HeaderText = "Tổng Số Lượng Bán";
            this.TONG_SL_BAN.Name = "TONG_SL_BAN";
            // 
            // SL_CON
            // 
            this.SL_CON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL_CON.DataPropertyName = "SL_CON";
            this.SL_CON.HeaderText = "Số Lượng Còn";
            this.SL_CON.Name = "SL_CON";
            // 
            // lb_title
            // 
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_title.Location = new System.Drawing.Point(0, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(705, 29);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Danh Sách Sản Phẩm Bán ";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.number_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.number_year);
            this.groupBox1.Controls.Add(this.lb_err_nam);
            this.groupBox1.Controls.Add(this.btn_san_pham_ton);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_tim_kiem);
            this.groupBox1.Controls.Add(this.cb_thang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ma_sp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 465);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // number_date
            // 
            this.number_date.Location = new System.Drawing.Point(112, 107);
            this.number_date.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_date.Name = "number_date";
            this.number_date.Size = new System.Drawing.Size(165, 25);
            this.number_date.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày";
            // 
            // number_year
            // 
            this.number_year.Location = new System.Drawing.Point(112, 207);
            this.number_year.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_year.Name = "number_year";
            this.number_year.Size = new System.Drawing.Size(165, 25);
            this.number_year.TabIndex = 13;
            this.number_year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.number_year_KeyUp);
            this.number_year.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number_year_MouseDown);
            // 
            // lb_err_nam
            // 
            this.lb_err_nam.AutoSize = true;
            this.lb_err_nam.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_err_nam.ForeColor = System.Drawing.Color.Red;
            this.lb_err_nam.Location = new System.Drawing.Point(14, 236);
            this.lb_err_nam.Name = "lb_err_nam";
            this.lb_err_nam.Size = new System.Drawing.Size(0, 18);
            this.lb_err_nam.TabIndex = 12;
            // 
            // btn_san_pham_ton
            // 
            this.btn_san_pham_ton.Location = new System.Drawing.Point(17, 332);
            this.btn_san_pham_ton.Name = "btn_san_pham_ton";
            this.btn_san_pham_ton.Size = new System.Drawing.Size(260, 39);
            this.btn_san_pham_ton.TabIndex = 10;
            this.btn_san_pham_ton.Text = "Danh Sách Sản Phẩm Tồn";
            this.btn_san_pham_ton.UseVisualStyleBackColor = true;
            this.btn_san_pham_ton.Click += new System.EventHandler(this.btn_san_pham_ton_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(158, 268);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(119, 39);
            this.btn_huy.TabIndex = 8;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Location = new System.Drawing.Point(17, 268);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Size = new System.Drawing.Size(119, 39);
            this.btn_tim_kiem.TabIndex = 7;
            this.btn_tim_kiem.Text = "Tìm Kiếm";
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(112, 157);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(165, 26);
            this.cb_thang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng :";
            // 
            // txt_ma_sp
            // 
            this.txt_ma_sp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ma_sp.Location = new System.Drawing.Point(112, 63);
            this.txt_ma_sp.Name = "txt_ma_sp";
            this.txt_ma_sp.Size = new System.Drawing.Size(165, 25);
            this.txt_ma_sp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_thong_ke_san_pham_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "frm_thong_ke_san_pham_ban";
            this.Text = "Thống Kê Sản Phẩm Bán";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thong_ke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_year)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ma_sp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_thong_ke;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.Button btn_san_pham_ton;
        private System.Windows.Forms.Label lb_trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG_SL_BAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_CON;
        private System.Windows.Forms.NumericUpDown number_year;
        private System.Windows.Forms.Label lb_err_nam;
        private System.Windows.Forms.NumericUpDown number_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}