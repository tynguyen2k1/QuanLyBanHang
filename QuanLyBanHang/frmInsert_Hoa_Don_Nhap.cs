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
using Entity;
namespace QuanLyBanHang
{
    public partial class frmInsert_Hoa_Don_Nhap : Form
    {
        Doc_Tien doc_Tien = new Doc_Tien();
        private string manv { get; set; }
        Insert_Hoa_Don_Nhap insert_Hoa_Don_Nhap = new Insert_Hoa_Don_Nhap();
        public frmInsert_Hoa_Don_Nhap(string ma_nv)
        {
            InitializeComponent();
            this.manv = ma_nv;
            setcolumns_dataTable();
            LoadData();
        }
        DataTable dataTable;
        public void setcolumns_dataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("Ma_SP");
            dataTable.Columns.Add("Ten_SP");
            dataTable.Columns.Add("SL_Nhap");
            dataTable.Columns.Add("Gia_Nhap");
            dataTable.Columns.Add("Giam_gia");
            dataTable.Columns.Add("Tong");
        }
        public void clear_dataTable()
        {
            this.dataTable.Clear();
        }

        public bool kiem_tra_form_insert()
        {
            if (txt_Ten_SP_Nhap.Text == "")
            {
                lb_err_Ma_SP.Text = "Sản phẩm không tồn tại !!!";
                return false;
            }
            else if (number_sL_nhap.Value == 0)
            {
                lb_err_Ma_SP.Text = "";
                MessageBox.Show("Bạn Cần Nhập Số Lượng !!!");
                return false;
            }else if (numericGiaNhap.Value == 0)
            {
                lb_err_gia.Text = "Bạn cần nhập giá !!!";
                return false;
            }
            else
            {
                lb_err_gia.Text = "";
                lb_err_Ma_SP.Text = "";
                return true;
            }
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            if (dataCart.Rows[0].Cells[0].Value == null)
            {
                txtMaSP.Focus();
                MessageBox.Show( "Chưa có sản phẩm !!!");
                return;
            }
            else
            {
                QL_HOA_DON_NHAP qL_HOA_DON_NHAP = new QL_HOA_DON_NHAP();
                qL_HOA_DON_NHAP.TaoHoaDonNhap(dataTable, double.Parse(txt_tong_tien_cart.Text), this.manv);
                this.clear_dataTable();
                this.setcolumns_dataTable();
                LoadData();
                deleteform();
            }
        }

        private void txtMaSP_KeyUp(object sender, KeyEventArgs e)
        {
            string str = txtMaSP.Text;
            var sp = insert_Hoa_Don_Nhap.kiemTraTonTaiMaSP(str);
            if (sp != null)
            {
                txt_Ten_SP_Nhap.Text = sp.TEN_SP;
                lb_err_Ma_SP.Text = "";
            }
            else
            {
                txt_Ten_SP_Nhap.Text = "";
                lb_err_Ma_SP.Text = "Mã phẩm không tồn tại !!!";
            }
        }

        
        public void load_txt_tong_tien(float gia , int giam , int sl)
        {
           
           double tong = Math.Round((sl * (gia - (gia * giam) / 100)), 0);
           txtTong.Text = Convert.ToString(tong);
        }

        private void number_sL_nhap_KeyUp(object sender, KeyEventArgs e)
        {
            load_txt_tong_tien((float)numericGiaNhap.Value,(int) numericGiamGia.Value, (int)number_sL_nhap.Value);
        }

        private void number_sL_nhap_MouseDown(object sender, MouseEventArgs e)
        {
            load_txt_tong_tien((float)numericGiaNhap.Value, (int)numericGiamGia.Value, (int)number_sL_nhap.Value);
        }

        private void numericGiaNhap_MouseDown(object sender, MouseEventArgs e)
        {
            load_txt_tong_tien((float)numericGiaNhap.Value, (int)numericGiamGia.Value, (int)number_sL_nhap.Value);
        }

        private void numericGiaNhap_KeyUp(object sender, KeyEventArgs e)
        {
            load_txt_tong_tien((float)numericGiaNhap.Value, (int)numericGiamGia.Value, (int)number_sL_nhap.Value);
        }

        private void numericGiamGia_MouseDown(object sender, MouseEventArgs e)
        {
            load_txt_tong_tien((float)numericGiaNhap.Value, (int)numericGiamGia.Value, (int)number_sL_nhap.Value);
        }

        private void numericGiamGia_KeyUp(object sender, KeyEventArgs e)
        {
            load_txt_tong_tien((float)numericGiaNhap.Value, (int)numericGiamGia.Value, (int)number_sL_nhap.Value);
        }

