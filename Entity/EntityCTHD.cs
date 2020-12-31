using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class EntityCTHD
    {
        public void InsertCTHD(CT_HOA_DON cthd)
        {
           
            using (var db = new QL_BAN_HANG())
            {
                db.CT_HOA_DON.Add(cthd);
                db.SaveChanges();
            }
        }
        public List<CT_HOA_DON> getALLChiTietHoaDon(int MA_HD)
        {
            List<CT_HOA_DON> list = new List<CT_HOA_DON>();
            using (var db = new QL_BAN_HANG())
            {
                var listcthd = from a in db.CT_HOA_DON where(a.MA_HD==MA_HD) select(a);
                if(listcthd != null)
                {
                    foreach (var cthd in listcthd)
                    {
                        list.Add(cthd);
                    }
                   
                }
                return list;
            }
            
        }
        public List<GETALLCTHD_BAN_Result> GetAllCTHD_Ban(int mahd)
        {
            List<GETALLCTHD_BAN_Result> list  = new List<GETALLCTHD_BAN_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var list_cthd = db.GETALLCTHD_BAN(mahd).Select(a=>a);
                foreach (var a in list_cthd)
                {
                    list.Add(a);
                }
            }
            return list;
        }
    }
}
