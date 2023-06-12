namespace THUEPHONG
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHeThong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThongKe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.gControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnDatPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnSPDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThanhToan = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            this.gControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHeThong,
            this.toolStripSeparator1,
            this.btnThongKe,
            this.toolStripSeparator2,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1281, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.Image = global::THUEPHONG.Properties.Resources.hệ_thống;
            this.btnHeThong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(75, 56);
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::THUEPHONG.Properties.Resources.báo_cáo;
            this.btnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(74, 56);
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::THUEPHONG.Properties.Resources.exit;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 56);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 59);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.navMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1281, 680);
            this.splitContainerControl1.SplitterPosition = 274;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // navMain
            // 
            this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMain.Location = new System.Drawing.Point(0, 0);
            this.navMain.Name = "navMain";
            this.navMain.OptionsNavPane.ExpandedWidth = 274;
            this.navMain.Size = new System.Drawing.Size(274, 680);
            this.navMain.TabIndex = 0;
            this.navMain.Text = "navBarControl1";
            this.navMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMain_LinkClicked);
            // 
            // gControl
            // 
            this.gControl.Controls.Add(this.galleryControlClient1);
            this.gControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControl.Location = new System.Drawing.Point(0, 0);
            this.gControl.Name = "gControl";
            this.barManager1.SetPopupContextMenu(this.gControl, this.popupMenu1);
            this.gControl.Size = new System.Drawing.Size(995, 680);
            this.gControl.TabIndex = 0;
            this.gControl.Text = "galleryControl1";
            this.gControl.Click += new System.EventHandler(this.gControl_Click);
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(970, 676);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(THUEPHONG.MainViewModel);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bluehome2.png");
            this.imageList1.Images.SetKeyName(1, "redhome1.png");
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDatPhong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSPDV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenPhong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThanhToan)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Popup += new System.EventHandler(this.popupMenu1_Popup);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Caption = "Đặt phòng";
            this.btnDatPhong.Id = 0;
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatPhong_ItemClick);
            // 
            // btnSPDV
            // 
            this.btnSPDV.Caption = "Cập nhật Sản phẩm - Dịch vụ";
            this.btnSPDV.Id = 1;
            this.btnSPDV.Name = "btnSPDV";
            this.btnSPDV.VisibleInSearchMenu = false;
            this.btnSPDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSPDV_ItemClick);
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.Caption = "Chuyển phòng";
            this.btnChuyenPhong.Id = 3;
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenPhong_ItemClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Caption = "Thanh toán";
            this.btnThanhToan.Id = 2;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThanhToan_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDatPhong,
            this.btnSPDV,
            this.btnThanhToan,
            this.btnChuyenPhong});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1281, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 739);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1281, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 739);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1281, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 739);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 739);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            this.gControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHeThong;
        private System.Windows.Forms.ToolStripButton btnThongKe;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navMain;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDatPhong;
        private DevExpress.XtraBars.BarButtonItem btnSPDV;
        private DevExpress.XtraBars.BarButtonItem btnThanhToan;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        public DevExpress.XtraBars.Ribbon.GalleryControl gControl;
        private DevExpress.XtraBars.BarButtonItem btnChuyenPhong;
    }
}

