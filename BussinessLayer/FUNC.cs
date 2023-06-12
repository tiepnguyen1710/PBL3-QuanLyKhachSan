using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class FUNC
    {   
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_Func> getParent()
        {
            return db.tb_Func.Where(x => x.ISGROUP == true && x.MENU == true).OrderBy(x => x.SORT).ToList();
        }

        public List<tb_Func> getChild(string parent)
        {
            return db.tb_Func.Where(x => x.ISGROUP == false && x.MENU == true && x.PARENT == parent).OrderBy(x => x.SORT).ToList();
        }
    }
}
