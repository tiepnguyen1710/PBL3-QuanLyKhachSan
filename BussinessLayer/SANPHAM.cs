using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BussinessLayer
{
    public class SANPHAM
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_SanPham> getAll()
        {
            return db.tb_SanPham.ToList();
        }

        public tb_SanPham getItem(int idSanPham)
        {
            return db.tb_SanPham.FirstOrDefault(x => x.IDSP == idSanPham);
        }

        public void add(tb_SanPham sanpham)
        {
            try
            {
                db.tb_SanPham.Add(sanpham);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void update(tb_SanPham sanpham)
        {
            tb_SanPham _sanpham = db.tb_SanPham.FirstOrDefault(x => x.IDSP == sanpham.IDSP);
            _sanpham.TENSP = sanpham.TENSP;
            _sanpham.DONGIA = sanpham.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void delete(int idSanPham)
        {
            tb_SanPham _sanpham = db.tb_SanPham.FirstOrDefault(x => x.IDSP == idSanPham);
            if (_sanpham != null)
            {
                try
                {
                    db.tb_SanPham.Remove(_sanpham);
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
