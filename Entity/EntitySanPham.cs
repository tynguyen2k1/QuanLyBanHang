using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class EntitySanPham
    {
        public List<GET_ALL_SAN_PHAM_Result> GetListSanPham()
        {
            List<GET_ALL_SAN_PHAM_Result> list_sp = new List<GET_ALL_SAN_PHAM_Result>();
            QL_BAN_HANGEntities db = new QL_BAN_HANGEntities();
 
            var dt = db.GET_ALL_SAN_PHAM().Select(a=> a);
            foreach (var i in dt)
            {
                list_sp.Add(i);
            }
            return list_sp;
        }

        public bool checkIssetTenSPUpdate(string str ,string masp)
        {

            using (var db = new QL_BAN_HANGEntities())
            {

                string sql = "select * from SAN_PHAM  where SAN_PHAM.TEN_SP = N'" + str + "' and SAN_PHAM.MA_SP != '" + masp + "'";
                var dm = db.SAN_PHAM.SqlQuery(sql).ToList();
                if (dm.Count >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkIssetTenSPInsert(string str)
        {

            using (var db = new QL_BAN_HANGEntities())
            {

                string sql = "select * from SAN_PHAM  where SAN_PHAM.TEN_SP = N'" + str + "'";
                var dm = db.SAN_PHAM.SqlQuery(sql).ToList();
                if (dm.Count >= 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkIssetMa_SP(string str)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                SAN_PHAM dm = db.SAN_PHAM.FirstOrDefault(c => c.MA_SP == str);
                if (dm != null)
                {
                    return true;
                }
            }
            return false;
        }
        public SAN_PHAM ReturnSP_MaSP(string str)
        {
            using (var db = new QL_BAN_HANGEntities())
            {
                SAN_PHAM dm = db.SAN_PHAM.FirstOrDefault(c => c.MA_SP == str);
                if (dm != null)
                {
                    return dm;
                }
            }
            return null;
        }
        public bool AddSanPham(SAN_PHAM sp)
        {
            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    db.SAN_PHAM.Add(sp);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EditSanPham(SAN_PHAM sp)
        {

            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    SAN_PHAM s = db.SAN_PHAM.FirstOrDefault(c => c.MA_SP == sp.MA_SP);
                    s.TEN_SP = sp.TEN_SP;
                    s.GIA_NHAP = sp.GIA_NHAP;
                    s.GIA_BAN = sp.GIA_BAN;
                    s.GIAM_GIA = sp.GIAM_GIA;
                    s.GHI_CHU = sp.GHI_CHU;
                    s.MA_DM = sp.MA_DM;
                    s.SO_LUONG = sp.SO_LUONG;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<DANH_MUC> getDanhMuc()
        {
            List<DANH_MUC> list = new List<DANH_MUC>();
            using (var db = new QL_BAN_HANGEntities())
            {
                var dm = db.DANH_MUC.Select(c=>c);
                foreach (DANH_MUC d in dm)
                {
                    DANH_MUC m = new DANH_MUC();
                    m = d;
                    list.Add(m);
                }
            }
            return list;

        }
        public bool DeleteSanPham(string SP)
        {
            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    SAN_PHAM sp = db.SAN_PHAM.FirstOrDefault(c => c.MA_SP == SP);
                    db.SAN_PHAM.Remove(sp);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public List<SEARCH_SAN_PHAM_Result> Search_List_San_Pham(string ma, string ten, string dm, string ghichu, string sl, string giaban, string gianhap, string giamgia)
        {
            var list_sp =new List<SEARCH_SAN_PHAM_Result>();
            using (var db = new QL_BAN_HANGEntities())
            {
                var list = db.SEARCH_SAN_PHAM( ma,ten , gianhap,giaban,sl,giamgia,ghichu,dm).Select(c => c);
                foreach (var sp in list)
                {
                    list_sp.Add(sp);
                }
            }
            return list_sp;
        }

        public List<THONG_KE_SAN_PHAM_BAN_CHAY_Result> ThongKeSanPhamBanChay(string ma_sp ,string ngay, string thang , string nam)
        {
            var list_sp = new List<THONG_KE_SAN_PHAM_BAN_CHAY_Result>();
            using (var db = new QL_BAN_HANGEntities())
            {
                var list = db.THONG_KE_SAN_PHAM_BAN_CHAY(ngay,thang ,nam , ma_sp).Select(c => c);
                foreach (var sp in list)
                {
                    list_sp.Add(sp);
                }
            }
            return list_sp;
        }
        public List<THONG_KE_SAN_PHAM_TON_Result> ThongKeSanPhamBanTon()
        {
            var list_sp = new List<THONG_KE_SAN_PHAM_TON_Result>();
            using (var db = new QL_BAN_HANGEntities())
            {
                var list = db.THONG_KE_SAN_PHAM_TON().Select(c => c);
                foreach (var sp in list)
                {
                    list_sp.Add(sp);
                }
            }
            return list_sp;
        }
        public List<THONG_KE_SAN_PHAM_NHAP_Result> ThongKeSanPhamNhap(string ma_sp, string ngay, string thang, string nam)
        {
            var list_sp = new List<THONG_KE_SAN_PHAM_NHAP_Result>();
            using (var db = new QL_BAN_HANGEntities())
            {
                var list = db.THONG_KE_SAN_PHAM_NHAP(ngay, thang, nam, ma_sp).Select(c => c);
                foreach (var sp in list)
                {
                    list_sp.Add(sp);
                }
            }
            return list_sp;
        }
        public void Update_Sl_sp(string ma_sp,  int sl )
        {
            try
            {
                using (var db = new QL_BAN_HANGEntities())
                {
                    db.UPDATE_SO_LUONG_SAN_PHAM(ma_sp,sl);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
