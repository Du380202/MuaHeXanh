namespace QLMuaHeXanh
{
    partial class frmKhenThuong
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
            System.Windows.Forms.Label maThanhTichLabel;
            System.Windows.Forms.Label maSinhVienLabel;
            System.Windows.Forms.Label ngayKhenThuongLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhenThuong));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcTT = new DevExpress.XtraGrid.GridControl();
            this.bdsThanhTich = new System.Windows.Forms.BindingSource(this.components);
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaThanhTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThanhTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSV = new DevExpress.XtraGrid.GridControl();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSinhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sinhVienTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.thanhTichTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.ThanhTichTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.pnInput = new DevExpress.XtraEditors.PanelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.bdsKhenThuong = new System.Windows.Forms.BindingSource(this.components);
            this.edNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtTT = new DevExpress.XtraEditors.TextEdit();
            this.khenThuongTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.KhenThuongTableAdapter();
            this.gcKT = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKhenThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSinhVien1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaThanhTich1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKhenThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            maThanhTichLabel = new System.Windows.Forms.Label();
            maSinhVienLabel = new System.Windows.Forms.Label();
            ngayKhenThuongLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThanhTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnInput)).BeginInit();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // maThanhTichLabel
            // 
            maThanhTichLabel.AutoSize = true;
            maThanhTichLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maThanhTichLabel.Location = new System.Drawing.Point(315, 109);
            maThanhTichLabel.Name = "maThanhTichLabel";
            maThanhTichLabel.Size = new System.Drawing.Size(86, 15);
            maThanhTichLabel.TabIndex = 2;
            maThanhTichLabel.Text = "Mã Thành Tích:";
            // 
            // maSinhVienLabel
            // 
            maSinhVienLabel.AutoSize = true;
            maSinhVienLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSinhVienLabel.Location = new System.Drawing.Point(324, 161);
            maSinhVienLabel.Name = "maSinhVienLabel";
            maSinhVienLabel.Size = new System.Drawing.Size(72, 15);
            maSinhVienLabel.TabIndex = 4;
            maSinhVienLabel.Text = "Mã Sinh Viên";
            // 
            // ngayKhenThuongLabel
            // 
            ngayKhenThuongLabel.AutoSize = true;
            ngayKhenThuongLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKhenThuongLabel.Location = new System.Drawing.Point(293, 209);
            ngayKhenThuongLabel.Name = "ngayKhenThuongLabel";
            ngayKhenThuongLabel.Size = new System.Drawing.Size(106, 15);
            ngayKhenThuongLabel.TabIndex = 6;
            ngayKhenThuongLabel.Text = "Ngày Khen Thưởng:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ghiChuLabel.Location = new System.Drawing.Point(347, 267);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(51, 15);
            ghiChuLabel.TabIndex = 8;
            ghiChuLabel.Text = "Ghi Chú:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1111, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(109, 18);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(234, 27);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(49, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcTT);
            this.panelControl2.Controls.Add(this.gcSV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 63);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1111, 274);
            this.panelControl2.TabIndex = 1;
            // 
            // gcTT
            // 
            this.gcTT.DataSource = this.bdsThanhTich;
            this.gcTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcTT.Location = new System.Drawing.Point(871, 2);
            this.gcTT.MainView = this.gridView2;
            this.gcTT.Name = "gcTT";
            this.gcTT.Size = new System.Drawing.Size(238, 270);
            this.gcTT.TabIndex = 1;
            this.gcTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsThanhTich
            // 
            this.bdsThanhTich.DataMember = "ThanhTich";
            this.bdsThanhTich.DataSource = this.muaHeXanhDataSet;
            // 
            // muaHeXanhDataSet
            // 
            this.muaHeXanhDataSet.DataSetName = "MuaHeXanhDataSet";
            this.muaHeXanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaThanhTich,
            this.colTenThanhTich});
            this.gridView2.GridControl = this.gcTT;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // colMaThanhTich
            // 
            this.colMaThanhTich.FieldName = "MaThanhTich";
            this.colMaThanhTich.Name = "colMaThanhTich";
            this.colMaThanhTich.Visible = true;
            this.colMaThanhTich.VisibleIndex = 0;
            // 
            // colTenThanhTich
            // 
            this.colTenThanhTich.FieldName = "TenThanhTich";
            this.colTenThanhTich.Name = "colTenThanhTich";
            this.colTenThanhTich.Visible = true;
            this.colTenThanhTich.VisibleIndex = 1;
            // 
            // gcSV
            // 
            this.gcSV.DataSource = this.bdsSV;
            this.gcSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcSV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcSV.Location = new System.Drawing.Point(2, 2);
            this.gcSV.MainView = this.gridView1;
            this.gcSV.Name = "gcSV";
            this.gcSV.Size = new System.Drawing.Size(869, 270);
            this.gcSV.TabIndex = 0;
            this.gcSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SinhVien";
            this.bdsSV.DataSource = this.muaHeXanhDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSinhVien,
            this.colHo,
            this.colTen,
            this.colPhai,
            this.colNgaySinh,
            this.colDiaChi,
            this.colMaNhom,
            this.colSoDienThoai,
            this.colMaDiaBan});
            this.gridView1.GridControl = this.gcSV;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaSinhVien
            // 
            this.colMaSinhVien.FieldName = "MaSinhVien";
            this.colMaSinhVien.Name = "colMaSinhVien";
            this.colMaSinhVien.Visible = true;
            this.colMaSinhVien.VisibleIndex = 0;
            this.colMaSinhVien.Width = 105;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 91;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 91;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 3;
            this.colPhai.Width = 91;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 4;
            this.colNgaySinh.Width = 91;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 91;
            // 
            // colMaNhom
            // 
            this.colMaNhom.FieldName = "MaNhom";
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.Visible = true;
            this.colMaNhom.VisibleIndex = 6;
            this.colMaNhom.Width = 91;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 7;
            this.colSoDienThoai.Width = 91;
            // 
            // colMaDiaBan
            // 
            this.colMaDiaBan.FieldName = "MaDiaBan";
            this.colMaDiaBan.Name = "colMaDiaBan";
            this.colMaDiaBan.Visible = true;
            this.colMaDiaBan.VisibleIndex = 8;
            this.colMaDiaBan.Width = 102;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = null;
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
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.ThanhTichTableAdapter = null;
            this.tableAdapterManager.ThucHienCongViecTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = null;
            // 
            // thanhTichTableAdapter
            // 
            this.thanhTichTableAdapter.ClearBeforeFill = true;
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
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 24);
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
            // pnInput
            // 
            this.pnInput.Controls.Add(ghiChuLabel);
            this.pnInput.Controls.Add(this.txtGhiChu);
            this.pnInput.Controls.Add(ngayKhenThuongLabel);
            this.pnInput.Controls.Add(this.edNgayKT);
            this.pnInput.Controls.Add(maSinhVienLabel);
            this.pnInput.Controls.Add(this.txtMaSV);
            this.pnInput.Controls.Add(maThanhTichLabel);
            this.pnInput.Controls.Add(this.txtTT);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInput.Location = new System.Drawing.Point(0, 361);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(871, 326);
            this.pnInput.TabIndex = 26;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhenThuong, "GhiChu", true));
            this.txtGhiChu.Location = new System.Drawing.Point(401, 264);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 9;
            // 
            // bdsKhenThuong
            // 
            this.bdsKhenThuong.DataMember = "KhenThuong";
            this.bdsKhenThuong.DataSource = this.muaHeXanhDataSet;
            // 
            // edNgayKT
            // 
            this.edNgayKT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhenThuong, "NgayKhenThuong", true));
            this.edNgayKT.EditValue = null;
            this.edNgayKT.Location = new System.Drawing.Point(401, 206);
            this.edNgayKT.Name = "edNgayKT";
            this.edNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNgayKT.Size = new System.Drawing.Size(100, 20);
            this.edNgayKT.TabIndex = 7;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhenThuong, "MaSinhVien", true));
            this.txtMaSV.Location = new System.Drawing.Point(401, 158);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtTT
            // 
            this.txtTT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhenThuong, "MaThanhTich", true));
            this.txtTT.Location = new System.Drawing.Point(401, 106);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(100, 20);
            this.txtTT.TabIndex = 3;
            // 
            // khenThuongTableAdapter
            // 
            this.khenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // gcKT
            // 
            this.gcKT.DataSource = this.bdsKhenThuong;
            this.gcKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcKT.Location = new System.Drawing.Point(871, 361);
            this.gcKT.MainView = this.gridView3;
            this.gcKT.Name = "gcKT";
            this.gcKT.Size = new System.Drawing.Size(240, 326);
            this.gcKT.TabIndex = 26;
            this.gcKT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKhenThuong,
            this.colMaSinhVien1,
            this.colMaThanhTich1,
            this.colNgayKhenThuong,
            this.colGhiChu});
            this.gridView3.GridControl = this.gcKT;
            this.gridView3.Name = "gridView3";
            // 
            // colIDKhenThuong
            // 
            this.colIDKhenThuong.FieldName = "IDKhenThuong";
            this.colIDKhenThuong.Name = "colIDKhenThuong";
            this.colIDKhenThuong.Visible = true;
            this.colIDKhenThuong.VisibleIndex = 0;
            // 
            // colMaSinhVien1
            // 
            this.colMaSinhVien1.FieldName = "MaSinhVien";
            this.colMaSinhVien1.Name = "colMaSinhVien1";
            this.colMaSinhVien1.Visible = true;
            this.colMaSinhVien1.VisibleIndex = 1;
            // 
            // colMaThanhTich1
            // 
            this.colMaThanhTich1.FieldName = "MaThanhTich";
            this.colMaThanhTich1.Name = "colMaThanhTich1";
            this.colMaThanhTich1.Visible = true;
            this.colMaThanhTich1.VisibleIndex = 2;
            // 
            // colNgayKhenThuong
            // 
            this.colNgayKhenThuong.FieldName = "NgayKhenThuong";
            this.colNgayKhenThuong.Name = "colNgayKhenThuong";
            this.colNgayKhenThuong.Visible = true;
            this.colNgayKhenThuong.VisibleIndex = 3;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            // 
            // frmKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 687);
            this.Controls.Add(this.gcKT);
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKhenThuong";
            this.Text = "Khen Thưởng";
            this.Load += new System.EventHandler(this.frmKhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThanhTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnInput)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private System.Windows.Forms.BindingSource bdsSV;
        private MuaHeXanhDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDiaBan;
        private System.Windows.Forms.BindingSource bdsThanhTich;
        private MuaHeXanhDataSetTableAdapters.ThanhTichTableAdapter thanhTichTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThanhTich;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThanhTich;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.PanelControl pnInput;
        private System.Windows.Forms.BindingSource bdsKhenThuong;
        private MuaHeXanhDataSetTableAdapters.KhenThuongTableAdapter khenThuongTableAdapter;
        private DevExpress.XtraGrid.GridControl gcKT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKhenThuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSinhVien1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThanhTich1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKhenThuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.DateEdit edNgayKT;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit txtTT;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
    }
}