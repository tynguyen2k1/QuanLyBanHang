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
        public HOA_DON hoadon;
        public InHoaDon(HOA_DON hd)
        {
            this.hoadon = hd;
        }
        public void ghifileTXT()
        {
            string file = @"D:\hoadon\Ma_" + hoadon.MA_HD + ".txt";

            FileStream fs = new FileStream(file, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            StreamWriter ghifile = new StreamWriter(fs);
            string str = "";
            str += "\nCỬA HÀNG BÁN ....... ";
            str += "\n\tTên khách hàng : ";
            str += "\n\tSố điện thoại : ";
            str += "\n\tMã hoá đơn : ";
            str += "\n\tNgày mua : ";
            str += "\n\tTổng hoá đơn : ";
            str += "\n\tChữ : ";
            str += "\n\n                                                  THÔNG TIN HOÁ ĐƠN                                                    \n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "| STT | Mã Sản Phẩm |            Tên Sản Phẩm          | SL Mua |      Giá Bán        | Giảm(%) |       Tổng Tiền      |\n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += String.Format("| {0,3} | {1,11} | {2,32} | {3,6} | {4,15} VNĐ | {5,7} | {4,16} VNĐ |\n", 1, "QB000001", "Quần Bò", 10, 1200000, 10, 120000000);
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "|                                                                                       Tổng : 1230034324 VND          |\n";
            str += "+----------------------------------------------------------------------------------------------------------------------+\n";
            str += "\n\n\tMọi thắc mắc xin liên hệ với chúng tôi qua số điện thoạt : 0123456789";
            ghifile.WriteLine(str);
            ghifile.Flush();
            ghifile.Close();
            fs.Close();
        }
    }
}
