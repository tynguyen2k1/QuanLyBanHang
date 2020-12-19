using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class Entity_DanhMuc
    {
        public List<DANH_MUC> GetListDanhMuc()
        {
            List<DANH_MUC> list_dm = new List<DANH_MUC>();
            QL_BAN_HANG db = new QL_BAN_HANG();
            var dt = from a in db.DANH_MUC select new { Ma_DM = a.Ma_DM , Ten_DM = a.TEN_DM , Mo_Ta = a.MO_TA };
            foreach (var i in dt)
            {
                DANH_MUC dm = new DANH_MUC();
                dm.Ma_DM = i.Ma_DM;
                dm.TEN_DM = i.Ten_DM;
                dm.MO_TA = i.Mo_Ta;
                list_dm.Add(dm);
            }
            return list_dm;
        }
        public bool checkIssetMaDM(string danhmuc)
        {
            using (var db = new QL_BAN_HANG())
            {
                DANH_MUC dm = db.DANH_MUC.FirstOrDefault(c => c.Ma_DM == danhmuc);
                if (dm != null)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool checkIssetTenDM(string danhmuc)
        {
            using (var db = new QL_BAN_HANG())
            {
                DANH_MUC dm = db.DANH_MUC.FirstOrDefault(c => c.TEN_DM == danhmuc);
                if (dm != null)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool InsertDanhMuc(DANH_MUC danhmuc)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    db.DANH_MUC.Add(danhmuc);
                    db.SaveChanges();
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<DANH_MUC> SearchMaDM(string str)
        {
            List<DANH_MUC> list_dm = new List<DANH_MUC>();
            QL_BAN_HANG db = new QL_BAN_HANG();
            var dt = from a in db.DANH_MUC where a.Ma_DM==str select new { Ma_DM = a.Ma_DM, Ten_DM = a.TEN_DM, Mo_Ta = a.MO_TA };
            foreach (var i in dt)
            {
                DANH_MUC dm = new DANH_MUC();
                dm.Ma_DM = i.Ma_DM;
                dm.TEN_DM = i.Ten_DM;
                dm.MO_TA = i.Mo_Ta;
                list_dm.Add(dm);
            }
            return list_dm;
        }
        public List<DANH_MUC> SearchTen(string str)
        {
            List<DANH_MUC> list_dm = new List<DANH_MUC>();
            QL_BAN_HANG db = new QL_BAN_HANG();
            var dt = db.DANH_MUC.Where(c=>c.TEN_DM.Contains(str));
            foreach (var i in dt)
            {
                DANH_MUC dm = new DANH_MUC();
                dm.Ma_DM = i.Ma_DM;
                dm.TEN_DM = i.TEN_DM;
                dm.MO_TA = i.MO_TA;
                list_dm.Add(dm);
            }
            return list_dm;
        }
        public bool EditDanhMuc(DANH_MUC danhmuc)
        {

            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    DANH_MUC dm = db.DANH_MUC.FirstOrDefault(c => c.Ma_DM == danhmuc.Ma_DM);
                    dm.TEN_DM = danhmuc.TEN_DM;
                    dm.MO_TA = danhmuc.MO_TA;
                    db.SaveChanges();
                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public bool DeleteDanhMuc(string DM)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    DANH_MUC dm = db.DANH_MUC.FirstOrDefault(c => c.Ma_DM == DM);
                    db.DANH_MUC.Remove(dm);
                    db.SaveChanges();  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }
    }
}
