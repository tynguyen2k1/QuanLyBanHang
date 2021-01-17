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
    public partial class frm_thong_ke_san_pham_nhap : Form
    {
        public frm_thong_ke_san_pham_nhap()
        {
            InitializeComponent();
            list_thong_ke = new List<DataAccess.Model.Model_thong_ke_san_pham_nhap>();
            this.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        QL_SanPham qL_SanPham = new QL_SanPham();
        List<DataAccess.Model.Model_thong_ke_san_pham_nhap> list_thong_ke { get; set; }
        private int page { set; get; }
        private int loadeRecord { set; get; }
        public void setloadeRecord()
        {
            this.loadeRecord = 0;
        }
        public void setListThongKe()
        {
            this.list_thong_ke.Clear();
        }
        public void loadDanhSachThongKeSanPham()
        {

            float pageNumber = (float)this.list_thong_ke.Count / 16;
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
            data_thong_ke.DataSource = load_sl_data(this.loadeRecord, 12);

        }
        public void hienThiPhanTrang()
        {
            if (this.list_thong_ke.Count >= 2)
            {
                btn_prev.Enabled = true;
                btn_next.Enabled = true;
            }
            else
            {
                btn_prev.Enabled = false;
                btn_next.Enabled = false;
            }
        }
        public List<DataAccess.Model.Model_thong_ke_san_pham_nhap> load_sl_data(int page, int sl)
        {
            var list = new List<DataAccess.Model.Model_thong_ke_san_pham_nhap>();
            list = this.list_thong_ke.Skip(sl * page).Take(sl).ToList();
            return list;
        }
        public void LoadData()
        {
            var date = DateTime.Now.Year;
            this.list_thong_ke = qL_SanPham.Thong_Ke_San_Pham_Nhap("", "", "", Convert.ToString(date));
            loadDanhSachThongKeSanPham();
            lb_title.Text= "Danh Sách Sản Phẩm Nhập ( "+date+" ) ";
            setloadeRecord();
            loadComboBox_Month();
        }
        public void loadComboBox_Month()
        {
            List<string> list_thang = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                list_thang.Add(Convert.ToString(i));
            }
            list_thang.Insert(0, "");
            cb_thang.DataSource = list_thang;

        }
        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            if (this.number_year.Value != 0)
            {
                if (lb_err_nam.Text != "")
                {
                    return;
                }
            }
            string date = (number_date.Value == 0) ? "" : Convert.ToString(number_date.Value);
            this.list_thong_ke = qL_SanPham.Thong_Ke_San_Pham_Nhap(this.txt_ma_sp.Text ,date, cb_thang.SelectedItem.ToString(), Convert.ToString(this.number_year.Value));
            this.setloadeRecord();
            this.loadDanhSachThongKeSanPham();
            lb_title.Text = "Danh Sách Sản Phẩm Nhập (" + date + "/" + cb_thang.SelectedItem.ToString() + "/" + number_year.Value + ")";

        }

        private void number_year_MouseDown(object sender, MouseEventArgs e)
        {
            check_year((int)number_year.Value);
        }
        public void check_year(int val)
        {

            if ((0 < val && val < 100) || val >= 10000)
            {
                lb_err_nam.Text = "Năm không hợp lệ ( 100 <  year <  9999 )";
            }
            else
            {
                lb_err_nam.Text = "";
            }
        }

        private void number_year_KeyUp(object sender, KeyEventArgs e)
        {
            check_year((int)number_year.Value);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord < 0)
                {
                    this.setloadeRecord();
                    loadDanhSachThongKeSanPham();
                }
                else
                {
                    this.loadeRecord--;
                    loadDanhSachThongKeSanPham();
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord == this.page - 1)
                {
                    this.setloadeRecord();
                    loadDanhSachThongKeSanPham();
                }
                else
                {
                    this.loadeRecord++;
                    loadDanhSachThongKeSanPham();
                }
            }

        }
    }
}
