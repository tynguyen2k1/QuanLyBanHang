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
        string ma_nv { set; get; }
        public QL_HoaDon(string ma)
        {
            this.ma_nv = ma;
        }
        public QL_HoaDon()
        {
        }
       
        
        public List<Model.Model_Hoa_Don> GetListHoaDon()
        {
            var list = hoadon.GetDanhSachHoaDon(this.ma_nv);
            var list_hd = new List<Model.Model_Hoa_Don>();
            foreach (var hd in list)
            {
                Model.Model_Hoa_Don model_Hoa_Don = new Model.Model_Hoa_Don();
                model_Hoa_Don.MA_HD = hd.MA_HD;
                model_Hoa_Don.TEN_KH = hd.TEN_KH;
                model_Hoa_Don.NGAY_BAN = hd.NGAY_BAN;
                model_Hoa_Don.TONG_TIEN = hd.TONG_TIEN;
                model_Hoa_Don.MA_KH = hd.MA_KH;
                model_Hoa_Don.MA_NV = hd.MA_NV;
                list_hd.Add(model_Hoa_Don);
            }
            return list_hd;
        }
        public void Update_sl_mua_sp(string ma_sp , int sl)
        {
            EntitySanPham entity = new EntitySanPham();
            entity.Update_Sl_sp(ma_sp, -sl);
        }
        public List<Model.Model_Hoa_Don> GetListHoaDonLoc(DateTime start, DateTime end)
        {
            var list = hoadon.getAllHoaDon_Start_End(this.ma_nv, start, end);
            var list_hd =new List<Model.Model_Hoa_Don>();
            foreach (var hd in list)
            {
                Model.Model_Hoa_Don model_Hoa_Don = new Model.Model_Hoa_Don();
                model_Hoa_Don.MA_HD = hd.MA_HD;
                model_Hoa_Don.TEN_KH = hd.TEN_KH;
                model_Hoa_Don.NGAY_BAN = hd.NGAY_BAN;
                model_Hoa_Don.TONG_TIEN = hd.TONG_TIEN;
                model_Hoa_Don.MA_KH = hd.MA_KH;
                model_Hoa_Don.MA_NV = hd.MA_NV;
                list_hd.Add(model_Hoa_Don);
            }
            return list_hd;
        }
        public bool TaoHoaDon(DataTable data ,string TEN_KH,string SDT,string DIA_CHI,bool GIOI_TINH,DateTime NGAY_SINH , double tong , string ma_nv)
        {
            if (data.Rows.Count > 0)
            {
                KHACH_HANG khach = khachhang.GetKhachHang_Phone(SDT);
                if (khach == null)
                {
                    KHACH_HANG kh = new KHACH_HANG();
                    kh.TEN_KH = TEN_KH;
                    kh.SDT = SDT;
                    kh.NGAY_SINH = NGAY_SINH;
                    kh.GIOI_TINH = GIOI_TINH;
                    kh.DIA_CHI = DIA_CHI;
                    khach = khachhang.Insert(kh);
                }

                HOA_DON hd = new HOA_DON();
                hd.MA_KH = khach.MA_KH;
                hd.MA_NV = ma_nv;
                hd.TONG_TIEN = tong;
                hd.NGAY_BAN = DateTime.Now;
                var hoaDon = hoadon.InsertHoaDon(hd);

                if (hoaDon == null)
                {
                    return false;
                }
                foreach (DataRow row in data.Rows)
                {

                    CT_HOA_DON cthd = new CT_HOA_DON();
                    cthd.MA_SP = row["Ma_SP"].ToString();
                    cthd.SO_LUONG = int.Parse(row["SL_Mua"].ToString());
                    cthd.GIA_BAN = double.Parse(row["Gia_Ban"].ToString());
                    cthd.GIAM_GIA = double.Parse(row["Giam_gia"].ToString());
                    cthd.THANH_TIEN = double.Parse(row["Tong"].ToString());
                    cthd.MA_HD = hd.MA_HD;
                    entitycthd.InsertCTHD(cthd);
                    this.Update_sl_mua_sp(cthd.MA_SP, cthd.SO_LUONG);
                }
                inHoaDon(hd);

                return true;
            }
            else
            {
                MessageBox.Show("Error : Không thể tạo hoá đơn !!!");
                return false;
            }
        }
        public bool ghifileTXT(int ma_sp)
        {
            HOA_DON hd = hoadon.returnHoaDon(ma_sp);
            inhoadon.ghifileTXT(hd);
            return true;
        }
        public void inHoaDon(HOA_DON hd)
        {
            

            string message = "In hoá đơn !!!";
            string title = "Tạo Thành Công Hoá Đơn";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                InHoaDon inHoaDon = new InHoaDon();
                inHoaDon.ghifileTXT(hd);
                MessageBox.Show("In thành công !!!");
            }

            else
            {
                return;
            }
        }
     

        public void getALLChiTietHoaDon_MAHD(DataGridView data , int MaHD)
        {
            EntityCTHD ql_cthd = new EntityCTHD();
            data.DataSource = ql_cthd.GetAllCTHD_Ban(MaHD);
        }

        public List< Model.Model_Hoa_Don >Search_Hoa_Don(string hd)
        {
            var list_hd = new List<Model.Model_Hoa_Don>();
            var list = hoadon.Search_Hoa_Don(this.ma_nv, hd);
            foreach(var i in list)
            {
                var a = new Model.Model_Hoa_Don();
                a.MA_HD = i.MA_HD;
                a.MA_KH = i.MA_KH;
                a.TEN_KH = i.TEN_KH;
                a.TONG_TIEN = i.TONG_TIEN;
                a.NGAY_BAN = i.NGAY_BAN;
                a.MA_NV = i.MA_NV;
                list_hd.Add(a);
            }
            return list_hd;
        }

        public HOA_DON getHoaDon_MaHD(int hd)
        {
            return hoadon.returnHoaDon(hd);
        }
        public void setSL_SP_Sau_Khi_Xoa(int ma_hd)
        {
            EntitySanPham entitySanPham = new EntitySanPham();
            var list = entitycthd.getALLChiTietHoaDon(ma_hd);
            foreach(var a in list)
            {
                if (entitySanPham.checkIssetMa_SP(a.MA_SP))
                {
                    entitySanPham.Update_Sl_sp(a.MA_SP, a.SO_LUONG);
                }
                else
                {
                    continue;
                }
            }
        }

        

        public bool deleteHoaDon(int Ma_hd)
        {
            if (hoadon.returnHoaDon(Ma_hd)!= null)
            {
                setSL_SP_Sau_Khi_Xoa(Ma_hd);

                return hoadon.deleteHoaDon(Ma_hd);
            }
            else
            {
                
                return false;
            }
        }

        public bool checkquyen(NHAN_VIEN nv , int ma_hd)
        {
            var hd = hoadon.returnHoaDon(ma_hd);
            if (hd.MA_NV == nv.MA_NV)
            {
                return true;
            }
            else if(nv.CHUC_VU == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


       
    }
}
