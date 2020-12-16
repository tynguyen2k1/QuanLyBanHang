using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntitySanPham
    {
        public List<SAN_PHAM> GetListSanPham()
        {
            List<SAN_PHAM> list_sp = new List<SAN_PHAM>();
            QL_BAN_HANGEntities db = new QL_BAN_HANGEntities();
            var dt = from a in db.SAN_PHAM select new {
                Ma_SP = a.MA_SP,
                Ten_Sp = a.TEN_SP,
                So_Luong = a.SO_LUONG,
                Gia_Nhap = a.GIA_NHAP,
                Gia_Ban = a.GIA_BAN,
                Ghi_Chu = a.GHI_CHU,
                Giam_Gia = a.GIAM_GIA,
                Anh = a.ANH,
                Ma_DM = a.MA_DM
            };
            foreach (var i in dt)
            {
                var sp = new SAN_PHAM();
                sp.MA_SP  =  i.Ma_SP;
                sp.TEN_SP = i.Ten_Sp;
                sp.DANH_MUC = db.DANH_MUC.Find(i.Ma_DM);
                sp.GIAM_GIA = i.Giam_Gia;
                sp.GIA_NHAP = i.Gia_Nhap;
                sp.GIA_BAN = i.Gia_Ban;
                sp.ANH = i.Anh;
                sp.GHI_CHU = i.Ghi_Chu;
                sp.SO_LUONG = i.So_Luong;
                sp.MA_DM = i.Ma_DM;
                list_sp.Add(sp);
            }
            return list_sp;
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
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
