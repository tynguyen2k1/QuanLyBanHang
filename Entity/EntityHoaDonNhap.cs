using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityHoaDonNhap
    {
        public List<GETALLHOADONNHAP_Result> GETALLHOADONNHAP(string  ma_nv)
        {
            List<GETALLHOADONNHAP_Result> list = new List<GETALLHOADONNHAP_Result>();
            using(var ql = new QL_BAN_HANGEntities())
            {
                var list_hd = ql.GETALLHOADONNHAP(ma_nv).Select(a => a);
                foreach (var hd in list_hd)
                {
                    list.Add(hd);
                }
            }
            return list;
        }
        public List<LOC_HOA_DON_NHAP_Result> LOC_HOA_DON_NHAP(string ma_nv ,DateTime start , DateTime end)
        {
            List<LOC_HOA_DON_NHAP_Result> list_hdn = new List<LOC_HOA_DON_NHAP_Result>();
            using(var db = new QL_BAN_HANGEntities())
            {
                var list = db.LOC_HOA_DON_NHAP(ma_nv , start ,end).Select(a => a);
                foreach(var hdn in list)
                {
                    list_hdn.Add(hdn);
                }
            }
            return list_hdn;
        }
        public List<SEARCH_HOA_DON_NHAP_Result> TimKiemHoaDon(string ma ,string chuc_vu)
        {
            List<SEARCH_HOA_DON_NHAP_Result> list_hdn = new List<SEARCH_HOA_DON_NHAP_Result>();
            using(var db = new QL_BAN_HANGEntities())
            {
                var list = db.SEARCH_HOA_DON_NHAP(ma , chuc_vu).Select(a => a);
                foreach (var hdn in list)
                {
                    list_hdn.Add(hdn);
                }
            }
            return list_hdn;
        }
        public HOA_DON_NHAP Insert_HDN(HOA_DON_NHAP hdn)
        {
            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    var hd = db.HOA_DON_NHAP.Add(hdn);
                    db.SaveChanges();
                    return hd;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool kiem_tra_ma_hdn(int ma)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                var hd = db.HOA_DON_NHAP.Find(ma);
                if (hd != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public HOA_DON_NHAP ReturnHoaDon(int ma)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                var hd = db.HOA_DON_NHAP.Find(ma);
                return hd;
            }
        }
        public bool Delete_HoaDon_Nhap(int ma_hd)
        {
            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    db.DELETE_HOA_DON_NHAP(ma_hd);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
