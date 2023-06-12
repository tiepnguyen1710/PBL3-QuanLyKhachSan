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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SYS_PARAM _param;
        SYS_USER _sysUser;
        string _macty;
        string _madvi;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool us = _sysUser.checkUserExist(_macty, _madvi, txtUsername.Text.Trim());
            if (!us)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string pass = txtPassword.Text;
            tb_SYS_USER user = _sysUser.getItem(txtUsername.Text.Trim(), _macty, _madvi);
            if (user.PASSWD.Equals(pass))
            {
                MainView frm = new MainView(user);
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu đăng nhập không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _sysUser = new SYS_USER();
            _param = new SYS_PARAM();
            var _pr = _param.getParam();
            _macty = _pr.MACTY;
            _madvi = _pr.MADVI;
        }
    }
}