namespace QLMuaHeXanh
{
    partial class frmChiTietCongViec
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
            System.Windows.Forms.Label tenCongViecLabel;
            System.Windows.Forms.Label tenApLabel;
            System.Windows.Forms.Label ngayBatDauLabel;
            System.Windows.Forms.Label ngayKetThucLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietCongViec));
            this.bdsCongViec = new System.Windows.Forms.BindingSource(this.components);
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.bdsAp = new System.Windows.Forms.BindingSource(this.components);
            this.apTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ApTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.congViecTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.CongViecTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.bdsVChiTiet = new System.Windows.Forms.BindingSource(this.components);
            this.vChiTietCVTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.VChiTietCVTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcCTAp = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietAp = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCongViec = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmbXa = new System.Windows.Forms.ComboBox();
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenCongViec1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVCTCV = new DevExpress.XtraGrid.GridControl();
            this.chiTietApTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ChiTietApTableAdapter();
            this.txtCongViec = new DevExpress.XtraEditors.TextEdit();
            this.txtTenAp = new DevExpress.XtraEditors.TextEdit();
            this.dNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.dNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.thucHienCongViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucHienCongViecTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ThucHienCongViecTableAdapter();
            tenCongViecLabel = new System.Windows.Forms.Label();
            tenApLabel = new System.Windows.Forms.Label();
            ngayBatDauLabel = new System.Windows.Forms.Label();
            ngayKetThucLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVCTCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenAp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thucHienCongViecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenCongViecLabel
            // 
            tenCongViecLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenCongViecLabel.AutoSize = true;
            tenCongViecLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenCongViecLabel.Location = new System.Drawing.Point(51, 54);
            tenCongViecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenCongViecLabel.Name = "tenCongViecLabel";
            tenCongViecLabel.Size = new System.Drawing.Size(103, 19);
            tenCongViecLabel.TabIndex = 0;
            tenCongViecLabel.Text = "Tên Công Việc:";
            // 
            // tenApLabel
            // 
            tenApLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenApLabel.AutoSize = true;
            tenApLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenApLabel.Location = new System.Drawing.Point(51, 111);
            tenApLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenApLabel.Name = "tenApLabel";
            tenApLabel.Size = new System.Drawing.Size(58, 19);
            tenApLabel.TabIndex = 2;
            tenApLabel.Text = "Tên Ấp:";
            // 
            // ngayBatDauLabel
            // 
            ngayBatDauLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ngayBatDauLabel.AutoSize = true;
            ngayBatDauLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayBatDauLabel.Location = new System.Drawing.Point(51, 167);
            ngayBatDauLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngayBatDauLabel.Name = "ngayBatDauLabel";
            ngayBatDauLabel.Size = new System.Drawing.Size(99, 19);
            ngayBatDauLabel.TabIndex = 4;
            ngayBatDauLabel.Text = "Ngày Bắt Đầu:";
            // 
            // ngayKetThucLabel
            // 
            ngayKetThucLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ngayKetThucLabel.AutoSize = true;
            ngayKetThucLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayKetThucLabel.Location = new System.Drawing.Point(51, 226);
            ngayKetThucLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngayKetThucLabel.Name = "ngayKetThucLabel";
            ngayKetThucLabel.Size = new System.Drawing.Size(106, 19);
            ngayKetThucLabel.TabIndex = 6;
            ngayKetThucLabel.Text = "Ngày Kết Thúc:";
            // 
            // bdsCongViec
            // 
            this.bdsCongViec.DataMember = "CongViec";
            this.bdsCongViec.DataSource = this.muaHeXanhDataSet;
            // 
            // muaHeXanhDataSet
            // 
            this.muaHeXanhDataSet.DataSetName = "MuaHeXanhDataSet";
            this.muaHeXanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsAp
            // 
            this.bdsAp.DataMember = "Ap";
            this.bdsAp.DataSource = this.muaHeXanhDataSet;
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = this.apTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuoiCVTableAdapter = null;
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
            // congViecTableAdapter
            // 
            this.congViecTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 24);
            this.panel2.TabIndex = 24;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnReload.Location = new System.Drawing.Point(375, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 24);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // btnUndo
            // 
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUndo.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnUndo.Location = new System.Drawing.Point(300, 0);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 24);
            this.btnUndo.TabIndex = 26;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnDelete.Location = new System.Drawing.Point(225, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSave.Location = new System.Drawing.Point(150, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnEdit.Location = new System.Drawing.Point(75, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 24);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 24);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Add";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // bdsVChiTiet
            // 
            this.bdsVChiTiet.DataMember = "VChiTietCV";
            this.bdsVChiTiet.DataSource = this.muaHeXanhDataSet;
            // 
            // vChiTietCVTableAdapter
            // 
            this.vChiTietCVTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcCTAp);
            this.panelControl1.Controls.Add(this.gcCongViec);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(846, 296);
            this.panelControl1.TabIndex = 0;
            // 
            // gcCTAp
            // 
            this.gcCTAp.DataSource = this.bdsChiTietAp;
            this.gcCTAp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTAp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcCTAp.Location = new System.Drawing.Point(534, 43);
            this.gcCTAp.MainView = this.gridView2;
            this.gcCTAp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcCTAp.Name = "gcCTAp";
            this.gcCTAp.Size = new System.Drawing.Size(310, 251);
            this.gcCTAp.TabIndex = 2;
            this.gcCTAp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsChiTietAp
            // 
            this.bdsChiTietAp.DataMember = "ChiTietAp";
            this.bdsChiTietAp.DataSource = this.muaHeXanhDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaAp,
            this.colTenAp,
            this.colTenXa,
            this.colTenDiaBan});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gcCTAp;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
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
            // colTenXa
            // 
            this.colTenXa.FieldName = "TenXa";
            this.colTenXa.MinWidth = 19;
            this.colTenXa.Name = "colTenXa";
            this.colTenXa.Visible = true;
            this.colTenXa.VisibleIndex = 2;
            this.colTenXa.Width = 70;
            // 
            // colTenDiaBan
            // 
            this.colTenDiaBan.FieldName = "TenDiaBan";
            this.colTenDiaBan.MinWidth = 19;
            this.colTenDiaBan.Name = "colTenDiaBan";
            this.colTenDiaBan.Visible = true;
            this.colTenDiaBan.VisibleIndex = 3;
            this.colTenDiaBan.Width = 70;
            // 
            // gcCongViec
            // 
            this.gcCongViec.DataSource = this.bdsCongViec;
            this.gcCongViec.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcCongViec.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcCongViec.Location = new System.Drawing.Point(2, 43);
            this.gcCongViec.MainView = this.gridView1;
            this.gcCongViec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcCongViec.Name = "gcCongViec";
            this.gcCongViec.Size = new System.Drawing.Size(532, 251);
            this.gcCongViec.TabIndex = 1;
            this.gcCongViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCongViec,
            this.colTenCongViec});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gcCongViec;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
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
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.cmbXa);
            this.panelControl3.Controls.Add(this.cmbDiaBan);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(842, 41);
            this.panelControl3.TabIndex = 0;
            // 
            // cmbXa
            // 
            this.cmbXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbXa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbXa.FormattingEnabled = true;
            this.cmbXa.Location = new System.Drawing.Point(434, 8);
            this.cmbXa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbXa.Name = "cmbXa";
            this.cmbXa.Size = new System.Drawing.Size(166, 27);
            this.cmbXa.TabIndex = 3;
            this.cmbXa.SelectedIndexChanged += new System.EventHandler(this.cmbXa_SelectedIndexChanged);
            // 
            // cmbDiaBan
            // 
            this.cmbDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(148, 8);
            this.cmbDiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(166, 27);
            this.cmbDiaBan.TabIndex = 2;
            this.cmbDiaBan.SelectedIndexChanged += new System.EventHandler(this.cmbDiaBan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(395, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xã";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa Bàn: ";
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenCongViec1,
            this.colTenAp1,
            this.colNgayBatDau,
            this.colNgayKetThuc});
            this.gridView3.DetailHeight = 284;
            this.gridView3.GridControl = this.gcVCTCV;
            this.gridView3.Name = "gridView3";
            // 
            // colTenCongViec1
            // 
            this.colTenCongViec1.FieldName = "TenCongViec";
            this.colTenCongViec1.MinWidth = 19;
            this.colTenCongViec1.Name = "colTenCongViec1";
            this.colTenCongViec1.Visible = true;
            this.colTenCongViec1.VisibleIndex = 0;
            this.colTenCongViec1.Width = 70;
            // 
            // colTenAp1
            // 
            this.colTenAp1.FieldName = "TenAp";
            this.colTenAp1.MinWidth = 19;
            this.colTenAp1.Name = "colTenAp1";
            this.colTenAp1.Visible = true;
            this.colTenAp1.VisibleIndex = 1;
            this.colTenAp1.Width = 70;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.FieldName = "NgayBatDau";
            this.colNgayBatDau.MinWidth = 19;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.Visible = true;
            this.colNgayBatDau.VisibleIndex = 2;
            this.colNgayBatDau.Width = 70;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.FieldName = "NgayKetThuc";
            this.colNgayKetThuc.MinWidth = 19;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 3;
            this.colNgayKetThuc.Width = 70;
            // 
            // gcVCTCV
            // 
            this.gcVCTCV.DataSource = this.bdsVChiTiet;
            this.gcVCTCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVCTCV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcVCTCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcVCTCV.Location = new System.Drawing.Point(534, 320);
            this.gcVCTCV.MainView = this.gridView3;
            this.gcVCTCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcVCTCV.Name = "gcVCTCV";
            this.gcVCTCV.Size = new System.Drawing.Size(312, 289);
            this.gcVCTCV.TabIndex = 25;
            this.gcVCTCV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // chiTietApTableAdapter
            // 
            this.chiTietApTableAdapter.ClearBeforeFill = true;
            // 
            // txtCongViec
            // 
            this.txtCongViec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCongViec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVChiTiet, "TenCongViec", true));
            this.txtCongViec.Location = new System.Drawing.Point(177, 52);
            this.txtCongViec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCongViec.Name = "txtCongViec";
            this.txtCongViec.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCongViec.Properties.Appearance.Options.UseFont = true;
            this.txtCongViec.Size = new System.Drawing.Size(198, 26);
            this.txtCongViec.TabIndex = 1;
            // 
            // txtTenAp
            // 
            this.txtTenAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenAp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVChiTiet, "TenAp", true));
            this.txtTenAp.Location = new System.Drawing.Point(177, 106);
            this.txtTenAp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenAp.Name = "txtTenAp";
            this.txtTenAp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenAp.Properties.Appearance.Options.UseFont = true;
            this.txtTenAp.Size = new System.Drawing.Size(198, 26);
            this.txtTenAp.TabIndex = 3;
            // 
            // dNgayBD
            // 
            this.dNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dNgayBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVChiTiet, "NgayBatDau", true));
            this.dNgayBD.EditValue = null;
            this.dNgayBD.Location = new System.Drawing.Point(177, 164);
            this.dNgayBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dNgayBD.Name = "dNgayBD";
            this.dNgayBD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dNgayBD.Properties.Appearance.Options.UseFont = true;
            this.dNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayBD.Size = new System.Drawing.Size(198, 26);
            this.dNgayBD.TabIndex = 5;
            // 
            // dNgayKT
            // 
            this.dNgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dNgayKT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVChiTiet, "NgayKetThuc", true));
            this.dNgayKT.EditValue = null;
            this.dNgayKT.Location = new System.Drawing.Point(177, 221);
            this.dNgayKT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dNgayKT.Name = "dNgayKT";
            this.dNgayKT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dNgayKT.Properties.Appearance.Options.UseFont = true;
            this.dNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayKT.Size = new System.Drawing.Size(198, 26);
            this.dNgayKT.TabIndex = 7;
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(ngayKetThucLabel);
            this.panelNhapXuat.Controls.Add(this.dNgayKT);
            this.panelNhapXuat.Controls.Add(ngayBatDauLabel);
            this.panelNhapXuat.Controls.Add(this.dNgayBD);
            this.panelNhapXuat.Controls.Add(tenApLabel);
            this.panelNhapXuat.Controls.Add(this.txtTenAp);
            this.panelNhapXuat.Controls.Add(tenCongViecLabel);
            this.panelNhapXuat.Controls.Add(this.txtCongViec);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 320);
            this.panelNhapXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(534, 289);
            this.panelNhapXuat.TabIndex = 25;
            // 
            // thucHienCongViecBindingSource
            // 
            this.thucHienCongViecBindingSource.DataMember = "ThucHienCongViec";
            this.thucHienCongViecBindingSource.DataSource = this.muaHeXanhDataSet;
            // 
            // thucHienCongViecTableAdapter
            // 
            this.thucHienCongViecTableAdapter.ClearBeforeFill = true;
            // 
            // frmChiTietCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 609);
            this.Controls.Add(this.gcVCTCV);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChiTietCongViec";
            this.Text = "Chi Tiết Công Việc";
            this.Load += new System.EventHandler(this.frmChiTietCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsVChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVCTCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenAp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thucHienCongViecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private System.Windows.Forms.BindingSource bdsAp;
        private MuaHeXanhDataSetTableAdapters.ApTableAdapter apTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCongViec;
        private MuaHeXanhDataSetTableAdapters.CongViecTableAdapter congViecTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private System.Windows.Forms.BindingSource bdsVChiTiet;
        private MuaHeXanhDataSetTableAdapters.VChiTietCVTableAdapter vChiTietCVTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongViec1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private DevExpress.XtraGrid.GridControl gcVCTCV;
        private System.Windows.Forms.ComboBox cmbXa;
        private DevExpress.XtraGrid.GridControl gcCongViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongViec;
        private System.Windows.Forms.BindingSource bdsChiTietAp;
        private MuaHeXanhDataSetTableAdapters.ChiTietApTableAdapter chiTietApTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTAp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenXa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDiaBan;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.TextEdit txtCongViec;
        private DevExpress.XtraEditors.TextEdit txtTenAp;
        private DevExpress.XtraEditors.DateEdit dNgayBD;
        private DevExpress.XtraEditors.DateEdit dNgayKT;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private System.Windows.Forms.ComboBox cmbDiaBan;
        private System.Windows.Forms.BindingSource thucHienCongViecBindingSource;
        private MuaHeXanhDataSetTableAdapters.ThucHienCongViecTableAdapter thucHienCongViecTableAdapter;
    }
}