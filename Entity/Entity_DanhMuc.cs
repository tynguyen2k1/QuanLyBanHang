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
            QL_BAN_HANGEntities db = new QL_BAN_HANGEntities();
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
        public bool checkID(DANH_MUC danhmuc)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                DANH_MUC dm = db.DANH_MUC.FirstOrDefault(c => c.Ma_DM == danhmuc.Ma_DM);
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
                using (var db = new QL_BAN_HANGEntities())
                {
                    if (!this.checkID(danhmuc))
                    {

                        db.DANH_MUC.Add(danhmuc);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EditDanhMuc(DANH_MUC danhmuc)
        {

            try
            {
                using (var db = new QL_BAN_HANGEntities())
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
                using (var db = new QL_BAN_HANGEntities())
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
