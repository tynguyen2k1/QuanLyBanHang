using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class QL_KhachHang
    {


        public List<Model.Model_Khach_Hang> GetListKhachHang()
        {
            List<Model.Model_Khach_Hang> list_khach_hang = new List<Model.Model_Khach_Hang>();
            EntityKhachHang entityKhach = new EntityKhachHang();
            var list = entityKhach.GetListKhachHang();
            foreach(var kh in list)
            {
                var khachhang = new Model.Model_Khach_Hang();
                khachhang.MA_KH = kh.MA_KH;
                khachhang.NGAY_SINH = kh.NGAY_SINH;
                khachhang.SDT = kh.SDT;
                khachhang.TEN_KH = kh.TEN_KH;
                khachhang.Gioi_Tinh = kh.Gioi_Tinh;
                khachhang.DIA_CHI = kh.DIA_CHI;
                list_khach_hang.Add(khachhang);
            }
            return list_khach_hang;
        }
        
        public KHACH_HANG GetSanPham(string phone)
        {
            EntityKhachHang kh = new EntityKhachHang();
            if (phone!= "")
            {
                string sdt = phone.Replace("-", "");
                sdt = sdt.Replace(" ", "");
                sdt = sdt.Replace("+84", "0");
                sdt = sdt.Replace(".", "");
                if (kh.GetKhachHang_Phone(sdt) != null)
                {
                    return kh.GetKhachHang_Phone(sdt);
                }
                else
                {
                    return null;
                }
            }
            return null;
           
        }
        public void insertKhachHang(string ten, string diachi, string sdt, bool gt, DateTime ns)
        {
            EntityKhachHang khachhang = new EntityKhachHang();
            if (sdt != "")
            {
                string phone = sdt.Replace("-", "");
                phone = phone.Replace(" ", "");
                phone = phone.Replace("+84", "0");
                phone = phone.Replace(".", "");
                if (khachhang.GetKhachHang_Phone(sdt) != null)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại !!!");
                }
                else
                {
                    KHACH_HANG kh = new KHACH_HANG();
                    kh.TEN_KH = ten;
                    kh.SDT = sdt;
                    kh.GIOI_TINH = gt;
                    kh.NGAY_SINH = ns;
                    kh.DIA_CHI = diachi;

                    if (khachhang.insert_khach_hang(kh))
                    {
                        MessageBox.Show("Chèn thành công !!!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể chèn khách hàng !!!");
                    }
                }
            }
            
        }
        public bool UpdateKhachHang(string ma_kh , string ten , DateTime ns , string sdt ,string diachi, bool gt)
        {
            EntityKhachHang khachhang = new EntityKhachHang();
            if (sdt != "")
            {
                string phone = sdt.Replace("-", "");
                phone = phone.Replace(" ", "");
                phone = phone.Replace("+84", "0");
                phone = phone.Replace(".", "");

                bool check = khachhang.Validate_Phone_Update(phone, int.Parse(ma_kh));
                if (check)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại ");
                    return false;
                }
                else
                {
                    KHACH_HANG kh = new KHACH_HANG();
                    kh.MA_KH = int.Parse(ma_kh);
                    kh.TEN_KH = ten;
                    kh.NGAY_SINH = ns;
                    kh.SDT = sdt;
                    kh.DIA_CHI = diachi;
                    kh.GIOI_TINH = gt;
                    if (khachhang.Update_Khach_Hang(kh))
                    {
                        MessageBox.Show("Sửa thành công !!!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error : Không thể sửa khách hàng này !!!");
                        return false;
                    }
                }
            }
            return false;
        }
        public bool DeleteKhachHang(int kh)
        {
            EntityKhachHang khachhang = new EntityKhachHang();
            return khachhang.DeleteKhachHang(kh);
        }
        public List<Model.Model_Khach_Hang> GetListSearch(string ma , string ten , string sdt ,string diachi)
        {
            EntityKhachHang entity_khachhang = new EntityKhachHang();
            var list_kh = new List<Model.Model_Khach_Hang>();
            var list_kh_search = entity_khachhang.GetListSearch(ma, ten, sdt, diachi);
            foreach (var kh in list_kh_search)
            {
                var khachhang = new Model.Model_Khach_Hang();
                khachhang.MA_KH = kh.MA_KH;
                khachhang.NGAY_SINH = kh.NGAY_SINH;
                khachhang.SDT = kh.SDT;
                khachhang.TEN_KH = kh.TEN_KH;
                khachhang.Gioi_Tinh = kh.Gioi_Tinh;
                khachhang.DIA_CHI = kh.DIA_CHI;
                list_kh.Add(khachhang);
            }
            return list_kh;
        }
    }
}
