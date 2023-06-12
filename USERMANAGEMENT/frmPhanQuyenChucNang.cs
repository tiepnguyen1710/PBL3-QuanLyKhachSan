using BussinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USERMANAGEMENT
{
    public partial class frmPhanQuyenChucNang : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyenChucNang()
        {
            InitializeComponent();
        }

        public int _idUser;
        public string _macty;
        public string _madvi;
        SYS_USER _sysUser;
        SYS_RIGHT _sysRight;
        private void frmPhanQuyenChucNang_Load(object sender, EventArgs e)
        {
            _sysUser = new SYS_USER();
            _sysRight = new SYS_RIGHT();
            loadUsers();
            loadFuncByUser();
            gvChucNang.RowStyle += GvChucNang_RowStyle;
        }

        private void GvChucNang_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isRed = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns["ISGROUP"]));
                if (isRed)
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = new Font("Tahoma", 12, FontStyle.Bold);
                }
            }
        }

        void loadUsers()
        {
            if (_macty == null && _madvi == null)
            {
                gcUsers.DataSource = _sysUser.getUserByDViFunc("CTYME", "~");
                gvUsers.OptionsBehavior.Editable = false;
            }
            else
            {
                gcUsers.DataSource = _sysUser.getUserByDViFunc(_macty, _madvi);
                gvUsers.OptionsBehavior.Editable = false;
            }
        }

        void loadFuncByUser()
        {
            View_FUNC_SYS_RIGHT _vFuncRight = new View_FUNC_SYS_RIGHT();
            gcChucNang.DataSource = _vFuncRight.getFuncByUser(_idUser);
            gvChucNang.OptionsBehavior.Editable = false;
            for (int i = 0; i < gvUsers.RowCount; i++)
            {
                if (int.Parse(gvUsers.GetRowCellValue(i, "IDUSER").ToString()) == _idUser)
                {
                    gvUsers.ClearSelection();
                    gvUsers.FocusedRowHandle = i;
                }
            }
            gvChucNang.ClearSelection();
        }

        private void chỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvChucNang.RowCount; i++)
            {
                if (gvChucNang.IsRowSelected(i))
                {
                    _sysRight.update(_idUser, gvChucNang.GetRowCellValue(i, "FUNC_CODE").ToString(), 1);
                }
            }
            loadFuncByUser();
        }

        private void mnCamQuyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvChucNang.RowCount; i++)
            {
                if (gvChucNang.IsRowSelected(i))
                {
                    _sysRight.update(_idUser, gvChucNang.GetRowCellValue(i, "FUNC_CODE").ToString(), 0);
                }
            }
            loadFuncByUser();
        }

        private void mnToanQuyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvChucNang.RowCount; i++)
            {
                if (gvChucNang.IsRowSelected(i))
                {
                    _sysRight.update(_idUser, gvChucNang.GetRowCellValue(i, "FUNC_CODE").ToString(), 2);
                }
            }
            loadFuncByUser();
        }

        private void gvUsers_Click(object sender, EventArgs e)
        {
            _idUser = int.Parse(gvUsers.GetFocusedRowCellValue("IDUSER").ToString());
            loadFuncByUser();
        }
    }
}