        private void btn_them_sp_cart_Click(object sender, EventArgs e)
        {
            if (kiem_tra_form_insert() == false)
            {
                return;
            }

            else
            {
                string ma_sp = txtMaSP.Text;
                int sl = (int)number_sL_nhap.Value;
                float gia_nhap = (float)numericGiaNhap.Value;
                int giam_gia = (int)numericGiamGia.Value;
                string ten_sp = txt_Ten_SP_Nhap.Text;
                double tong_tien = double.Parse(txtTong.Text);
                if (check_isset_product(ma_sp))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (String.Compare(row["Ma_SP"].ToString().ToUpper(), ma_sp.ToUpper(), true) == 0)
                        {
                            int value = int.Parse(row["SL_Nhap"].ToString());
                            row["SL_Nhap"] = value + sl;
                            float tong_old = float.Parse(row["Tong"].ToString());
                            row["Tong"] = (tong_old + tong_tien);
                        }
                    }
                    LoadData();
                    deleteform();
                }
                else
                {
                    add(ma_sp, ten_sp, gia_nhap, giam_gia, sl, tong_tien);
                    LoadData();
                    deleteform();
                }
            }

        }
        public void deleteform()
        {
            txtTong.Text = "";
            txtMaSP.Focus();
            lb_err_Ma_SP.Text = "";
            lb_err_gia.Text = "";
            lb_err_giam_gia.Text = "";
            txtMaSP.Text = "";
            txt_Ten_SP_Nhap.Text = "";
            txtMaSP.Enabled = true;
            btn_Sua_Prod_Cart.Enabled = false;
            btn_them_sp_cart.Enabled = true;
            number_sL_nhap.Value = 0;
            numericGiamGia.Value = 0;
            numericGiaNhap.Value = 0;
            numericGiaNhap.Text = numericGiamGia.Text=number_sL_nhap.Text= "0";
        }
        public void LoadData()
        {

            deleteform();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["STT"] = i + 1;
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
                txt_doc_tien.Text = doc_Tien.DocTienBangChu(0, " VND ");
            }
            
           
        }
        public void add(string Ma_SP, string ten_sp, double gia_ban, int giam_gia, int sl_mua, double tong)
        {
            DataRow row = dataTable.NewRow();
            row["STT"] = "";
            row["Ma_SP"] = Ma_SP;
            row["Ten_SP"] = ten_sp;
            row["SL_Nhap"] = sl_mua;
            row["Gia_Nhap"] = gia_ban;
            row["Giam_gia"] = giam_gia;
            row["Tong"] = tong;
            dataTable.Rows.Add(row);
        }
        /*Hàm check sp tồn tại trong giỏ hàng hay ko */
        public bool check_isset_product(string Ma_sp)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (String.Compare(row["Ma_SP"].ToString().ToUpper(), Ma_sp.ToUpper(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huy_hoa_don_Click(object sender, EventArgs e)
        {
            deleteform();
            clear_dataTable();
            LoadData();
        }

        private void dataCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit_product_cart(e.RowIndex);
            }
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
                txt_Ten_SP_Nhap.Text = row.Cells["Ten_SP"].Value.ToString();
                numericGiaNhap.Text = row.Cells["Gia_Nhap"].Value.ToString();
                numericGiamGia.Text = row.Cells["Giam_Gia"].Value.ToString();
                number_sL_nhap.Text = row.Cells["SL_Nhap"].Value.ToString();
                txtTong.Text = row.Cells["Tong"].Value.ToString();
            }
            else
            {
                txtMaSP.Focus();
            }
        }

        private void btn_huy_product_Click(object sender, EventArgs e)
        {
            btn_huy_product.Text = "Huỷ";
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
            string ma_sp = txtMaSP.Text;
            int sl = (int)number_sL_nhap.Value;
            float gia_nhap = (float)numericGiaNhap.Value;
            int giam_gia = (int)numericGiamGia.Value;
            double tong_tien = double.Parse(txtTong.Text);
            
            if (sl == 0)
                {
                    delete_product_cart(ma_sp);
                    deleteform();
                }
            else
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if ((row["Ma_SP"].ToString()).ToUpper() == ma_sp.ToUpper())
                        {
                        row["SL_Nhap"] = sl;
                        row["Gia_Nhap"] = gia_nhap;
                        row["Giam_gia"] = giam_gia;
                        row["Tong"] = tong_tien;
                        }
                    }
                    MessageBox.Show("Sửa Thành Công !!!");
                    LoadData();
                    deleteform();
                }
            
        }
    }
}
