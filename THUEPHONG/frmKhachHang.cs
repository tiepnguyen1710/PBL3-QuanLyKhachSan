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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KHACHHANG _khachhang;
        bool _them;
        int _idKH;
        public string kh_dp;
        frmDatPhong objDP = (frmDatPhong)Application.OpenForms["frmDatPhong"];
        frmDatPhongDon objDPDon = (frmDatPhongDon)Application.OpenForms["frmDatPhongDon"];

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KHACHHANG();
            loadData();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _khachhang.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void showHideControl(bool t)
        {
            btnAdd.Visible = t;
            btnEdit.Visible = t;
            btnDelete.Visible = t;
            btnExit.Visible = t;
            btnSave.Visible = !t;
            btnSkip.Visible = !t;
        }

        void _enable(bool t)
        {
            txtId.Enabled = t;
            txtName.Enabled = t;
            txtCCCD.Enabled = t;
            txtPhone.Enabled = t;
            txtEmail.Enabled = t;
            txtAddress.Enabled = t;
        }

        void _reset()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCCCD.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enable(true);
            _reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _them = false;
            _enable(true);
            showHideControl(false);
            txtId.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _khachhang.delete(_idKH);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_KhachHang khachhang = new tb_KhachHang();
                khachhang.IDKH = Convert.ToInt32(txtId.Text.ToString());
                khachhang.HOTEN = txtName.Text.ToString();
                khachhang.CCCD = txtCCCD.Text.ToString();
                khachhang.EMAIL = txtEmail.Text.ToString();
                khachhang.DIENTHOAI = txtPhone.Text.ToString();
                khachhang.DIACHI = txtAddress.Text.ToString();
                _khachhang.add(khachhang);
            }
            else
            {
                tb_KhachHang khachhang = _khachhang.getItem(_idKH);
                khachhang.HOTEN = txtName.Text.ToString();
                khachhang.CCCD = txtCCCD.Text.ToString();
                khachhang.EMAIL = txtEmail.Text.ToString();
                khachhang.DIENTHOAI = txtPhone.Text.ToString();
                khachhang.DIACHI = txtAddress.Text.ToString();
                _khachhang.update(khachhang);
            }
            _them = false;
            loadData();
            _enable(false);
            showHideControl(true);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enable(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idKH = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
                txtId.Text = gvDanhSach.GetFocusedRowCellValue("IDKH").ToString();
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
                txtCCCD.Text = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                txtPhone.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtAddress.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhSach.GetFocusedRowCellValue("IDKH") != null)
            {
                if (kh_dp == "datphongdon")
                {
                    objDPDon.loadKH();
                    objDPDon.setKH(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                }
                else
                {
                    objDP.loadKH();
                    objDP.setKhachHang(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                }

                this.Close();
            }
        }
    }
}