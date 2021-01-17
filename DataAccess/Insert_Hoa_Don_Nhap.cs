using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataAccess
{
    public class Insert_Hoa_Don_Nhap
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
    }
}
