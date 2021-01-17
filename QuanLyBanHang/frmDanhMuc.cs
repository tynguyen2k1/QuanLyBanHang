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

        private List<DataAccess.Model.Model_Danh_Muc> ListDanhMuc { get; set; }
        private int page { set; get; }
        private bool list_dm_ton_tai_or_xoa { get; set; }
        private int loadeRecord { set; get; }
        public void setloadeRecord()
        {
            this.loadeRecord = 0;
        }
        public void setListDanhMuc()
        {
            this.ListDanhMuc.Clear();
        }
        public void loadDanhSachDanhMuc()
        {

            float pageNumber = (float)this.ListDanhMuc.Count / 10;
            this.page = (int)Math.Ceiling((double)pageNumber);
            hienThiPhanTrang();
            if (loadeRecord == -1)
            {
                lb_trang.Text = Convert.ToString(0);
            }
            else
            {
                lb_trang.Text = Convert.ToString(this.loadeRecord);
            }
            dgvDanhMuc.DataSource = load_sl_data(this.loadeRecord, 10);

        }
        public void hienThiPhanTrang()
        {
            if (this.ListDanhMuc.Count >= 2)
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }
        }

        public List<DataAccess.Model.Model_Danh_Muc> load_sl_data(int page, int sl)
        {
            List<DataAccess.Model.Model_Danh_Muc> list = new List<DataAccess.Model.Model_Danh_Muc>();
            list = this.ListDanhMuc.Skip(sl * page).Take(sl).ToList();
            return list;
        }


        public frmDanhMuc()
        {
            InitializeComponent();
            this.ListDanhMuc = new List<DataAccess.Model.Model_Danh_Muc>();
            this.list_dm_ton_tai_or_xoa = true;
            LoadDanhMucHienThi();
        }
        public void LoadDanhMucHienThi()
        {
            if (this.list_dm_ton_tai_or_xoa)
            {
                Load_Data_Ton_Tai();
                btn_xoa_list.Text = "Xoá Danh Mục Chọn";
            }
            else
            {
                Load_Data_Xoa();
                btn_xoa_list.Text = "Cập Nhập Mục Chọn";
            }
        }
        public void Load_Data_Ton_Tai()
        {
            lb_title.Text = "Danh Sách Danh Mục";
            resetForm();
            this.setListDanhMuc();
            this.ListDanhMuc = qldm.Get_List_Danh_Muc_Ton_Tai();
            this.loadDanhSachDanhMuc();
        }
        public void Load_Data_Xoa()
        {
            lb_title.Text = "Danh Sách Danh Mục ( Đã Xoá )";
            resetForm();
            this.setListDanhMuc();
            this.ListDanhMuc = qldm.Get_List_Danh_Muc_Da_Xoa();
            this.loadDanhSachDanhMuc();
        }
        public void resetForm()
        {
            txtMaDM.Text = "";
            txtMaDM.Enabled = true;
            txtMoTa.Enabled = true;
            txtTenDM.Enabled = true;
            txtMaDM.Focus();
            txtTenDM.Text = "";
            txtMoTa.Text = "";
            btn_Huy.Text = "Huỷ";
            btnSuaDM.Enabled = false;
            btnThemDM.Enabled = true;
            btnXoaDM.Enabled = false;
        }
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.list_dm_ton_tai_or_xoa)
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow row = dgvDanhMuc.Rows[index];
                    txtMaDM.Text = row.Cells[0].Value.ToString();
                    txtTenDM.Text = row.Cells[1].Value.ToString();
                    txtMoTa.Text = row.Cells[2].Value.ToString();
                    txtMaDM.Enabled = false;
                    btnThemDM.Enabled = false;
                    btnSuaDM.Enabled = true;
                    btn_Huy.Text = "Huỷ Sửa";
                    btnXoaDM.Enabled = true; 
                }
            }
            else
            {
                txtMaDM.Enabled = true;
                txtMaDM.Text = "";
                txtMaDM.Focus();
                txtTenDM.Text = "";
                txtMoTa.Text = "";
                btnThemDM.Enabled = false;
                btnSuaDM.Enabled = false;
                btnXoaDM.Enabled = false;
            }
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


        private void btnThemDM_Click_1(object sender, EventArgs e)
        {
            string str = qldm.InsertData(txtMaDM.Text, txtTenDM.Text, txtMoTa.Text);
            if (str == "")
            {
                MessageBox.Show("Chèn Thành Công");
                //Load_Data();
            }
            else
            {
                MessageBox.Show(str);
            }
        }

        private void btnSuaDM_Click_1(object sender, EventArgs e)
        {
            if (qldm.EditData(txtMaDM.Text, txtTenDM.Text, txtMoTa.Text))
            {
                MessageBox.Show("Sửa Thành Công !!!");
            }
            else
            {
                MessageBox.Show("Error !!! ");
            }
            //Load_Data();
        }

        private void btnXoaDM_Click_1(object sender, EventArgs e)
        {
            if (this.list_dm_ton_tai_or_xoa)
            {

            }
           // Load_Data();
        }

        

        private void btn_list_dm_xoa_Click(object sender, EventArgs e)
        {
            btn_list_dm_xoa.Text = "Cập Nhập Mục Chọn";
            this.list_dm_ton_tai_or_xoa = false;
            this.LoadDanhMucHienThi();
            btnThemDM.Enabled = false;
            btnSuaDM.Enabled = false;
            btnXoaDM.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord < 0)
                {
                    this.setloadeRecord();
                    loadDanhSachDanhMuc();
                }
                else
                {
                    this.loadeRecord--;
                    loadDanhSachDanhMuc();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord == this.page - 1)
                {
                    this.setloadeRecord();
                    loadDanhSachDanhMuc();
                }
                else
                {
                    this.loadeRecord++;
                    loadDanhSachDanhMuc();
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.list_dm_ton_tai_or_xoa = true;
            LoadDanhMucHienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.list_dm_ton_tai_or_xoa)
            {
                btn_Huy.Text = "Huỷ Tìm Kiếm";
                this.ListDanhMuc = qldm.Search_Danh_Muc_Ton_Tai(txtMaDM.Text,txtTenDM.Text,txtMoTa.Text);
                loadDanhSachDanhMuc();
            }
            else
            {
                btn_Huy.Text = "Huỷ Tìm Kiếm";
                this.ListDanhMuc = qldm.Search_Danh_Muc_Da_Xoa(txtMaDM.Text, txtTenDM.Text, txtMoTa.Text);
                loadDanhSachDanhMuc();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhMuc.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if ((dgvDanhMuc.Rows[e.RowIndex].Cells["TRANG_THAI"].Value.ToString()).CompareTo("Tồn Tại")==0)
                {
                    DialogResult result1 = MessageBox.Show("Cập Nhập",
                "Bạn Có Chắc Muốn Cập Nhập",
                MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (qldm.updateTrangThai(dgvDanhMuc.Rows[e.RowIndex].Cells["Ma_DM"].Value.ToString(), 1))
                        {
                            MessageBox.Show("Cập Nhập Thành Công");
                            LoadDanhMucHienThi();
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Cập Nhập");
                        }
                    }
                }
                else
                {
                    DialogResult result1 = MessageBox.Show("Cập Nhập",
                "Bạn Có Chắc Muốn Cập Nhập",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        if (qldm.updateTrangThai(dgvDanhMuc.Rows[e.RowIndex].Cells["Ma_DM"].Value.ToString(), 0))
                        {
                            MessageBox.Show("Cập Nhập Thành Công");
                            LoadDanhMucHienThi();
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Cập Nhập");
                        }
                    }
                }
            }
        }

        private void btn_chon_all_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                {
                    row.Selected = true;
                }
            }
        }

        private void btn_xoa_list_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.SelectedRows.Count > 0)
            {
                string message = (this.list_dm_ton_tai_or_xoa)?"Bạn có chắc muốn xoá  [ " + dgvDanhMuc.SelectedRows.Count + " ] hoá đơn đã chọn": "Bạn có chắc muốn cập nhập " + dgvDanhMuc.SelectedRows.Count + " ] hoá đơn đã chọn";

                string title = (this.list_dm_ton_tai_or_xoa)? "Delete Hoá Đơn" : "Cập Nhập Hoá Đơn";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {  
                        bool kiemtra = false;
                        foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                        {
                        if (this.list_dm_ton_tai_or_xoa)
                        {
                            if (row.Selected == true)
                            {
                                kiemtra = qldm.updateTrangThai(row.Cells["Ma_DM"].Value.ToString(), 1);
                            }
                        }
                        else
                        {
                            if (row.Selected == true)
                            {
                                kiemtra = qldm.updateTrangThai(row.Cells["Ma_DM"].Value.ToString(), 0);
                            }
                        }
                            
                        }
                        if (kiemtra)
                        {
                            MessageBox.Show("Cập Nhập thành công !!!");
                            LoadDanhMucHienThi();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá !!!");
                        }
                }
            }
            else
            {
                MessageBox.Show((this.list_dm_ton_tai_or_xoa)? "Bạn Cần Chọn Dòng Muốn Xoá" : "Bạn Cần Chọn Dòng Muốn Cập Nhập");
            }
        }

        private void btnSapXepDM_Click(object sender, EventArgs e)
        {

        }
    }
}
