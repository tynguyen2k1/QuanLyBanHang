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
        QL_HoaDon qL_HoaDon = new QL_HoaDon();
        public frmHoaDon( NHAN_VIEN nv)
        {
            this.nv = nv;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            dtpk_Start.Value = DateTime.Now;
            dtpk_End.Value = DateTime.Now;
            qL_HoaDon.LoadDanhSachHoaDon(dataHoaDon,nv.MA_NV);
            indulieuraCTHD(0);
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

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (dtpk_Start.Value <= dtpk_End.Value)
            {
                qL_HoaDon.getAllHoaDon_Start_End(dataHoaDon, dtpk_Start.Value, dtpk_End.Value, nv.MA_NV);
                if (dataHoaDon.Rows.Count > 0)
                {
                    indulieuraCTHD(0);
                }
            }
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            loadData();
            
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
                    if (qL_HoaDon.checkquyen(this.nv , val))
                    {
                        MessageBox.Show("Bạn không có quyền xoá !!!");
                    }
                    else
                    {
                        MessageBox.Show("Xoá Thành Công Hoá Đơn");
                        /*if (qL_HoaDon.deleteHoaDon(val))
                        {
                            MessageBox.Show("Xoá Thành Công Hoá Đơn");
                            loadData();
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Xoá Hoá Đơn Này !!!");
                        }*/
                    }
                }     
            }
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
           
            this.Close();
           
        }
    }
}
