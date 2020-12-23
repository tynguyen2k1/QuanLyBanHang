using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityCTHD
    {
        public bool InsertCTHD(CT_HOA_DON cthd)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    db.CT_HOA_DON.Add(cthd);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
