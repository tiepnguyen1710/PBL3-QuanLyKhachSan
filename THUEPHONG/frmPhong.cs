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
using BussinessLayer;
using DataLayer;

namespace THUEPHONG
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        PHONG _phong;
        TANG _tang;
        LOAIPHONG _loaiphong;
        bool _them;
        int _idPhong;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            _tang = new TANG();
            _loaiphong = new LOAIPHONG();
            loadData();
            loadTang();
            loadLoaiPhong();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _phong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadTang()
        {
            cboTang.DataSource = _tang.getAll();
            cboTang.DisplayMember = "TENTANG";
            cboTang.ValueMember = "IDTANG";
        }

        void loadLoaiPhong()
        {
            cboLoaiPhong.DataSource = _loaiphong.getAll();
            cboLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cboLoaiPhong.ValueMember = "IDLOAIPHONG";
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
            cboTang.Enabled = t;
            cboLoaiPhong.Enabled = t;
            cbxStatus.Enabled = t;
        }

        void _reset()
        {
            txtId.Text = "";
            txtName.Text = "";
            cboTang.Text = "";
            cboLoaiPhong.Text = "";
            cbxStatus.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enable(true);
            _reset();
            txtId.Enabled = true;
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
                _phong.delete(_idPhong);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_Phong phong = new tb_Phong();
                phong.IDPHONG = Convert.ToInt32(txtId.Text.ToString());
                phong.TENPHONG = txtName.Text.ToString();
                phong.TRANGTHAI = cbxStatus.Checked;
                phong.IDTANG = Convert.ToInt32(cboTang.SelectedValue.ToString());
                phong.IDLOAIPHONG = Convert.ToInt32(cboLoaiPhong.SelectedValue.ToString());
                _phong.add(phong);
            }
            else
            {
                tb_Phong phong = _phong.getItem(_idPhong);
                phong.TENPHONG = txtName.Text.ToString();
                phong.TRANGTHAI= cbxStatus.Checked;
                phong.IDTANG = Convert.ToInt32(cboTang.SelectedValue.ToString());
                phong.IDLOAIPHONG = Convert.ToInt32(cboLoaiPhong.SelectedValue.ToString());
                _phong.update(phong);
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
                _idPhong = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENPHONG").ToString();
                txtId.Text = gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString();
                cbxStatus.Checked = Convert.ToBoolean(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
                cboTang.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDTANG").ToString();
                cboTang.SelectedItem = gvDanhSach.GetFocusedRowCellValue("TENTANG").ToString();
                cboLoaiPhong.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString();
                cboLoaiPhong.SelectedItem = gvDanhSach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
            }
        }
    }
}