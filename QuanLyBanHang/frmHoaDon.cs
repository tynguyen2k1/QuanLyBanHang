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
    public partial class frmHoaDon : Form
    {
        QL_HoaDon qL_HoaDon = new QL_HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            qL_HoaDon.LoadDanhSachHoaDon(dataHoaDon);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            qL_HoaDon.getAllHoaDon_Start_End(dataHoaDon,dtpk_Start.Value, dtpk_End.Value);
        }

        private void dataHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) { return; }
            
            DataGridViewRow row = this.dataHoaDon.Rows[index];
            //Đưa dữ liệu vào textbox

            if (row.Cells["MA_HD"].Value.ToString() != "")
            {
                int ma = int.Parse(row.Cells["MA_HD"].Value.ToString());
                qL_HoaDon.getALLChiTietHoaDon_MAHD(dataCTHD,ma);
            }
            
        }

        private void dataCTHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("" + e.RowIndex);
        }
    }
}
