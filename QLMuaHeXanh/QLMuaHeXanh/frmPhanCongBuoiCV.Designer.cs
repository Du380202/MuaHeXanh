namespace QLMuaHeXanh
{
    partial class frmPhanCongBuoiCV
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
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCongBuoiCV));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcNhomKhoa = new DevExpress.XtraGrid.GridControl();
            this.bdsNhomKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsBuoi = new System.Windows.Forms.BindingSource(this.components);
            this.buoiCVTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.BuoiCVTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.bdsNhom = new System.Windows.Forms.BindingSource(this.components);
            this.nhomTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.NhomTableAdapter();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.bdsPhanCong = new System.Windows.Forms.BindingSource(this.components);
            this.phanCongTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.PhanCongTableAdapter();
            this.nHOMKHOATableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.NHOMKHOATableAdapter();
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.cmbBuoi = new System.Windows.Forms.ComboBox();
            this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.bdsVPhanCong = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_PHANCONGTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.VIEW_PHANCONGTableAdapter();
            this.vIEW_PHANCONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNhom1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ghiChuLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhomKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVPhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_PHANCONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ghiChuLabel.Location = new System.Drawing.Point(77, 235);
            ghiChuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(62, 19);
            ghiChuLabel.TabIndex = 0;
            ghiChuLabel.Text = "Ghi Chú:";
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNhomLabel.Location = new System.Drawing.Point(77, 72);
            tenNhomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(77, 19);
            tenNhomLabel.TabIndex = 3;
            tenNhomLabel.Text = "Tên Nhóm:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcNhomKhoa);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(904, 326);
            this.panelControl1.TabIndex = 0;
            // 
            // gcNhomKhoa
            // 
            this.gcNhomKhoa.DataSource = this.bdsNhomKhoa;
            this.gcNhomKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhomKhoa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcNhomKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcNhomKhoa.Location = new System.Drawing.Point(2, 43);
            this.gcNhomKhoa.MainView = this.gridView2;
            this.gcNhomKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.gcNhomKhoa.Name = "gcNhomKhoa";
            this.gcNhomKhoa.Size = new System.Drawing.Size(900, 281);
            this.gcNhomKhoa.TabIndex = 2;
            this.gcNhomKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsNhomKhoa
            // 
            this.bdsNhomKhoa.DataMember = "NHOMKHOA";
            this.bdsNhomKhoa.DataSource = this.muaHeXanhDataSet;
            // 
            // muaHeXanhDataSet
            // 
            this.muaHeXanhDataSet.DataSetName = "MuaHeXanhDataSet";
            this.muaHeXanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhom,
            this.colTenNhom,
            this.colTenKhoa});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gcNhomKhoa;
            this.gridView2.Name = "gridView2";
            // 
            // colMaNhom
            // 
            this.colMaNhom.FieldName = "MaNhom";
            this.colMaNhom.MinWidth = 19;
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.Visible = true;
            this.colMaNhom.VisibleIndex = 0;
            this.colMaNhom.Width = 70;
            // 
            // colTenNhom
            // 
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.MinWidth = 19;
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 1;
            this.colTenNhom.Width = 70;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.FieldName = "TenKhoa";
            this.colTenKhoa.MinWidth = 19;
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.Visible = true;
            this.colTenKhoa.VisibleIndex = 2;
            this.colTenKhoa.Width = 70;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbKhoa);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(900, 41);
            this.panelControl2.TabIndex = 0;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(88, 8);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(192, 27);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa:";
            // 
            // bdsBuoi
            // 
            this.bdsBuoi.DataMember = "BuoiCV";
            this.bdsBuoi.DataSource = this.muaHeXanhDataSet;
            // 
            // buoiCVTableAdapter
            // 
            this.buoiCVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuoiCVTableAdapter = this.buoiCVTableAdapter;
            this.tableAdapterManager.ChiTietCongViecTableAdapter = null;
            this.tableAdapterManager.CongViecTableAdapter = null;
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
            // bdsNhom
            // 
            this.bdsNhom.DataMember = "Nhom";
            this.bdsNhom.DataSource = this.muaHeXanhDataSet;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 24);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Thêm ";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnDelete.Location = new System.Drawing.Point(75, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSave.Location = new System.Drawing.Point(150, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUndo.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnUndo.Location = new System.Drawing.Point(225, 0);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 24);
            this.btnUndo.TabIndex = 25;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 24);
            this.panel2.TabIndex = 22;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnReload.Location = new System.Drawing.Point(300, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 24);
            this.btnReload.TabIndex = 26;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // bdsPhanCong
            // 
            this.bdsPhanCong.DataMember = "PhanCong";
            this.bdsPhanCong.DataSource = this.muaHeXanhDataSet;
            // 
            // phanCongTableAdapter
            // 
            this.phanCongTableAdapter.ClearBeforeFill = true;
            // 
            // nHOMKHOATableAdapter
            // 
            this.nHOMKHOATableAdapter.ClearBeforeFill = true;
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(this.cmbBuoi);
            this.panelNhapXuat.Controls.Add(tenNhomLabel);
            this.panelNhapXuat.Controls.Add(this.txtTenNhom);
            this.panelNhapXuat.Controls.Add(this.label1);
            this.panelNhapXuat.Controls.Add(ghiChuLabel);
            this.panelNhapXuat.Controls.Add(this.txtGhiChu);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 350);
            this.panelNhapXuat.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(440, 320);
            this.panelNhapXuat.TabIndex = 23;
            // 
            // cmbBuoi
            // 
            this.cmbBuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbBuoi.FormattingEnabled = true;
            this.cmbBuoi.Location = new System.Drawing.Point(166, 145);
            this.cmbBuoi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuoi.Name = "cmbBuoi";
            this.cmbBuoi.Size = new System.Drawing.Size(161, 27);
            this.cmbBuoi.TabIndex = 5;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhomKhoa, "TenNhom", true));
            this.txtTenNhom.Location = new System.Drawing.Point(166, 69);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhom.Properties.Appearance.Options.UseFont = true;
            this.txtTenNhom.Size = new System.Drawing.Size(160, 26);
            this.txtTenNhom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(77, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buổi: ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhanCong, "GhiChu", true));
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(166, 222);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(161, 46);
            this.txtGhiChu.TabIndex = 1;
            this.txtGhiChu.Text = "";
            // 
            // bdsVPhanCong
            // 
            this.bdsVPhanCong.DataMember = "VIEW_PHANCONG";
            this.bdsVPhanCong.DataSource = this.muaHeXanhDataSet;
            // 
            // vIEW_PHANCONGTableAdapter
            // 
            this.vIEW_PHANCONGTableAdapter.ClearBeforeFill = true;
            // 
            // vIEW_PHANCONGGridControl
            // 
            this.vIEW_PHANCONGGridControl.DataSource = this.bdsVPhanCong;
            this.vIEW_PHANCONGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vIEW_PHANCONGGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.vIEW_PHANCONGGridControl.Location = new System.Drawing.Point(440, 350);
            this.vIEW_PHANCONGGridControl.MainView = this.gridView3;
            this.vIEW_PHANCONGGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.vIEW_PHANCONGGridControl.Name = "vIEW_PHANCONGGridControl";
            this.vIEW_PHANCONGGridControl.Size = new System.Drawing.Size(464, 320);
            this.vIEW_PHANCONGGridControl.TabIndex = 23;
            this.vIEW_PHANCONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNhom1,
            this.colTenBuoi,
            this.colGhiChu});
            this.gridView3.DetailHeight = 284;
            this.gridView3.GridControl = this.vIEW_PHANCONGGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colTenNhom1
            // 
            this.colTenNhom1.FieldName = "TenNhom";
            this.colTenNhom1.MinWidth = 19;
            this.colTenNhom1.Name = "colTenNhom1";
            this.colTenNhom1.Visible = true;
            this.colTenNhom1.VisibleIndex = 0;
            this.colTenNhom1.Width = 70;
            // 
            // colTenBuoi
            // 
            this.colTenBuoi.FieldName = "TenBuoi";
            this.colTenBuoi.MinWidth = 19;
            this.colTenBuoi.Name = "colTenBuoi";
            this.colTenBuoi.Visible = true;
            this.colTenBuoi.VisibleIndex = 1;
            this.colTenBuoi.Width = 70;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 19;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 70;
            // 
            // frmPhanCongBuoiCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 670);
            this.Controls.Add(this.vIEW_PHANCONGGridControl);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhanCongBuoiCV";
            this.Text = "Phân Công Buổi Công Việc";
            this.Load += new System.EventHandler(this.PhanCongBuoiCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhomKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVPhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_PHANCONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private System.Windows.Forms.BindingSource bdsBuoi;
        private MuaHeXanhDataSetTableAdapters.BuoiCVTableAdapter buoiCVTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsNhom;
        private MuaHeXanhDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bdsPhanCong;
        private MuaHeXanhDataSetTableAdapters.PhanCongTableAdapter phanCongTableAdapter;
        private System.Windows.Forms.BindingSource bdsNhomKhoa;
        private MuaHeXanhDataSetTableAdapters.NHOMKHOATableAdapter nHOMKHOATableAdapter;
        private DevExpress.XtraGrid.GridControl gcNhomKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoa;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private System.Windows.Forms.BindingSource bdsVPhanCong;
        private MuaHeXanhDataSetTableAdapters.VIEW_PHANCONGTableAdapter vIEW_PHANCONGTableAdapter;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private DevExpress.XtraGrid.GridControl vIEW_PHANCONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.ComboBox cmbBuoi;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}