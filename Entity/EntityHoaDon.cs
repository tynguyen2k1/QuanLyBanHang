using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityHoaDon
    {
        public HOA_DON InsertHoaDon(HOA_DON hd)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    
                    HOA_DON a = db.HOA_DON.Add(hd);
                    db.SaveChanges();
                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<GETALLHOADON_Result> GetDanhSachHoaDon()
        {
            List<GETALLHOADON_Result> list = new List<GETALLHOADON_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var listhoadon = db.GETALLHOADON().Select(a => a);
                foreach(GETALLHOADON_Result hd in listhoadon)
                {
                    list.Add(hd);
                }
            }
            return list;
        }
        public List<LOC_HOA_DON_Result> getAllHoaDon_Start_End( DateTime start, DateTime end)
        {
            List<LOC_HOA_DON_Result> list = new List<LOC_HOA_DON_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var listhoadon = db.LOC_HOA_DON(start,end).Select(a => a);
                foreach (LOC_HOA_DON_Result hd in listhoadon)
                {
                    list.Add(hd);
                }
            }
            return list;
        }
        public HOA_DON returnHoaDon(HOA_DON hd)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    HOA_DON a = db.HOA_DON.Find(hd);
                    if (a != null)
                    {
                        return a;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        
    }
}
