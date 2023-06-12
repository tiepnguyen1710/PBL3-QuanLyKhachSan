using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class View_FUNC_SYS_RIGHT
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<V_FUNC_SYS_RIGHT> getFuncByUser(int idUser)
        {
            return db.V_FUNC_SYS_RIGHT.Where(x => x.IDUSER == idUser).OrderBy(x => x.SORT).ToList();
        }
    }
}
