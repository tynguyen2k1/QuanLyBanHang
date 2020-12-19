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
    public partial class frm_san_pham : Form
    {
        QL_SanPham QLSP = new QL_SanPham();
        public frm_san_pham()
        {
            
            InitializeComponent();
            Load_Data();
            QLSP.LoadComboboxMa_DM(cbMa_DM);
        }

        public void Load_Data()
        {
            load_form();
            QLSP.HienThi(dataSanPham);
        }

        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataSanPham.Rows[index];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                numericGiaNhap.Text = row.Cells[2].Value.ToString();
                numericGiaBan.Text = row.Cells[3].Value.ToString();
                numericSL.Text = row.Cells[4].Value.ToString();
                numericGiamGia.Text = row.Cells[5].Value.ToString();
                txtMoTa.Text = (row.Cells[6].Value.ToString() != null) ? row.Cells[6].Value.ToString() : "";
                /*MessageBox.Show( row.Cells[7].Value.ToString());*/
                cbMa_DM.SelectedValue = row.Cells[7].Value.ToString();
                btnSuaSP.Enabled = true;
                btnXoaSP.Enabled = true;
                txtMaSP.Enabled = false;
                btnThemSP.Enabled = false;
                btnHuySP.Text = "Huỷ Sửa";
            }
        }
        private void load_form()
        {
            txtMaSP.Enabled = true;
            txtMaSP.Text = "";
            txtMoTa.Text = "";
            txtTenSP.Text = "";
            numericGiaBan.Value = 0;
            numericGiamGia.Value = 0;
            numericSL.Value = 0;
            numericGiaNhap.Value = 0;
            QLSP.LoadComboboxMa_DM(cbMa_DM);
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
            btnHuySP.Text = "Huỷ";

        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string gianhap = numericGiaNhap.Text;
            string giaban = numericGiaBan.Text;
            string giamgia = numericGiamGia.Text;
            string sl = numericSL.Text;
            string mo_ta = txtMoTa.Text;
            string ma_dm = cbMa_DM.SelectedValue.ToString();

            string str = QLSP.UpdateSP(masp, tensp, gianhap, giaban, giamgia, sl, mo_ta, ma_dm);
            if (str == "")
            {
                MessageBox.Show("Sửa Thành Công !!!");
                Load_Data();
                load_form();
            }
            else
            {
                MessageBox.Show(str);
            }

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string gianhap = numericGiaNhap.Text;
            string giaban = numericGiaBan.Text;
            string giamgia = numericGiamGia.Text;
            string sl = numericSL.Text;
            string mo_ta = txtMoTa.Text;
            string ma_dm = cbMa_DM.SelectedValue.ToString();

            string str = QLSP.InsertSP(masp, tensp, gianhap, giaban, giamgia, sl, mo_ta, ma_dm);
            if (str == "")
            {
                MessageBox.Show("Thêm Thành Công !!!");
                Load_Data();
                load_form();
            }
            else
            {
                MessageBox.Show(str);
            }
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            load_form();
            Load_Data();
            txtMaSP.Focus() ;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (QLSP.DeleteSP(txtMaSP.Text))
            {
                MessageBox.Show("Xoá Thành Công Sản Phẩm");
                Load_Data();
                load_form();
            }
            else
            {
                MessageBox.Show("Không Thể Xoá Sản Phẩm");
            }
        }
    }
}
