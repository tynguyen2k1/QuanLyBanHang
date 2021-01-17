using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class QL_SanPham
    {
        QL_DanhMuc DM = new QL_DanhMuc();
        EntitySanPham QL_SP;
        ValidateData Validate = new ValidateData();
        public  QL_SanPham()
        {
            QL_SP = new EntitySanPham();
        }
        public List<Model.Model_San_Pham> GetListNhanVien()
        {
            
            List<Model.Model_San_Pham> list_nv = new List<Model.Model_San_Pham>();
            var list = QL_SP.GetListSanPham();
            foreach (var i in list)
            {
                var nv =new Model.Model_San_Pham();
                nv.MA_SP = i.MA_SP;
                nv.TEN_DM = i.TEN_DM;
                nv.SO_LUONG = i.SO_LUONG;
                nv.MA_DM = i.MA_DM;
                nv.GIA_NHAP = i.GIA_NHAP;
                nv.GIA_BAN = i.GIA_BAN;
                nv.GIAM_GIA = i.GIAM_GIA;
                nv.GHI_CHU = i.GHI_CHU;
                nv.TEN_SP = i.TEN_SP;
                list_nv.Add(nv);
            }
            return list_nv;
        }
       
        public void LoadComboboxMa_DM(ComboBox cb)
        {
           
            var list = QL_SP.getDanhMuc();
            DANH_MUC dm = new DANH_MUC();
            dm.TEN_DM = "";
            dm.TEN_DM = "";
            dm.MO_TA = "";
            list.Insert(0, dm);
            cb.DataSource = list;
            cb.DisplayMember = "TEN_DM";
            cb.ValueMember = "Ma_DM";
        }
        public string InsertSP(string masp,string tensp, string gianhap, string giaban,string giamgia,string sl,string mo_ta,string ma_dm)
        {
            string Err = "";
            Err = Validate.validate_ma_san_pham(masp);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_ten_sanpham(tensp, masp , "Insert");
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_number_sl(sl);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_number_gia(gianhap);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_number_gia(giaban);
            if (Err != "")
            {
                return Err;
            }
            
            Err = Validate.validate_giam_gia(giamgia);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_mo_ta_sp(mo_ta);
            if (Err != "")
            {
                return Err;
            }
            SAN_PHAM sp = new SAN_PHAM();
            sp.MA_SP = masp;
            sp.TEN_SP = tensp;
            sp.GIA_NHAP = double.Parse(gianhap);
            sp.GIA_BAN = double.Parse(giaban);
            sp.GIAM_GIA = int.Parse(giamgia);
            sp.SO_LUONG = int.Parse(sl);
            sp.GHI_CHU = mo_ta;
            sp.MA_DM = ma_dm;
            if (QL_SP.AddSanPham(sp))
            {
                return "";
            }
            else { return "Error : Không thể thêm sản phẩm "; }
        }
        public string UpdateSP(string masp, string tensp, string gianhap, string giaban, string giamgia, string sl, string mo_ta, string ma_dm)
        {
            string Err;
            Err = Validate.validate_ten_sanpham(tensp, masp, "Update");
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_number_sl(sl);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_number_gia(gianhap);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_number_gia(giaban);
            if (Err != "")
            {
                return Err;
            }

            Err = Validate.validate_giam_gia(giamgia);
            if (Err != "")
            {
                return Err;
            }
            Err = Validate.validate_mo_ta_sp(mo_ta);
            if (Err != "")
            {
                return Err;
            }
            SAN_PHAM sp = new SAN_PHAM();
            sp.MA_SP = masp;
            sp.TEN_SP = tensp;
            sp.GIA_NHAP = double.Parse(gianhap);
            sp.GIA_BAN = double.Parse(giaban);
            sp.GIAM_GIA = int.Parse(giamgia);
            sp.SO_LUONG = int.Parse(sl);
            sp.GHI_CHU = mo_ta;
            sp.MA_DM = ma_dm;
            if (QL_SP.EditSanPham(sp))
            {
                return "";
            }
            else { return "Error : Không thể sửa sản phẩm "; }
        }
        public bool DeleteSP(string MaSp)
        {
            if (QL_SP.DeleteSanPham(MaSp))
            {
                return true;
            }
            return false;
        }

        public List<Model.Model_San_Pham> Search_List_San_Pham(string ma , string ten , string dm, string ghichu, string sl , string giaban , string gianhap , string giamgia)
        {
            QL_SP = new EntitySanPham();
            List<Model.Model_San_Pham> list_nv = new List<Model.Model_San_Pham>();
            var list = QL_SP.Search_List_San_Pham(ma, ten, dm, ghichu, sl, giaban, gianhap, giamgia);
            foreach (var i in list)
            {
                var nv = new Model.Model_San_Pham();
                nv.MA_SP = i.MA_SP;
                nv.TEN_DM = i.TEN_DM;
                nv.SO_LUONG = i.SO_LUONG;
                nv.MA_DM = i.MA_DM;
                nv.GIA_NHAP = i.GIA_NHAP;
                nv.GIA_BAN = i.GIA_BAN;
                nv.GIAM_GIA = i.GIAM_GIA;
                nv.GHI_CHU = i.GHI_CHU;
                nv.TEN_SP = i.TEN_SP;
                list_nv.Add(nv);
            }
            return list_nv;
        }


        public List<Model.Model_thong_ke_san_pham_ban> Thong_Ke_San_Pham_Ban_Chay(string  ma,string ngay , string thang , string nam)
        {
            var list_sp =new List<Model.Model_thong_ke_san_pham_ban>();
            var list = QL_SP.ThongKeSanPhamBanChay(ma,ngay, thang, nam);
            foreach(var a in list)
            {
                var sp = new Model.Model_thong_ke_san_pham_ban();
                sp.MA_SP = a.MA_SP;
                sp.SL_CON = a.SL_CON;
                sp.TEN_SP = a.TEN_SP;
                sp.TONG_SL_BAN = a.TONG_SL_BAN;
                list_sp.Add(sp);
            }
            return list_sp;
        }
        public List<Model.Model_thong_ke_san_pham_ban> Thong_Ke_San_Pham_Ton()
        {
            var list_sp = new List<Model.Model_thong_ke_san_pham_ban>();
            var list = QL_SP.ThongKeSanPhamBanTon();
            foreach (var a in list)
            {
                var sp = new Model.Model_thong_ke_san_pham_ban();
                sp.MA_SP = a.MA_SP;
                sp.SL_CON = a.SL_CON;
                sp.TEN_SP = a.TEN_SP;
                sp.TONG_SL_BAN = a.TONG_SL_BAN;
                list_sp.Add(sp);
            }
            return list_sp;
        }
        public List<Model.Model_thong_ke_san_pham_nhap> Thong_Ke_San_Pham_Nhap(string ma, string ngay, string thang, string nam)
        {
            var list_sp = new List<Model.Model_thong_ke_san_pham_nhap>();
            var list = QL_SP.ThongKeSanPhamNhap(ma, ngay, thang, nam);
            foreach (var a in list)
            {
                var sp = new Model.Model_thong_ke_san_pham_nhap();
                sp.MA_SP = a.MA_SP;
                sp.SL_CON = a.SL_CON;
                sp.TEN_SP = a.TEN_SP;
                sp.TONG_SL_NHAP = a.TONG_SL_NHAP;
                list_sp.Add(sp);
            }
            return list_sp;
        }
    }
}
