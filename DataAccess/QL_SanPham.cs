using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace DataAccess
{
    public class QL_SanPham
    {
        EntitySanPham QL_SP;
        public void HienThi (DataGridView view)
        {
            QL_SP = new EntitySanPham();
            view.DataSource = QL_SP.GetListSanPham();
        }
    }
}
