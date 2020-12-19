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
            QL_BAN_HANG db = new QL_BAN_HANG();
            /*var dt = from a in db.SAN_PHAM select new {
                Ma_SP = a.MA_SP,
                Ten_Sp = a.TEN_SP,
                So_Luong = a.SO_LUONG,
                Gia_Nhap = a.GIA_NHAP,
                Gia_Ban = a.GIA_BAN,
                Ghi_Chu = a.GHI_CHU,
                Giam_Gia = a.GIAM_GIA,
                Anh = a.ANH,
                Ma_DM = a.MA_DM
            };*/
            var dt = db.GET_ALL_SAN_PHAM().Select(a=> new
            {
                Ma_SP = a.MA_SP,
                Ten_Sp = a.TEN_SP,
                So_Luong = a.SO_LUONG,
                Gia_Nhap = a.GIA_NHAP,
                Gia_Ban = a.GIA_BAN,
                Ghi_Chu = a.GHI_CHU,
                Giam_Gia = a.GIAM_GIA,
                Ma_DM = a.MA_DM,
                Ten_DM = a.TEN_DM
            });
            foreach (var i in dt)
            {
                var sp = new GET_ALL_SAN_PHAM_Result();
                sp.MA_SP  =  i.Ma_SP;
                sp.TEN_SP = i.Ten_Sp;
                sp.GIAM_GIA = i.Giam_Gia;
                sp.GIA_NHAP = i.Gia_Nhap;
                sp.GIA_BAN = i.Gia_Ban;
                sp.GHI_CHU = i.Ghi_Chu;
                sp.SO_LUONG = i.So_Luong;
                sp.MA_DM = i.Ma_DM;
                sp.TEN_DM = i.Ten_DM;
                list_sp.Add(sp);
            }
            return list_sp;
        }
        public bool checkIssetTenSPUpdate(string str ,string masp)
        {

            using (var db = new QL_BAN_HANG())
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

            using (var db = new QL_BAN_HANG())
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
            using (var db = new QL_BAN_HANG())
            {
                SAN_PHAM dm = db.SAN_PHAM.FirstOrDefault(c => c.MA_SP == str);
                if (dm != null)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AddSanPham(SAN_PHAM sp)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
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
                using (var db = new QL_BAN_HANG())
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
            using (var db = new QL_BAN_HANG())
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
                using (var db = new QL_BAN_HANG())
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
    }
}
