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
        public void Hien_Thi( DataGridView dataGridView)
        {
            dataGridView.DataSource = dm.GetListDanhMuc();
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
            DANH_MUC danhmuc = new DANH_MUC(a, b, c);
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
            DANH_MUC danhmuc = new DANH_MUC(Ma_Dm , Ten , mota);
            return dm.EditDanhMuc(danhmuc);
        }

        public bool DeleteData(string Ma_Dm )
        {
            return dm.DeleteDanhMuc(Ma_Dm);
        }

        public void TimKiemMaDM(string str , DataGridView gridView)
        {
            gridView.DataSource = dm.SearchMaDM(str);
        }
        public void TimKiemTenDM(string str, DataGridView gridView)
        {
            gridView.DataSource = dm.SearchTen(str);
        }
    }
}
