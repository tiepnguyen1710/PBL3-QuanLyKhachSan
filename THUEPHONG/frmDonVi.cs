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
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        CONGTY _congty;
        DONVI _donvi;
        bool _them;
        string _madvi;
        public frmDonVi()
        {
            InitializeComponent();
        }
        private void frmDonVi_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            loadCty();
            loadData();
            showHideControl(true);
            _enable(false);
            cboCty.SelectedIndexChanged += CboCty_SelectedIndexChanged;
        }

        private void CboCty_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDviByCty();
        }

        void loadCty()
        {
            cboCty.DataSource = _congty.getAll();
            cboCty.DisplayMember = "TENCTY";
            cboCty.ValueMember = "MACTY";
        }

        void loadData()
        {
            gcDanhSach.DataSource = _donvi.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadDviByCty()
        {
            gcDanhSach.DataSource = _donvi.getByMaCty(cboCty.SelectedValue.ToString());
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
            txtMa.Enabled = t;
            txtName.Enabled = t;
            txtPhone.Enabled = t;
            txtFax.Enabled = t;
            txtEmail.Enabled = t;
            txtAddress.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
            txtMa.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            chkDisabled.Checked = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enable(true);
            _reset();
            txtMa.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _them = false;
            _enable(true);
            showHideControl(false);
            txtMa.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _donvi.delete(_madvi);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_DonVi dvi = new tb_DonVi();
                dvi.MACTY = cboCty.SelectedValue.ToString();
                dvi.MADVI = txtMa.Text.ToString();
                dvi.TENDVI = txtName.Text.ToString();
                dvi.DIENTHOAI = txtPhone.Text.ToString();
                dvi.FAX = txtFax.Text.ToString();
                dvi.EMAIL = txtEmail.Text.ToString();
                dvi.DIACHI = txtAddress.Text.ToString();
                dvi.DISABLED = chkDisabled.Checked;
                _donvi.add(dvi);
            }
            else
            {
                tb_DonVi dvi = _donvi.getItem(_madvi);
                dvi.MACTY = cboCty.SelectedValue.ToString();
                dvi.TENDVI = txtName.Text.ToString();
                dvi.DIENTHOAI = txtPhone.Text.ToString();
                dvi.FAX = txtFax.Text.ToString();
                dvi.EMAIL = txtEmail.Text.ToString();
                dvi.DIACHI = txtAddress.Text.ToString();
                dvi.DISABLED = chkDisabled.Checked;
                _donvi.update(dvi);
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
            txtMa.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _madvi = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
                cboCty.SelectedValue = gvDanhSach.GetFocusedRowCellValue("MACTY");
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENDVI").ToString();
                txtPhone.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtAddress.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                chkDisabled.Checked = Convert.ToBoolean(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}