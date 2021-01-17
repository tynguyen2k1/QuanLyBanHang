using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_CTHD_NHAP
    {
        public List<GETALLCTHD_NHAP_Result> GETALLCTHD_NHAP(int ma_hd)
        {
            List<GETALLCTHD_NHAP_Result> list = new List<GETALLCTHD_NHAP_Result>();
            using(var ql = new QL_BAN_HANGEntities())
            {
                var list_cthd = ql.GETALLCTHD_NHAP(ma_hd).Select(a => a);
                foreach(var cthd in list_cthd)
                {
                    list.Add(cthd);
                }
            }
            return list;
        }
        public void Insert_CTHD_Nhap(CT_HOA_DON_NHAP cthdn)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                db.CT_HOA_DON_NHAP.Add(cthdn);
                db.SaveChanges();
            }
        }
       
    }
}
