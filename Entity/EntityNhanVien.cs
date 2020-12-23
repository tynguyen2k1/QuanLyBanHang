using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityNhanVien
    {
        public bool checkTaiKhoanLogin(string tk , string mk)
        {
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Select(c=>c);
                foreach (var i in dt)
                {
                    if(String.Compare(i.TAI_KHOAN,tk,false)==0 && String.Compare(i.MAT_KHAU, mk, false) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public NHAN_VIEN returnNhanVien(string tk , string mk)
        {
            if (this.checkTaiKhoanLogin(tk, mk) == true)
            {
                using (var db = new QL_BAN_HANG())
                {
                    var dt = db.NHAN_VIEN.Select(c => c);
                    foreach (var i in dt)
                    {
                        if (String.Compare(i.TAI_KHOAN, tk, false) == 0 && String.Compare(i.MAT_KHAU, mk, false) == 0)
                        {
                            return i;
                        }
                    }
                    return null;
                }
            }
            return null;
        }
    }
}
