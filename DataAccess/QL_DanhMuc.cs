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
        Entity_DanhMuc dm = new Entity_DanhMuc();
        public void Hien_Thi( DataGridView dataGridView)
        {
            dataGridView.DataSource = dm.GetListDanhMuc();
        }

        public void InsertData(string a,string b, string c)
        {
            if(a=="" || b=="" || c == "")
            {
                MessageBox.Show("Thông tin không được để chống");
            }
            else
            {
                DANH_MUC danhmuc = new DANH_MUC(a, b, c);
                if (dm.InsertDanhMuc(danhmuc))
                {
                    MessageBox.Show("Chèn Thành Công");
                }
                else
                {
                    MessageBox.Show("Error");
                }
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
        public void checkIssetMa_DM()
        {
            
        }
    }
}
