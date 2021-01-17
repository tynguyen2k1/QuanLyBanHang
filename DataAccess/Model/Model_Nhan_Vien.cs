using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Model_Nhan_Vien
    {
        public string MA_NV { get; set; }
        public string TEN_NV { get; set; }
        public string GIOI_TINH { get; set; }
        public string DIA_CHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> NGAY_VL { get; set; }
        public string TAI_KHOAN { get; set; }
        public string MAT_KHAU { get; set; }
        public string CHUC_VU { get; set; }
        public string TRANG_THAI { get; set; }
    }
}
