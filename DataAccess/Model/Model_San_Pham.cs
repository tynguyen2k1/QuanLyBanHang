using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Model_San_Pham
    {
        public string MA_SP { get; set; }
        public string TEN_SP { get; set; }
        public Nullable<int> SO_LUONG { get; set; }
        public double GIA_NHAP { get; set; }
        public double GIA_BAN { get; set; }
        public Nullable<int> GIAM_GIA { get; set; }
        public string GHI_CHU { get; set; }
        public string MA_DM { get; set; }
        public string TEN_DM { get; set; }
    }
}
