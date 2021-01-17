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

        bool Check_quyen { get; set; }

        private List<DataAccess.Model.Model_San_Pham> ListSanPham { get; set; }
        private int page { set; get; }
        private bool list_dm_ton_tai_or_xoa { get; set; }
        private int loadeRecord { set; get; }
        public void setloadeRecord()
        {
            this.loadeRecord = 0;
        }
        public void setListSanPham()
        {
            this.ListSanPham.Clear();
        }
        public void loadDanhSachSanPham()
        {

            float pageNumber = (float)this.ListSanPham.Count / 13;
            this.page = (int)Math.Ceiling((double)pageNumber);
            hienThiPhanTrang();
            /*if (loadeRecord == -1)
            {
                lb_trang.Text = Convert.ToString(0);
            }
            else
            {
                lb_trang.Text = Convert.ToString(this.loadeRecord);
            }*/
            dataSanPham.DataSource = load_sl_data(this.loadeRecord, 13);

        }
        public void hienThiPhanTrang()
        {
            if (this.ListSanPham.Count >= 2)
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

        public List<DataAccess.Model.Model_San_Pham> load_sl_data(int page, int sl)
        {
            List<DataAccess.Model.Model_San_Pham> list = new List<DataAccess.Model.Model_San_Pham>();
            list = this.ListSanPham.Skip(sl * page).Take(sl).ToList();
            return list;
        }


        public frm_san_pham(int val)
        {
            this.Check_quyen = (val == 0) ? false : true;
            ListSanPham = new List<DataAccess.Model.Model_San_Pham>();
            InitializeComponent();
            Load_Data();
            QLSP.LoadComboboxMa_DM(cbMa_DM);
        }
        
        public void Load_Data()
        {
            load_form();
            this.setListSanPham();
            this.ListSanPham = QLSP.GetListNhanVien();
            loadDanhSachSanPham();
        }

        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
                if (index >= 0)
                {
                    DataGridViewRow row = dataSanPham.Rows[index];
                    txtMaSP.Text = row.Cells[0].Value.ToString();
                    txtTenSP.Text = row.Cells[1].Value.ToString();
                    txtGiaNhap.Text = row.Cells[2].Value.ToString();
                    txtGiaBan.Text = row.Cells[3].Value.ToString();
                    txtSL.Text = row.Cells[4].Value.ToString();
                    txtGiamGia.Text = row.Cells[5].Value.ToString();
                    txtMoTa.Text = (row.Cells[6].Value.ToString() != null) ? row.Cells[6].Value.ToString() : "";
                    /*MessageBox.Show( row.Cells[7].Value.ToString());*/
                    cbMa_DM.SelectedValue = row.Cells[7].Value.ToString();

                    if (this.Check_quyen)
                    {
                        btnSuaSP.Enabled = true;
                        btnXoaSP.Enabled = true;
                        txtMaSP.Enabled = false;
                        btnThemSP.Enabled = false;
                    }
                    else
                    {
                        btnSuaSP.Enabled = false;
                        btnXoaSP.Enabled = false;
                        txtMaSP.Enabled = true;
                        btnThemSP.Enabled = false;
                    }
                    btnHuySP.Text =(this.Check_quyen) ? "Huỷ Sửa":"Huỷ";
                }
                
            
        }
        private void load_form()
        {
            txtMaSP.Enabled = true;
            txtMaSP.Text = "";
            txtMoTa.Text = "";
            txtTenSP.Text = "";
            txtGiamGia.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtSL.Text = "";
            QLSP.LoadComboboxMa_DM(cbMa_DM);
            if (this.Check_quyen)
            {
                btnThemSP.Enabled = true;
                btnSuaSP.Enabled = false;
                btnXoaSP.Enabled = false;
            }
            else
            {
                btnThemSP.Enabled = false;
                btnSuaSP.Enabled = false;
                btnXoaSP.Enabled = false;
            }
            btnHuySP.Text = "Huỷ";

        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string gianhap = txtGiaNhap.Text;
            string giaban = txtGiaBan.Text;
            string giamgia = txtGiamGia.Text;
            string sl = txtSL.Text;
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
            string gianhap = txtGiaNhap.Text;
            string giaban = txtGiaBan.Text;
            string giamgia = txtGiamGia.Text;
            string sl = txtSL.Text;
            string mo_ta = txtMoTa.Text;
            string ma_dm = cbMa_DM.SelectedValue.ToString();
            if (cbMa_DM.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn danh mục");
                return;
            }
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
            if (this.Check_quyen)
            {
                string message = "Bạn Có Chắc Muốn Xoá Mã Sản Phẩm : "+txtMaSP.Text;
                string title = "Xoá Sản Phẩm";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons , MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
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
            else
            {
                MessageBox.Show("Bạn Không Có Quyền !!!");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord < 0)
                {
                    this.setloadeRecord();
                    loadDanhSachSanPham();
                }
                else
                {
                    this.loadeRecord--;
                    loadDanhSachSanPham();
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
                    loadDanhSachSanPham();
                }
                else
                {
                    this.loadeRecord++;
                    loadDanhSachSanPham();
                }
            }
        }

        private void btnSapXepSP_Click(object sender, EventArgs e)
        {
            if (this.ListSanPham.Count > 0)
            {
                for(int i = 0; i < this.ListSanPham.Count-1; i++)
                {
                    for (int j = i+1; j < this.ListSanPham.Count; j++)
                    {
                        if (String.Compare(this.ListSanPham[i].MA_SP, this.ListSanPham[j].MA_SP, false) < 0)
                        {
                            var nv = this.ListSanPham[i];
                            this.ListSanPham[i] = this.ListSanPham[j];
                            this.ListSanPham[j] = nv;
                        }
                    }
                }
            }
            this.setloadeRecord();
            loadDanhSachSanPham();
            btnHuySP.Text = "Huỷ Sắp Xếp";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuySP.Text = "Huỷ Tìm Kiếm";
            ValidateData Validate = new ValidateData();
            if (Validate.validate_number_sl(txtSL.Text.Replace(" ","")) != "" && txtSL.Text!="")
            {
                MessageBox.Show(Validate.validate_number_sl(txtSL.Text.Replace(" ", "")));
                return;
            }
            if (Validate.validate_number_gia(txtGiaNhap.Text.Replace(" ", "")) != "" && txtGiaNhap.Text != "")
            {
                MessageBox.Show(Validate.validate_number_gia(txtGiaNhap.Text.Replace(" ", "")));
                return;
            }
            if (Validate.validate_number_gia(txtGiaBan.Text.Replace(" ", "")) != "" && txtGiaBan.Text != "")
            {
                MessageBox.Show(Validate.validate_number_gia(txtGiaBan.Text.Replace(" ", "")));
                return;
            }

            if (Validate.validate_giam_gia(txtGiamGia.Text.Replace(" ", "")) != "" && txtGiamGia.Text != "")
            {
                MessageBox.Show(Validate.validate_number_gia(txtGiamGia.Text.Replace(" ", "")));
                return;
            }
            this.ListSanPham = QLSP.Search_List_San_Pham(txtMaSP.Text, txtTenSP.Text, cbMa_DM.SelectedValue.ToString().Trim(), 
                txtMoTa.Text, txtSL.Text.Replace(" ", ""), txtGiaBan.Text.Replace(" ", ""), txtGiaNhap.Text.Replace(" ", ""),
                txtGiamGia.Text.Replace(" ", ""));
            this.setloadeRecord();
            this.loadDanhSachSanPham();
            
        }
    }
}
