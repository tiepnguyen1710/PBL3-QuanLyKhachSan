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
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        TANG _tang;
        bool _them;
        int _idTang;
        public frmTang()
        {
            InitializeComponent();
        }

        private void frmTang_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _tang = new TANG();
            loadData();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _tang.getAll();
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
            txtTenTang.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
            txtTenTang.Text = "";
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
            showHideControl(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tang.delete(_idTang);
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_Tang tang = new tb_Tang();
                tang.TENTANG = txtTenTang.Text.ToString();
                tang.DISABLED = chkDisabled.Checked;
                _tang.add(tang);
            }
            else
            {
                tb_Tang tang = _tang.getItem(_idTang);
                tang.TENTANG = txtTenTang.Text.ToString();
                tang.DISABLED = chkDisabled.Checked;
                _tang.update(tang);
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
    }
}