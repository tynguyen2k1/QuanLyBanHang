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
    public class QL_CTHD_NHAP
    {
        public void Load_CTHD_Nhap(DataGridView data, int ma_hd)
        {
            Entity_CTHD_NHAP entity_CTHD_NHAP = new Entity_CTHD_NHAP();
            data.DataSource = entity_CTHD_NHAP.GETALLCTHD_NHAP(ma_hd);
        }
        public void Insert_CTHD_Nhap(CT_HOA_DON_NHAP cthd)
        {
            Entity_CTHD_NHAP entity_CTHD_NHAP = new Entity_CTHD_NHAP();
            entity_CTHD_NHAP.Insert_CTHD_Nhap(cthd);

        }


    }
}
