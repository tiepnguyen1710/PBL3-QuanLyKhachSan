using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class PHONGTHIETBI
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_Phong_ThietBi> getAll()
        {
            return db.tb_Phong_ThietBi.ToList();
        }

        public tb_Phong_ThietBi getItem(int idPhong)
        {
            return db.tb_Phong_ThietBi.FirstOrDefault(x => x.IDPHONG == idPhong);
        }

        public List<objPhongThietBi> getList()
        {
            var lstPhongTB = db.tb_Phong_ThietBi.ToList();
            List<objPhongThietBi> lstPhongTBFull = new List<objPhongThietBi>();
            objPhongThietBi objPTB;
            foreach(var item in lstPhongTB)
            {
                objPTB = new objPhongThietBi();
                objPTB.IDPHONG = item.IDPHONG;
                var p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
                objPTB.TENPHONG = p.TENPHONG;
                objPTB.IDTB = item.IDTB;
                var tb = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == item.IDTB);
                objPTB.TENTB = tb.TENTB;
                objPTB.SOLUONG = item.SOLUONG;
                lstPhongTBFull.Add(objPTB);
            }
            return lstPhongTBFull;
        }

        public void add(tb_Phong_ThietBi phongtb)
        {
            try
            {
                db.tb_Phong_ThietBi.Add(phongtb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void update(tb_Phong_ThietBi phongtb)
        {
            tb_Phong_ThietBi _phongtb = db.tb_Phong_ThietBi.FirstOrDefault(x => x.IDPHONG == phongtb.IDPHONG);
            
            _phongtb.IDPHONG = phongtb.IDPHONG;
            _phongtb.IDTB = phongtb.IDTB;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void delete(int idPhong)
        {
            tb_Phong_ThietBi _phongtb = db.tb_Phong_ThietBi.FirstOrDefault(x => x.IDPHONG == idPhong);
            if (_phongtb != null)
            {
                try
                {
                    db.tb_Phong_ThietBi.Remove(_phongtb);
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
