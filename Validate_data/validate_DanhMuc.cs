using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Validate_data
{
    class validate_DanhMuc
    {
        string ten_danh_muc;
        string mo_ta;
        
        public bool validate_ten_danh_muc(string str)
        {
            var error = "";
            if( str.Length < 2 || str.Length > 100) 
            {
                return false;
            }
            return true;
        }
        public bool validate_mo_ta(string str)
        {
            if (str.Length > 200)
            {
                return false;
            }
            return true;
        }
        public string error_ten_danh_muc(string str)
        {
            if (this.validate_ten_danh_muc(str) == false)
            {
                return "Error !!! Tên danh mục phải có độ dài từ 2 -> 100 ký tự";
            }
            return null;
        }
        public string error_mo_ta(string str)
        {
            if (this.validate_mo_ta(str) == false)
            {
                return "Error !!! Mô tả không được quá 200 ký tự";
            }
            return null;
        }
    }
}
