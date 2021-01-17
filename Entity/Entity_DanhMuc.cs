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
        
        public List<GET_ALL_DANH_MUC_TON_TAI_Result> GetListDanhMucTonTai()
        {
            List<GET_ALL_DANH_MUC_TON_TAI_Result> list_dm = new List<GET_ALL_DANH_MUC_TON_TAI_Result>();
            var db = new QL_BAN_HANGEntities();
            var dt = db.GET_ALL_DANH_MUC_TON_TAI().Select(a => a);
            foreach (var i in dt)
            {
                list_dm.Add(i);
            }
            return list_dm;
        }
        public List<GET_ALL_DANH_MUC_DELETE_Result> GetListDanhMucXoa()
        {
            List<GET_ALL_DANH_MUC_DELETE_Result> list_dm = new List<GET_ALL_DANH_MUC_DELETE_Result>();
            var db = new QL_BAN_HANGEntities();
            var dt = db.GET_ALL_DANH_MUC_DELETE().Select(a => a);
            foreach (var i in dt)
            {
                list_dm.Add(i);
            }
            return list_dm;
        }
        public bool checkIssetMaDM(string danhmuc)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                DANH_MUC dm = db.DANH_MUC.FirstOrDefault(c => c.Ma_DM == danhmuc);
                if (dm != null)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool updateTrangThai(string ma_dm , byte val)
        {
            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    DANH_MUC dm = db.DANH_MUC.Find(ma_dm);
                    dm.TRANG_THAI = val;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool checkIssetTenDM(string danhmuc)
        {
            using (var db = new QL_BAN_HANGEntities())
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
                using (var db = new QL_BAN_HANGEntities())
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
        public List<SEARCH_DANH_MUC_TON_TAI_Result> GetListSearchDanhTonTai(string a, string b ,string c)
        {
            List<SEARCH_DANH_MUC_TON_TAI_Result> list_dm = new List<SEARCH_DANH_MUC_TON_TAI_Result>();
            var db = new QL_BAN_HANGEntities();
            var dt = db.SEARCH_DANH_MUC_TON_TAI(a,b,c).Select(d => d);
            foreach (var i in dt)
            {
                list_dm.Add(i);
            }
            return list_dm;
        }
        public List<SEARCH_DANH_MUC_DELETE_Result> GetListSearchDanhDaXoa(string a, string b, string c)
        {
            List<SEARCH_DANH_MUC_DELETE_Result> list_dm = new List<SEARCH_DANH_MUC_DELETE_Result>();
            var db = new QL_BAN_HANGEntities();
            var dt = db.SEARCH_DANH_MUC_DELETE(a, b, c).Select(d => d);
            foreach (var i in dt)
            {
                list_dm.Add(i);
            }
            return list_dm;
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
