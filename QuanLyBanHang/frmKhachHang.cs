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
    public partial class frmKhachHang : Form
    {
        QL_KhachHang qL_KhachHang = new QL_KhachHang();
        ValidateData validate = new ValidateData();
        public frmKhachHang()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            qL_KhachHang.loadFormGridView(dataKhachHang);
            txt_Ma_KH.Enabled = false;
            txt_Ma_KH.Text = "";
            btnThem.Enabled = true;
            btn_Edit.Enabled = false;
            btnXoa.Enabled = false;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            rd_nam.Checked = true;
            txtTenkh.Text = "";
            txt_search_dia_chi.Text = "";
            txt_search_sdt.Text = "";
            txt_search_ten.Text = "";
            Ma_Kh_search.Value = 0;
            dtpk_ngay_sinh.Value = DateTime.Parse("1/1/2010");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validate.validate_ten_kh(txtTenkh.Text) != "")
            {
                MessageBox.Show(validate.validate_ten_kh(txtTenkh.Text));
                return;
            }
            else if (validate.validate_ngay_sinh(dtpk_ngay_sinh.Value) != "") {
                MessageBox.Show(validate.validate_ngay_sinh(dtpk_ngay_sinh.Value));
                return;
            }
            else if (!validate.IsPhoneNbr(txtSDT.Text))
            {
                MessageBox.Show("Số Điện Thoại Sai Định Dạng : \n   [84|0]123 456 789  ; \n   [84|0]123-456-789 ; \n   [84|0] 123.456.789 ; \n   [84|0]123456789");
                return;
            }
            else if (validate.validate_dia_chi_kh(txtDiaChi.Text) != "")
            {
                MessageBox.Show(validate.validate_dia_chi_kh(txtDiaChi.Text));
                return;
            }
            else
            {
                bool gt = (rd_nam.Checked == true) ? false : true ;
                qL_KhachHang.insertKhachHang(txtTenkh.Text, txtDiaChi.Text, txtSDT.Text, gt, dtpk_ngay_sinh.Value);
                Load();
            }
        }

        

        private void dataKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow data = dataKhachHang.Rows[e.RowIndex];
                txt_Ma_KH.Text = data.Cells["MA_KH"].Value.ToString();
                txt_Ma_KH.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btn_Edit.Enabled = true;
                txtTenkh.Text = data.Cells["TEN_KH"].Value.ToString();
                txtSDT.Text = (data.Cells["SDT"].Value.ToString()).Trim();
                dtpk_ngay_sinh.Value = DateTime.Parse(data.Cells["Ngay_Sinh"].Value.ToString());
                txtDiaChi.Text = data.Cells["Dia_Chi"].Value.ToString();
                if (data.Cells["Gioi_Tinh"].Value.ToString() == "Nam")
                {
                    rd_nam.Checked = true;
                }
                else
                {
                    rd_nu.Checked = true;
                }
                btnHuy.Text = "Huỷ Sửa";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (validate.validate_ten_kh(txtTenkh.Text) != "")
            {
                MessageBox.Show(validate.validate_ten_kh(txtTenkh.Text));
                return;
            }
            else if (validate.validate_ngay_sinh(dtpk_ngay_sinh.Value) != "")
            {
                MessageBox.Show(validate.validate_ngay_sinh(dtpk_ngay_sinh.Value));
                return;
            }
            else if (!validate.IsPhoneNbr(txtSDT.Text))
            {
                MessageBox.Show("Số Điện Thoại Sai Định Dạng : \n   [84|0]123 456 789  ; \n   [84|0]123-456-789 ; \n   [84|0] 123.456.789 ; \n   [84|0]123456789"); 
                return;
            }
            else if (validate.validate_dia_chi_kh(txtDiaChi.Text) != "")
            {
                MessageBox.Show(validate.validate_dia_chi_kh(txtDiaChi.Text));
                return;
            }
            bool gt = (rd_nam.Checked == true) ? false : true;

            if (qL_KhachHang.UpdateKhachHang(txt_Ma_KH.Text, txtTenkh.Text, dtpk_ngay_sinh.Value, txtSDT.Text, txtDiaChi.Text, gt))
            {
                Load();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Text = "Huỷ";
            Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string message = "Bạn Có Muốn Xoá Sản Phẩm Này !!!";
            string title = "Delete Product Cart";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if(txt_Ma_KH.Text != "")
                {
                    if (qL_KhachHang.DeleteKhachHang(int.Parse(txt_Ma_KH.Text)))
                    {
                        MessageBox.Show("Xoá thành công khách hàng !!!");
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Error : Không thể xoá khách hàng này !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Error !!!");
                }
            }
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            qL_KhachHang.GetListSearch(dataKhachHang , ((Ma_Kh_search.Value) == 0)?"" : Ma_Kh_search.Value.ToString(), txt_search_ten.Text , txt_search_sdt.Text , txt_search_dia_chi.Text);
            btnHuy.Text = "Huỷ tìm kiếm";
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
