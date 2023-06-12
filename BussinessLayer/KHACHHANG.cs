using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class KHACHHANG
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<tb_KhachHang> getAll()
        {
            return db.tb_KhachHang.ToList();
        }

        public tb_KhachHang getItem(int idKhachHang)
        {
            return db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idKhachHang);
        }

        public void add(tb_KhachHang khachhang)
        {
            try
            {
                db.tb_KhachHang.Add(khachhang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void update(tb_KhachHang khachhang)
        {
            tb_KhachHang _khachhang = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == khachhang.IDKH);
            _khachhang.HOTEN = khachhang.HOTEN;
            _khachhang.CCCD = khachhang.CCCD;
            _khachhang.DIENTHOAI = khachhang.DIENTHOAI;
            _khachhang.EMAIL = khachhang.EMAIL;
            _khachhang.DIACHI = khachhang.DIACHI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.Message);
            }
        }

        public void delete(int idKhachHang)
        {
            tb_KhachHang _khachhang = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idKhachHang);
            if (_khachhang != null)
            {
                try
                {
                    db.tb_KhachHang.Remove(_khachhang);
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
