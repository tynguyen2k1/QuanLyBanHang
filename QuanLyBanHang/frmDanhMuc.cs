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
    public partial class frmDanhMuc : Form
    {
        QL_DanhMuc qldm = new QL_DanhMuc();
        public frmDanhMuc()
        {
            InitializeComponent();
            Load_Data();
        }
        public void Load_Data()
        {
            qldm.Hien_Thi(dgvDanhMuc);
            txtMaDM.Text = "";
            txtMaDM.Enabled = true;
            txtTenDM.Text = "";
            txtMoTa.Text = "";
            btnHuyDM.Text = "Huỷ";
            btnSuaDM.Enabled = false;
            btnThemDM.Enabled = true;
            btnXoaDM.Enabled = false;

        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            qldm.InsertData(txtMaDM.Text,txtTenDM.Text,txtMoTa.Text);
            Load_Data();
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            if (qldm.EditData(txtMaDM.Text , txtTenDM.Text ,txtMoTa.Text))
            {
                MessageBox.Show("Sửa Thành Công !!!");
            }
            else
            {
                MessageBox.Show("Error !!! ");
            }
            Load_Data();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                DataGridViewRow row = dgvDanhMuc.Rows[index];
                txtMaDM.Text = row.Cells[0].Value.ToString();
                txtTenDM.Text = row.Cells[1].Value.ToString();
                txtMoTa.Text = row.Cells[2].Value.ToString();
                txtMaDM.Enabled = false;
                btnThemDM.Enabled = false;
                btnSuaDM.Enabled = true;
                btnHuyDM.Text = "Huỷ Sửa";
                btnXoaDM.Enabled = true;
            }
        }

        private void btnHuyDM_Click(object sender, EventArgs e)
        {
            txtMaDM.Text = "";
            txtMaDM.Enabled = true;
            txtTenDM.Text = "";
            txtMoTa.Text = "";
            btnHuyDM.Text = "Huỷ";
            btnSuaDM.Enabled = false;
            btnThemDM.Enabled = true;
            btnXoaDM.Enabled = false;
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (qldm.DeleteData(txtMaDM.Text))
            {
                MessageBox.Show("Delete Thành Công !!!");
            }
            else
            {
                MessageBox.Show("Error !!! ");
            }
            Load_Data();
        }

        private void dgvDanhMuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                string str = "";
                foreach(DataGridViewRow a in dgvDanhMuc.SelectedRows)
                {
                    str += a.Cells[0].Value.ToString() + "  => ";
                }
                MessageBox.Show(str);
            }
        }

        private void btnTimKiemDM_Click(object sender, EventArgs e)
        {

        }
    }
}
