using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class TANG
    {
        QLHOTELSEntities db = new QLHOTELSEntities();
        public List<tb_Tang> getAll()
        {
            return db.tb_Tang.ToList();
        }

        public tb_Tang getItem(int idTang)
        {
            return db.tb_Tang.FirstOrDefault(x => x.IDTANG == idTang);
        }

        public void add(tb_Tang tang)
        {
            try
            {
                db.tb_Tang.Add(tang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void update(tb_Tang tang)
        {
            tb_Tang _tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == tang.IDTANG);
            _tang.TENTANG = tang.TENTANG;
            _tang.DISABLED = tang.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void delete(int idTang)
        {
            tb_Tang _tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == idTang);
            _tang.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }
    }
}
