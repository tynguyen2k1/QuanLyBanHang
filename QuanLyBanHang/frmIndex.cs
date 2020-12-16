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

namespace QuanLyBanHang
{
    public partial class frmIndex : Form
    {
        Database_acsset database = new Database_acsset();
        DataTable dataTable;
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
        public void LoadData()
        {
            btn_Sua_Prod_Cart.Enabled = false;
            for(int i  = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["STT"] = i+1;
            }
            dataCart.DataSource = dataTable;
        }
        public void add(string Ma_SP, string ten_sp , float gia_ban , int giam_gia , int sl_mua , float tong)
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
                float gia_ban = float.Parse(txtGia_Ban_Mua.Text);
                float tong = float.Parse(txtTong.Text);
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
            string sql = "Select * from SAN_PHAM WHERE MA_SP = '"+str+"';";
            DataTable data = database.CheckData(sql);
            if (data != null)
            {
                foreach(DataRow rows in data.Rows)
                {
                    txt_Ten_SP_Mua.Text = rows["Ten_SP"].ToString();
                    txtGiamGiaMua.Text = rows["GIAM_GIA"].ToString();
                    txtGia_Ban_Mua.Text = rows["GIA_BAN"].ToString();
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
            number_sL_mua.Text = "0";
            txtTong.Text = "";
            txtGiamGiaMua.Text = "";
            txtGia_Ban_Mua.Text = "";
            txt_Ten_SP_Mua.Text = "";
        }

        private void number_sL_mua_MouseDown(object sender, MouseEventArgs e)
        {
            if(txt_Ten_SP_Mua.Text != "")
            {
                int a = int.Parse(number_sL_mua.Text);
                txtTong.Text = Convert.ToString(a);
            }
        }

        private void number_sL_mua_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Ten_SP_Mua.Text != "")
            {
                bool a = int.TryParse(number_sL_mua.Text, out int value);
                if (a)
                {
                    float gia_ban = float.Parse(txtGia_Ban_Mua.Text);
                    int giam_gia = int.Parse(txtGiamGiaMua.Text);
                    double tong = Math.Round(value * (gia_ban - (gia_ban * giam_gia) / 100));
                    txtTong.Text = Convert.ToString(tong);
                }
                else
                {
                    txtTong.Text = Convert.ToString(0);
                }
            }
        }

        private void number_sL_mua_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (txt_Ten_SP_Mua.Text != "")
            {
                bool a = int.TryParse(number_sL_mua.Text, out int value);
                if (a)
                {
                    float gia_ban = float.Parse(txtGia_Ban_Mua.Text);
                    int giam_gia = int.Parse(txtGiamGiaMua.Text);
                    double tong = Math.Round(value * (gia_ban - (gia_ban * giam_gia) / 100));
                    txtTong.Text = Convert.ToString(tong);
                }
                else
                {
                    txtTong.Text = Convert.ToString(0);
                }
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
            
            txtMaSP.Text = row.Cells["Ma_SP"].Value.ToString();
            txtMaSP.Enabled = false;
            txt_Ten_SP_Mua.Text = row.Cells["Ten_SP"].Value.ToString();
            txtGia_Ban_Mua.Text = row.Cells["Gia_Ban"].Value.ToString();
            txtGiamGiaMua.Text = row.Cells["Giam_Gia"].Value.ToString();
            number_sL_mua.Text = row.Cells["SL_Mua"].Value.ToString();
            txtTong.Text = row.Cells["Tong"].Value.ToString();

        }
        private void dataCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_them_sp_cart.Enabled = false;
            btn_huy_product.Text = "Huỷ Sửa";
            btn_Sua_Prod_Cart.Enabled = true;
            if (e.RowIndex>=0)
            {
                edit_product_cart(e.RowIndex);
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
            if ( sl_mua == 0 )
            {
                delete_product_cart(Ma_sp);
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
                LoadData();
                txtMaSP.Text = "";
                deleteform();
            }
        }
    }
}
