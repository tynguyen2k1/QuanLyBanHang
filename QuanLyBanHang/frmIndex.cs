using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Entity;
namespace QuanLyBanHang
{
    public partial class frmIndex : Form
    {
        

        NHAN_VIEN taiKhoan;
        EntityNhanVien nhanVien = new EntityNhanVien();

        Database_acsset database = new Database_acsset();
        DataTable dataTable;
        Doc_Tien doc_Tien = new Doc_Tien();
        Index DataAccessIndex = new Index();

        public void setcolumns_dataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("Ma_SP");
            dataTable.Columns.Add("Ten_SP");
            dataTable.Columns.Add("SL_Mua");
            dataTable.Columns.Add("Gia_Ban");
            dataTable.Columns.Add("Giam_gia");
            dataTable.Columns.Add("Tong");
        }
        public void clear_dataTable()
        {
            this.dataTable.Clear();
           
        }
        
        public frmIndex()
        {
            InitializeComponent();
            setcolumns_dataTable();
            deleteform();
            LoadData();
        }
        public frmIndex(NHAN_VIEN nv)
        {
            this.taiKhoan = nv;
            InitializeComponent();
            setcolumns_dataTable();
            deleteform();
            LoadData();
        }
        public void LoadData()
        {

            btn_Sua_Prod_Cart.Enabled = false;
            for(int i  = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["STT"] = i+1;
            }
            dataCart.DataSource = dataTable;
            
            if (dataTable.Rows.Count > 0)
            {
                double tong = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    tong += float.Parse(row["Tong"].ToString());

                }
                txt_tong_tien_cart.Text = tong.ToString();
                txt_doc_tien.Text = doc_Tien.DocTienBangChu(tong, " VND ");
            }
            else
            {
                txt_tong_tien_cart.Text = "0";
                txt_doc_tien.Text = doc_Tien.DocTienBangChu(0 , " VND ");
            }
            txtMaSP.Focus();
        }
        public void add(string Ma_SP, string ten_sp , double gia_ban , int giam_gia , int sl_mua , double tong)
        {
            DataRow row = dataTable.NewRow();
            row["STT"] = "";
            row["Ma_SP"] = Ma_SP;
            row["Ten_SP"] = ten_sp;
            row["SL_Mua"] = sl_mua;
            row["Gia_Ban"]= gia_ban;
            row["Giam_gia"] = giam_gia;
            row["Tong"] = tong;
            dataTable.Rows.Add(row);
        }

        public int check_sl_sp_trong_kho(string str)
        {
            if (DataAccessIndex.returnSl_SP(str) >= 0)
            {
                return DataAccessIndex.returnSl_SP(str);
            }
            return -1;
        }
        private void btn_them_sp_cart_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txt_Ten_SP_Mua.Text == "")
            {
                MessageBox.Show("Bạn Cần Nhập Mã Sản Phẩm");
            } else if (number_sL_mua.Text == "" || number_sL_mua.Text == "0") 
            {
                MessageBox.Show("Bạn Cần Nhập Số Lượng Mua");
            }
            else 
            {
                string Ma_sp = txtMaSP.Text;
                string Ten_sp = txt_Ten_SP_Mua.Text;
                int sl_Mua = Convert.ToInt32(number_sL_mua.Text);
                int giam_gia = Convert.ToInt32(txtGiamGiaMua.Text);
                double gia_ban = double.Parse(txtGia_Ban_Mua.Text);
                double tong = double.Parse(txtTong.Text);
                if (check_isset_product(Ma_sp))
                {
                    foreach(DataRow row in dataTable.Rows)
                    {
                        if (String.Compare(row["Ma_SP"].ToString().ToUpper(), Ma_sp.ToUpper(), true) == 0)
                        {
                            int value = int.Parse(row["SL_Mua"].ToString());
                            row["SL_Mua"] = value + sl_Mua;
                            float tong_old = float.Parse(row["Tong"].ToString());
                            row["Tong"] = (tong_old + tong);
                        }
                    }
                    LoadData();
                    txtMaSP.Text = "";
                    deleteform();
                }
                else
                {
                    add(Ma_sp, Ten_sp, gia_ban, giam_gia, sl_Mua, tong);
                    LoadData();
                    txtMaSP.Text = "";
                    deleteform();
                }
            }
        }

        

        private void txtProductID_KeyUp(object sender, KeyEventArgs e)
        {
            string str = txtMaSP.Text;
            SAN_PHAM sp = DataAccessIndex.kiemTraTonTaiMaSP(str);
            if (sp != null)
            {
                txt_Ten_SP_Mua.Text = sp.TEN_SP;
                txtGia_Ban_Mua.Text = sp.GIA_BAN.ToString();
                txtGiamGiaMua.Text = sp.GIAM_GIA.ToString();
                if (check_sl_sp_trong_kho(sp.MA_SP) <= 10)
                {
                    txtErrSL.Text = "Số sản phẩm lượng còn  : "+check_sl_sp_trong_kho(sp.MA_SP);
                }
                else
                {
                    txtErrSL.Text = "";
                }
            }
            else
            {
                deleteform();
            }
            
        }

        private void quảnLýDanhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmdanhmuc = new frmDanhMuc();
            this.Hide();
            frmdanhmuc.ShowDialog();
            this.Show();
        }

        private void quảnLýDanhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_san_pham frmSanPham = new frm_san_pham();
            this.Hide();
            frmSanPham.ShowDialog();
            this.Show();
        }

        private void quảnLýHoáĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoaDon frmhoaDon = new frmHoaDon();
            this.Hide();
            frmhoaDon.ShowDialog();
            this.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhach = new frmKhachHang();
            this.Hide();
            frmKhach.ShowDialog();
            this.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNv = new frmNhanVien();
            this.Hide();
            frmNv.ShowDialog();
            this.Show();
        }
        public void deleteform()
        {
            txtMaSP.Enabled = true;
            number_sL_mua.Text = "0";
            txtTong.Text = "";
            txtGiamGiaMua.Text = "";
            txtGia_Ban_Mua.Text = "";
            txt_Ten_SP_Mua.Text = "";
            btn_huy_product.Text = "Huỷ";
            btn_them_sp_cart.Enabled = true;
            btn_Sua_Prod_Cart.Enabled = false;
        }

        private void number_sL_mua_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Ten_SP_Mua.Text != "")
            {
                bool a = int.TryParse(number_sL_mua.Text, out int value);
                int sl_con = check_sl_sp_trong_kho(txtMaSP.Text);
                bool_thay_doi_sl_mua(a, value, sl_con);
            }
        }
        public void bool_thay_doi_sl_mua(bool a , int value,int sl_con)
        {
            if (a)
            {
                if (sl_con < value)
                {
                    txtErrSL.Text = "Số lượng sản phẩm còn : " + sl_con;
                    btn_them_sp_cart.Enabled = false;
                    
                }
                else
                {
                    txtErrSL.Text = "";
                    btn_them_sp_cart.Enabled = true;
                    
                    }
                float gia_ban = float.Parse(txtGia_Ban_Mua.Text);
                int giam_gia = int.Parse(txtGiamGiaMua.Text);
                double tong = Math.Round((value * (gia_ban - (gia_ban * giam_gia) / 100)),0);
                txtTong.Text = Convert.ToString(tong);
            }
            else
            {
                txtTong.Text = Convert.ToString(0);
            }
        }
        private void number_sL_mua_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (txt_Ten_SP_Mua.Text != "")
            {
                bool a = int.TryParse(number_sL_mua.Text, out int value);
                int sl_con = check_sl_sp_trong_kho(txtMaSP.Text);
                bool_thay_doi_sl_mua(a, value, sl_con);
            }
        }

        /*Hàm check sp tồn tại trong giỏ hàng hay ko */
        public bool check_isset_product( string Ma_sp)
        {
            foreach(DataRow row in dataTable.Rows)
            {
                if(String.Compare(row["Ma_SP"].ToString().ToUpper(), Ma_sp.ToUpper(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void edit_product_cart(int index)
        {
            DataGridViewRow row = this.dataCart.Rows[index];
            //Đưa dữ liệu vào textbox

            if (row.Cells["Ma_SP"].Value.ToString() != "")
            {

                btn_them_sp_cart.Enabled = false;
                btn_huy_product.Text = "Huỷ Sửa";
                btn_Sua_Prod_Cart.Enabled = true;
                txtMaSP.Text = row.Cells["Ma_SP"].Value.ToString();
                txtMaSP.Enabled = false;
                txt_Ten_SP_Mua.Text = row.Cells["Ten_SP"].Value.ToString();
                txtGia_Ban_Mua.Text = row.Cells["Gia_Ban"].Value.ToString();
                txtGiamGiaMua.Text = row.Cells["Giam_Gia"].Value.ToString();
                number_sL_mua.Text = row.Cells["SL_Mua"].Value.ToString();
                txtTong.Text = row.Cells["Tong"].Value.ToString();
            }
            else
            {
                txtMaSP.Focus();
            }
        }
        

        private void btn_huy_product_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            btn_huy_product.Text = "Huỷ";
            btn_them_sp_cart.Enabled = true;
            txtMaSP.Enabled = true;
            btn_Sua_Prod_Cart.Enabled = false;
            deleteform();
        }
        public void delete_product_cart(string Ma_Sp)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow[] advRow = dataTable.Select("Ma_SP='" + Ma_Sp + "'");
                for (int i = advRow.Length - 1; i >= 0; i--)
                {
                    dataTable.Rows.Remove(advRow[i]);
                }
            }
        }
        private void btn_Sua_Prod_Cart_Click(object sender, EventArgs e)
        {
            int sl_mua = int.Parse(number_sL_mua.Text);
            string Ma_sp = txtMaSP.Text;
            if (sl_mua > check_sl_sp_trong_kho(Ma_sp))
            {
                txtErrSL.Text = "Error !!! Số lượng còn : " + check_sl_sp_trong_kho(Ma_sp);
            }
            else
            {
                if (sl_mua == 0)
                {
                    delete_product_cart(Ma_sp);
                    deleteform();
                }
                else
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if ((row["Ma_SP"].ToString()).ToUpper() == Ma_sp.ToUpper())
                        {
                            row["SL_Mua"] = number_sL_mua.Text;
                            row["Tong"] = txtTong.Text;
                        }
                    }
                    MessageBox.Show("Sửa Thành Công !!!");
                    LoadData();
                    txtMaSP.Text = "";
                    deleteform();
                    txtMaSP.Focus();
                }
            }
        }

        private void dataCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                edit_product_cart(e.RowIndex);
            }
        }

        private void dataCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string a = dataCart.Rows[e.RowIndex].Cells["Ma_SP"].Value.ToString();
                if (a != "")
                {
                    string message = "Bạn Có Muốn Xoá Sản Phẩm Này !!!";
                    string title = "Delete Product Cart";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        delete_product_cart(a);
                        MessageBox.Show("Xoá Thành Công !!!");
                        deleteform();
                        LoadData();
                        txtMaSP.Text = "";
                        txtMaSP.Focus();
                    }
                }
            }
        }
        public void deleteformkhachhang()
        {
            txt_sdt_kh.Text = "";
            txt_dia_chi.Text = "";
            txt_ten_kh.Text = "";
            dtpk_ngay_sinh.Value = DateTime.Now;
            rd_Nam.Checked = true;
        }
        private void txt_sdt_kh_TextChanged(object sender, EventArgs e)
        {
            ValidateData validate = new ValidateData();
            if (validate.IsPhoneNbr(txt_sdt_kh.Text))
            {
                lbErrPhone.Text = "";
                QL_KhachHang qL_Khach = new QL_KhachHang();
               
                if(qL_Khach.GetSanPham(txt_sdt_kh.Text) != null)
                {
                    KHACH_HANG kh = qL_Khach.GetSanPham(txt_sdt_kh.Text);
                    txt_ten_kh.Text = kh.TEN_KH;
                    dtpk_ngay_sinh.Value = kh.NGAY_SINH;
                    txt_dia_chi.Text = kh.DIA_CHI;
                    var a = (kh.GIOI_TINH.Value == true) ?rd_Nam.Checked=true: rd_Nu.Checked=true;
                }
            }
            else
            {
                lbErrPhone.Text = "Error : Số điện thoai chưa đúng đinh dạng";
            }
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            string err = CheckNULLThanhToan();
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
            else
            {
                bool kiemtra = (rd_Nam.Checked==true) ? true: false;
                KHACH_HANG kh = new KHACH_HANG(txt_ten_kh.Text , txt_sdt_kh.Text,txt_dia_chi.Text,kiemtra , dtpk_ngay_sinh.Value);
                QL_HoaDon qL_Khach = new QL_HoaDon();
                bool check = qL_Khach.TaoHoaDon(dataTable,kh,double.Parse(txt_tong_tien_cart.Text));
                if (check)
                {
                    MessageBox.Show("Tạo Thành Công !!!");

                    clear_dataTable();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error : Không Thể Tạo Hoá Đơn !!! ");
                }
            }
            
        }
        public string CheckNULLThanhToan()
        {
            ValidateData validate = new ValidateData();
            if(dataCart.Rows[0].Cells[0].Value == null)
            {
                txtMaSP.Focus();
                return "Chưa có sản phẩm !!!";

            }
            if (!validate.IsPhoneNbr(txt_sdt_kh.Text))
            {
                return "Error : Số điện thoai chưa đúng đinh dạng";
            }
            if (validate.validate_ten_kh(txt_ten_kh.Text) != ""){
                txt_ten_kh.Focus();
                return validate.validate_ten_kh(txt_ten_kh.Text);
            }
            if (validate.validate_ngay_sinh(dtpk_ngay_sinh.Value) != "")
            {
                dtpk_ngay_sinh.Focus();
                return validate.validate_ngay_sinh(dtpk_ngay_sinh.Value);
            }
            if (validate.validate_dia_chi_kh(txt_dia_chi.Text) != "")
            {
                txt_dia_chi.Focus();
                return validate.validate_dia_chi_kh(txt_dia_chi.Text);
            }
            return "";
        }
    }
}
