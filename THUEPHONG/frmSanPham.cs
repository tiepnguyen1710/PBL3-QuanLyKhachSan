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
using System.Xml.Linq;
using DataLayer;

namespace THUEPHONG
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        SANPHAM _sanpham;
        bool _them;
        int _idSanPham;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _sanpham = new SANPHAM();
            loadData();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _sanpham.getAll();
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
            txtPrice.Enabled = t;
        }

        void _reset()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
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
                _sanpham.delete(_idSanPham);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_SanPham sanpham = new tb_SanPham();
                sanpham.IDSP = Convert.ToInt32(txtId.Text.ToString());
                sanpham.TENSP = txtName.Text.ToString();
                sanpham.DONGIA = Convert.ToDouble(txtPrice.Text.ToString());
                _sanpham.add(sanpham);
            }
            else
            {
                tb_SanPham sanpham = _sanpham.getItem(_idSanPham);
                sanpham.TENSP = txtName.Text.ToString();
                sanpham.DONGIA = Convert.ToDouble(txtPrice.Text.ToString());
                _sanpham.update(sanpham);
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
                _idSanPham = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDSP").ToString());
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENSP").ToString();
                txtPrice.Text = gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString();
            }
        }
    }
}