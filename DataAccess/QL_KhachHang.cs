using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataAccess
{
    public class QL_KhachHang
    {
        public KHACH_HANG GetSanPham(string phone)
        {
            EntityKhachHang kh = new EntityKhachHang();
            if (phone!= "")
            {
                string sdt = phone.Replace("-", "");
                sdt = sdt.Replace(" ", "");
                sdt = sdt.Replace("+84", "0");
                sdt = sdt.Replace(".", "");
                if (kh.GetKhachHang_Phone(sdt) != null)
                {
                    return kh.GetKhachHang_Phone(sdt);
                }
                else
                {
                    return null;
                }
            }
            return null;
           
        }
    }
}
