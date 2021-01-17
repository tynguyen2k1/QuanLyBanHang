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
    public partial class frmHoaDonNhap : Form
    {

        QL_HOA_DON_NHAP qL_HOA_DON_NHAP = new QL_HOA_DON_NHAP();
        List<DataAccess.Model.Model_Hoa_Don_Nhap> ListHoaDonNhap { get; set; }
        string ma_nv { get; set; }
        private int page { set; get; }
        private int loadeRecord { set; get; }
        
        public void setListHoaDonNhap()
        {
            this.ListHoaDonNhap = new List<DataAccess.Model.Model_Hoa_Don_Nhap>();
            this.ListHoaDonNhap.Clear();
        }

        public void setloadeRecord()
        {
            this.loadeRecord = 0;
        }
       
        public frmHoaDonNhap(string manv)
        {
            InitializeComponent();
            this.ma_nv = manv;
            Load();
        }
        
        public void loadDanhSachHoaDon()
        {
            if (this.ListHoaDonNhap.Count > 0)
            {
                float pageNumber = (float)this.ListHoaDonNhap.Count / 10;
                this.page = (int)Math.Ceiling((double)pageNumber);
                dataHoaDonNhap.DataSource = load_sl_data(this.loadeRecord, 10);
            }
            else
            {
                dataHoaDonNhap.DataSource = null;
            }
        }
        public List<DataAccess.Model.Model_Hoa_Don_Nhap> load_sl_data(int page, int sl)
        {
            List<DataAccess.Model.Model_Hoa_Don_Nhap> list = new List<DataAccess.Model.Model_Hoa_Don_Nhap>();
            list = this.ListHoaDonNhap.Skip(sl * page).Take(sl).ToList();
            return list;
        }


        public void Load()
        {
            setListHoaDonNhap();
            this.ListHoaDonNhap = qL_HOA_DON_NHAP.GetListHoaDonNhap(this.ma_nv);
            this.loadDanhSachHoaDon();
            dtpk_Start.Value = DateTime.Now;
            dtpk_End.Value = DateTime.Now;
            txt_Ma_HDN.Text = "";
            btnHuyLoc.Text = "Huỷ";
            HienThiPhanTrang();
            if (this.ListHoaDonNhap.Count > 0)
            {
                this.Load_CTHD_NHAP(
                    int.Parse(dataHoaDonNhap.Rows[0].Cells["MA_HD_NHAP"].Value.ToString()),
                    dataHoaDonNhap.Rows[0].Cells["MA_NV"].Value.ToString(),
                    DateTime.Parse(dataHoaDonNhap.Rows[0].Cells["NGAY_NHAP"].Value.ToString()),
                    double.Parse(dataHoaDonNhap.Rows[0].Cells["TONG_TIEN"].Value.ToString())
                ) ;
            }
            else
            {
                DeleteFormCTHD();
            }
        }
        public void HienThiPhanTrang()
        {
            if(this.page <= 0)
            {
                btn_next.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
                btn_prev.Enabled = true;
            }
        }
        private void btn_Loc_Click(object sender, EventArgs e)
        {
           
            btnHuyLoc.Text = "Huỷ Lọc";
            this.setloadeRecord();
            this.setListHoaDonNhap();
            this.ListHoaDonNhap = qL_HOA_DON_NHAP.LocHoaDonNhap(ma_nv, dtpk_Start.Value , dtpk_End.Value);
            float pageNumber = (float)this.ListHoaDonNhap.Count / 10;
            this.page = (int)Math.Ceiling((double)pageNumber);
            dataHoaDonNhap.DataSource = load_sl_data(this.loadeRecord, 10);
            HienThiPhanTrang();
            if (this.ListHoaDonNhap.Count > 0)
            {
                this.Load_CTHD_NHAP(
                    int.Parse(dataHoaDonNhap.Rows[0].Cells["MA_HD_NHAP"].Value.ToString()),
                    dataHoaDonNhap.Rows[0].Cells["MA_NV"].Value.ToString(),
                    DateTime.Parse(dataHoaDonNhap.Rows[0].Cells["NGAY_NHAP"].Value.ToString()),
                    double.Parse(dataHoaDonNhap.Rows[0].Cells["TONG_TIEN"].Value.ToString())
                );
            }
            else
            {
                DeleteFormCTHD();
            }
        }


        

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txt_Ma_HDN.Text!= "")
            {
                this.setloadeRecord();
                this.setListHoaDonNhap();
                this.ListHoaDonNhap = qL_HOA_DON_NHAP.SearchHoaDonNhap(this.ma_nv , txt_Ma_HDN.Text);
                float pageNumber = (float)this.ListHoaDonNhap.Count / 10;
                this.page = (int)Math.Ceiling((double)pageNumber);
                dataHoaDonNhap.DataSource = load_sl_data(this.loadeRecord, 10);
                HienThiPhanTrang();
                if (this.ListHoaDonNhap.Count > 0)
                {
                    this.Load_CTHD_NHAP(
                        int.Parse(dataHoaDonNhap.Rows[0].Cells["MA_HD_NHAP"].Value.ToString()),
                        dataHoaDonNhap.Rows[0].Cells["MA_NV"].Value.ToString(),
                        DateTime.Parse(dataHoaDonNhap.Rows[0].Cells["NGAY_NHAP"].Value.ToString()),
                        double.Parse(dataHoaDonNhap.Rows[0].Cells["TONG_TIEN"].Value.ToString())
                    );
                }
                else
                {
                    DeleteFormCTHD();
                }
                btnHuyLoc.Text = "Huỷ tìm kiếm";
            }
        }
        public void DeleteFormCTHD()
        {
            this.dataCTHD_Nhap.DataSource = null;
            lb_ma_nv.Text = "";
            lb_ngay_nhap.Text = "";
            lb_ten_nv.Text ="";
            lb_tong.Text = " VNĐ";
        }
        public void Load_CTHD_NHAP(int ma_hd , string ma_nv , DateTime date , double tong)
        {
            QL_CTHD_NHAP qL_CTHD_NHAP = new QL_CTHD_NHAP();
            QL_NhanVien qL_NhanVien = new QL_NhanVien();
            qL_CTHD_NHAP.Load_CTHD_Nhap(dataCTHD_Nhap, ma_hd);
            var nv = qL_NhanVien.returnNhanVien(ma_nv);
            lb_Ma_HDN.Text = Convert.ToString( ma_hd);
            lb_ma_nv.Text = nv.MA_NV;
            lb_ngay_nhap.Text = date.ToString();
            lb_ten_nv.Text = nv.TEN_NV;
            lb_tong.Text = Convert.ToString(tong)+" VNĐ";
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_hdn_Click(object sender, EventArgs e)
        {
            frmInsert_Hoa_Don_Nhap frmInsert_Hoa_Don = new frmInsert_Hoa_Don_Nhap(this.ma_nv);
            this.Hide();
            frmInsert_Hoa_Don.ShowDialog();
            this.Show();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord < 0)
                {
                    this.setloadeRecord();
                    loadDanhSachHoaDon();
                }
                else
                {
                    this.loadeRecord--;
                    loadDanhSachHoaDon();
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
                    loadDanhSachHoaDon();
                }
                else
                {
                    this.loadeRecord++;
                    loadDanhSachHoaDon();
                }
            }
        }

        private void dataHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int value = e.RowIndex;
            if (value >= 0)
            {
                 int val = int.Parse(dataHoaDonNhap.Rows[value].Cells["MA_HD_NHAP"].Value.ToString());
                 string ma_nv = dataHoaDonNhap.Rows[value].Cells["MA_NV"].Value.ToString();
                 var date = DateTime.Parse(dataHoaDonNhap.Rows[value].Cells["NGAY_NHAP"].Value.ToString());
                 double tong = double.Parse(dataHoaDonNhap.Rows[value].Cells["TONG_TIEN"].Value.ToString());
                 grb_cthd_nhap.Text = "Thông tin mã hoá đơn : " + val;
                 Load_CTHD_NHAP(val, ma_nv, date, tong);
            }   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lb_Ma_HDN.Text != "")
            {
                string message = "Bạn có chắc muốn xoá hoá đơn nhập : "+lb_Ma_HDN.Text;
                string title = "Delete Hoá Đơn Nhập";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons , MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    if (qL_HOA_DON_NHAP.DeleteHoaDonNhap(lb_Ma_HDN.Text))
                    {
                        MessageBox.Show("Xoá Thành Công");
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Không Thể Xoá Hoá Đơn");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_Ma_HDN.Text != "")
            {
                if(qL_HOA_DON_NHAP.inHoaDon(lb_Ma_HDN.Text)){
                    MessageBox.Show("In thành công hoá đơn nhâp :" + lb_Ma_HDN.Text);
                }
                else
                {
                    MessageBox.Show("Error !!!");
                }
            }
        }
    }
}
