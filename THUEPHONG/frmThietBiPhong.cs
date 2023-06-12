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

namespace THUEPHONG
{
    public partial class frmThietBiPhong : DevExpress.XtraEditors.XtraForm
    {
        PHONGTHIETBI _phongtb;
        PHONG _phong;
        THIETBI _thietbi;
        bool _them;
        int _idPhong;
        public frmThietBiPhong()
        {
            InitializeComponent();
        }

        private void frmThietBiPhong_Load(object sender, EventArgs e)
        {
            _phongtb = new PHONGTHIETBI();
            _phong = new PHONG();
            _thietbi = new THIETBI();
            loadData();
            loadPhong();
            loadThietBi();
            showHideControl(true);
            _enable(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _phongtb.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadPhong()
        {
            cboRoom.DataSource = _phong.getAll();
            cboRoom.DisplayMember = "TENPHONG";
            cboRoom.ValueMember = "IDPHONG";
        }

        void loadThietBi()
        {
            cboDevice.DataSource = _thietbi.getAll();
            cboDevice.DisplayMember = "TENTB";
            cboDevice.ValueMember = "IDTB";
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
            cboRoom.Enabled = t;
            cboDevice.Enabled = t;
            numQuantity.Enabled = t;
        }

        void _reset()
        {
            cboRoom.Text = "";
            cboDevice.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {

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
            }
        }

    }
}