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
    public class QL_HOA_DON_NHAP
    {

        public List<Model.Model_Hoa_Don_Nhap> GetListHoaDonNhap(string manv)
        {
            EntityHoaDonNhap entityHoaDonNhap = new EntityHoaDonNhap();
            List<Model.Model_Hoa_Don_Nhap> list = new List<Model.Model_Hoa_Don_Nhap>();
            var listhdn = entityHoaDonNhap.GETALLHOADONNHAP(manv);
            foreach (var hdn in listhdn)
            {
                var hd = new Model.Model_Hoa_Don_Nhap();
                hd.MA_NV = hdn.MA_NV;
                hd.TEN_NV = hdn.TEN_NV;
                hd.NGAY_NHAP = hdn.NGAY_NHAP;
                hd.TONG_TIEN = hdn.TONG_TIEN;
                hd.MA_HD_NHAP = hdn.MA_HD_NHAP;
                list.Add(hd);
            }
            return list;
        }
        public List<Model.Model_Hoa_Don_Nhap> LocHoaDonNhap(string manv, DateTime start, DateTime end)
        {
            EntityHoaDonNhap entityHoaDonNhap = new EntityHoaDonNhap();
            List<Model.Model_Hoa_Don_Nhap> list = new List<Model.Model_Hoa_Don_Nhap>();
            var listhdn = entityHoaDonNhap.LOC_HOA_DON_NHAP(manv, start, end);
            foreach (var hdn in listhdn)
            {
                var hd = new Model.Model_Hoa_Don_Nhap();
                hd.MA_NV = hdn.MA_NV;
                hd.TEN_NV = hdn.TEN_NV;
                hd.NGAY_NHAP = hdn.NGAY_NHAP;
                hd.TONG_TIEN = hdn.TONG_TIEN;
                hd.MA_HD_NHAP = hdn.MA_HD_NHAP;
                list.Add(hd);
            }
            return list;
        }
        public List<Model.Model_Hoa_Don_Nhap> SearchHoaDonNhap(string manv, string ma_hd)
        {
            EntityHoaDonNhap entityHoaDonNhap = new EntityHoaDonNhap();
            List<Model.Model_Hoa_Don_Nhap> list = new List<Model.Model_Hoa_Don_Nhap>();
            var listhdn = entityHoaDonNhap.TimKiemHoaDon(ma_hd, manv);
            foreach (var hdn in listhdn)
            {
                var hd = new Model.Model_Hoa_Don_Nhap();
                hd.MA_NV = hdn.MA_NV;
                hd.TEN_NV = hdn.TEN_NV;
                hd.NGAY_NHAP = hdn.NGAY_NHAP;
                hd.TONG_TIEN = hdn.TONG_TIEN;
                hd.MA_HD_NHAP = hdn.MA_HD_NHAP;
                list.Add(hd);
            }
            return list;
        }
        public void Update_SL(int sl , string ma_sp)
        {
            EntitySanPham entitySanPham = new EntitySanPham();
            entitySanPham.Update_Sl_sp(ma_sp, sl);
        }
        public bool TaoHoaDonNhap(DataTable data, double tong, string ma_nv)
        {
            EntityHoaDonNhap entityHoaDonNhap = new EntityHoaDonNhap();
            Entity_CTHD_NHAP entity_CTHD_NHAP = new Entity_CTHD_NHAP();
            
            if (data.Rows.Count > 0)
            {
                HOA_DON_NHAP hd = new HOA_DON_NHAP();
                hd.MA_NV = ma_nv;
                hd.NGAY_NHAP = DateTime.Now;
                hd.TONG_TIEN = tong;
                var hdn = entityHoaDonNhap.Insert_HDN(hd);

                if (hdn == null)
                {
                    return false;
                }
                foreach (DataRow row in data.Rows)
                {
                    
                    CT_HOA_DON_NHAP cthd = new CT_HOA_DON_NHAP();
                    cthd.MA_SP = row["Ma_SP"].ToString();
                    cthd.SO_LUONG = int.Parse(row["SL_Nhap"].ToString());
                    cthd.GIA_NHAP = double.Parse(row["Gia_Nhap"].ToString());
                    cthd.GIAM_GIA = double.Parse(row["Giam_gia"].ToString());
                    cthd.THANH_TIEN = double.Parse(row["Tong"].ToString());
                    cthd.MA_HD_NHAP = hdn.MA_HD_NHAP;
                    entity_CTHD_NHAP.Insert_CTHD_Nhap(cthd);
                    Update_SL(cthd.SO_LUONG, cthd.MA_SP);
                }
                InHoaDon inHoaDon = new InHoaDon();
                string message = "Thêm Thành Công Hoá Đơn !!! \nBạn Có Muốn In Hoá Đơn Này !!!";
                string title = "In Hoá Đơn Nhập";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    inHoaDon.ghifileTXT_Nhap(hdn);
                }
                return true;
            }
            return false;
        }
        public bool DeleteHoaDonNhap(string ma)
        {
            EntityHoaDonNhap entityHoaDonNhap = new EntityHoaDonNhap();
            var Ct_hoa_don = new Entity_CTHD_NHAP();
            if (entityHoaDonNhap.kiem_tra_ma_hdn(int.Parse(ma)) == true)
            {
                var list = Ct_hoa_don.GETALLCTHD_NHAP(int.Parse(ma));
                if (list.Count > 0)
                {
                    EntitySanPham entitysp = new EntitySanPham();
                    foreach (var hd in list)
                    {
                        var sp = entitysp.ReturnSP_MaSP(hd.MA_SP);
                        if(sp.SO_LUONG < hd.SO_LUONG)
                        {
                           continue;
                        }
                        else
                        {
                            entitysp.Update_Sl_sp(hd.MA_SP, -hd.SO_LUONG);
                        }
                    }
                }
                return entityHoaDonNhap.Delete_HoaDon_Nhap(int.Parse(ma));   
            }
            else
            {
                return false;
            }
            
        }
        public bool inHoaDon(string ma)
        {
            EntityHoaDonNhap entityHoaDonNhap = new EntityHoaDonNhap();
            var hd = entityHoaDonNhap.ReturnHoaDon(int.Parse(ma));
            if (hd != null)
            {
                InHoaDon inHoaDon = new InHoaDon();
                try
                {
                    inHoaDon.ghifileTXT_Nhap(hd);
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
