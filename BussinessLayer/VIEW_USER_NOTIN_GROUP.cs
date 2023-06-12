using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class VIEW_USER_NOTIN_GROUP
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<V_USER_NOTIN_GROUP> getUserNotInGroup(string madvi, string macty)
        {
            return db.V_USER_NOTIN_GROUP.Where(x => x.MADVI == madvi && x.MACTY == macty && x.ISGROUP == false && x.DISABLED == false).ToList();
        }
    }
}
