using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class LOAIPHONG
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_LoaiPhong> getAll()
        {
            return db.tb_LoaiPhong.ToList();
        }

        public tb_LoaiPhong getItem(int idLoaiPhong)
        {
            return db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idLoaiPhong);
        }

        public void add(tb_LoaiPhong loaiphong)
        {
            try
            {
                db.tb_LoaiPhong.Add(loaiphong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra " + ex.Message);
            }
        }

        public void update(tb_LoaiPhong loaiphong)
        {
            tb_LoaiPhong _loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == loaiphong.IDLOAIPHONG);
            _loaiphong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
            _loaiphong.DONGIA = loaiphong.DONGIA;
            _loaiphong.SONGUOI = loaiphong.SOGIUONG;
            _loaiphong.SONGUOI = loaiphong.SONGUOI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void delete(int idLoaiPhong)
        {
            tb_LoaiPhong _loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idLoaiPhong);
            if (_loaiphong != null)
            {
                try
                {
                    db.tb_LoaiPhong.Remove(_loaiphong);
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
