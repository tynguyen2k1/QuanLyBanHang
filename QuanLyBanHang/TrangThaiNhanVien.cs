using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class TrangThaiNhanVien : Form
    {
        public TrangThaiNhanVien()
        {
            InitializeComponent();
            setTrang_Thai(-1);
        }
        public int trang_thai { set; get; }
        public void setTrang_Thai(int val)
        {
            this.trang_thai =val;
        }
        public int getTrangThai()
        {
            return this.trang_thai;
        }
        private void btn_nghi_viec_Click(object sender, EventArgs e)
        {
            this.setTrang_Thai(1);
            this.Close();
        }

        private void btn_chan_Click(object sender, EventArgs e)
        {
            this.setTrang_Thai(2);
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            this.setTrang_Thai(0);
            this.Close();
        }
    }
}
