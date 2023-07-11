namespace QLMuaHeXanh
{
    partial class frmThucHienCV
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
            System.Windows.Forms.Label tenApLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.Windows.Forms.Label tenCongViecLabel;
            System.Windows.Forms.Label tenBuoiLabel;
            System.Windows.Forms.Label ngayThucHienLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucHienCV));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcVCTPC = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPC = new System.Windows.Forms.BindingSource(this.components);
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVCTCV = new DevExpress.XtraGrid.GridControl();
            this.bdsVCTCV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vChiTietCVTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.VChiTietCVTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.view_ChiTietPhanCongTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.View_ChiTietPhanCongTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.dThucHien = new DevExpress.XtraEditors.DateEdit();
            this.bdsThucHien = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuoi = new DevExpress.XtraEditors.TextEdit();
            this.txtCongViec = new DevExpress.XtraEditors.TextEdit();
            this.txtNhom = new DevExpress.XtraEditors.TextEdit();
            this.txtAp = new DevExpress.XtraEditors.TextEdit();
            this.thucHienTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ThucHienTableAdapter();
            this.gcThucHien = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenAp2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCongViec1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBuoi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThucHien = new DevExpress.XtraGrid.Columns.GridColumn();
            tenApLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            tenCongViecLabel = new System.Windows.Forms.Label();
            tenBuoiLabel = new System.Windows.Forms.Label();
            ngayThucHienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVCTPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVCTCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVCTCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dThucHien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dThucHien.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThucHien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucHien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tenApLabel
            // 
            tenApLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenApLabel.AutoSize = true;
            tenApLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenApLabel.Location = new System.Drawing.Point(68, 55);
            tenApLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenApLabel.Name = "tenApLabel";
            tenApLabel.Size = new System.Drawing.Size(58, 19);
            tenApLabel.TabIndex = 0;
            tenApLabel.Text = "Tên Ấp:";
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNhomLabel.Location = new System.Drawing.Point(68, 115);
            tenNhomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(77, 19);
            tenNhomLabel.TabIndex = 2;
            tenNhomLabel.Text = "Tên Nhóm:";
            // 
            // tenCongViecLabel
            // 
            tenCongViecLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenCongViecLabel.AutoSize = true;
            tenCongViecLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenCongViecLabel.Location = new System.Drawing.Point(68, 175);
            tenCongViecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenCongViecLabel.Name = "tenCongViecLabel";
            tenCongViecLabel.Size = new System.Drawing.Size(103, 19);
            tenCongViecLabel.TabIndex = 4;
            tenCongViecLabel.Text = "Tên Công Việc:";
            // 
            // tenBuoiLabel
            // 
            tenBuoiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenBuoiLabel.AutoSize = true;
            tenBuoiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenBuoiLabel.Location = new System.Drawing.Point(358, 242);
            tenBuoiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tenBuoiLabel.Name = "tenBuoiLabel";
            tenBuoiLabel.Size = new System.Drawing.Size(67, 19);
            tenBuoiLabel.TabIndex = 6;
            tenBuoiLabel.Text = "Tên Buổi:";
            // 
            // ngayThucHienLabel
            // 
            ngayThucHienLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ngayThucHienLabel.AutoSize = true;
            ngayThucHienLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayThucHienLabel.Location = new System.Drawing.Point(68, 242);
            ngayThucHienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngayThucHienLabel.Name = "ngayThucHienLabel";
            ngayThucHienLabel.Size = new System.Drawing.Size(113, 19);
            ngayThucHienLabel.TabIndex = 8;
            ngayThucHienLabel.Text = "Ngày Thực Hiện:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcVCTPC);
            this.panelControl1.Controls.Add(this.gcVCTCV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(956, 270);
            this.panelControl1.TabIndex = 0;
            // 
            // gcVCTPC
            // 
            this.gcVCTPC.DataSource = this.bdsCTPC;
            this.gcVCTPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVCTPC.Location = new System.Drawing.Point(588, 2);
            this.gcVCTPC.MainView = this.gridView2;
            this.gcVCTPC.Name = "gcVCTPC";
            this.gcVCTPC.Size = new System.Drawing.Size(366, 266);
            this.gcVCTPC.TabIndex = 1;
            this.gcVCTPC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsCTPC
            // 
            this.bdsCTPC.DataMember = "View_ChiTietPhanCong";
            this.bdsCTPC.DataSource = this.muaHeXanhDataSet;
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
            this.colTenNhom,
            this.colTenAp,
            this.colTenXa,
            this.colTenBuoi,
            this.colGhiChu});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gcVCTPC;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // colTenNhom
            // 
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.MinWidth = 19;
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            this.colTenNhom.Width = 70;
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
            // colTenBuoi
            // 
            this.colTenBuoi.FieldName = "TenBuoi";
            this.colTenBuoi.MinWidth = 19;
            this.colTenBuoi.Name = "colTenBuoi";
            this.colTenBuoi.Visible = true;
            this.colTenBuoi.VisibleIndex = 3;
            this.colTenBuoi.Width = 70;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 19;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 70;
            // 
            // gcVCTCV
            // 
            this.gcVCTCV.DataSource = this.bdsVCTCV;
            this.gcVCTCV.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcVCTCV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcVCTCV.Location = new System.Drawing.Point(2, 2);
            this.gcVCTCV.MainView = this.gridView1;
            this.gcVCTCV.Margin = new System.Windows.Forms.Padding(4);
            this.gcVCTCV.Name = "gcVCTCV";
            this.gcVCTCV.Size = new System.Drawing.Size(586, 266);
            this.gcVCTCV.TabIndex = 0;
            this.gcVCTCV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsVCTCV
            // 
            this.bdsVCTCV.DataMember = "VChiTietCV";
            this.bdsVCTCV.DataSource = this.muaHeXanhDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenCongViec,
            this.colTenAp1,
            this.colNgayBatDau,
            this.colNgayKetThuc});
            this.gridView1.DetailHeight = 355;
            this.gridView1.GridControl = this.gcVCTCV;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colTenCongViec
            // 
            this.colTenCongViec.FieldName = "TenCongViec";
            this.colTenCongViec.MinWidth = 19;
            this.colTenCongViec.Name = "colTenCongViec";
            this.colTenCongViec.Visible = true;
            this.colTenCongViec.VisibleIndex = 0;
            this.colTenCongViec.Width = 70;
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
            // vChiTietCVTableAdapter
            // 
            this.vChiTietCVTableAdapter.ClearBeforeFill = true;
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
            // view_ChiTietPhanCongTableAdapter
            // 
            this.view_ChiTietPhanCongTableAdapter.ClearBeforeFill = true;
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
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 24);
            this.panel2.TabIndex = 25;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnReload.Location = new System.Drawing.Point(375, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 24);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUndo.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnUndo.Location = new System.Drawing.Point(300, 0);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
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
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnEdit.Location = new System.Drawing.Point(75, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 24);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Add";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(ngayThucHienLabel);
            this.panelNhapXuat.Controls.Add(this.dThucHien);
            this.panelNhapXuat.Controls.Add(tenBuoiLabel);
            this.panelNhapXuat.Controls.Add(this.txtBuoi);
            this.panelNhapXuat.Controls.Add(tenCongViecLabel);
            this.panelNhapXuat.Controls.Add(this.txtCongViec);
            this.panelNhapXuat.Controls.Add(tenNhomLabel);
            this.panelNhapXuat.Controls.Add(this.txtNhom);
            this.panelNhapXuat.Controls.Add(tenApLabel);
            this.panelNhapXuat.Controls.Add(this.txtAp);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 294);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(588, 323);
            this.panelNhapXuat.TabIndex = 26;
            // 
            // dThucHien
            // 
            this.dThucHien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dThucHien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThucHien, "NgayThucHien", true));
            this.dThucHien.EditValue = null;
            this.dThucHien.Location = new System.Drawing.Point(199, 237);
            this.dThucHien.Name = "dThucHien";
            this.dThucHien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dThucHien.Properties.Appearance.Options.UseFont = true;
            this.dThucHien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dThucHien.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dThucHien.Size = new System.Drawing.Size(117, 26);
            this.dThucHien.TabIndex = 9;
            // 
            // bdsThucHien
            // 
            this.bdsThucHien.DataMember = "ThucHien";
            this.bdsThucHien.DataSource = this.muaHeXanhDataSet;
            // 
            // txtBuoi
            // 
            this.txtBuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuoi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThucHien, "TenBuoi", true));
            this.txtBuoi.Location = new System.Drawing.Point(448, 237);
            this.txtBuoi.Name = "txtBuoi";
            this.txtBuoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBuoi.Properties.Appearance.Options.UseFont = true;
            this.txtBuoi.Size = new System.Drawing.Size(117, 26);
            this.txtBuoi.TabIndex = 7;
            // 
            // txtCongViec
            // 
            this.txtCongViec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCongViec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThucHien, "TenCongViec", true));
            this.txtCongViec.Location = new System.Drawing.Point(199, 170);
            this.txtCongViec.Name = "txtCongViec";
            this.txtCongViec.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCongViec.Properties.Appearance.Options.UseFont = true;
            this.txtCongViec.Size = new System.Drawing.Size(202, 26);
            this.txtCongViec.TabIndex = 5;
            // 
            // txtNhom
            // 
            this.txtNhom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThucHien, "TenNhom", true));
            this.txtNhom.Location = new System.Drawing.Point(199, 112);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhom.Properties.Appearance.Options.UseFont = true;
            this.txtNhom.Size = new System.Drawing.Size(202, 26);
            this.txtNhom.TabIndex = 3;
            // 
            // txtAp
            // 
            this.txtAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThucHien, "TenAp", true));
            this.txtAp.Location = new System.Drawing.Point(199, 50);
            this.txtAp.Name = "txtAp";
            this.txtAp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAp.Properties.Appearance.Options.UseFont = true;
            this.txtAp.Size = new System.Drawing.Size(202, 26);
            this.txtAp.TabIndex = 1;
            // 
            // thucHienTableAdapter
            // 
            this.thucHienTableAdapter.ClearBeforeFill = true;
            // 
            // gcThucHien
            // 
            this.gcThucHien.DataSource = this.bdsThucHien;
            this.gcThucHien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThucHien.Location = new System.Drawing.Point(588, 294);
            this.gcThucHien.MainView = this.gridView3;
            this.gcThucHien.Name = "gcThucHien";
            this.gcThucHien.Size = new System.Drawing.Size(368, 323);
            this.gcThucHien.TabIndex = 26;
            this.gcThucHien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenAp2,
            this.colTenNhom1,
            this.colTenCongViec1,
            this.colTenBuoi1,
            this.colNgayThucHien});
            this.gridView3.DetailHeight = 284;
            this.gridView3.GridControl = this.gcThucHien;
            this.gridView3.Name = "gridView3";
            // 
            // colTenAp2
            // 
            this.colTenAp2.FieldName = "TenAp";
            this.colTenAp2.MinWidth = 19;
            this.colTenAp2.Name = "colTenAp2";
            this.colTenAp2.Visible = true;
            this.colTenAp2.VisibleIndex = 0;
            this.colTenAp2.Width = 70;
            // 
            // colTenNhom1
            // 
            this.colTenNhom1.FieldName = "TenNhom";
            this.colTenNhom1.MinWidth = 19;
            this.colTenNhom1.Name = "colTenNhom1";
            this.colTenNhom1.Visible = true;
            this.colTenNhom1.VisibleIndex = 1;
            this.colTenNhom1.Width = 70;
            // 
            // colTenCongViec1
            // 
            this.colTenCongViec1.FieldName = "TenCongViec";
            this.colTenCongViec1.MinWidth = 19;
            this.colTenCongViec1.Name = "colTenCongViec1";
            this.colTenCongViec1.Visible = true;
            this.colTenCongViec1.VisibleIndex = 2;
            this.colTenCongViec1.Width = 70;
            // 
            // colTenBuoi1
            // 
            this.colTenBuoi1.FieldName = "TenBuoi";
            this.colTenBuoi1.MinWidth = 19;
            this.colTenBuoi1.Name = "colTenBuoi1";
            this.colTenBuoi1.Visible = true;
            this.colTenBuoi1.VisibleIndex = 3;
            this.colTenBuoi1.Width = 70;
            // 
            // colNgayThucHien
            // 
            this.colNgayThucHien.FieldName = "NgayThucHien";
            this.colNgayThucHien.MinWidth = 19;
            this.colNgayThucHien.Name = "colNgayThucHien";
            this.colNgayThucHien.Visible = true;
            this.colNgayThucHien.VisibleIndex = 4;
            this.colNgayThucHien.Width = 70;
            // 
            // frmThucHienCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 617);
            this.Controls.Add(this.gcThucHien);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThucHienCV";
            this.Text = "Thực hiện công việc";
            this.Load += new System.EventHandler(this.frmThucHienCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVCTPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVCTCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVCTCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dThucHien.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dThucHien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThucHien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucHien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private System.Windows.Forms.BindingSource bdsVCTCV;
        private MuaHeXanhDataSetTableAdapters.VChiTietCVTableAdapter vChiTietCVTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVCTCV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsCTPC;
        private MuaHeXanhDataSetTableAdapters.View_ChiTietPhanCongTableAdapter view_ChiTietPhanCongTableAdapter;
        private DevExpress.XtraGrid.GridControl gcVCTPC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenXa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private System.Windows.Forms.BindingSource bdsThucHien;
        private MuaHeXanhDataSetTableAdapters.ThucHienTableAdapter thucHienTableAdapter;
        private DevExpress.XtraEditors.DateEdit dThucHien;
        private DevExpress.XtraEditors.TextEdit txtBuoi;
        private DevExpress.XtraEditors.TextEdit txtCongViec;
        private DevExpress.XtraEditors.TextEdit txtNhom;
        private DevExpress.XtraEditors.TextEdit txtAp;
        private DevExpress.XtraGrid.GridControl gcThucHien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongViec1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBuoi1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThucHien;
    }
}