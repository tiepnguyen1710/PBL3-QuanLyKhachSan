using BussinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmDatPhongDon : DevExpress.XtraEditors.XtraForm
    {
        public bool _them;
        public int _idPhong;
        int _idDP = 0;
        DATPHONG _datphong;
        DATPHONG_CHITIET _datphongct;
        DATPHONG_SANPHAM _datphongsp;
        objPHONG _phongHienTai;
        PHONG _phong;
        KHACHHANG _khachhang;
        SANPHAM _sanpham;
        List<objDPSP> lstDPSP;
        double _tongtien = 0;
        string _macty;
        string _madvi;
        SYS_PARAM _param;
        MainView objMain = (MainView)Application.OpenForms["MainView"];
        public frmDatPhongDon()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (searchKH.EditValue == null || searchKH.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            saveData();
            _tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phong.getItemFull(_idPhong).DONGIA * (dtNgayTra.Value.Day - dtNgayDat.Value.Day);
            var dp = _datphong.getItem(_idDP);
            dp.SOTIEN = _tongtien;
            _datphong.update(dp);
            objMain.gControl.Gallery.Groups.Clear();
            objMain.showRoom();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!_them)
            {
                saveData();
                _tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phong.getItemFull(_idPhong).DONGIA * (dtNgayTra.Value.Day - dtNgayDat.Value.Day);
                var dp = _datphong.getItem(_idDP);
                dp.SOTIEN = _tongtien;
                _datphong.update(dp);
                _datphong.updateStatus(_idDP);
                _phong.updateStatus(_idPhong, false);
                //XuatReport("PHIEU_DATPHONG_DON", "Chi tiết đặt phòng");
                cboTrangThai.SelectedValue = true;
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
            }
            /*else
            {
                XuatReport("PHIEU_DATPHONG_DON", "Chi tiết đặt phòng");
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmDatPhongDon_Load(object sender, EventArgs e)
        {
            _datphong = new DATPHONG();
            _datphongsp = new DATPHONG_SANPHAM();
            _datphongct = new DATPHONG_CHITIET();
            _phong = new PHONG();
            _phongHienTai = _phong.getItemFull(_idPhong);
            _khachhang = new KHACHHANG();
            _sanpham = new SANPHAM();
            lstDPSP = new List<objDPSP>();
            _param = new SYS_PARAM();
            var _pr = _param.getParam();
            _macty = _pr.MACTY;
            _madvi = _pr.MADVI;
            lblPhong.Text = _phongHienTai.TENPHONG + " - Đơn giá: " + _phongHienTai.DONGIA.ToString("N0") + " VNĐ";


            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);

            cboTrangThai.DataSource = TRANGTHAI.getList();
            cboTrangThai.ValueMember = "_value";
            cboTrangThai.DisplayMember = "_display";
            spSoNguoi.Text = "1";

            loadKH();
            loadSP();

            var dpct = _datphongct.getIDDPByPhong(_idPhong);
            if (!_them && dpct != null)
            {
                _idDP = dpct.IDDP;
                var dp = _datphong.getItem(_idDP);
                searchKH.EditValue = dp.IDKH;
                dtNgayDat.Value = dp.NGAYDATPHONG.Value;
                if (dp.NGAYDATPHONG.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    dtNgayTra.Value = dp.NGAYDATPHONG.Value.AddDays(1);
                else
                    dtNgayTra.Value = DateTime.Now;
                if (dp.STATUS == true)
                    btnPrint.Enabled = false;
                else
                    btnPrint.Enabled = true;
                cboTrangThai.SelectedValue = dp.STATUS;
                spSoNguoi.Text = dp.SONGUOIO.ToString();
                txtGhiChu.Text = dp.GHICHU.ToString();
                txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");

            }

            loadSPDV();

        }

        void loadSPDV()
        {
            gcSPDV.DataSource = _datphongsp.getAllByDatPhong(_idDP);
            lstDPSP = _datphongsp.getAllByDatPhong(_idDP);
        }

        public void loadKH()
        {
            _khachhang = new KHACHHANG();
            searchKH.Properties.DataSource = _khachhang.getAll();
            searchKH.Properties.ValueMember = "IDKH";
            searchKH.Properties.DisplayMember = "HOTEN";
        }

        void loadSP()
        {
            gcSanPham.DataSource = _sanpham.getAll();
            gvSanPham.OptionsBehavior.Editable = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.kh_dp = "datphongdon";
            frm.ShowDialog();
        }

        public void setKH(int idKH)
        {
            searchKH.EditValue = idKH;
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (_idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (bool.Parse(cboTrangThai.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Phiếu đã hoàn tất không được chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSanPham.GetFocusedRowCellValue("IDSP") != null)
            {
                objDPSP sp = new objDPSP();
                sp.IDSP = int.Parse(gvSanPham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanPham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idPhong;
                sp.TENPHONG = _phongHienTai.TENPHONG;
                sp.DONGIA = float.Parse(gvSanPham.GetFocusedRowCellValue("DONGIA").ToString());
                sp.SOLUONG = 1;
                sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;
                foreach (var item in lstDPSP)
                {
                    if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadDPSP();
                        return;
                    }

                }
                lstDPSP.Add(sp);
            }
            loadDPSP();
            txtThanhTien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) 
                + _phongHienTai.DONGIA * (dtNgayTra.Value.Day - dtNgayDat.Value.Day)).ToString("N0");
        }

        void loadDPSP()
        {
            List<objDPSP> lsDP = new List<objDPSP>();
            foreach (var item in lstDPSP)
            {
                lsDP.Add(item);
            }
            gcSPDV.DataSource = lsDP;
        }

        private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "DONGIA").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", sl * gia);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }
            }
            gvSPDV.UpdateTotalSummary();
            txtThanhTien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString())
                + _phongHienTai.DONGIA * (dtNgayTra.Value.Day - dtNgayDat.Value.Day)).ToString("N0");
            //txtThanhTien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + (double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day)).ToString("N0");
        }

        private void gvSPDV_HiddenEditor(object sender, EventArgs e)
        {
            gvSPDV.UpdateCurrentRow();
        }

        void saveData()
        {
            if (_them)
            {
                tb_DatPhong dp = new tb_DatPhong();
                tb_DatPhong_CT dpct;
                tb_DatPhong_SanPham dpsp;
                dp.NGAYDATPHONG = dtNgayDat.Value;
                dp.NGAYTRAPHONG = dtNgayTra.Value;
                dp.SONGUOIO = int.Parse(spSoNguoi.EditValue.ToString());
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.THEODOAN = false;
                dp.IDKH = int.Parse(searchKH.EditValue.ToString());
                dp.SOTIEN = double.Parse(txtThanhTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.DISABLED = false;
                dp.IDUSER = 1;
                dp.MACTY = _macty;
                dp.MADVI = _madvi;
                dp.CREATE_DATE = DateTime.Now;
                var _dp = _datphong.add(dp);
                _idDP = _dp.IDDP;

                dpct = new tb_DatPhong_CT();
                dpct.IDDP = _dp.IDDP;
                dpct.IDPHONG = _idPhong;
                dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                dpct.DONGIA = int.Parse(_phongHienTai.DONGIA.ToString());
                dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                dpct.NGAY = DateTime.Now;
                var _dpct = _datphongct.add(dpct);
                _phong.updateStatus(dpct.IDPHONG, true);
                if (gvSPDV.RowCount > 0)
                {
                    for (int j = 0; j < gvSPDV.RowCount; j++)
                    {
                        if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                        {
                            dpsp = new tb_DatPhong_SanPham();
                            dpsp.IDDP = _dp.IDDP;
                            dpsp.IDDPCT = _dpct.IDDPCT;
                            dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                            dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                            dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                            dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                            dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                            _datphongsp.add(dpsp);
                        }
                        else
                        {
                            dpsp = new tb_DatPhong_SanPham();
                            dpsp.IDDP = _dp.IDDP;
                            dpsp.IDDPCT = _dpct.IDDPCT;
                            dpsp.IDPHONG = dpct.IDPHONG;
                            _datphongsp.add(dpsp);
                        }
                    }
                }
                else
                {
                    dpsp = new tb_DatPhong_SanPham();
                    dpsp.IDDP = _dp.IDDP;
                    dpsp.IDDPCT = _dpct.IDDPCT;
                    dpsp.IDPHONG = dpct.IDPHONG;
                    _datphongsp.add(dpsp);
                }

            }
            else
            {
                //update  
                tb_DatPhong dp = _datphong.getItem(_idDP);
                tb_DatPhong_CT dpct;
                tb_DatPhong_SanPham dpsp;
                dp.NGAYDATPHONG = dtNgayDat.Value;
                dp.NGAYTRAPHONG = dtNgayTra.Value;
                dp.SONGUOIO = int.Parse(spSoNguoi.EditValue.ToString());
                dp.STATUS = bool.Parse(cboTrangThai.SelectedValue.ToString());
                dp.IDKH = int.Parse(searchKH.EditValue.ToString());
                dp.SOTIEN = double.Parse(txtThanhTien.Text);
                dp.GHICHU = txtGhiChu.Text;
                dp.IDUSER = 1;
                dp.UPDATE_BY = 1;
                dp.UPDATE_DATE = DateTime.Now;
                var _dp = _datphong.update(dp);
                _idDP = _dp.IDDP;
                _datphongsp.deleteAll(_dp.IDDP);
                _datphongct.deleteAll(_dp.IDDP);
                

                dpct = new tb_DatPhong_CT();
                dpct.IDDP = _dp.IDDP;
                dpct.IDPHONG = _idPhong;
                dpct.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                dpct.DONGIA = int.Parse(_phongHienTai.DONGIA.ToString());
                dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                dpct.NGAY = DateTime.Now;
                var _dpct = _datphongct.add(dpct);
                _phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);
                if (gvSPDV.RowCount > 0)
                {
                    for (int j = 0; j < gvSPDV.RowCount; j++)
                    {
                        if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                        {
                            dpsp = new tb_DatPhong_SanPham();
                            dpsp.IDDP = _dp.IDDP;
                            dpsp.IDDPCT = _dpct.IDDPCT;
                            dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                            dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
                            dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                            dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
                            dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
                            _datphongsp.add(dpsp);
                        }
                        else
                        {
                            dpsp = new tb_DatPhong_SanPham();
                            dpsp.IDDP = _dp.IDDP;
                            dpsp.IDDPCT = _dpct.IDDPCT;
                            dpsp.IDPHONG = dpct.IDPHONG;
                            _datphongsp.add(dpsp);
                        }
                    }
                }
                else
                {
                    dpsp = new tb_DatPhong_SanPham();
                    dpsp.IDDP = _dp.IDDP;
                    dpsp.IDDPCT = _dpct.IDDPCT;
                    dpsp.IDPHONG = dpct.IDPHONG;
                    _datphongsp.add(dpsp);
                }
            }
        }

        
    }
}