namespace QLMuaHeXanh
{
    partial class frmCongViec
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
            System.Windows.Forms.Label maCongViecLabel;
            System.Windows.Forms.Label tenCongViecLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongViec));
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.bdsCongViec = new System.Windows.Forms.BindingSource(this.components);
            this.congViecTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.CongViecTableAdapter();
            this.bdsChiTietCV = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietCongViecTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ChiTietCongViecTableAdapter();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.gcCongViec = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.txtTenCV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCV = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiCV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            maCongViecLabel = new System.Windows.Forms.Label();
            tenCongViecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // maCongViecLabel
            // 
            maCongViecLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maCongViecLabel.AutoSize = true;
            maCongViecLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maCongViecLabel.Location = new System.Drawing.Point(200, 63);
            maCongViecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maCongViecLabel.Name = "maCongViecLabel";
            maCongViecLabel.Size = new System.Drawing.Size(101, 19);
            maCongViecLabel.TabIndex = 0;
            maCongViecLabel.Text = "Mã Công Việc:";
            // 
            // tenCongViecLabel
            // 
            tenCongViecLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenCongViecLabel.AutoSize = true;
            tenCongViecLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenCongViecLabel.Location = new System.Drawing.Point(200, 117);
            tenCongViecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenCongViecLabel.Name = "tenCongViecLabel";
            tenCongViecLabel.Size = new System.Drawing.Size(103, 19);
            tenCongViecLabel.TabIndex = 2;
            tenCongViecLabel.Text = "Tên Công Việc:";
            // 
            // muaHeXanhDataSet
            // 
            this.muaHeXanhDataSet.DataSetName = "MuaHeXanhDataSet";
            this.muaHeXanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuoiCVTableAdapter = null;
            this.tableAdapterManager.ChiTietCongViecTableAdapter = null;
            this.tableAdapterManager.CongViecTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DiaBanTableAdapter = null;
            this.tableAdapterManager.GiaoVienTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.NhaDanTableAdapter = null;
            this.tableAdapterManager.NhomTableAdapter = null;
            this.tableAdapterManager.PhanCongTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.ThanhTichTableAdapter = null;
            this.tableAdapterManager.ThucHienCongViecTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = null;
            // 
            // bdsCongViec
            // 
            this.bdsCongViec.DataMember = "CongViec";
            this.bdsCongViec.DataSource = this.muaHeXanhDataSet;
            // 
            // congViecTableAdapter
            // 
            this.congViecTableAdapter.ClearBeforeFill = true;
            // 
            // bdsChiTietCV
            // 
            this.bdsChiTietCV.DataMember = "FK_ChiTietCongViec_CongViec";
            this.bdsChiTietCV.DataSource = this.bdsCongViec;
            // 
            // chiTietCongViecTableAdapter
            // 
            this.chiTietCongViecTableAdapter.ClearBeforeFill = true;
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.barButtonItem3,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnLamMoi,
            this.btnDanhSachSV,
            this.btnThoat,
            this.btnTaoTK,
            this.barButtonItem2});
            this.barManager2.MaxItemId = 18;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 24);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl1.Size = new System.Drawing.Size(683, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 396);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl2.Size = new System.Drawing.Size(683, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl3.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(683, 24);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl4.Size = new System.Drawing.Size(0, 372);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 2;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 5;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 6;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 9;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 10;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 11;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // btnDanhSachSV
            // 
            this.btnDanhSachSV.Id = 17;
            this.btnDanhSachSV.Name = "btnDanhSachSV";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 13;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Id = 15;
            this.btnTaoTK.Name = "btnTaoTK";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // gcCongViec
            // 
            this.gcCongViec.DataSource = this.bdsCongViec;
            this.gcCongViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCongViec.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcCongViec.Location = new System.Drawing.Point(0, 24);
            this.gcCongViec.MainView = this.gridView1;
            this.gcCongViec.Margin = new System.Windows.Forms.Padding(2);
            this.gcCongViec.MenuManager = this.barManager2;
            this.gcCongViec.Name = "gcCongViec";
            this.gcCongViec.Size = new System.Drawing.Size(683, 188);
            this.gcCongViec.TabIndex = 4;
            this.gcCongViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCongViec,
            this.colTenCongViec});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gcCongViec;
            this.gridView1.Name = "gridView1";
            // 
            // colMaCongViec
            // 
            this.colMaCongViec.FieldName = "MaCongViec";
            this.colMaCongViec.MinWidth = 19;
            this.colMaCongViec.Name = "colMaCongViec";
            this.colMaCongViec.Visible = true;
            this.colMaCongViec.VisibleIndex = 0;
            this.colMaCongViec.Width = 70;
            // 
            // colTenCongViec
            // 
            this.colTenCongViec.FieldName = "TenCongViec";
            this.colTenCongViec.MinWidth = 19;
            this.colTenCongViec.Name = "colTenCongViec";
            this.colTenCongViec.Visible = true;
            this.colTenCongViec.VisibleIndex = 1;
            this.colTenCongViec.Width = 70;
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(tenCongViecLabel);
            this.panelNhapXuat.Controls.Add(this.txtTenCV);
            this.panelNhapXuat.Controls.Add(maCongViecLabel);
            this.panelNhapXuat.Controls.Add(this.txtMaCV);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 212);
            this.panelNhapXuat.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(683, 184);
            this.panelNhapXuat.TabIndex = 5;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenCV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCongViec, "TenCongViec", true));
            this.txtTenCV.Location = new System.Drawing.Point(348, 112);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenCV.MenuManager = this.barManager2;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenCV.Properties.Appearance.Options.UseFont = true;
            this.txtTenCV.Size = new System.Drawing.Size(145, 26);
            this.txtTenCV.TabIndex = 3;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaCV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCongViec, "MaCongViec", true));
            this.txtMaCV.Location = new System.Drawing.Point(348, 58);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCV.MenuManager = this.barManager2;
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaCV.Properties.Appearance.Options.UseFont = true;
            this.txtMaCV.Size = new System.Drawing.Size(145, 26);
            this.txtMaCV.TabIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl5);
            this.barManager1.DockControls.Add(this.barDockControl6);
            this.barManager1.DockControls.Add(this.barDockControl7);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemCV,
            this.btnSuaCV,
            this.btnGhiCV,
            this.barButtonItem7,
            this.btnXoaCV,
            this.btnUndo,
            this.btnReload,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem11, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem12, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem13)});
            this.bar1.Text = "Tools";
            // 
            // btnThemCV
            // 
            this.btnThemCV.Caption = "Thêm";
            this.btnThemCV.Id = 2;
            this.btnThemCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemCV.ImageOptions.SvgImage")));
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCV_ItemClick);
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.Caption = "Sửa";
            this.btnSuaCV.Id = 5;
            this.btnSuaCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaCV.ImageOptions.SvgImage")));
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaCV_ItemClick);
            // 
            // btnGhiCV
            // 
            this.btnGhiCV.Caption = "Ghi";
            this.btnGhiCV.Id = 6;
            this.btnGhiCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiCV.ImageOptions.Image")));
            this.btnGhiCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiCV.ImageOptions.LargeImage")));
            this.btnGhiCV.Name = "btnGhiCV";
            this.btnGhiCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiCV_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Caption = "Xóa";
            this.btnXoaCV.Id = 9;
            this.btnXoaCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCV.ImageOptions.Image")));
            this.btnXoaCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCV.ImageOptions.LargeImage")));
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCV_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 10;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm mới";
            this.btnReload.Id = 11;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Thoát";
            this.barButtonItem11.Id = 13;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Id = 15;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Id = 16;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager1;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl5.Size = new System.Drawing.Size(683, 24);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 396);
            this.barDockControl6.Manager = this.barManager1;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl6.Size = new System.Drawing.Size(683, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 24);
            this.barDockControl7.Manager = this.barManager1;
            this.barDockControl7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl7.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(683, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(683, 24);
            this.barDockControl8.Manager = this.barManager1;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl8.Size = new System.Drawing.Size(0, 372);
            // 
            // frmCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 396);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.gcCongViec);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCongViec";
            this.Text = "Công Việc";
            this.Load += new System.EventHandler(this.frmCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCongViec;
        private MuaHeXanhDataSetTableAdapters.CongViecTableAdapter congViecTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietCV;
        private MuaHeXanhDataSetTableAdapters.ChiTietCongViecTableAdapter chiTietCongViecTableAdapter;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private DevExpress.XtraEditors.TextEdit txtTenCV;
        private DevExpress.XtraEditors.TextEdit txtMaCV;
        private DevExpress.XtraGrid.GridControl gcCongViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongViec;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemCV;
        private DevExpress.XtraBars.BarButtonItem btnSuaCV;
        private DevExpress.XtraBars.BarButtonItem btnGhiCV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnXoaCV;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachSV;
    }
}