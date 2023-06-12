using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class THIETBI
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_ThietBi> getAll()
        {
            return db.tb_ThietBi.ToList();
        }

        public tb_ThietBi getItem(int idThietBi)
        {
            return db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idThietBi);
        }

        public void add(tb_ThietBi thietbi)
        {
            try
            {
                db.tb_ThietBi.Add(thietbi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void update(tb_ThietBi thietbi)
        {
            tb_ThietBi _thietbi = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == thietbi.IDTB);
            _thietbi.TENTB = thietbi.TENTB;
            _thietbi.DONGIA = thietbi.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void delete(int idThietBi)
        {
            tb_ThietBi _thietbi = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idThietBi);
            if (_thietbi != null)
            {
                try
                {
                    db.tb_ThietBi.Remove(_thietbi);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra" + ex.Message);
                }
            }
        }
    }
}
