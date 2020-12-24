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

               /* HOA_DON hd = new HOA_DON(1, DateTime.Now, khach.MA_KH, tong);
                var hoaDon = hoadon.InsertHoaDon(hd);*/
                /*this.inhoadon = new InHoaDon(hoaDon);*/
                /*this.inhoadon.ghifileTXT();*/
                /*if (hoaDon == null)
                {
                    return false;
                }*/
                foreach (DataRow row in data.Rows)
                {
                    /*CT_HOA_DON cthd = new CT_HOA_DON(
                         row["Ma_SP"].ToString(),
                         int.Parse(row["SL_Mua"].ToString()),
                         double.Parse(row["Gia_Ban"].ToString()),
                         double.Parse(row["Giam_gia"].ToString()),
                         double.Parse(row["Tong"].ToString()),
                         16
                        ) ;*/

                    /*entitycthd.InsertCTHD(cthd);
                   */
                    CT_HOA_DON cthd = new CT_HOA_DON();
                    cthd.MA_SP = row["Ma_SP"].ToString();
                    cthd.SO_LUONG = int.Parse(row["SL_Mua"].ToString());
                    cthd.GIA_BAN = double.Parse(row["Gia_Ban"].ToString());
                    cthd.GIAM_GIA = double.Parse(row["Giam_gia"].ToString());
                    cthd.THANH_TIEN = double.Parse(row["Tong"].ToString());
                    cthd.MA_HD = 16;
                    entitycthd.InsertCTHD(cthd);
                }
                return true;
            }
            return false;
        }
        public void LoadDanhSachHoaDon(DataGridView data)
        {
           data.DataSource =  hoadon.GetDanhSachHoaDon();
            
        }
        public void getALLChiTietHoaDon_MAHD(DataGridView data , int MaHD)
        {
            EntityCTHD ql_cthd = new EntityCTHD();
            data.DataSource = ql_cthd.getALLChiTietHoaDon(MaHD);
        }
        public void getAllHoaDon_Start_End(DataGridView data , DateTime start , DateTime end)
        {
            data.DataSource = hoadon.getAllHoaDon_Start_End(start ,end);
        }
    }
}
