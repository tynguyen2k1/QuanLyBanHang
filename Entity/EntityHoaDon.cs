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

        public List<GETALLHOADON_Result> GetDanhSachHoaDon(string manv)
        {
            List<GETALLHOADON_Result> list = new List<GETALLHOADON_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var listhoadon = db.GETALLHOADON(manv).Select(a => a);
                foreach(GETALLHOADON_Result hd in listhoadon)
                {
                    list.Add(hd);
                }
            }
            return list;
        }
        public List<LOC_HOA_DON_Result> getAllHoaDon_Start_End(string manv, DateTime start, DateTime end)
        {
            List<LOC_HOA_DON_Result> list = new List<LOC_HOA_DON_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var listhoadon = db.LOC_HOA_DON(manv,start, end).Select(a => a);
                foreach (LOC_HOA_DON_Result hd in listhoadon)
                {
                    list.Add(hd);
                }
            }
            return list;
        }
        public HOA_DON returnHoaDon(int hd)
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

        public bool deleteHoaDon(int Ma_hd)
        {
            using (var db = new QL_BAN_HANG())
            {
                try 
                {
                    db.DELETE_HOA_DON(Ma_hd);
                    db.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }

    }
}
