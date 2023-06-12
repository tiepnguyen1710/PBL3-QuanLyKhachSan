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
using System.Xml.Linq;

namespace THUEPHONG
{
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        LOAIPHONG _loaiphong;
        bool _them;
        int _idLoaiPhong;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            _loaiphong = new LOAIPHONG();
            loadData();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _loaiphong.getAll();
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
            txtName.Enabled = t;
            txtPrice.Enabled = t;
            numPeople.Enabled = t;
            numBed.Enabled = t;
        }

        void _reset()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            numPeople.Value = 0;
            numBed.Value = 0;
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaiphong.delete(_idLoaiPhong);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_LoaiPhong loaiphong = new tb_LoaiPhong();
                loaiphong.TENLOAIPHONG = txtName.Text.ToString();
                loaiphong.DONGIA = Convert.ToDouble(txtPrice.Text.ToString());
                loaiphong.SONGUOI = Convert.ToInt32(numPeople.Value);
                loaiphong.SOGIUONG = Convert.ToInt32(numBed.Value);
                _loaiphong.add(loaiphong);
            }
            else
            {
                tb_LoaiPhong loaiphong = _loaiphong.getItem(_idLoaiPhong);
                loaiphong.TENLOAIPHONG = txtName.Text.ToString();
                loaiphong.DONGIA = Convert.ToDouble(txtPrice.Text.ToString());
                loaiphong.SONGUOI = Convert.ToInt32(numPeople.Value);
                loaiphong.SOGIUONG = Convert.ToInt32(numBed.Value);
                _loaiphong.update(loaiphong);
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
                _idLoaiPhong = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
                txtPrice.Text = gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString();
                numPeople.Value = gvDanhSach.GetFocusedRowCellValue("SONGUOI").ToString().Length;
                numBed.Value = gvDanhSach.GetFocusedRowCellValue("SOGIUONG").ToString().Length;
            }
        }
    }
}