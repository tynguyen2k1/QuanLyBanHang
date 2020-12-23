using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class QL_HoaDon
    {
        InHoaDon inhoadon;
        EntityKhachHang khachhang = new EntityKhachHang();
        EntityHoaDon hoadon = new EntityHoaDon();
        EntityCTHD entitycthd = new EntityCTHD();
        public bool TaoHoaDon(DataTable data , KHACH_HANG kh ,double a)
        {
            if(data.Rows.Count > 0 && kh!= null)
            {
                KHACH_HANG khach = khachhang.GetKhachHang_Phone(kh.SDT);
                if(khach == null)
                {
                    khach = khachhang.Insert(kh);
                }
                double tong = a;

                HOA_DON hd = new HOA_DON(1, DateTime.Now, khach.MA_KH, tong);
                var hoaDon = hoadon.InsertHoaDon(hd);
                this.inhoadon = new InHoaDon(hoaDon);
                this.inhoadon.ghifileTXT();
                if (hoaDon == null)
                {
                    return false;
                }
                foreach (DataRow row in data.Rows)
                {
                    CT_HOA_DON cthd = new CT_HOA_DON(
                         row["Ma_SP"].ToString(),
                         int.Parse(row["SL_Mua"].ToString()),
                         double.Parse(row["Gia_Ban"].ToString()),
                         double.Parse(row["Giam_gia"].ToString()),
                         double.Parse(row["Tong"].ToString()),
                         hoaDon.MA_HD
                        ) ;
                    var b = entitycthd.InsertCTHD(cthd);

                }
                return true;
            }
            return false;
        }
    }
}
