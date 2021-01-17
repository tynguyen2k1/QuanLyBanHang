using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Model_thong_ke_san_pham_nhap
    {
        public string MA_SP { get; set; }
        public Nullable<int> TONG_SL_NHAP { get; set; }
        public string TEN_SP { get; set; }
        public Nullable<int> SL_CON { get; set; }
    }
}
