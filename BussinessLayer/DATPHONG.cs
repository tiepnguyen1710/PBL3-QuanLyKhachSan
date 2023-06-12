using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class DATPHONG
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public tb_DatPhong getItem(int id)
        {
            return db.tb_DatPhong.FirstOrDefault(x => x.IDDP == id);
        }
        public List<tb_DatPhong> getAll()
        {
            return db.tb_DatPhong.ToList();
        }
        public List<objDatPhong> getAll(DateTime tungay, DateTime denngay, string macty, string madvi)
        {
            var listDP = db.tb_DatPhong.Where(x => x.NGAYDATPHONG >= tungay && x.NGAYDATPHONG < denngay && x.MACTY == macty && x.MADVI == madvi).ToList();
            List<objDatPhong> lstDP = new List<objDatPhong>();
            objDatPhong dp;
            foreach (var item in listDP)
            {
                dp = new objDatPhong();
                dp.IDDP = item.IDDP;
                dp.IDKH = item.IDKH;
                var kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == item.IDKH);
                dp.HOTEN = kh.HOTEN;
                dp.IDUSER = item.IDUSER;
                dp.NGAYDATPHONG = item.NGAYDATPHONG;
                dp.NGAYTRAPHONG = item.NGAYTRAPHONG;
                dp.MACTY = item.MACTY;
                dp.MADVI = item.MADVI;
                dp.SONGUOIO = item.SONGUOIO;
                dp.SOTIEN = item.SOTIEN;
                dp.STATUS = item.STATUS;
                dp.THEODOAN = item.THEODOAN;
                dp.DISABLED = item.DISABLED;
                dp.GHICHU = item.GHICHU;
                lstDP.Add(dp);
            }
            return lstDP;
        }
        public tb_DatPhong add(tb_DatPhong _dp)
        {
            try
            {
                db.tb_DatPhong.Add(_dp);
                db.SaveChanges();
                return _dp;
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public void updateStatus(int idDP)
        {
            tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == idDP);
            dp.STATUS = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public tb_DatPhong update(tb_DatPhong _dp)
        {
            tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == _dp.IDDP);
            dp.IDKH = _dp.IDKH;
            dp.MACTY = _dp.MACTY;
            dp.MADVI = _dp.MADVI;
            dp.NGAYDATPHONG = _dp.NGAYDATPHONG;
            dp.NGAYTRAPHONG = _dp.NGAYTRAPHONG;
            dp.SONGUOIO = _dp.SONGUOIO;
            dp.SOTIEN = _dp.SOTIEN;
            dp.IDUSER = _dp.IDUSER;
            dp.DISABLED = _dp.DISABLED;
            dp.THEODOAN = _dp.THEODOAN;
            dp.GHICHU = _dp.GHICHU;
            dp.CREATE_DATE = _dp.CREATE_DATE;

            try
            {
                db.SaveChanges();
                return dp;
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public void delete(int _id)
        {
            tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == _id);
            dp.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
    }
}
