using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class QL_DanhMuc
    {
        ValidateData validate = new ValidateData();
        Entity_DanhMuc dm = new Entity_DanhMuc();
       
        public List<Model.Model_Danh_Muc> Get_List_Danh_Muc_Ton_Tai()
        {
            var list_dm =new List<Model.Model_Danh_Muc>();
            var list = dm.GetListDanhMucTonTai();
            foreach(var danhmuc in list)
            {
                var val = new Model.Model_Danh_Muc();
                val.Ma_DM = danhmuc.Ma_DM;
                val.TEN_DM = danhmuc.TEN_DM;
                val.MO_TA = danhmuc.MO_TA;
                val.TRANG_THAI = danhmuc.TRANG_THAI;
                list_dm.Add(val);
            }
            return list_dm;
        }
        public List<Model.Model_Danh_Muc> Get_List_Danh_Muc_Da_Xoa()
        {
            var list_dm = new List<Model.Model_Danh_Muc>();
            var list = dm.GetListDanhMucXoa();
            foreach (var danhmuc in list)
            {
                var val = new Model.Model_Danh_Muc();
                val.Ma_DM = danhmuc.Ma_DM;
                val.TEN_DM = danhmuc.TEN_DM;
                val.MO_TA = danhmuc.MO_TA;
                val.TRANG_THAI = danhmuc.TRANG_THAI;
                list_dm.Add(val);
            }
            return list_dm;
        }
        
        public string InsertData(string a,string b, string c)
        {
            string error_1 = validate.validate_danh_muc_ma_sp(a);
            string error_2 = validate.validate_ten_danh_muc(b);
            string error_3 = validate.validate_mo_ta_danh_muc(c);
            if (error_1 != "")
            {
                return error_1;
            }else if(error_2!=""){
                return error_2;
            }
            else if (error_3 != "")
            {
                return error_3;
            }
            DANH_MUC danhmuc = new DANH_MUC();
            danhmuc.Ma_DM = a;
            danhmuc.TEN_DM = b;
            danhmuc.MO_TA = c;
            if (dm.InsertDanhMuc(danhmuc))
            {
                return "";
            }
            else
            {
                return "Error";
            }
        }
        public bool EditData(string Ma_Dm ,string Ten , string mota)
        {
            DANH_MUC danhmuc = new DANH_MUC();
            danhmuc.Ma_DM = Ma_Dm;
            danhmuc.TEN_DM = Ten;
            danhmuc.MO_TA = mota;
            return dm.EditDanhMuc(danhmuc);
        }

        public bool DeleteData(string Ma_Dm )
        {
            return dm.DeleteDanhMuc(Ma_Dm);
        }

        public List<Model.Model_Danh_Muc> Search_Danh_Muc_Ton_Tai(string a,string b,string c)
        {
            var list_dm = new List<Model.Model_Danh_Muc>();
            var list = dm.GetListSearchDanhTonTai(a,b,c);
            foreach (var danhmuc in list)
            {
                var val = new Model.Model_Danh_Muc();
                val.Ma_DM = danhmuc.Ma_DM;
                val.TEN_DM = danhmuc.TEN_DM;
                val.MO_TA = danhmuc.MO_TA;
                val.TRANG_THAI = danhmuc.TRANG_THAI;
                list_dm.Add(val);
            }
            return list_dm;
        }
        public List<Model.Model_Danh_Muc> Search_Danh_Muc_Da_Xoa(string a, string b, string c)
        {
            var list_dm = new List<Model.Model_Danh_Muc>();
            var list = dm.GetListSearchDanhDaXoa(a, b, c);
            foreach (var danhmuc in list)
            {
                var val = new Model.Model_Danh_Muc();
                val.Ma_DM = danhmuc.Ma_DM;
                val.TEN_DM = danhmuc.TEN_DM;
                val.MO_TA = danhmuc.MO_TA;
                val.TRANG_THAI = danhmuc.TRANG_THAI;
                list_dm.Add(val);
            }
            return list_dm;
        }
        public bool updateTrangThai(string ma, int val)
        {
            return dm.updateTrangThai(ma, (byte)val);
        }
    }
}
