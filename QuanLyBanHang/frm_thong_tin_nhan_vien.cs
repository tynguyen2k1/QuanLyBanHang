using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
namespace QuanLyBanHang
{
    public partial class frm_thong_tin_nhan_vien : Form
    {
        private string ma_nv;
        public frm_thong_tin_nhan_vien(string ma)
        {
            InitializeComponent();
            this.ma_nv = ma;
            Load();
        }
        public void Load()
        {
            QL_NhanVien qL_NhanVien = new QL_NhanVien();
            var nv = qL_NhanVien.return_Nhan_Vien_Ma_nv(this.ma_nv);
            txtMa_nv.Text = nv.MA_NV;
            txtTenNV.Text = nv.TEN_NV;
            txtDiaChi.Text = nv.DIA_CHI;
            txtEmail.Text = nv.EMAIL;
            lb_gioi_tinh.Text = nv.GIOI_TINH;
            lb_chuc_vu.Text = nv.CHUC_VU;
            txtSDT.Text = nv.SDT;
            txtTK.Text = nv.TAI_KHOAN;
            Txt_MK.Text = nv.MAT_KHAU;
            string nvl = Convert.ToString(nv.NGAY_VL);
            dtpk_nvl.Value = DateTime.Parse(nvl);

        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            QL_NhanVien qL_NhanVien = new QL_NhanVien();
            if(qL_NhanVien.Update_Information_Nhan_Vien(txtMa_nv.Text, txtTenNV.Text, txtDiaChi.Text, Txt_MK.Text))
            {
                MessageBox.Show("Thay Đổi Thành Công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        
        }
    }
}
