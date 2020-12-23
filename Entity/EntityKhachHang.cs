using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityKhachHang
    {
        public KHACH_HANG GetKhachHang_Phone(string phone)
        {
            using (var db = new QL_BAN_HANG())
            {
                KHACH_HANG khach_hang = db.KHACH_HANG.FirstOrDefault(k => k.SDT == phone);
                if(khach_hang != null)
                {
                    return khach_hang;
                }
            }
            return null;
        }
        public KHACH_HANG Insert(KHACH_HANG kh)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    KHACH_HANG a = db.KHACH_HANG.Add(kh);
                    db.SaveChanges();
                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
