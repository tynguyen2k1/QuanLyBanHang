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
        public void GetListNhanVien(DataGridView data)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            data.DataSource = entityNhanVien.GetListNhanVien();
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
        public void Search_Nhan_Vien(DataGridView data, string ma, string ten, string diachi, string email, string gt, string sdt, string nvl, string tk, string mk, string chucvu)
        {
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            data.DataSource = entityNhanVien.Search_Nhan_Vien(ma,  ten,  diachi,  email,  gt,  sdt,  nvl,  tk,  mk,  chucvu);
        }
    }
}
