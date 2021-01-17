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
    public partial class frmHoaDon : Form
    {
        NHAN_VIEN nv;
        QL_HoaDon qL_HoaDon;
        List<DataAccess.Model.Model_Hoa_Don> list_hoa_don { get; set; }
        public frmHoaDon(NHAN_VIEN nv)
        {
            this.nv = nv;
            qL_HoaDon = new QL_HoaDon(nv.MA_NV);
            this.list_hoa_don = new List<DataAccess.Model.Model_Hoa_Don>();
            InitializeComponent();
            LoadData();
            
        }
        private List<string> arrchon;
        private int page { set; get; }
        private int loadeRecord { set; get; }
        public void setloadeRecord()
        {
            this.loadeRecord = 0;
        }
        public void setArrChon(string str)
        {
            this.arrchon.Add(str);
        }
        public void LoadData()
        {
            this.list_hoa_don = qL_HoaDon.GetListHoaDon();
            this.txt_ma_hd.Text = "";
            setloadeRecord();
            loadDanhSachHoaDon();

        }
        public void loadDanhSachHoaDon()
        {
            float pageNumber = (float)this.list_hoa_don.Count / 10;
            this.page = (int)Math.Ceiling((double)pageNumber);
            dataHoaDon.DataSource = load_sl_data(this.loadeRecord,10);
            if (dataHoaDon.Rows.Count>0)
            {
                indulieuraCTHD(0);
            }
        }

        public List<DataAccess.Model.Model_Hoa_Don> load_sl_data(int page , int sl){
            List<DataAccess.Model.Model_Hoa_Don> list = new List<DataAccess.Model.Model_Hoa_Don>();
            list = this.list_hoa_don.Skip(sl*page).Take(sl).ToList();
            return list;
        }

        public void indulieuraCTHD(int index)
        {
            if (index == -1)
            {
                return;
            }
            Entity.EntityKhachHang entityKhach = new Entity.EntityKhachHang();
            DataGridViewRow row = this.dataHoaDon.Rows[index];
            //Đưa dữ liệu vào textbox
            grb_cthd.Text = "Thông tin mã hoá đơn : " + row.Cells["MA_HD"].Value.ToString() + "  / Khách hàng : " + row.Cells["TEN_KH"].Value.ToString();
            if (row.Cells["MA_HD"].Value.ToString() != "")
            {
                int ma = int.Parse(row.Cells["MA_HD"].Value.ToString());
                qL_HoaDon.getALLChiTietHoaDon_MAHD(dataCTHD, ma);
            }
            lb_ma_hoa_don.Text = row.Cells["MA_HD"].Value.ToString();
            lb_TenKH.Text = row.Cells["TEN_KH"].Value.ToString();
            lb_TongTien.Text = row.Cells["TONG_TIEN"].Value.ToString() + " VND";
            lb_Ngay_Ban.Text = row.Cells["NGAY_BAN"].Value.ToString();
            var kh = entityKhach.GetKHACH_HANG_MAKH(int.Parse(row.Cells["MA_KH"].Value.ToString()));
            lb_Sdt_KH.Text = (kh != null) ? kh.SDT : "";
        }
        private void dataHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            indulieuraCTHD(e.RowIndex);

        }

        private void dataCTHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("" + e.RowIndex);
        }

        private void btn_in_hoa_don_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(lb_ma_hoa_don.Text, out int val);
            if (check)
            {
                InHoaDon inhoadon = new InHoaDon();
                if (qL_HoaDon.getHoaDon_MaHD(val) != null) {
                    inhoadon.ghifileTXT(qL_HoaDon.getHoaDon_MaHD(val));
                    MessageBox.Show("In thành công hoá đơn !!!");
                }
                else
                {
                    MessageBox.Show("Không thể in hoá đơn này !!!");
                }
            }
        }
        public void deleteFormCTHD()
        {
            dataCTHD.DataSource = null;
            lb_ma_hoa_don.Text = "";
            lb_TenKH.Text = "";
            lb_TongTien.Text = "";
            lb_Ngay_Ban.Text = "";
            lb_Sdt_KH.Text = "";
        }
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (dtpk_Start.Value <= dtpk_End.Value)
            {
                this.list_hoa_don = this.qL_HoaDon.GetListHoaDonLoc(dtpk_Start.Value, dtpk_End.Value);
                this.setloadeRecord();
                this.loadDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("Không hợp lệ !!!");
            }
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_xoa_hoa_don_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(lb_ma_hoa_don.Text, out int val);
            if (check)
            {
                string message = "Bạn có chắc muốn xoá hoá đơn : "+val;
                string title = "Delete Hoá Đơn";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if (this.nv.CHUC_VU==0)
                    {
                        MessageBox.Show("Bạn không có quyền xoá !!!");
                    }
                    else
                    {
                        if (qL_HoaDon.deleteHoaDon(int.Parse(lb_ma_hoa_don.Text)))
                        {
                            MessageBox.Show("Xoá Thành Công Hoá Đơn"+ int.Parse(lb_ma_hoa_don.Text));
                            LoadData();
                     
                        }
                        else
                        {
                            MessageBox.Show("Xoá Không Thành Công Hoá Đơn"+ int.Parse(lb_ma_hoa_don.Text));
                        }
                    }
                }     
            }
            else
            {
                MessageBox.Show("Không tồn tại hoá đơn");
            }
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
           
            this.Close();
           
        }

        private void btnXoa_all_Click(object sender, EventArgs e)
        {
            if (dataHoaDon.SelectedRows.Count > 0)
            {
                string message = "Bạn có chắc muốn xoá  [ " + dataHoaDon.SelectedRows.Count+ " ] hoá đơn đã chọn";
                string title = "Delete Hoá Đơn";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if (this.nv.CHUC_VU == 0)
                    {
                        MessageBox.Show("Bạn không có quyền xoá !!!");
                    }
                    else
                    {
                        bool kiemtra = false;
                        foreach (DataGridViewRow row in dataHoaDon.Rows)
                        {
                            if (row.Selected == true)
                            {
                                kiemtra = qL_HoaDon.deleteHoaDon(int.Parse(row.Cells["MA_HD"].Value.ToString()));
                            }
                        }
                        if (kiemtra)
                        {
                            MessageBox.Show("Xoá thành công !!!");
                            this.LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá !!!");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Bạn Cần Chọn Dòng Muốn Xoá");
            }
        }

        private void btn_in_all_Click(object sender, EventArgs e)
        {
            if (dataHoaDon.SelectedRows.Count > 0)
            {
                string message = "Bạn có chắc muốn in  [ " + dataHoaDon.SelectedRows.Count + " ] hoá đơn đã chọn";
                string title = "In Hoá Đơn";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                bool kiemtra = false;
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataHoaDon.Rows)
                    {
                        if (row.Selected == true)
                        {
                            kiemtra = qL_HoaDon.ghifileTXT(int.Parse(row.Cells["MA_HD"].Value.ToString()));
                        }
                    }
                    if (kiemtra)
                    {
                        MessageBox.Show("In thành công hoá đơn !!!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể in hoá đơn này !!!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn Cần Chọn Dòng Muốn In");
            }
        }

        private void btn_huy_chon_all_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataHoaDon.Rows)
            {
                row.Selected = false;
            }
        }

        private void btn_chon_all_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataHoaDon.Rows)
            {
                row.Selected = true;
            }
        }

        private void btn_sort_tong_Click(object sender, EventArgs e)
        {
            if (this.list_hoa_don.Count > 0)
            {
                for(int i = 0 ; i < this.list_hoa_don.Count-1 ; i++)
                {
                    for (int j = i+1 ; j < this.list_hoa_don.Count ; j++)
                    {
                        if((double)this.list_hoa_don[i].TONG_TIEN < (double)this.list_hoa_don[j].TONG_TIEN)
                        {
                            var hd = this.list_hoa_don[i];
                            this.list_hoa_don[i] = this.list_hoa_don[j];
                            this.list_hoa_don[j] = hd;
                        }
                    }
                }
            }
            this.setloadeRecord();
            this.loadDanhSachHoaDon();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(this.page > 0)
            {
                if(this.loadeRecord == this.page-1)
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

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (this.page > 0)
            {
                if (this.loadeRecord < 0 )
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

        private void btn_sort_ngay_Click(object sender, EventArgs e)
        {
            if (this.list_hoa_don.Count > 0)
            {
                for (int i = 0; i < this.list_hoa_don.Count - 1; i++)
                {
                    for (int j = i + 1; j < this.list_hoa_don.Count; j++)
                    {
                        if (this.list_hoa_don[i].NGAY_BAN.CompareTo(this.list_hoa_don[j].NGAY_BAN) < 0)
                        {
                            var hd = this.list_hoa_don[i];
                            this.list_hoa_don[i] = this.list_hoa_don[j];
                            this.list_hoa_don[j] = hd;
                        }
                    }
                }
            }
            this.setloadeRecord();
            this.loadDanhSachHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.list_hoa_don.Clear();
            this.list_hoa_don = qL_HoaDon.Search_Hoa_Don(txt_ma_hd.Text);
            if (this.list_hoa_don.Count > 0)
            {
                MessageBox.Show("true");
            }
            this.setloadeRecord();
            this.loadDanhSachHoaDon();
            btnHuyLoc.Text = "Huỷ search";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
