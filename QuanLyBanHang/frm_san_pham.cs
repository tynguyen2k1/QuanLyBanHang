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
        public frm_san_pham()
        {
            InitializeComponent();
            Load_Data();
        }

        public void Load_Data()
        {
            QLSP.HienThi(dataSanPham);
        }
    }
}
