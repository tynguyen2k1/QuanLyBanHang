using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityHoaDon
    {
        public HOA_DON InsertHoaDon(HOA_DON hd)
        {
            try
            {
                using (var db = new QL_BAN_HANG())
                {
                    HOA_DON a = db.HOA_DON.Add(hd);
                    db.SaveChanges();
                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
