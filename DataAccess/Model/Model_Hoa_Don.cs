using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Model_Hoa_Don
    {
        public int MA_HD { get; set; }
        public Nullable<int> MA_KH { get; set; }
        public string TEN_KH { get; set; }
        public System.DateTime NGAY_BAN { get; set; }
        public double TONG_TIEN { get; set; }
        public string MA_NV { get; set; }
    }
}
