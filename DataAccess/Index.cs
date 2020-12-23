using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataAccess
{
    
    public class Index
    {
        private EntitySanPham entitySanPham = new EntitySanPham();
        public SAN_PHAM kiemTraTonTaiMaSP(string str)
        {
            SAN_PHAM sp;
            if (entitySanPham.checkIssetMa_SP(str))
            {
                sp = entitySanPham.ReturnSP_MaSP(str);
                return sp;
            }
            return null;
        }
        public int returnSl_SP(string ma_sp)
        {
            int value = -1;
            if (entitySanPham.checkIssetMa_SP(ma_sp))
            {
                SAN_PHAM sp = entitySanPham.ReturnSP_MaSP(ma_sp);
                value = sp.SO_LUONG.Value;
            }
            return value;
        }
    }
}
