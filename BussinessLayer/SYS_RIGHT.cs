using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class SYS_RIGHT
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public tb_SYS_RIGHT getRight(int idUser, string func_code)
        {
            return db.tb_SYS_RIGHT.FirstOrDefault(x => x.IDUSER == idUser && x.FUNC_CODE == func_code);
        }
        public void update(int idUser, string func_code, int right)
        {
            tb_SYS_RIGHT sRigh = db.tb_SYS_RIGHT.FirstOrDefault(x => x.IDUSER == idUser && x.FUNC_CODE == func_code);
            try
            {
                sRigh.USER_RIGHT = right;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
