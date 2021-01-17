using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class QL_NhanVien
    {
        public List<Model.Model_Nhan_Vien> GetListNhanVien()
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            var list_nv = new List<Model.Model_Nhan_Vien>();
            var list = entityNhanVien.GetListNhanVien();
            foreach(var item in list)
            {
                var nv = new Model.Model_Nhan_Vien();
                nv.MA_NV = item.MA_NV;
                nv.TEN_NV = item.TEN_NV;
                nv.NGAY_VL = item.NGAY_VL;
                nv.SDT = item.SDT;
                nv.TRANG_THAI = item.TRANG_THAI;
                nv.TAI_KHOAN = item.TAI_KHOAN;
                nv.GIOI_TINH = item.GIOI_TINH;
                nv.MAT_KHAU = item.MAT_KHAU;
                nv.DIA_CHI = item.DIA_CHI;
                nv.CHUC_VU = item.CHUC_VU;
                nv.EMAIL = item.EMAIL;
                list_nv.Add(nv);

            }
            return list_nv;
        }
        
        public bool Insert_Nhan_Vien(string ma , string ten , string diachi, string email , bool gt , string sdt , DateTime nvl , string tk ,string mk , byte chucvu)
        {
            string phone = sdt.Replace("-", "");
            phone = phone.Replace(" ", "");
            phone = phone.Replace("+84", "0");
            phone = phone.Replace(".", "");
            NHAN_VIEN nv = new NHAN_VIEN();
            nv.MA_NV = ma;
            nv.TEN_NV = ten;
            nv.DIA_CHI = diachi;
            nv.EMAIL = email;
            nv.GIOI_TINH = gt;
            nv.SDT = phone;
            nv.NGAY_VL = nvl;
            nv.TAI_KHOAN = tk;
            nv.MAT_KHAU = mk;
            nv.CHUC_VU = chucvu;
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            if (entityNhanVien.Insert_Nhan_Vien(nv))
            {
                MessageBox.Show("Chèn thành công !!!");
                return true;
            }
            else
            {
                MessageBox.Show("Error : Không thể chèn nhân viên !!!");
                return false;
            }
        }
        public string returnMatKhau(string Ma)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            var nv = entityNhanVien.return_NhanVien_MA_NV(Ma);
            if (nv != null)
            {
                return nv.MAT_KHAU;
            }
            return "";
        }
        public byte return_ChucVu(string Ma)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            var nv = entityNhanVien.return_NhanVien_MA_NV(Ma);
            if (nv != null && nv.CHUC_VU!=null)
            {
                return (byte)nv.CHUC_VU;
            }
            return 0;
        }
        public void DeleteNhanVien(string ma)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            if (entityNhanVien.DeleteNhanVien( ma))
            {
                MessageBox.Show("Xoá thành công nhân viên ");
            }
            else
            {
                MessageBox.Show("Error : Không thể xoá nhân viên !!!");
            }
        }
        public bool Edit_Nhan_Vien(string ma, string ten, string diachi, string email, bool gt, string sdt, DateTime nvl, string tk, string mk, byte chucvu)
        {
            string phone = sdt.Replace("-", "");
            phone = phone.Replace(" ", "");
            phone = phone.Replace("+84", "0");
            phone = phone.Replace(".", "");
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            if (entityNhanVien.check_sdt_update(ma, phone))
            {
                MessageBox.Show("Số điện thoại đã tồn tại !!!");
                return false;
            }
            NHAN_VIEN nv = new NHAN_VIEN();
            nv.MA_NV = ma;
            nv.TEN_NV = ten;
            nv.DIA_CHI = diachi;
            nv.EMAIL = email;
            nv.GIOI_TINH = gt;
            nv.SDT = phone;
            nv.NGAY_VL = nvl;
            nv.TAI_KHOAN = tk;
            nv.MAT_KHAU = mk;
            nv.CHUC_VU = chucvu;
            if (entityNhanVien.EditNhanVien(nv))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error : Không thể sửa nhân viên !!!");
                return false;
            }
        }

        public List<Model.Model_Nhan_Vien> Search_Nhan_Vien(string ma, string ten, string diachi, string email, string gt, string sdt, string nvl, string tk, string mk, string chucvu)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            var list_nv = new List<Model.Model_Nhan_Vien>();
            var list = entityNhanVien.Search_Nhan_Vien(ma, ten, diachi, email, gt, sdt, nvl, tk, mk, chucvu); ;
            foreach (var item in list)
            {
                var nv = new Model.Model_Nhan_Vien();
                nv.MA_NV = item.MA_NV;
                nv.TEN_NV = item.TEN_NV;
                nv.NGAY_VL = item.NGAY_VL;
                nv.SDT = item.SDT;
                nv.TRANG_THAI = item.TRANG_THAI;
                nv.TAI_KHOAN = item.TAI_KHOAN;
                nv.GIOI_TINH = item.GIOI_TINH;
                nv.MAT_KHAU = item.MAT_KHAU;
                nv.DIA_CHI = item.DIA_CHI;
                nv.CHUC_VU = item.CHUC_VU;
                nv.EMAIL = item.EMAIL;
                list_nv.Add(nv);

            }
            return list_nv;
        }

        public NHAN_VIEN returnNhanVien(string manv)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            return entityNhanVien.return_NhanVien_MA_NV(manv);
        }

        public Model.Model_Nhan_Vien return_Nhan_Vien_Ma_nv(string ma)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            var item =  entityNhanVien.return_NhanVien_MA_NV(ma);
            var nv = new Model.Model_Nhan_Vien();
            nv.MA_NV = item.MA_NV;
            nv.TEN_NV = item.TEN_NV;
            nv.NGAY_VL = item.NGAY_VL;
            nv.SDT = item.SDT;
            if(item.TRANG_THAI == 0)
            {
                nv.TRANG_THAI = "Đang làm";
            }else if (item.TRANG_THAI == 1)
            {
                nv.TRANG_THAI = "Nghỉ việc";
            }
            else
            {
                nv.TRANG_THAI = "Đã chặn !!!";
            }
            nv.TAI_KHOAN = item.TAI_KHOAN;
            nv.GIOI_TINH = (item.GIOI_TINH==false)?"Nam":"Nữ";
            nv.MAT_KHAU = item.MAT_KHAU;
            nv.DIA_CHI = item.DIA_CHI;
            nv.CHUC_VU = (item.CHUC_VU==0)? "Nhân Viên Bán Hàng": "Quản Lý";
            nv.EMAIL = item.EMAIL;
            return nv;
        }

        public bool Update_Information_Nhan_Vien(string ma , string ten , string diachi , string mat_khau)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            return entityNhanVien.Update_Information_Nhan_Vien( ma,  ten,  diachi,  mat_khau);
        }

        public bool updateTrangThaiNhanVien(string manv , int val)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            
            return entityNhanVien.CheckUpdateTrangThaiNhanVien(manv , (byte)val);
        }
    }
}
