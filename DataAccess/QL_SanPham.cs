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
        public void HienThi (DataGridView view)
        {
            QL_SP = new EntitySanPham();
            
            view.DataSource = QL_SP.GetListSanPham();
        }
        public void LoadComboboxMa_DM(ComboBox cb)
        {
            QL_SP = new EntitySanPham();
            cb.DataSource = QL_SP.getDanhMuc();
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
            SAN_PHAM sp = new SAN_PHAM(masp,tensp,double.Parse(gianhap), double.Parse(giaban),int.Parse(giamgia),int.Parse(sl),mo_ta,ma_dm);
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
            SAN_PHAM sp = new SAN_PHAM(masp, tensp, double.Parse(gianhap), double.Parse(giaban), int.Parse(giamgia), int.Parse(sl), mo_ta, ma_dm);
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
    }
}
