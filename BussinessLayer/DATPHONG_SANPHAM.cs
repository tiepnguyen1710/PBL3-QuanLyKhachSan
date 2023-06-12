﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class DATPHONG_SANPHAM
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public List<objDPSP> getAllByDatPhong(int idDP)
        {
            var lst = db.tb_DatPhong_SanPham.Where(x => x.IDDP == idDP).ToList();
            List<objDPSP> lstDPSP = new List<objDPSP>();
            objDPSP sp;
            foreach (var item in lst)
            {
                sp = new objDPSP();
                sp.IDDPSP = item.IDDPSP;
                sp.IDDP = item.IDDP;
                sp.IDPHONG = item.IDPHONG;
                var p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
                sp.TENPHONG = p.TENPHONG;
                sp.IDSP = item.IDSP;
                var s = db.tb_SanPham.FirstOrDefault(x => x.IDSP == item.IDSP);
                sp.TENSP = s.TENSP;
                sp.SOLUONG = item.SOLUONG;
                sp.DONGIA = item.DONGIA;
                sp.THANHTIEN = item.THANHTIEN;
                
                lstDPSP.Add(sp);
            }
            return lstDPSP;
        }
        public List<tb_DatPhong_SanPham> getAllByPhong(int idDP, int idDPCT)
        {
            return db.tb_DatPhong_SanPham.Where(x => x.IDDP == idDP && x.IDDPCT == idDPCT).ToList();
        }
        public void add(tb_DatPhong_SanPham dpsp)
        {
            try
            {
                db.tb_DatPhong_SanPham.Add(dpsp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dứ liệu" + ex.Message);
            }
        }
        public void update(tb_DatPhong_SanPham dpsp)
        {
            tb_DatPhong_SanPham sp = db.tb_DatPhong_SanPham.FirstOrDefault(x => x.IDDPSP == dpsp.IDDPSP);
            sp.IDDP = dpsp.IDDP;
            sp.IDPHONG = dpsp.IDPHONG;
            sp.SOLUONG = dpsp.SOLUONG;
            sp.NGAY = dpsp.NGAY;
            sp.DONGIA = dpsp.DONGIA;
            sp.THANHTIEN = dpsp.THANHTIEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deleteAll(int idDP)
        {
            List<tb_DatPhong_SanPham> lstSP = db.tb_DatPhong_SanPham.Where(x => x.IDDP == idDP).ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(lstSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dứ liệu" + ex.Message);
            }
        }
        public void deleteAllByPhong(int idDP, int _idPhong)
        {
            List<tb_DatPhong_SanPham> lstSP = db.tb_DatPhong_SanPham.Where(x => x.IDDP == idDP && x.IDPHONG == _idPhong).ToList();
            try
            {
                db.tb_DatPhong_SanPham.RemoveRange(lstSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dứ liệu" + ex.Message);
            }
        }
    }
}
