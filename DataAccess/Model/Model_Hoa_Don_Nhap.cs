using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Model_Hoa_Don_Nhap
    {
        public int MA_HD_NHAP { get; set; }
        public System.DateTime NGAY_NHAP { get; set; }
        public double TONG_TIEN { get; set; }
        public string MA_NV { get; set; }
        public string TEN_NV { get; set; }
    }
}
