namespace USERMANAGEMENT
{
    partial class frmGroup
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
            this.pageThanhVienXtra = new DevExpress.XtraTab.XtraTabControl();
            this.pageNhom = new DevExpress.XtraTab.XtraTabPage();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageThanhVien = new DevExpress.XtraTab.XtraTabPage();
            this.btnBot = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcThanhVien = new DevExpress.XtraGrid.GridControl();
            this.gvThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pageThanhVienXtra)).BeginInit();
            this.pageThanhVienXtra.SuspendLayout();
            this.pageNhom.SuspendLayout();
            this.pageThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pageThanhVienXtra
            // 
            this.pageThanhVienXtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageThanhVienXtra.Location = new System.Drawing.Point(0, 0);
            this.pageThanhVienXtra.Name = "pageThanhVienXtra";
            this.pageThanhVienXtra.SelectedTabPage = this.pageNhom;
            this.pageThanhVienXtra.Size = new System.Drawing.Size(576, 322);
            this.pageThanhVienXtra.TabIndex = 0;
            this.pageThanhVienXtra.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageNhom,
            this.pageThanhVien});
            // 
            // pageNhom
            // 
            this.pageNhom.Controls.Add(this.txtMoTa);
            this.pageNhom.Controls.Add(this.txtTenNhom);
            this.pageNhom.Controls.Add(this.label2);
            this.pageNhom.Controls.Add(this.label1);
            this.pageNhom.Name = "pageNhom";
            this.pageNhom.Size = new System.Drawing.Size(574, 292);
            this.pageNhom.Text = "Nhóm";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(196, 141);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(253, 23);
            this.txtMoTa.TabIndex = 1;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTenNhom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtTenNhom.Location = new System.Drawing.Point(196, 68);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(253, 23);
            this.txtTenNhom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // pageThanhVien
            // 
            this.pageThanhVien.Controls.Add(this.btnBot);
            this.pageThanhVien.Controls.Add(this.btnThem);
            this.pageThanhVien.Controls.Add(this.gcThanhVien);
            this.pageThanhVien.Name = "pageThanhVien";
            this.pageThanhVien.Size = new System.Drawing.Size(574, 292);
            this.pageThanhVien.Text = "Thành viên";
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(446, 242);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(94, 29);
            this.btnBot.TabIndex = 1;
            this.btnBot.Text = "Bớt";
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(316, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gcThanhVien
            // 
            this.gcThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThanhVien.Location = new System.Drawing.Point(0, 0);
            this.gcThanhVien.MainView = this.gvThanhVien;
            this.gcThanhVien.Name = "gcThanhVien";
            this.gcThanhVien.Size = new System.Drawing.Size(574, 222);
            this.gcThanhVien.TabIndex = 0;
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
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(317, 340);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(447, 340);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 29);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 400);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pageThanhVienXtra);
            this.Name = "frmGroup";
            this.Text = "Nhóm người dùng";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageThanhVienXtra)).EndInit();
            this.pageThanhVienXtra.ResumeLayout(false);
            this.pageNhom.ResumeLayout(false);
            this.pageNhom.PerformLayout();
            this.pageThanhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl pageThanhVienXtra;
        private DevExpress.XtraTab.XtraTabPage pageNhom;
        private DevExpress.XtraTab.XtraTabPage pageThanhVien;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraGrid.GridControl gcThanhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThanhVien;
        private DevExpress.XtraEditors.SimpleButton btnBot;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
    }
}