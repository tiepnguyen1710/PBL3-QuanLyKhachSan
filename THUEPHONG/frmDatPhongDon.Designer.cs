namespace THUEPHONG
{
    partial class frmDatPhongDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhongDon));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcSPDV = new DevExpress.XtraGrid.GridControl();
            this.gvSPDV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spIDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spIDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchKH = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPhong = new System.Windows.Forms.Label();
            this.spSoNguoi = new DevExpress.XtraEditors.SpinEdit();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.chkDoan = new System.Windows.Forms.CheckBox();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblHuy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNguoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnPrint,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 55);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::THUEPHONG.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 52);
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::THUEPHONG.Properties.Resources.print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 52);
            this.btnPrint.Text = "In";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::THUEPHONG.Properties.Resources.exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 52);
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1070, 639);
            this.splitContainerControl1.SplitterPosition = 686;
            this.splitContainerControl1.TabIndex = 9;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtThanhTien);
            this.groupControl5.Controls.Add(this.lblThanhToan);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 506);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(686, 133);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "Tổng thanh toán";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(161, 47);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(318, 23);
            this.txtThanhTien.TabIndex = 3;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblThanhToan.Location = new System.Drawing.Point(43, 47);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(100, 24);
            this.lblThanhToan.TabIndex = 2;
            this.lblThanhToan.Text = "Tổng Tiền";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gcSPDV);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 245);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(686, 261);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Danh sách Sản phẩm - Dịch vụ";
            // 
            // gcSPDV
            // 
            this.gcSPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSPDV.Location = new System.Drawing.Point(2, 28);
            this.gcSPDV.MainView = this.gvSPDV;
            this.gcSPDV.Name = "gcSPDV";
            this.gcSPDV.Size = new System.Drawing.Size(682, 231);
            this.gcSPDV.TabIndex = 0;
            this.gcSPDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPDV});
            // 
            // gvSPDV
            // 
            this.gvSPDV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.spIDSP,
            this.spTENPHONG,
            this.spTENSP,
            this.spIDPHONG,
            this.spSOLUONG,
            this.spDONGIA,
            this.spTHANHTIEN});
            this.gvSPDV.GridControl = this.gcSPDV;
            this.gvSPDV.Name = "gvSPDV";
            this.gvSPDV.HiddenEditor += new System.EventHandler(this.gvSPDV_HiddenEditor);
            this.gvSPDV.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSPDV_CellValueChanged);
            // 
            // spIDSP
            // 
            this.spIDSP.Caption = "IDSP";
            this.spIDSP.FieldName = "IDSP";
            this.spIDSP.MinWidth = 25;
            this.spIDSP.Name = "spIDSP";
            this.spIDSP.Width = 94;
            // 
            // spTENPHONG
            // 
            this.spTENPHONG.Caption = "PHÒNG";
            this.spTENPHONG.FieldName = "TENPHONG";
            this.spTENPHONG.MinWidth = 25;
            this.spTENPHONG.Name = "spTENPHONG";
            this.spTENPHONG.OptionsColumn.AllowEdit = false;
            this.spTENPHONG.Visible = true;
            this.spTENPHONG.VisibleIndex = 0;
            this.spTENPHONG.Width = 94;
            // 
            // spTENSP
            // 
            this.spTENSP.Caption = "TÊN SP-DV";
            this.spTENSP.FieldName = "TENSP";
            this.spTENSP.MinWidth = 25;
            this.spTENSP.Name = "spTENSP";
            this.spTENSP.OptionsColumn.AllowEdit = false;
            this.spTENSP.Visible = true;
            this.spTENSP.VisibleIndex = 1;
            this.spTENSP.Width = 94;
            // 
            // spIDPHONG
            // 
            this.spIDPHONG.Caption = "IDPHONG";
            this.spIDPHONG.FieldName = "IDPHONG";
            this.spIDPHONG.MinWidth = 25;
            this.spIDPHONG.Name = "spIDPHONG";
            this.spIDPHONG.Width = 94;
            // 
            // spSOLUONG
            // 
            this.spSOLUONG.Caption = "SỐ LƯỢNG";
            this.spSOLUONG.FieldName = "SOLUONG";
            this.spSOLUONG.MinWidth = 25;
            this.spSOLUONG.Name = "spSOLUONG";
            this.spSOLUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SOLUONG", "{0:0.##}")});
            this.spSOLUONG.Visible = true;
            this.spSOLUONG.VisibleIndex = 2;
            this.spSOLUONG.Width = 94;
            // 
            // spDONGIA
            // 
            this.spDONGIA.Caption = "ĐƠN GIÁ";
            this.spDONGIA.FieldName = "DONGIA";
            this.spDONGIA.MinWidth = 25;
            this.spDONGIA.Name = "spDONGIA";
            this.spDONGIA.OptionsColumn.AllowEdit = false;
            this.spDONGIA.Visible = true;
            this.spDONGIA.VisibleIndex = 3;
            this.spDONGIA.Width = 94;
            // 
            // spTHANHTIEN
            // 
            this.spTHANHTIEN.Caption = "THÀNH TIỀN";
            this.spTHANHTIEN.FieldName = "THANHTIEN";
            this.spTHANHTIEN.MinWidth = 25;
            this.spTHANHTIEN.Name = "spTHANHTIEN";
            this.spTHANHTIEN.OptionsColumn.AllowEdit = false;
            this.spTHANHTIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANHTIEN", "{0:0.##}")});
            this.spTHANHTIEN.Visible = true;
            this.spTHANHTIEN.VisibleIndex = 4;
            this.spTHANHTIEN.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.searchKH);
            this.groupControl1.Controls.Add(this.lblPhong);
            this.groupControl1.Controls.Add(this.spSoNguoi);
            this.groupControl1.Controls.Add(this.btnAddNew);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.chkDoan);
            this.groupControl1.Controls.Add(this.dtNgayTra);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dtNgayDat);
            this.groupControl1.Controls.Add(this.lblHuy);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.cboTrangThai);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(686, 245);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // searchKH
            // 
            this.searchKH.EditValue = "";
            this.searchKH.Location = new System.Drawing.Point(159, 70);
            this.searchKH.Name = "searchKH";
            this.searchKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchKH.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchKH.Size = new System.Drawing.Size(317, 22);
            this.searchKH.TabIndex = 30;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDKH,
            this.HOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDKH
            // 
            this.IDKH.Caption = "ID";
            this.IDKH.FieldName = "IDKH";
            this.IDKH.MaxWidth = 50;
            this.IDKH.MinWidth = 30;
            this.IDKH.Name = "IDKH";
            this.IDKH.Visible = true;
            this.IDKH.VisibleIndex = 0;
            this.IDKH.Width = 50;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 150;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 150;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhong.ForeColor = System.Drawing.Color.Red;
            this.lblPhong.Location = new System.Drawing.Point(114, 33);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(74, 24);
            this.lblPhong.TabIndex = 29;
            this.lblPhong.Text = "Phòng";
            // 
            // spSoNguoi
            // 
            this.spSoNguoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSoNguoi.Location = new System.Drawing.Point(161, 140);
            this.spSoNguoi.Name = "spSoNguoi";
            this.spSoNguoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSoNguoi.Size = new System.Drawing.Size(165, 24);
            this.spSoNguoi.TabIndex = 22;
            // 
            // btnAddNew
            // 
            this.btnAddNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ImageOptions.Image")));
            this.btnAddNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddNew.Location = new System.Drawing.Point(501, 60);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(34, 29);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(161, 206);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(317, 23);
            this.txtGhiChu.TabIndex = 20;
            // 
            // chkDoan
            // 
            this.chkDoan.AutoSize = true;
            this.chkDoan.Location = new System.Drawing.Point(412, 143);
            this.chkDoan.Name = "chkDoan";
            this.chkDoan.Size = new System.Drawing.Size(90, 20);
            this.chkDoan.TabIndex = 19;
            this.chkDoan.Text = "Theo đoàn";
            this.chkDoan.UseVisualStyleBackColor = true;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(449, 105);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(200, 23);
            this.dtNgayTra.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày trả";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDat.Location = new System.Drawing.Point(159, 107);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(200, 23);
            this.dtNgayDat.TabIndex = 18;
            // 
            // lblHuy
            // 
            this.lblHuy.AutoSize = true;
            this.lblHuy.ForeColor = System.Drawing.Color.Red;
            this.lblHuy.Location = new System.Drawing.Point(597, 40);
            this.lblHuy.Name = "lblHuy";
            this.lblHuy.Size = new System.Drawing.Size(15, 16);
            this.lblHuy.TabIndex = 12;
            this.lblHuy.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số người";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày đặt";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(161, 172);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(165, 24);
            this.cboTrangThai.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Khách hàng";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcSanPham);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(372, 639);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Sản phẩm- Dịch vụ";
            // 
            // gcSanPham
            // 
            this.gcSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPham.Location = new System.Drawing.Point(2, 28);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(368, 609);
            this.gcSanPham.TabIndex = 0;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDSP,
            this.TENSP,
            this.DONGIA});
            this.gvSanPham.GridControl = this.gcSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.DoubleClick += new System.EventHandler(this.gvSanPham_DoubleClick);
            // 
            // IDSP
            // 
            this.IDSP.Caption = "IDSP";
            this.IDSP.FieldName = "IDSP";
            this.IDSP.MinWidth = 25;
            this.IDSP.Name = "IDSP";
            this.IDSP.Width = 94;
            // 
            // TENSP
            // 
            this.TENSP.Caption = "TÊN SP-DV";
            this.TENSP.FieldName = "TENSP";
            this.TENSP.MinWidth = 25;
            this.TENSP.Name = "TENSP";
            this.TENSP.Visible = true;
            this.TENSP.VisibleIndex = 0;
            this.TENSP.Width = 94;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 1;
            this.DONGIA.Width = 94;
            // 
            // frmDatPhongDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 694);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDatPhongDon";
            this.Text = "fmDatPhongDon";
            this.Load += new System.EventHandler(this.fmDatPhongDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoNguoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnExit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit spSoNguoi;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.CheckBox chkDoan;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.Label lblHuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcSPDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPDV;
        private DevExpress.XtraGrid.Columns.GridColumn spIDSP;
        private DevExpress.XtraGrid.Columns.GridColumn spTENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spTENSP;
        private DevExpress.XtraGrid.Columns.GridColumn spIDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn spDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn spTHANHTIEN;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhToan;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IDSP;
        private DevExpress.XtraGrid.Columns.GridColumn TENSP;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Label lblPhong;
        private DevExpress.XtraEditors.SearchLookUpEdit searchKH;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IDKH;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
    }
}