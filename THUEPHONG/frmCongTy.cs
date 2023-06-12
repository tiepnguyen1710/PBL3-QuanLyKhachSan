using BussinessLayer;
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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        CONGTY _congty;
        bool _them;
        string _macty;
        public frmCongTy()
        {
            InitializeComponent();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadData();
            showHideControl(true);
            _enable(false);
            txtMa.Enabled = false;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _congty.getAll();
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _them = false;
            _enable(true);
            txtMa.Enabled = false;
            showHideControl(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _congty.delete(_macty);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_CongTy cty = new tb_CongTy();
                cty.MACTY = txtMa.Text.ToString();
                cty.TENCTY = txtName.Text.ToString();
                cty.DIENTHOAI = txtPhone.Text.ToString();
                cty.FAX = txtFax.Text.ToString();
                cty.EMAIL = txtEmail.Text.ToString();
                cty.DIACHI = txtAddress.Text.ToString();
                cty.DISABLED = chkDisabled.Checked;
                _congty.add(cty);
            }
            else
            {
                tb_CongTy cty = _congty.getItem(_macty);
                cty.TENCTY = txtName.Text.ToString();
                cty.DIENTHOAI = txtPhone.Text.ToString();
                cty.FAX = txtFax.Text.ToString();
                cty.EMAIL = txtEmail.Text.ToString();
                cty.DIACHI = txtAddress.Text.ToString();
                cty.DISABLED = chkDisabled.Checked;
                _congty.edit(cty);
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
            if(gvDanhSach.RowCount > 0)
            {
                _macty = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                txtPhone.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtAddress.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                chkDisabled.Checked = Convert.ToBoolean(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}