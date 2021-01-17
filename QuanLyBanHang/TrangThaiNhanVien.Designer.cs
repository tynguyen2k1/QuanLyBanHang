namespace QuanLyBanHang
{
    partial class TrangThaiNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_nghi_viec = new System.Windows.Forms.Button();
            this.btn_chan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Trạng Thái ";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Lime;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(301, 60);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(171, 39);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Khôi Phục (Đang Làm)";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_nghi_viec
            // 
            this.btn_nghi_viec.BackColor = System.Drawing.Color.Red;
            this.btn_nghi_viec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nghi_viec.ForeColor = System.Drawing.Color.White;
            this.btn_nghi_viec.Location = new System.Drawing.Point(12, 60);
            this.btn_nghi_viec.Name = "btn_nghi_viec";
            this.btn_nghi_viec.Size = new System.Drawing.Size(133, 39);
            this.btn_nghi_viec.TabIndex = 1;
            this.btn_nghi_viec.Text = "Nghỉ Việc";
            this.btn_nghi_viec.UseVisualStyleBackColor = false;
            this.btn_nghi_viec.Click += new System.EventHandler(this.btn_nghi_viec_Click);
            // 
            // btn_chan
            // 
            this.btn_chan.BackColor = System.Drawing.Color.Yellow;
            this.btn_chan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chan.Location = new System.Drawing.Point(151, 60);
            this.btn_chan.Name = "btn_chan";
            this.btn_chan.Size = new System.Drawing.Size(144, 39);
            this.btn_chan.TabIndex = 1;
            this.btn_chan.Text = "Chặn Tài Khoản";
            this.btn_chan.UseVisualStyleBackColor = false;
            this.btn_chan.Click += new System.EventHandler(this.btn_chan_Click);
            // 
            // TrangThaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.btn_nghi_viec);
            this.Controls.Add(this.btn_chan);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "TrangThaiNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trạng Thái ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_nghi_viec;
        private System.Windows.Forms.Button btn_chan;
    }
}

