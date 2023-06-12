﻿namespace USERMANAGEMENT
{
    partial class frmPhanQuyenChucNang
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChucNang = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnCamQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChiXem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.gvChucNang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FUNC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DECRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gcUsers);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcChucNang);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(944, 680);
            this.splitContainerControl1.SplitterPosition = 344;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gcUsers
            // 
            this.gcUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsers.Location = new System.Drawing.Point(0, 0);
            this.gcUsers.MainView = this.gvUsers;
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.Size = new System.Drawing.Size(344, 680);
            this.gcUsers.TabIndex = 0;
            this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            // 
            // gvUsers
            // 
            this.gvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ISGROUP,
            this.USERNAME,
            this.FULLNAME,
            this.IDUSER});
            this.gvUsers.GridControl = this.gcUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.OptionsView.ShowGroupPanel = false;
            this.gvUsers.Click += new System.EventHandler(this.gvUsers_Click);
            // 
            // ISGROUP
            // 
            this.ISGROUP.FieldName = "ISGROUP";
            this.ISGROUP.MinWidth = 25;
            this.ISGROUP.Name = "ISGROUP";
            this.ISGROUP.Visible = true;
            this.ISGROUP.VisibleIndex = 0;
            this.ISGROUP.Width = 56;
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "USERNAME";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.MinWidth = 25;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 1;
            this.USERNAME.Width = 127;
            // 
            // FULLNAME
            // 
            this.FULLNAME.Caption = "FULLNAME";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.MinWidth = 25;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 2;
            this.FULLNAME.Width = 131;
            // 
            // IDUSER
            // 
            this.IDUSER.Caption = "ID";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.MinWidth = 25;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Width = 94;
            // 
            // gcChucNang
            // 
            this.gcChucNang.ContextMenuStrip = this.contextMenuStrip1;
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChucNang.Location = new System.Drawing.Point(0, 0);
            this.gcChucNang.MainView = this.gvChucNang;
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(588, 680);
            this.gcChucNang.TabIndex = 0;
            this.gcChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChucNang});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCamQuyen,
            this.mnChiXem,
            this.mnToanQuyen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 76);
            // 
            // mnCamQuyen
            // 
            this.mnCamQuyen.Name = "mnCamQuyen";
            this.mnCamQuyen.Size = new System.Drawing.Size(156, 24);
            this.mnCamQuyen.Text = "Khóa quyền";
            this.mnCamQuyen.Click += new System.EventHandler(this.mnCamQuyen_Click);
            // 
            // mnChiXem
            // 
            this.mnChiXem.Name = "mnChiXem";
            this.mnChiXem.Size = new System.Drawing.Size(156, 24);
            this.mnChiXem.Text = "Chỉ xem";
            this.mnChiXem.Click += new System.EventHandler(this.chỉToolStripMenuItem_Click);
            // 
            // mnToanQuyen
            // 
            this.mnToanQuyen.Name = "mnToanQuyen";
            this.mnToanQuyen.Size = new System.Drawing.Size(156, 24);
            this.mnToanQuyen.Text = "Toàn quyền";
            this.mnToanQuyen.Click += new System.EventHandler(this.mnToanQuyen_Click);
            // 
            // gvChucNang
            // 
            this.gvChucNang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FUNC_CODE,
            this.DECRIPTION,
            this.QUYEN,
            this.cISGROUP});
            this.gvChucNang.GridControl = this.gcChucNang;
            this.gvChucNang.Name = "gvChucNang";
            this.gvChucNang.OptionsSelection.MultiSelect = true;
            this.gvChucNang.OptionsView.ShowGroupPanel = false;
            // 
            // FUNC_CODE
            // 
            this.FUNC_CODE.Caption = "FUNC_CODE";
            this.FUNC_CODE.FieldName = "FUNC_CODE";
            this.FUNC_CODE.MinWidth = 25;
            this.FUNC_CODE.Name = "FUNC_CODE";
            this.FUNC_CODE.Width = 94;
            // 
            // DECRIPTION
            // 
            this.DECRIPTION.Caption = "CHỨC NĂNG";
            this.DECRIPTION.FieldName = "DECRIPTION";
            this.DECRIPTION.MinWidth = 25;
            this.DECRIPTION.Name = "DECRIPTION";
            this.DECRIPTION.Visible = true;
            this.DECRIPTION.VisibleIndex = 0;
            this.DECRIPTION.Width = 94;
            // 
            // QUYEN
            // 
            this.QUYEN.Caption = "QUYỀN";
            this.QUYEN.FieldName = "QUYEN";
            this.QUYEN.MinWidth = 25;
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.Visible = true;
            this.QUYEN.VisibleIndex = 1;
            this.QUYEN.Width = 94;
            // 
            // cISGROUP
            // 
            this.cISGROUP.Caption = "GROUP";
            this.cISGROUP.FieldName = "ISGROUP";
            this.cISGROUP.MinWidth = 25;
            this.cISGROUP.Name = "cISGROUP";
            this.cISGROUP.Width = 94;
            // 
            // frmPhanQuyenChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 680);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPhanQuyenChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền chức năng";
            this.Load += new System.EventHandler(this.frmPhanQuyenChucNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
        private DevExpress.XtraGrid.GridControl gcChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn ISGROUP;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn FUNC_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn DECRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn QUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn cISGROUP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnCamQuyen;
        private System.Windows.Forms.ToolStripMenuItem mnChiXem;
        private System.Windows.Forms.ToolStripMenuItem mnToanQuyen;
    }
}