using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Model_Khach_Hang
    {
        public int MA_KH { get; set; }
        public string TEN_KH { get; set; }
        public string SDT { get; set; }
        public string Gioi_Tinh { get; set; }
        public string DIA_CHI { get; set; }
        public System.DateTime NGAY_SINH { get; set; }
    }
}
