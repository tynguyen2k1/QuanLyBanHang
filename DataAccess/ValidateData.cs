using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class ValidateData
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

        


        /*KHACH_HANG*/
        public string validate_ten_kh(string str)
        {
            if (str.Length < 1 || str.Length > 55)
            {
                return "Tên khách hàng phải có độ dài ( 1 => 55 ) ký tự !!!";
            }
            return "";
        }
        public string validate_dia_chi_kh(string str)
        {
            if (str.Length < 1 || str.Length > 100)
            {
                return "Địa chỉ khách hàng phải có độ dài ( 1 => 100 ) ký tự  !!!";
            }
            return "";
        }
        public string validate_ngay_sinh(DateTime dt)
        {
            if (dt.CompareTo(DateTime.Now) > 0)
            {
                return "Ngày sinh lỗi !!!";
            }
            return "";
        }
        public bool IsPhoneNbr(string number)
        {
            return Regex.IsMatch(number, @"^(0|\+84)\d{3}[-. ]?\d{3}[-. ]?\d{3}$");
        }
        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool Check_Ky_Tu_Dac_Biet(string str)
        {
            return str.Any(ch => Char.IsLetterOrDigit(ch));
        }

        /*Nhân Viên :*/
        public bool check_Ma_NV(string str)
        {
            EntityNhanVien entity = new EntityNhanVien();
            if (str.Length < 1 || str.Length > 20)
            {
                MessageBox.Show("Mã nhân viên phải có độ dài từ 1=>20 ký tự !!!");
                return false;
            }
            if(!this.Check_Ky_Tu_Dac_Biet(str))
            {
                MessageBox.Show("Mã nhân viên không được chứa ký tự đặc biệt !!!");
                return false;
            }
            if (entity.Check_Ma_NV(str))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại !!!");
                return false;
            }
            return true;
        }
        public bool validate_ten_nv(string str)
        {
            if (str.Length < 1 || str.Length > 55)
            {
                MessageBox.Show( "Tên nhân viên phải có độ dài ( 1 => 55 ) ký tự !!!");
                return false;
            }
            return true;
        }
        public bool validate_dia_chi_nv(string str)
        {
            if (str.Length < 1 || str.Length > 100)
            {
                MessageBox.Show("Địa chỉ nhân viên phải có độ dài ( 1 => 100 ) ký tự  !!!");
                return false;
            }
            return true;
        }
        public bool check_Email_NV(string str)
        {
            EntityNhanVien entity = new EntityNhanVien();
            if (str.Length < 1 || str.Length > 100)
            {
                MessageBox.Show("Email phải có độ dài từ 1=>100 ký tự !!!");
                return false;
            }
            if(!this.IsValidEmail(str))
            {
                MessageBox.Show("Email không đúng định dạng !!!");
                return false;
            }
            if (entity.Check_Email_NV(str))
            {
                MessageBox.Show("Email nhân viên đã tồn tại !!!");
                return false;
            }
            return true;
        }
        public bool check_Tai_Khoan_NV(string str)
        {
            EntityNhanVien entity = new EntityNhanVien();
            if (str.Length < 1 || str.Length > 20)
            {
                MessageBox.Show("Tài khoản nhân viên phải có độ dài từ 1=>50 ký tự !!!");
                return false;
            }
            if (entity.Check_Tai_Khoan_NV(str))
            {
                MessageBox.Show("Tài khoản nhân viên đã tồn tại !!!");
                return false;
            }
            if (!this.Check_Ky_Tu_Dac_Biet(str))
            {
                MessageBox.Show("Tài khoản nhân viên không được chứa ký tự đặc biệt !!!");
                return false;
            }
            return true;
        }
        public bool check_Mk_NV(string str)
        {
            if(str.Length<6 || str.Length > 50)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 => 50 ký tự");
                return false;
            }

            return true;
        }
       
        public bool check_SDT_NV(string str)
        {
            EntityNhanVien entity = new EntityNhanVien();
            if (!this.IsPhoneNbr(str))
            {
                MessageBox.Show("Số Điện Thoại Sai Định Dạng : \n   [84|0]123 456 789  ; \n   [84|0]123-456-789 ; \n   [84|0] 123.456.789 ; \n   [84|0]123456789");
                return false;
            }
            if (entity.Check_SDT_NV(str))
            {
                MessageBox.Show("Số điện thoại đã tồn tại !!!");
                return false;
            }
            return true;
        }
        
    }
}
