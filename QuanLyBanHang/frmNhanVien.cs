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
    public partial class frmNhanVien : Form
    {
        QL_NhanVien ql_nv;
        ValidateData validate = new ValidateData();
        public frmNhanVien()
        {
            InitializeComponent();
            ql_nv = new QL_NhanVien();
            LoadData();
        }
        public void LoadData()
        {
            txtMa_nv.Focus();
            txtMa_nv.Text = "";
            txtMa_nv.Enabled = true;
            btnHuy.Text = "Huỷ";
            txtTenNV.Text = "";
            txtEmail.Text = "";
            btnSua.Enabled = false;
            btn_Xoa.Enabled = false;
            txtSDT.Text = "";
            txtTK.Text = "";
            txtDiaChi.Text = "";
            Txt_MK.Text = "";
            rd_Nam.Checked = false;
            rd_Nu.Checked = false;
            rd_nv.Checked = false;
            txtTK.Enabled = true;
            rd_kt.Checked = false;
            rd_ql.Checked = false;
            btnTimKiem.Enabled = true;
            btn_Them.Enabled = true;
            dtpk_nvl.Value = DateTime.Parse("1/1/1900");
            ql_nv.GetListNhanVien(dataNhanVien);
        }
        public bool checked_radio()
        {
            if (!validate.check_Ma_NV(txtMa_nv.Text))
            {
                return false;
            }
            if (!validate.validate_ten_nv(txtTenNV.Text))
            {
                return false;
            }
            if (!validate.validate_dia_chi_nv(txtDiaChi.Text))
            {
                return false;
            }
            if (!validate.check_Email_NV(txtEmail.Text))
            {
                return false;
            }
            if (rd_Nam.Checked == false && rd_Nu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính !!!");
                return false;
            }
            if (!validate.check_SDT_NV(txtSDT.Text))
            {
                return false;
            }

            if (!validate.check_Tai_Khoan_NV(txtTK.Text))
            {
                return false;
            }

            if (!validate.check_Mk_NV(Txt_MK.Text))
            {
                return false;
            }
            if (rd_ql.Checked == false && rd_nv.Checked == false && rd_kt.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ !!!");
                return false;
            }
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (!checked_radio())
            {
                return;
            }
            else
            {
                /*0 : Nhân viên thường , 1; kế toán, 2: quản lý*/
                byte chucvu = 0;
                bool gt;
                gt = (rd_Nam.Checked == true) ? true : false;
                if (rd_kt.Checked == true)
                {
                    chucvu = 1;
                }
                if (rd_ql.Checked == true)
                {
                    chucvu = 2;
                }
                if(ql_nv.Insert_Nhan_Vien(txtMa_nv.Text, txtTenNV.Text, txtDiaChi.Text, txtEmail.Text, gt, txtSDT.Text, dtpk_nvl.Value, txtTK.Text, Txt_MK.Text, chucvu))
                {
                    LoadData();
                }    
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!validate.validate_ten_nv(txtTenNV.Text))
            {
                return ;
            }
            if (!validate.validate_dia_chi_nv(txtDiaChi.Text))
            {
                return ;
            }
            if (!validate.IsValidEmail(txtEmail.Text))
            {
                return ;
            }
            
            if (validate.IsPhoneNbr(txtSDT.Text))
            {
                MessageBox.Show("Số Điện Thoại Sai Định Dạng : \n   [84|0]123 456 789  ; \n   [84|0]123-456-789 ; \n   [84|0] 123.456.789 ; \n   [84|0]123456789");
                return ;
            }
            byte chucvu = 0;
            bool gt;
            gt = (rd_Nam.Checked == true) ? true : false;
            if (rd_kt.Checked == true)
            {
                chucvu = 1;
            }
            if (rd_ql.Checked == true)
            {
                chucvu = 2;
            }
            if (ql_nv.Edit_Nhan_Vien(txtMa_nv.Text, txtTenNV.Text, txtDiaChi.Text, txtEmail.Text, gt, txtSDT.Text, dtpk_nvl.Value, txtTK.Text, Txt_MK.Text, chucvu))
            {
                MessageBox.Show("Sửa Thành Công !!!");
                LoadData();
            }
            
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMa_nv.Enabled = false;
                btnHuy.Text = "Huỷ Sửa";
                btn_Them.Enabled = false;
                btnTimKiem.Enabled = false;
                txtTK.Enabled = false;
                btn_Xoa.Enabled = true;
                btnSua.Enabled = true;
                DataGridViewRow data_row = dataNhanVien.Rows[e.RowIndex];
                txtMa_nv.Text = data_row.Cells["MA_NV"].Value.ToString();
                txtTenNV.Text = data_row.Cells["TEN_NV"].Value.ToString();
                txtDiaChi.Text = data_row.Cells["DIA_CHI"].Value.ToString();
                txtEmail.Text = data_row.Cells["EMAIL"].Value.ToString();
                var gt=(data_row.Cells["GIOI_TINH"].Value.ToString() == "Nam") ? rd_Nam.Checked = true : rd_Nu.Checked = true;
                txtSDT.Text = ((data_row.Cells["SDT"].Value.ToString()).Insert(4,"-")).Insert(8,"-");
                dtpk_nvl.Value = DateTime.Parse( data_row.Cells["NGAY_VL"].Value.ToString());
                txtTK.Text = data_row.Cells["TAI_KHOAN"].Value.ToString();
                Txt_MK.Text = ql_nv.returnMatKhau(data_row.Cells["MA_NV"].Value.ToString());
                if (ql_nv.return_ChucVu(data_row.Cells["MA_NV"].Value.ToString()) == 0) { rd_nv.Checked = true; }
                else if (ql_nv.return_ChucVu(data_row.Cells["MA_NV"].Value.ToString()) == 1) { rd_kt.Checked = true; }
                else { rd_ql.Checked = true; }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Bạn Có Chăc Muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                ql_nv.DeleteNhanVien(txtMa_nv.Text);
                LoadData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string nvl = (dtpk_nvl.Value == DateTime.Parse("1/1/1900"))?"":dtpk_nvl.Value.ToString();
            if (txtSDT.Text != "")
            {
                if (!validate.IsPhoneNbr(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại chưa đúng định dạng !!!");
                    return;
                }
            }
            if (txtEmail.Text != "")
            {
                if (!validate.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email chưa đúng định dạng !!!");
                    return;
                }
            }
            string gt = "";
            if (rd_Nam.Checked) gt = "0";
            if (rd_Nu.Checked) gt = "1";
            
            string chucvu = "";
            if (rd_nv.Checked) chucvu = "0";
            if (rd_kt.Checked) chucvu = "1";
            if (rd_ql.Checked) chucvu = "2";
            btnHuy.Text = "Huỷ Tìm Kiếm";
            ql_nv.Search_Nhan_Vien(dataNhanVien , txtMa_nv.Text, txtTenNV.Text, txtDiaChi.Text, txtEmail.Text, gt, txtSDT.Text, nvl, txtTK.Text, Txt_MK.Text, chucvu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
