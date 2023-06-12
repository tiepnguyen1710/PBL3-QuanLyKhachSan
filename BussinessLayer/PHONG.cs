using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class PHONG
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_Phong> getAll()
        {
            return db.tb_Phong.ToList();
        }

        public objPHONG getItemFull(int id)
        {
            var _p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
            objPHONG phong = new objPHONG();
            phong.IDPHONG = _p.IDPHONG;
            phong.TENPHONG = _p.TENPHONG;
            phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
            //phong.DISABLED = bool.Parse(_p.DISABLED.ToString());
            phong.IDLOAIPHONG = _p.IDLOAIPHONG;
            phong.IDTANG = _p.IDTANG;
            var tang = db.tb_Tang.FirstOrDefault(t => t.IDTANG == _p.IDTANG);
            phong.TENTANG = tang.TENTANG;
            var lp = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == _p.IDLOAIPHONG);
            phong.TENLOAIPHONG = lp.TENLOAIPHONG;
            phong.DONGIA = double.Parse(lp.DONGIA.ToString());
            return phong;

        }

        public List<objPHONG> getPhongTrongFull()
        {
            var lsPhong = db.tb_Phong.Where(x => x.TRANGTHAI == false).ToList();
            List<objPHONG> lsPhongOBJ = new List<objPHONG>();
            objPHONG phong;
            foreach (var _p in lsPhong)
            {
                phong = new objPHONG();
                phong.IDPHONG = _p.IDPHONG;
                phong.TENPHONG = _p.TENPHONG;
                phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
                //phong.DISABLED = bool.Parse(_p.DISABLED.ToString());
                phong.IDLOAIPHONG = _p.IDLOAIPHONG;
                phong.IDTANG = _p.IDTANG;
                var tang = db.tb_Tang.FirstOrDefault(t => t.IDTANG == _p.IDTANG);
                phong.TENTANG = tang.TENTANG;
                var lp = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == _p.IDLOAIPHONG);
                phong.TENLOAIPHONG = lp.TENLOAIPHONG;
                phong.DONGIA = double.Parse(lp.DONGIA.ToString());

                lsPhongOBJ.Add(phong);
            }

            return lsPhongOBJ;

        }

        public List<objPHONG> getList()
        {
            var lstPhong = db.tb_Phong.ToList();
            List<objPHONG> lstPhongFull = new List<objPHONG>();
            objPHONG objP;
            foreach(var item in lstPhong)
            {
                objP = new objPHONG();
                objP.IDPHONG = item.IDPHONG;
                objP.TRANGTHAI = item.TRANGTHAI;
                objP.TENPHONG = item.TENPHONG;
                objP.IDTANG = item.IDTANG;
                var t = db.tb_Tang.FirstOrDefault(x => x.IDTANG == item.IDTANG);
                objP.TENTANG = t.TENTANG;
                objP.IDLOAIPHONG = item.IDLOAIPHONG;
                var lp = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == item.IDLOAIPHONG);
                objP.TENLOAIPHONG = lp.TENLOAIPHONG;
                lstPhongFull.Add(objP);
            }
            return lstPhongFull;
        }

        public void updateStatus(int id, bool status)
        {
            tb_Phong p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
            p.TRANGTHAI = status;
            db.SaveChanges();

        }

        public List<tb_Phong> getByTang(int idTang)
        {
            return db.tb_Phong.Where(x => x.IDTANG == idTang).ToList();
        }

        public tb_Phong getItem(int idPhong)
        {
            return db.tb_Phong.FirstOrDefault(x =>  x.IDPHONG == idPhong);
        }

        public void add(tb_Phong phong)
        {
            try
            {
                db.tb_Phong.Add(phong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void update(tb_Phong phong)
        {
            tb_Phong _phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == phong.IDPHONG);
            _phong.TENPHONG = phong.TENPHONG;
            _phong.TRANGTHAI = phong.TRANGTHAI;
            _phong.IDTANG = phong.IDTANG;
            _phong.IDLOAIPHONG = phong.IDLOAIPHONG;
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
            tb_Phong _phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idPhong);
            if (_phong != null)
            {
                try
                {
                    db.tb_Phong.Remove(_phong);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra" + ex.Message);
                }
            }
        }

        public bool checkEmpty(int idPhong)
        {
            var p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idPhong);
            if (p.TRANGTHAI == true)
                return true;
            else
                return false;
        }
    }
}
