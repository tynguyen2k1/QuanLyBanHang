using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class EntityKhachHang
    {
        public List<GET_ALL_KHACHHANG_Result> LoadData()
        {
            List<GET_ALL_KHACHHANG_Result> listkh = new List<GET_ALL_KHACHHANG_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var list = db.GET_ALL_KHACHHANG().Select(a => a);
                foreach(var kh in list)
                {
                    listkh.Add(kh);
                }
            }
            return listkh;
        }
        public List<SEARCH_KHACH_HANG_Result> GetListSearch(string ma,string ten,string sdt,string diachi)
        {
            List<SEARCH_KHACH_HANG_Result> listkh = new List<SEARCH_KHACH_HANG_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var list = db.SEARCH_KHACH_HANG(ma,ten,sdt,diachi).Select(a => a);
                foreach (var kh in list)
                {
                    listkh.Add(kh);
                }
            }
            return listkh;
        }
        public KHACH_HANG GetKhachHang_Phone(string phone)
        {
            using (var db = new QL_BAN_HANG())
            {
                KHACH_HANG khach_hang = db.KHACH_HANG.FirstOrDefault(k => k.SDT == phone);
                if(khach_hang != null)
                {
                    return khach_hang;
                }
            }
            return null;
        }
        public bool Validate_Phone_Update(string phone , int Ma_kh)
        {
            using (var db = new QL_BAN_HANG())
            {
                
                var listkh = db.KHACH_HANG.Where(a => a.MA_KH != Ma_kh && a.SDT == phone).ToList();
                if (listkh.Count > 0)
                {
                    return true;
                }
                return false;
            }
            
        }

        public KHACH_HANG GetKHACH_HANG_MAKH(int ma)
        {
            using (var db = new QL_BAN_HANG())
            {
                KHACH_HANG khach_hang = db.KHACH_HANG.Find(ma);
                if (khach_hang != null)
                {
                    return khach_hang;
                }
            }
            return null;
        }
        public KHACH_HANG Insert(KHACH_HANG kh)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    KHACH_HANG a = db.KHACH_HANG.Add(kh);
                    db.SaveChanges();
                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool insert_khach_hang(KHACH_HANG kh)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    db.KHACH_HANG.Add(kh);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update_Khach_Hang(KHACH_HANG kh)
        {
            using (var db = new QL_BAN_HANG())
            {
                KHACH_HANG khach_hang = db.KHACH_HANG.FirstOrDefault(c => c.MA_KH == kh.MA_KH);
                if (khach_hang != null)
                {
                    khach_hang.TEN_KH = kh.TEN_KH;
                    khach_hang.SDT = kh.SDT;
                    khach_hang.DIA_CHI = kh.DIA_CHI;
                    khach_hang.NGAY_SINH = kh.NGAY_SINH;
                    khach_hang.GIOI_TINH = kh.GIOI_TINH;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool DeleteKhachHang(int makh)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    KHACH_HANG kh = db.KHACH_HANG.Find(makh);
                    db.KHACH_HANG.Remove(kh);
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
