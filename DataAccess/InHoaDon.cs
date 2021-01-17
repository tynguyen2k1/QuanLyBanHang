using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataAccess
{
    public class InHoaDon
    {

        
        public InHoaDon()
        {
        }
        public void ghifileTXT(HOA_DON hd)
        {
            EntityCTHD entityCTHD = new EntityCTHD();
            EntityKhachHang entityKhachHang = new EntityKhachHang();
            int ma = Convert.ToInt32(hd.MA_KH); ;
            KHACH_HANG khach_hang = entityKhachHang.GetKHACH_HANG_MAKH(ma);
            var list_Cthd = entityCTHD.GetAllCTHD_Ban(hd.MA_HD);
            string file = @"D:\Ma_Hoa_Don_Ban" + hd.MA_HD + ".txt";

            FileStream fs = new FileStream(file, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            StreamWriter ghifile = new StreamWriter(fs);
            string str = "";
            str += "\nCỬA HÀNG BÁN ....... ";
            str += "\n \t\t\t THÔNG TIN HOÁ ĐƠN : " +hd.MA_HD+ "  ( "+hd.NGAY_BAN+" )";

            str += "\n\tTên khách hàng : "+khach_hang.TEN_KH;
            str += "\n\tSố điện thoại : "+khach_hang.SDT;
            str += "\n\tMã hoá đơn : "+hd.MA_HD;
            str += "\n\tNgày mua : "+hd.NGAY_BAN;
            str += "\n\tTổng hoá đơn : "+hd.TONG_TIEN;
            str += "\n\tChữ : ";
            str += "\n\n                                                  THÔNG TIN HOÁ ĐƠN                                                    \n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "| STT | Mã Sản Phẩm |            Tên Sản Phẩm          | SL Mua |      Giá Bán        | Giảm(%) |       Tổng Tiền      |\n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            
            for(int i=0; i < list_Cthd.Count; i++)
            {
                str += String.Format("| {0,3} | {1,11} | {2,32} | {3,6} | {4,15} VNĐ | {5,7} | {4,16} VNĐ |\n", i+1, list_Cthd[i].MA_SP, list_Cthd[i].TEN_SP, list_Cthd[i].SO_LUONG, list_Cthd[i].GIA_BAN, list_Cthd[i].GIAM_GIA , list_Cthd[i].THANH_TIEN);
            }
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "|                                                                                       Tổng : 1230034324 VND          |\n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "\n\n\tMọi thắc mắc xin liên hệ với chúng tôi qua số điện thoạt : 0123456789";
            ghifile.WriteLine(str);
            ghifile.Flush();
            ghifile.Close();
            fs.Close();
        }
        public void ghifileTXT_Nhap(HOA_DON_NHAP hd)
        {
            Entity_CTHD_NHAP entityCTHD = new Entity_CTHD_NHAP();
            EntityNhanVien entityNhanVien = new EntityNhanVien();
            string ma = hd.MA_NV; 
            var nhan_vien = entityNhanVien.return_NhanVien_MA_NV(ma);
            var list_Cthd = entityCTHD.GETALLCTHD_NHAP(hd.MA_HD_NHAP);
            string file = @"D:\Ma_Hoa_Don_Nhap_" + hd.MA_HD_NHAP + ".txt";
            
            FileStream fs = new FileStream(file, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            StreamWriter ghifile = new StreamWriter(fs);
            string str = "";
            str += "\nCỬA HÀNG BÁN ....... ";
            str += "\n \t\t\t THÔNG TIN HOÁ ĐƠN NHẬP : " + hd.MA_HD_NHAP + "  ( " + hd.NGAY_NHAP + " )";
            str += "\n\tMã nhân viên : " + nhan_vien.MA_NV;
            str += "\n\tTên nhân viên : " + nhan_vien.TEN_NV;
            str += "\n\tSố điện thoại : " + nhan_vien.SDT;
            str += "\n\tMã hoá đơn nhập: " + hd.MA_HD_NHAP;
            str += "\n\tNgày nhập : " + hd.NGAY_NHAP;
            str += "\n\tTổng tiền hoá đơn : " + hd.TONG_TIEN + "VND";
            str += "\n\tChữ : ";
            str += "\n\n                                              THÔNG TIN HOÁ ĐƠN NHẬP                                                    \n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "| STT | Mã Sản Phẩm |            Tên Sản Phẩm          | SL Nhập |      Giá Nhập       | Giảm(%) |       Tổng Tiền     |\n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";

            for (int i = 0; i < list_Cthd.Count; i++)
            {
                str += String.Format("| {0,3} | {1,11} | {2,32} | {3,7} | {4,15} VNĐ | {5,7} | {4,15} VNĐ |\n", i + 1, list_Cthd[i].MA_SP, list_Cthd[i].TEN_SP, list_Cthd[i].SO_LUONG, list_Cthd[i].GIA_NHAP, list_Cthd[i].GIAM_GIA, list_Cthd[i].THANH_TIEN);
            }
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += String.Format("|                                                                                       Tổng : {0,12} VND        |\n",hd.TONG_TIEN);
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "\n\n\tMọi thắc mắc xin liên hệ với chúng tôi qua số điện thoạt : "+nhan_vien.SDT;
            ghifile.WriteLine(str);
            ghifile.Flush();
            ghifile.Close();
            fs.Close();
        }
    }
}
