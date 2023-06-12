namespace USERMANAGEMENT
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.pageUsers = new DevExpress.XtraTab.XtraTabPage();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.btnBot = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcThanhVien = new DevExpress.XtraGrid.GridControl();
            this.gvThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageUsers.SuspendLayout();
            this.pageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageUsers;
            this.xtraTabControl1.Size = new System.Drawing.Size(692, 364);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageUsers,
            this.pageGroup});
            // 
            // pageUsers
            // 
            this.pageUsers.Controls.Add(this.chkDisabled);
            this.pageUsers.Controls.Add(this.txtRePass);
            this.pageUsers.Controls.Add(this.txtPass);
            this.pageUsers.Controls.Add(this.txtHoTen);
            this.pageUsers.Controls.Add(this.txtUsername);
            this.pageUsers.Controls.Add(this.label4);
            this.pageUsers.Controls.Add(this.label2);
            this.pageUsers.Controls.Add(this.label3);
            this.pageUsers.Controls.Add(this.label1);
            this.pageUsers.Name = "pageUsers";
            this.pageUsers.Size = new System.Drawing.Size(690, 334);
            this.pageUsers.Text = "Người dùng";
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(213, 287);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(97, 20);
            this.chkDisabled.TabIndex = 3;
            this.chkDisabled.Text = "Vô hiệu hóa";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // txtRePass
            // 
            this.txtRePass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRePass.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtRePass.Location = new System.Drawing.Point(213, 228);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(253, 23);
            this.txtRePass.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtPass.Location = new System.Drawing.Point(213, 171);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(253, 23);
            this.txtPass.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHoTen.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtHoTen.Location = new System.Drawing.Point(213, 114);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(253, 23);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(213, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // pageGroup
            // 
            this.pageGroup.Controls.Add(this.btnBot);
            this.pageGroup.Controls.Add(this.btnThem);
            this.pageGroup.Controls.Add(this.gcThanhVien);
            this.pageGroup.Name = "pageGroup";
            this.pageGroup.Size = new System.Drawing.Size(690, 334);
            this.pageGroup.Text = "Nhóm";
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(552, 285);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(94, 29);
            this.btnBot.TabIndex = 2;
            this.btnBot.Text = "Bớt";
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(422, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gcThanhVien
            // 
            this.gcThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThanhVien.Location = new System.Drawing.Point(0, 0);
            this.gcThanhVien.MainView = this.gvThanhVien;
            this.gcThanhVien.Name = "gcThanhVien";
            this.gcThanhVien.Size = new System.Drawing.Size(690, 279);
            this.gcThanhVien.TabIndex = 1;
            this.gcThanhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThanhVien});
            // 
            // gvThanhVien
            // 
            this.gvThanhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME});
            this.gvThanhVien.GridControl = this.gcThanhVien;
            this.gvThanhVien.Name = "gvThanhVien";
            // 
            // IDUSER
            // 
            this.IDUSER.Caption = "ID";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.MinWidth = 25;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Width = 94;
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "USERNAME";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.MinWidth = 25;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 0;
            this.USERNAME.Width = 94;
            // 
            // FULLNAME
            // 
            this.FULLNAME.Caption = "FULLNAME";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.MinWidth = 25;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 1;
            this.FULLNAME.Width = 94;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(553, 385);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 29);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(423, 385);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 434);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmUser";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageUsers.ResumeLayout(false);
            this.pageUsers.PerformLayout();
            this.pageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageUsers;
        private DevExpress.XtraTab.XtraTabPage pageGroup;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gcThanhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraEditors.SimpleButton btnBot;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkDisabled;
    }
}