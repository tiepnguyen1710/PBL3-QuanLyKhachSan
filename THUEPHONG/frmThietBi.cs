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
using System.Xml.Linq;
using DevExpress.Data.Mask;

namespace THUEPHONG
{
    public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
    {
        THIETBI _thietbi;
        bool _them;
        int _idThietBi;
        public frmThietBi()
        {
            InitializeComponent();
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            _thietbi = new THIETBI();
            loadData();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _thietbi.getAll();
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
            txtId.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _thietbi.delete(_idThietBi);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_ThietBi thietbi = new tb_ThietBi();
                thietbi.IDTB = Convert.ToInt32(txtId.Text.ToString());
                thietbi.TENTB = txtName.Text.ToString();
                thietbi.DONGIA = Convert.ToDouble(txtPrice.Text.ToString());
                _thietbi.add(thietbi);
            }
            else
            {
                tb_ThietBi thietbi = _thietbi.getItem(_idThietBi);
                thietbi.TENTB = txtName.Text.ToString();
                thietbi.DONGIA = Convert.ToDouble(txtPrice.Text.ToString());
                _thietbi.update(thietbi);
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
                _idThietBi = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDTB").ToString());
                txtId.Text = gvDanhSach.GetFocusedRowCellValue("IDTB").ToString();
                txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENTB").ToString();
                txtPrice.Text = gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString();
            }
        }
    }
}