using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    class ValidateData
    {
        QL_BAN_HANG validate_data = new QL_BAN_HANG();
        public string validate_danh_muc_ma_sp(string str)
        {
            Entity_DanhMuc entity = new Entity_DanhMuc();
            if (str.Length>10)
            {
                return "Mã danh mục không được dài quá 10 ký tự";
            }else if (entity.checkIssetMaDM(str))
            {
                return "Mã danh mục đã tồn tại !!!";
            }
            return "";
        }

        public string validate_ten_danh_muc(string str)
        {
            Entity_DanhMuc entity = new Entity_DanhMuc();
            if (str.Length > 100)
            {
                return "Tên danh mục không được dài quá 100 ký tự";
            }
            else if (entity.checkIssetTenDM(str))
            {
                return "Tên danh mục đã tồn tại !!!";
            }
            return "";
        }
        public string validate_mo_ta_danh_muc(string str)
        {
            Entity_DanhMuc entity = new Entity_DanhMuc();
            if (str.Length > 100)
            {
                return "Mô tả danh mục không được dài quá 100 ký tự";
            }
            return "";
        }

        /*Sản Phẩm*/
        public string validate_ma_san_pham(string ma_sp)
        {
            EntitySanPham entitySanPham = new EntitySanPham();
            if (ma_sp.Length< 1 ||ma_sp.Length >10)
            {
                return "Mã sản phẩm phải có độ dài trong khoảng ( 1 => 10) ký tự !!!";
            }else if (entitySanPham.checkIssetMa_SP(ma_sp) == true)
            {
                return "Mã sản phẩm đã tồn tại !!!";
            }else
                return "";
        }
        public string validate_ten_sanpham(string ten_sp , string ma_sp , string kieu)
        {
            EntitySanPham entitySanPham = new EntitySanPham();
            if (ten_sp.Length<1 || ten_sp.Length>200)
            {
                return "Tên sản phẩm phải có độ dài từ 0 -> 200 ký tự !!!";
            }
            if(entitySanPham.checkIssetTenSPUpdate(ten_sp,ma_sp) == true && kieu.Contains("Update"))
            {
                return "Tên sản phẩm đã tồn tại !!!";
            }
            if(entitySanPham.checkIssetTenSPInsert(ten_sp) && kieu.Contains("Insert"))
            {
                return "Tên sản phẩm đã tồn tại !!!";
            }

            return "";
        }
        public string validate_number_sl(string number)
        {
            bool check = int.TryParse(number, out int val);
            if (check !=true)
            {
                return "Số lượng phải là kiểu Integer !!!";
            }
            return "";
        }
        public string validate_number_gia( string number)
        {
            bool check = float.TryParse(number, out float val);
            if(check != true)
            {
                return "Giá phải là kiểu Số ( Integer , .....)!!! ";
            }
            return "";
        }
        public string validate_giam_gia(string str)
        {
            bool validate = int.TryParse(str, out int val);
            if (validate != true)
            {
                return "Giảm giá phải là kiểu Integer (VD : 10%)";
            }
            return "";
        }
        public string validate_mo_ta_sp(string str)
        {
            if (str.Length > 250)
            {
                return "Mô tả sản phẩm độ dài không được lớn hơn 250 ký tự !!!";
            }
            return "";
        }
    }
}
