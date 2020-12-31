using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityNhanVien
    {
        public bool checkTaiKhoanLogin(string tk , string mk)
        {
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Select(c=>c);
                foreach (var i in dt)
                {
                    if(String.Compare(i.TAI_KHOAN,tk,false)==0 && String.Compare(i.MAT_KHAU, mk, false) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public NHAN_VIEN returnNhanVien(string tk , string mk)
        {
            if (this.checkTaiKhoanLogin(tk, mk) == true)
            {
                using (var db = new QL_BAN_HANG())
                {
                    var dt = db.NHAN_VIEN.Select(c => c);
                    foreach (var i in dt)
                    {
                        if (String.Compare(i.TAI_KHOAN, tk, false) == 0 && String.Compare(i.MAT_KHAU, mk, false) == 0)
                        {
                            return i;
                        }
                    }
                    return null;
                }
            }
            return null;
        }
        public NHAN_VIEN return_NhanVien_MA_NV(string MA)
        {

            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Find(MA);
                if (dt != null)
                {
                    return dt;
                }
                return null;
            }
          
        }

        public List<GET_ALL_NHAN_VIEN_Result> GetListNhanVien()
        {
            List<GET_ALL_NHAN_VIEN_Result> list_nv = new List<GET_ALL_NHAN_VIEN_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var nv = db.GET_ALL_NHAN_VIEN().Select(c => c);
                foreach (var i in nv)
                {
                    list_nv.Add(i);
                }
            }
            return list_nv;
        }
        public bool Check_Ma_NV(string str)
        {
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Where(c=>c.MA_NV == str).FirstOrDefault();
                if (dt != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Check_Email_NV(string str)
        {
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Where(c => c.EMAIL == str).FirstOrDefault();
                if (dt != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Check_SDT_NV(string str)
        {
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Where(c => c.SDT == str).FirstOrDefault();
                if (dt != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Check_Tai_Khoan_NV(string str)
        {
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.NHAN_VIEN.Where(c => c.TAI_KHOAN == str).FirstOrDefault();
                if (dt != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Insert_Nhan_Vien(NHAN_VIEN nv)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    db.NHAN_VIEN.Add(nv);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool DeleteNhanVien(string ma)
        {
            try {
                using (var db = new QL_BAN_HANG())
                {
                    var dt = db.NHAN_VIEN.Find(ma);
                    db.NHAN_VIEN.Remove(dt);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public List<SEARCH_NHAN_VIEN_Result> Search_Nhan_Vien(string ma, string ten, string diachi, string email, string gt, string sdt, string nvl, string tk, string mk, string chucvu)
        {
            List<SEARCH_NHAN_VIEN_Result> list_nv = new List<SEARCH_NHAN_VIEN_Result>();
            using (var db = new QL_BAN_HANG())
            {
                var dt = db.SEARCH_NHAN_VIEN(ma , ten ,sdt,nvl,diachi,gt,email,tk,chucvu).Select(c=>c);
                foreach (var nv in dt)
                {
                    list_nv.Add(nv);
                }
            }
            return list_nv;
        }
        public bool EditNhanVien(NHAN_VIEN nv)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    NHAN_VIEN nhanvien = db.NHAN_VIEN.Where(c=>c.MA_NV==nv.MA_NV).FirstOrDefault();
                    if (nhanvien != null)
                    {
                        nhanvien.TEN_NV = nv.TEN_NV;
                        nhanvien.DIA_CHI = nv.DIA_CHI;
                        nhanvien.EMAIL = nv.EMAIL;
                        nhanvien.SDT = nv.SDT;
                        nhanvien.MAT_KHAU =  nv.MAT_KHAU;
                        nhanvien.GIOI_TINH = nv.GIOI_TINH;
                        nhanvien.CHUC_VU = nv.CHUC_VU;
                        nhanvien.NGAY_VL = nv.NGAY_VL;
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool check_sdt_update(string manv , string sdt)
        {
            using (var db = new QL_BAN_HANG())
            {

                var listkh = db.NHAN_VIEN.Where(a => a.MA_NV != manv && a.SDT == sdt).ToList();
                if (listkh.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
