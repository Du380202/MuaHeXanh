namespace QLMuaHeXanh
{
    partial class frmKhuVuc
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
            System.Windows.Forms.Label maDiaBanLabel;
            System.Windows.Forms.Label tenDiaBanLabel;
            System.Windows.Forms.Label maXaLabel;
            System.Windows.Forms.Label tenXaLabel;
            System.Windows.Forms.Label maDiaBanLabel1;
            System.Windows.Forms.Label maApLabel;
            System.Windows.Forms.Label tenApLabel;
            System.Windows.Forms.Label maXaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuVuc));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barSinhVien = new DevExpress.XtraBars.Bar();
            this.btnDiaBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnXa = new DevExpress.XtraBars.BarButtonItem();
            this.btnAp = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachSV = new DevExpress.XtraBars.BarButtonItem();
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.bdsDiaBan = new System.Windows.Forms.BindingSource(this.components);
            this.diaBanTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.DiaBanTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.xaTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.XaTableAdapter();
            this.bdsXa = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDiaBan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapDiaBan = new DevExpress.XtraEditors.PanelControl();
            this.btnLuuDB = new System.Windows.Forms.Button();
            this.btnXoaDB = new System.Windows.Forms.Button();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.txtTenDB = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaBan = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcXa = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDiaBan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGiamSat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGiamSat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDoiTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDoiPho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapXa = new DevExpress.XtraEditors.PanelControl();
            this.btnLuuXa = new System.Windows.Forms.Button();
            this.btnXoaXa = new System.Windows.Forms.Button();
            this.btnThemXa = new System.Windows.Forms.Button();
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.txtTenXa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaXa = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcAp = new DevExpress.XtraGrid.GridControl();
            this.apBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaXa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapAp = new DevExpress.XtraEditors.PanelControl();
            this.cmbXa1 = new System.Windows.Forms.ComboBox();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaAp1 = new DevExpress.XtraEditors.TextEdit();
            this.btnLuuAp = new System.Windows.Forms.Button();
            this.btnXoaAp = new System.Windows.Forms.Button();
            this.btnThemAp = new System.Windows.Forms.Button();
            this.apTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ApTableAdapter();
            maDiaBanLabel = new System.Windows.Forms.Label();
            tenDiaBanLabel = new System.Windows.Forms.Label();
            maXaLabel = new System.Windows.Forms.Label();
            tenXaLabel = new System.Windows.Forms.Label();
            maDiaBanLabel1 = new System.Windows.Forms.Label();
            maApLabel = new System.Windows.Forms.Label();
            tenApLabel = new System.Windows.Forms.Label();
            maXaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapDiaBan)).BeginInit();
            this.panelNhapDiaBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXa)).BeginInit();
            this.panelNhapXa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapAp)).BeginInit();
            this.panelNhapAp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaAp1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maDiaBanLabel
            // 
            maDiaBanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maDiaBanLabel.AutoSize = true;
            maDiaBanLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDiaBanLabel.Location = new System.Drawing.Point(110, 46);
            maDiaBanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maDiaBanLabel.Name = "maDiaBanLabel";
            maDiaBanLabel.Size = new System.Drawing.Size(86, 19);
            maDiaBanLabel.TabIndex = 0;
            maDiaBanLabel.Text = "Mã Địa Bàn:";
            // 
            // tenDiaBanLabel
            // 
            tenDiaBanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenDiaBanLabel.AutoSize = true;
            tenDiaBanLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenDiaBanLabel.Location = new System.Drawing.Point(110, 110);
            tenDiaBanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenDiaBanLabel.Name = "tenDiaBanLabel";
            tenDiaBanLabel.Size = new System.Drawing.Size(88, 19);
            tenDiaBanLabel.TabIndex = 2;
            tenDiaBanLabel.Text = "Tên Địa Bàn:";
            // 
            // maXaLabel
            // 
            maXaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maXaLabel.AutoSize = true;
            maXaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maXaLabel.Location = new System.Drawing.Point(107, 93);
            maXaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maXaLabel.Name = "maXaLabel";
            maXaLabel.Size = new System.Drawing.Size(55, 19);
            maXaLabel.TabIndex = 0;
            maXaLabel.Text = "Mã Xã:";
            // 
            // tenXaLabel
            // 
            tenXaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenXaLabel.AutoSize = true;
            tenXaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenXaLabel.Location = new System.Drawing.Point(107, 150);
            tenXaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenXaLabel.Name = "tenXaLabel";
            tenXaLabel.Size = new System.Drawing.Size(57, 19);
            tenXaLabel.TabIndex = 2;
            tenXaLabel.Text = "Tên Xã:";
            // 
            // maDiaBanLabel1
            // 
            maDiaBanLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            maDiaBanLabel1.AutoSize = true;
            maDiaBanLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maDiaBanLabel1.Location = new System.Drawing.Point(107, 40);
            maDiaBanLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maDiaBanLabel1.Name = "maDiaBanLabel1";
            maDiaBanLabel1.Size = new System.Drawing.Size(86, 19);
            maDiaBanLabel1.TabIndex = 4;
            maDiaBanLabel1.Text = "Mã Địa Bàn:";
            // 
            // maApLabel
            // 
            maApLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maApLabel.AutoSize = true;
            maApLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maApLabel.Location = new System.Drawing.Point(110, 127);
            maApLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maApLabel.Name = "maApLabel";
            maApLabel.Size = new System.Drawing.Size(56, 19);
            maApLabel.TabIndex = 7;
            maApLabel.Text = "Mã Ấp:";
            // 
            // tenApLabel
            // 
            tenApLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenApLabel.AutoSize = true;
            tenApLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenApLabel.Location = new System.Drawing.Point(110, 189);
            tenApLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenApLabel.Name = "tenApLabel";
            tenApLabel.Size = new System.Drawing.Size(58, 19);
            tenApLabel.TabIndex = 8;
            tenApLabel.Text = "Tên Ấp:";
            // 
            // maXaLabel1
            // 
            maXaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            maXaLabel1.AutoSize = true;
            maXaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maXaLabel1.Location = new System.Drawing.Point(110, 75);
            maXaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maXaLabel1.Name = "maXaLabel1";
            maXaLabel1.Size = new System.Drawing.Size(55, 19);
            maXaLabel1.TabIndex = 9;
            maXaLabel1.Text = "Mã Xã:";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barSinhVien});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnDiaBan,
            this.btnXa,
            this.btnAp,
            this.btnDanhSachSV,
            this.btnHoanTac,
            this.btnReload});
            this.barManager2.MaxItemId = 20;
            // 
            // barSinhVien
            // 
            this.barSinhVien.BarName = "Tools";
            this.barSinhVien.DockCol = 0;
            this.barSinhVien.DockRow = 0;
            this.barSinhVien.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barSinhVien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDiaBan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAp, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSinhVien.Text = "Tools";
            // 
            // btnDiaBan
            // 
            this.btnDiaBan.Caption = "Địa Bàn";
            this.btnDiaBan.Id = 2;
            this.btnDiaBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDiaBan.ImageOptions.Image")));
            this.btnDiaBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDiaBan.ImageOptions.LargeImage")));
            this.btnDiaBan.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDiaBan.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDiaBan.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDiaBan.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDiaBan.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnDiaBan.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnDiaBan.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDiaBan.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiaBan.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnDiaBan.Name = "btnDiaBan";
            this.btnDiaBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiaBan_ItemClick);
            // 
            // btnXa
            // 
            this.btnXa.Caption = "Xã";
            this.btnXa.Id = 5;
            this.btnXa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXa.ImageOptions.Image")));
            this.btnXa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXa.ImageOptions.LargeImage")));
            this.btnXa.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXa.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnXa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnXa.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXa.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnXa.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnXa.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnXa.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnXa.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXa.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnXa.Name = "btnXa";
            this.btnXa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXa_ItemClick);
            // 
            // btnAp
            // 
            this.btnAp.Caption = "Ấp";
            this.btnAp.Id = 6;
            this.btnAp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAp.ImageOptions.SvgImage")));
            this.btnAp.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnAp.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAp.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAp.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnAp.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnAp.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnAp.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnAp.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAp.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnAp.Name = "btnAp";
            this.btnAp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAp_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn Tác";
            this.btnHoanTac.Id = 17;
            this.btnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanTac.ImageOptions.SvgImage")));
            this.btnHoanTac.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnHoanTac.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnHoanTac.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHoanTac.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnHoanTac.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnHoanTac.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnHoanTac.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnHoanTac.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHoanTac.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 19;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReload.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnReload.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnReload.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReload.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReload.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl1.Size = new System.Drawing.Size(1924, 26);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 709);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl2.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 26);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl3.Size = new System.Drawing.Size(0, 683);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1924, 26);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl4.Size = new System.Drawing.Size(0, 683);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDanhSachSV
            // 
            this.btnDanhSachSV.Caption = "Danh sách giáo viên";
            this.btnDanhSachSV.Id = 12;
            this.btnDanhSachSV.Name = "btnDanhSachSV";
            // 
            // muaHeXanhDataSet
            // 
            this.muaHeXanhDataSet.DataSetName = "MuaHeXanhDataSet";
            this.muaHeXanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDiaBan
            // 
            this.bdsDiaBan.DataMember = "DiaBan";
            this.bdsDiaBan.DataSource = this.muaHeXanhDataSet;
            // 
            // diaBanTableAdapter
            // 
            this.diaBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuoiCVTableAdapter = null;
            this.tableAdapterManager.ChiTietCongViecTableAdapter = null;
            this.tableAdapterManager.CongViecTableAdapter = null;
            this.tableAdapterManager.DiaBanTableAdapter = this.diaBanTableAdapter;
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
            this.tableAdapterManager.XaTableAdapter = this.xaTableAdapter;
            // 
            // xaTableAdapter
            // 
            this.xaTableAdapter.ClearBeforeFill = true;
            // 
            // bdsXa
            // 
            this.bdsXa.DataMember = "FK_Xa_DiaBan";
            this.bdsXa.DataSource = this.bdsDiaBan;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcDiaBan);
            this.panelControl1.Controls.Add(this.panelNhapDiaBan);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 26);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1924, 196);
            this.panelControl1.TabIndex = 4;
            // 
            // gcDiaBan
            // 
            this.gcDiaBan.DataSource = this.bdsDiaBan;
            this.gcDiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiaBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcDiaBan.Location = new System.Drawing.Point(2, 2);
            this.gcDiaBan.MainView = this.gridView1;
            this.gcDiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.gcDiaBan.MenuManager = this.barManager2;
            this.gcDiaBan.Name = "gcDiaBan";
            this.gcDiaBan.Size = new System.Drawing.Size(1353, 192);
            this.gcDiaBan.TabIndex = 1;
            this.gcDiaBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDiaBan,
            this.colTenDiaBan});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gcDiaBan;
            this.gridView1.Name = "gridView1";
            // 
            // colMaDiaBan
            // 
            this.colMaDiaBan.FieldName = "MaDiaBan";
            this.colMaDiaBan.MinWidth = 19;
            this.colMaDiaBan.Name = "colMaDiaBan";
            this.colMaDiaBan.Visible = true;
            this.colMaDiaBan.VisibleIndex = 0;
            this.colMaDiaBan.Width = 70;
            // 
            // colTenDiaBan
            // 
            this.colTenDiaBan.FieldName = "TenDiaBan";
            this.colTenDiaBan.MinWidth = 19;
            this.colTenDiaBan.Name = "colTenDiaBan";
            this.colTenDiaBan.Visible = true;
            this.colTenDiaBan.VisibleIndex = 1;
            this.colTenDiaBan.Width = 70;
            // 
            // panelNhapDiaBan
            // 
            this.panelNhapDiaBan.Controls.Add(this.btnLuuDB);
            this.panelNhapDiaBan.Controls.Add(this.btnXoaDB);
            this.panelNhapDiaBan.Controls.Add(this.btnThemDB);
            this.panelNhapDiaBan.Controls.Add(tenDiaBanLabel);
            this.panelNhapDiaBan.Controls.Add(this.txtTenDB);
            this.panelNhapDiaBan.Controls.Add(maDiaBanLabel);
            this.panelNhapDiaBan.Controls.Add(this.txtDiaBan);
            this.panelNhapDiaBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNhapDiaBan.Enabled = false;
            this.panelNhapDiaBan.Location = new System.Drawing.Point(1355, 2);
            this.panelNhapDiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapDiaBan.Name = "panelNhapDiaBan";
            this.panelNhapDiaBan.Size = new System.Drawing.Size(567, 192);
            this.panelNhapDiaBan.TabIndex = 0;
            // 
            // btnLuuDB
            // 
            this.btnLuuDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDB.Location = new System.Drawing.Point(406, 76);
            this.btnLuuDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuDB.Name = "btnLuuDB";
            this.btnLuuDB.Size = new System.Drawing.Size(56, 24);
            this.btnLuuDB.TabIndex = 6;
            this.btnLuuDB.Text = "Lưu";
            this.btnLuuDB.UseVisualStyleBackColor = true;
            this.btnLuuDB.Click += new System.EventHandler(this.btnLuuDB_Click);
            // 
            // btnXoaDB
            // 
            this.btnXoaDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDB.Location = new System.Drawing.Point(406, 132);
            this.btnXoaDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDB.Name = "btnXoaDB";
            this.btnXoaDB.Size = new System.Drawing.Size(56, 24);
            this.btnXoaDB.TabIndex = 5;
            this.btnXoaDB.Text = "Xóa";
            this.btnXoaDB.UseVisualStyleBackColor = true;
            this.btnXoaDB.Click += new System.EventHandler(this.btnXoaDB_Click);
            // 
            // btnThemDB
            // 
            this.btnThemDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDB.Location = new System.Drawing.Point(406, 27);
            this.btnThemDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(56, 24);
            this.btnThemDB.TabIndex = 4;
            this.btnThemDB.Text = "Thêm";
            this.btnThemDB.UseVisualStyleBackColor = true;
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            // 
            // txtTenDB
            // 
            this.txtTenDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDiaBan, "TenDiaBan", true));
            this.txtTenDB.Location = new System.Drawing.Point(211, 108);
            this.txtTenDB.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDB.MenuManager = this.barManager2;
            this.txtTenDB.Name = "txtTenDB";
            this.txtTenDB.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDB.Properties.Appearance.Options.UseFont = true;
            this.txtTenDB.Size = new System.Drawing.Size(156, 26);
            this.txtTenDB.TabIndex = 3;
            // 
            // txtDiaBan
            // 
            this.txtDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaBan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDiaBan, "MaDiaBan", true));
            this.txtDiaBan.Location = new System.Drawing.Point(211, 43);
            this.txtDiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaBan.MenuManager = this.barManager2;
            this.txtDiaBan.Name = "txtDiaBan";
            this.txtDiaBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaBan.Properties.Appearance.Options.UseFont = true;
            this.txtDiaBan.Size = new System.Drawing.Size(156, 26);
            this.txtDiaBan.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcXa);
            this.panelControl2.Controls.Add(this.panelNhapXa);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 222);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1924, 212);
            this.panelControl2.TabIndex = 5;
            // 
            // gcXa
            // 
            this.gcXa.DataSource = this.bdsXa;
            this.gcXa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcXa.Location = new System.Drawing.Point(2, 2);
            this.gcXa.MainView = this.gridView2;
            this.gcXa.Margin = new System.Windows.Forms.Padding(2);
            this.gcXa.MenuManager = this.barManager2;
            this.gcXa.Name = "gcXa";
            this.gcXa.Size = new System.Drawing.Size(1353, 208);
            this.gcXa.TabIndex = 1;
            this.gcXa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaXa,
            this.colTenXa,
            this.colMaDiaBan1,
            this.colMaGiamSat1,
            this.colMaGiamSat2,
            this.colMaDoiTruong,
            this.colMaDoiPho});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gcXa;
            this.gridView2.Name = "gridView2";
            // 
            // colMaXa
            // 
            this.colMaXa.FieldName = "MaXa";
            this.colMaXa.MinWidth = 19;
            this.colMaXa.Name = "colMaXa";
            this.colMaXa.Visible = true;
            this.colMaXa.VisibleIndex = 0;
            this.colMaXa.Width = 70;
            // 
            // colTenXa
            // 
            this.colTenXa.FieldName = "TenXa";
            this.colTenXa.MinWidth = 19;
            this.colTenXa.Name = "colTenXa";
            this.colTenXa.Visible = true;
            this.colTenXa.VisibleIndex = 1;
            this.colTenXa.Width = 70;
            // 
            // colMaDiaBan1
            // 
            this.colMaDiaBan1.FieldName = "MaDiaBan";
            this.colMaDiaBan1.MinWidth = 19;
            this.colMaDiaBan1.Name = "colMaDiaBan1";
            this.colMaDiaBan1.Visible = true;
            this.colMaDiaBan1.VisibleIndex = 2;
            this.colMaDiaBan1.Width = 70;
            // 
            // colMaGiamSat1
            // 
            this.colMaGiamSat1.FieldName = "MaGiamSat1";
            this.colMaGiamSat1.MinWidth = 19;
            this.colMaGiamSat1.Name = "colMaGiamSat1";
            this.colMaGiamSat1.Visible = true;
            this.colMaGiamSat1.VisibleIndex = 3;
            this.colMaGiamSat1.Width = 70;
            // 
            // colMaGiamSat2
            // 
            this.colMaGiamSat2.FieldName = "MaGiamSat2";
            this.colMaGiamSat2.MinWidth = 19;
            this.colMaGiamSat2.Name = "colMaGiamSat2";
            this.colMaGiamSat2.Visible = true;
            this.colMaGiamSat2.VisibleIndex = 4;
            this.colMaGiamSat2.Width = 70;
            // 
            // colMaDoiTruong
            // 
            this.colMaDoiTruong.FieldName = "MaDoiTruong";
            this.colMaDoiTruong.MinWidth = 19;
            this.colMaDoiTruong.Name = "colMaDoiTruong";
            this.colMaDoiTruong.Visible = true;
            this.colMaDoiTruong.VisibleIndex = 5;
            this.colMaDoiTruong.Width = 70;
            // 
            // colMaDoiPho
            // 
            this.colMaDoiPho.FieldName = "MaDoiPho";
            this.colMaDoiPho.MinWidth = 19;
            this.colMaDoiPho.Name = "colMaDoiPho";
            this.colMaDoiPho.Visible = true;
            this.colMaDoiPho.VisibleIndex = 6;
            this.colMaDoiPho.Width = 70;
            // 
            // panelNhapXa
            // 
            this.panelNhapXa.Controls.Add(this.btnLuuXa);
            this.panelNhapXa.Controls.Add(this.btnXoaXa);
            this.panelNhapXa.Controls.Add(this.btnThemXa);
            this.panelNhapXa.Controls.Add(maDiaBanLabel1);
            this.panelNhapXa.Controls.Add(this.cmbDiaBan);
            this.panelNhapXa.Controls.Add(tenXaLabel);
            this.panelNhapXa.Controls.Add(this.txtTenXa);
            this.panelNhapXa.Controls.Add(maXaLabel);
            this.panelNhapXa.Controls.Add(this.txtMaXa);
            this.panelNhapXa.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNhapXa.Enabled = false;
            this.panelNhapXa.Location = new System.Drawing.Point(1355, 2);
            this.panelNhapXa.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapXa.Name = "panelNhapXa";
            this.panelNhapXa.Size = new System.Drawing.Size(567, 208);
            this.panelNhapXa.TabIndex = 0;
            // 
            // btnLuuXa
            // 
            this.btnLuuXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuXa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuXa.Location = new System.Drawing.Point(406, 90);
            this.btnLuuXa.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuXa.Name = "btnLuuXa";
            this.btnLuuXa.Size = new System.Drawing.Size(56, 24);
            this.btnLuuXa.TabIndex = 8;
            this.btnLuuXa.Text = "Lưu";
            this.btnLuuXa.UseVisualStyleBackColor = true;
            this.btnLuuXa.Click += new System.EventHandler(this.btnLuuXa_Click);
            // 
            // btnXoaXa
            // 
            this.btnXoaXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaXa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXa.Location = new System.Drawing.Point(406, 146);
            this.btnXoaXa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaXa.Name = "btnXoaXa";
            this.btnXoaXa.Size = new System.Drawing.Size(56, 24);
            this.btnXoaXa.TabIndex = 7;
            this.btnXoaXa.Text = "Xóa";
            this.btnXoaXa.UseVisualStyleBackColor = true;
            this.btnXoaXa.Click += new System.EventHandler(this.btnXoaXa_Click);
            // 
            // btnThemXa
            // 
            this.btnThemXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemXa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXa.Location = new System.Drawing.Point(406, 37);
            this.btnThemXa.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemXa.Name = "btnThemXa";
            this.btnThemXa.Size = new System.Drawing.Size(56, 24);
            this.btnThemXa.TabIndex = 6;
            this.btnThemXa.Text = "Thêm";
            this.btnThemXa.UseVisualStyleBackColor = true;
            this.btnThemXa.Click += new System.EventHandler(this.btnThemXa_Click);
            // 
            // cmbDiaBan
            // 
            this.cmbDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiaBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsXa, "MaDiaBan", true));
            this.cmbDiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(211, 37);
            this.cmbDiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(157, 27);
            this.cmbDiaBan.TabIndex = 5;
            // 
            // txtTenXa
            // 
            this.txtTenXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenXa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXa, "TenXa", true));
            this.txtTenXa.Location = new System.Drawing.Point(211, 148);
            this.txtTenXa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenXa.MenuManager = this.barManager2;
            this.txtTenXa.Name = "txtTenXa";
            this.txtTenXa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenXa.Properties.Appearance.Options.UseFont = true;
            this.txtTenXa.Size = new System.Drawing.Size(156, 26);
            this.txtTenXa.TabIndex = 3;
            // 
            // txtMaXa
            // 
            this.txtMaXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaXa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXa, "MaXa", true));
            this.txtMaXa.Location = new System.Drawing.Point(211, 91);
            this.txtMaXa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXa.MenuManager = this.barManager2;
            this.txtMaXa.Name = "txtMaXa";
            this.txtMaXa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaXa.Properties.Appearance.Options.UseFont = true;
            this.txtMaXa.Size = new System.Drawing.Size(156, 26);
            this.txtMaXa.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcAp);
            this.panelControl3.Controls.Add(this.panelNhapAp);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 434);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1924, 275);
            this.panelControl3.TabIndex = 6;
            // 
            // gcAp
            // 
            this.gcAp.DataSource = this.apBindingSource;
            this.gcAp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcAp.Location = new System.Drawing.Point(2, 2);
            this.gcAp.MainView = this.gridView3;
            this.gcAp.Margin = new System.Windows.Forms.Padding(2);
            this.gcAp.MenuManager = this.barManager2;
            this.gcAp.Name = "gcAp";
            this.gcAp.Size = new System.Drawing.Size(1353, 271);
            this.gcAp.TabIndex = 1;
            this.gcAp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // apBindingSource
            // 
            this.apBindingSource.DataMember = "FK_Ap_Xa";
            this.apBindingSource.DataSource = this.bdsXa;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaAp,
            this.colTenAp,
            this.colMaXa1});
            this.gridView3.DetailHeight = 284;
            this.gridView3.GridControl = this.gcAp;
            this.gridView3.Name = "gridView3";
            // 
            // colMaAp
            // 
            this.colMaAp.FieldName = "MaAp";
            this.colMaAp.MinWidth = 19;
            this.colMaAp.Name = "colMaAp";
            this.colMaAp.Visible = true;
            this.colMaAp.VisibleIndex = 0;
            this.colMaAp.Width = 70;
            // 
            // colTenAp
            // 
            this.colTenAp.FieldName = "TenAp";
            this.colTenAp.MinWidth = 19;
            this.colTenAp.Name = "colTenAp";
            this.colTenAp.Visible = true;
            this.colTenAp.VisibleIndex = 1;
            this.colTenAp.Width = 70;
            // 
            // colMaXa1
            // 
            this.colMaXa1.FieldName = "MaXa";
            this.colMaXa1.MinWidth = 19;
            this.colMaXa1.Name = "colMaXa1";
            this.colMaXa1.Visible = true;
            this.colMaXa1.VisibleIndex = 2;
            this.colMaXa1.Width = 70;
            // 
            // panelNhapAp
            // 
            this.panelNhapAp.Controls.Add(this.cmbXa1);
            this.panelNhapAp.Controls.Add(this.txtTen);
            this.panelNhapAp.Controls.Add(this.txtMaAp1);
            this.panelNhapAp.Controls.Add(this.btnLuuAp);
            this.panelNhapAp.Controls.Add(this.btnXoaAp);
            this.panelNhapAp.Controls.Add(maXaLabel1);
            this.panelNhapAp.Controls.Add(tenApLabel);
            this.panelNhapAp.Controls.Add(maApLabel);
            this.panelNhapAp.Controls.Add(this.btnThemAp);
            this.panelNhapAp.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNhapAp.Enabled = false;
            this.panelNhapAp.Location = new System.Drawing.Point(1355, 2);
            this.panelNhapAp.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapAp.Name = "panelNhapAp";
            this.panelNhapAp.Size = new System.Drawing.Size(567, 271);
            this.panelNhapAp.TabIndex = 0;
            // 
            // cmbXa1
            // 
            this.cmbXa1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbXa1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apBindingSource, "MaXa", true));
            this.cmbXa1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXa1.FormattingEnabled = true;
            this.cmbXa1.Location = new System.Drawing.Point(211, 72);
            this.cmbXa1.Name = "cmbXa1";
            this.cmbXa1.Size = new System.Drawing.Size(157, 27);
            this.cmbXa1.TabIndex = 15;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.apBindingSource, "TenAp", true));
            this.txtTen.Location = new System.Drawing.Point(211, 190);
            this.txtTen.MenuManager = this.barManager2;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(156, 26);
            this.txtTen.TabIndex = 14;
            // 
            // txtMaAp1
            // 
            this.txtMaAp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaAp1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.apBindingSource, "MaAp", true));
            this.txtMaAp1.Location = new System.Drawing.Point(211, 124);
            this.txtMaAp1.MenuManager = this.barManager2;
            this.txtMaAp1.Name = "txtMaAp1";
            this.txtMaAp1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaAp1.Properties.Appearance.Options.UseFont = true;
            this.txtMaAp1.Size = new System.Drawing.Size(157, 26);
            this.txtMaAp1.TabIndex = 13;
            // 
            // btnLuuAp
            // 
            this.btnLuuAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuAp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuAp.Location = new System.Drawing.Point(406, 124);
            this.btnLuuAp.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuAp.Name = "btnLuuAp";
            this.btnLuuAp.Size = new System.Drawing.Size(56, 24);
            this.btnLuuAp.TabIndex = 12;
            this.btnLuuAp.Text = "Lưu";
            this.btnLuuAp.UseVisualStyleBackColor = true;
            this.btnLuuAp.Click += new System.EventHandler(this.btnLuuAp_Click);
            // 
            // btnXoaAp
            // 
            this.btnXoaAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaAp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAp.Location = new System.Drawing.Point(406, 180);
            this.btnXoaAp.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaAp.Name = "btnXoaAp";
            this.btnXoaAp.Size = new System.Drawing.Size(56, 24);
            this.btnXoaAp.TabIndex = 11;
            this.btnXoaAp.Text = "Xóa";
            this.btnXoaAp.UseVisualStyleBackColor = true;
            this.btnXoaAp.Click += new System.EventHandler(this.btnXoaAp_Click);
            // 
            // btnThemAp
            // 
            this.btnThemAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemAp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAp.Location = new System.Drawing.Point(406, 69);
            this.btnThemAp.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemAp.Name = "btnThemAp";
            this.btnThemAp.Size = new System.Drawing.Size(56, 24);
            this.btnThemAp.TabIndex = 6;
            this.btnThemAp.Text = "Thêm";
            this.btnThemAp.UseVisualStyleBackColor = true;
            this.btnThemAp.Click += new System.EventHandler(this.btnThemAp_Click);
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 709);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKhuVuc";
            this.Text = "Khu Vực";
            this.Load += new System.EventHandler(this.frmKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapDiaBan)).EndInit();
            this.panelNhapDiaBan.ResumeLayout(false);
            this.panelNhapDiaBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXa)).EndInit();
            this.panelNhapXa.ResumeLayout(false);
            this.panelNhapXa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapAp)).EndInit();
            this.panelNhapAp.ResumeLayout(false);
            this.panelNhapAp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaAp1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar barSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnDiaBan;
        private DevExpress.XtraBars.BarButtonItem btnXa;
        private DevExpress.XtraBars.BarButtonItem btnAp;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachSV;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private System.Windows.Forms.BindingSource bdsDiaBan;
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private MuaHeXanhDataSetTableAdapters.DiaBanTableAdapter diaBanTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MuaHeXanhDataSetTableAdapters.XaTableAdapter xaTableAdapter;
        private System.Windows.Forms.BindingSource bdsXa;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcXa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaXa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenXa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDiaBan1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGiamSat1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGiamSat2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoiTruong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoiPho;
        private DevExpress.XtraEditors.PanelControl panelNhapXa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcDiaBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDiaBan;
        private DevExpress.XtraEditors.PanelControl panelNhapDiaBan;
        private System.Windows.Forms.Button btnThemDB;
        private DevExpress.XtraEditors.TextEdit txtTenDB;
        private DevExpress.XtraEditors.TextEdit txtDiaBan;
        private System.Windows.Forms.Button btnThemXa;
        private System.Windows.Forms.ComboBox cmbDiaBan;
        private DevExpress.XtraEditors.TextEdit txtTenXa;
        private DevExpress.XtraEditors.TextEdit txtMaXa;
        private System.Windows.Forms.Button btnLuuDB;
        private System.Windows.Forms.Button btnXoaDB;
        private System.Windows.Forms.Button btnLuuXa;
        private System.Windows.Forms.Button btnXoaXa;
        private System.Windows.Forms.BindingSource apBindingSource;
        private MuaHeXanhDataSetTableAdapters.ApTableAdapter apTableAdapter;
        private DevExpress.XtraGrid.GridControl gcAp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp;
        private DevExpress.XtraGrid.Columns.GridColumn colMaXa1;
        private DevExpress.XtraEditors.PanelControl panelNhapAp;
        private System.Windows.Forms.Button btnLuuAp;
        private System.Windows.Forms.Button btnXoaAp;
        private System.Windows.Forms.Button btnThemAp;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private System.Windows.Forms.ComboBox cmbXa1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMaAp1;
    }
}