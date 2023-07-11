namespace QLMuaHeXanh
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label maSinhVienLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label phaiLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label soDienThoaiLabel;
            System.Windows.Forms.Label maDiaBanLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barSinhVien = new DevExpress.XtraBars.Bar();
            this.btnThemSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoiSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachSV = new DevExpress.XtraBars.BarButtonItem();
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSinhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.bdsXA = new System.Windows.Forms.BindingSource(this.components);
            this.xaTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.XaTableAdapter();
            this.bdsNhom = new System.Windows.Forms.BindingSource(this.components);
            this.nhomTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.NhomTableAdapter();
            this.bdsKhenThuong = new System.Windows.Forms.BindingSource(this.components);
            this.khenThuongTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.KhenThuongTableAdapter();
            maSinhVienLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            phaiLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            soDienThoaiLabel = new System.Windows.Forms.Label();
            maDiaBanLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhenThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // maSinhVienLabel
            // 
            maSinhVienLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maSinhVienLabel.AutoSize = true;
            maSinhVienLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maSinhVienLabel.Location = new System.Drawing.Point(38, 29);
            maSinhVienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maSinhVienLabel.Name = "maSinhVienLabel";
            maSinhVienLabel.Size = new System.Drawing.Size(94, 19);
            maSinhVienLabel.TabIndex = 0;
            maSinhVienLabel.Text = "Mã Sinh Viên:";
            // 
            // hoLabel
            // 
            hoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            hoLabel.Location = new System.Drawing.Point(376, 32);
            hoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(58, 19);
            hoLabel.TabIndex = 2;
            hoLabel.Text = "Họ Tên:";
            hoLabel.Click += new System.EventHandler(this.hoLabel_Click);
            // 
            // phaiLabel
            // 
            phaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phaiLabel.AutoSize = true;
            phaiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            phaiLabel.Location = new System.Drawing.Point(376, 105);
            phaiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phaiLabel.Name = "phaiLabel";
            phaiLabel.Size = new System.Drawing.Size(38, 19);
            phaiLabel.TabIndex = 6;
            phaiLabel.Text = "Phái:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngaySinhLabel.Location = new System.Drawing.Point(40, 100);
            ngaySinhLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(75, 19);
            ngaySinhLabel.TabIndex = 8;
            ngaySinhLabel.Text = "Ngày Sinh:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            diaChiLabel.Location = new System.Drawing.Point(40, 239);
            diaChiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(58, 19);
            diaChiLabel.TabIndex = 10;
            diaChiLabel.Text = "Địa Chỉ:";
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            soDienThoaiLabel.Location = new System.Drawing.Point(38, 171);
            soDienThoaiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new System.Drawing.Size(99, 19);
            soDienThoaiLabel.TabIndex = 12;
            soDienThoaiLabel.Text = "Số Điên Thọai:";
            // 
            // maDiaBanLabel
            // 
            maDiaBanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maDiaBanLabel.AutoSize = true;
            maDiaBanLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maDiaBanLabel.Location = new System.Drawing.Point(760, 28);
            maDiaBanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maDiaBanLabel.Name = "maDiaBanLabel";
            maDiaBanLabel.Size = new System.Drawing.Size(86, 19);
            maDiaBanLabel.TabIndex = 14;
            maDiaBanLabel.Text = "Mã Địa Bàn:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maKhoaLabel.Location = new System.Drawing.Point(760, 102);
            maKhoaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(71, 19);
            maKhoaLabel.TabIndex = 16;
            maKhoaLabel.Text = "Mã Khoa:";
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
            this.btnThemSV,
            this.barButtonItem2,
            this.btnSuaSV,
            this.btnGhiSV,
            this.barButtonItem3,
            this.btnXoaSV,
            this.btnPhucHoiSV,
            this.btnLamMoiSV,
            this.btnDanhSachSV,
            this.btnThoat});
            this.barManager2.MaxItemId = 14;
            // 
            // barSinhVien
            // 
            this.barSinhVien.BarName = "Tools";
            this.barSinhVien.DockCol = 0;
            this.barSinhVien.DockRow = 0;
            this.barSinhVien.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barSinhVien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoiSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSinhVien.Text = "Tools";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Caption = "Thêm";
            this.btnThemSV.Id = 2;
            this.btnThemSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemSV.ImageOptions.SvgImage")));
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSV_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Caption = "Sửa";
            this.btnSuaSV.Id = 5;
            this.btnSuaSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaSV.ImageOptions.SvgImage")));
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaSV_ItemClick);
            // 
            // btnGhiSV
            // 
            this.btnGhiSV.Caption = "Ghi";
            this.btnGhiSV.Id = 6;
            this.btnGhiSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiSV.ImageOptions.Image")));
            this.btnGhiSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiSV.ImageOptions.LargeImage")));
            this.btnGhiSV.Name = "btnGhiSV";
            this.btnGhiSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiSV_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Caption = "Xóa";
            this.btnXoaSV.Id = 9;
            this.btnXoaSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.ImageOptions.Image")));
            this.btnXoaSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.ImageOptions.LargeImage")));
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaSV_ItemClick);
            // 
            // btnPhucHoiSV
            // 
            this.btnPhucHoiSV.Caption = "Phục hồi";
            this.btnPhucHoiSV.Id = 10;
            this.btnPhucHoiSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiSV.ImageOptions.SvgImage")));
            this.btnPhucHoiSV.Name = "btnPhucHoiSV";
            this.btnPhucHoiSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiSV_ItemClick);
            // 
            // btnLamMoiSV
            // 
            this.btnLamMoiSV.Caption = "Làm mới";
            this.btnLamMoiSV.Id = 11;
            this.btnLamMoiSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiSV.ImageOptions.SvgImage")));
            this.btnLamMoiSV.Name = "btnLamMoiSV";
            this.btnLamMoiSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoiSV_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 13;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl1.Size = new System.Drawing.Size(1015, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 596);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl2.Size = new System.Drawing.Size(1015, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl3.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1015, 24);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl4.Size = new System.Drawing.Size(0, 572);
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
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SinhVien";
            this.bdsSinhVien.DataSource = this.muaHeXanhDataSet;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1015, 67);
            this.panelControl1.TabIndex = 21;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(80, 20);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(230, 28);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa: ";
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSinhVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcSinhVien.Location = new System.Drawing.Point(0, 91);
            this.gcSinhVien.MainView = this.gridView1;
            this.gcSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.gcSinhVien.MenuManager = this.barManager2;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(1015, 208);
            this.gcSinhVien.TabIndex = 21;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcSinhVien.Click += new System.EventHandler(this.gcSinhVien_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSinhVien,
            this.colHo,
            this.colTen,
            this.colPhai,
            this.colNgaySinh,
            this.colDiaChi,
            this.colSoDienThoai,
            this.colMaDiaBan,
            this.colMaNhom,
            this.colMaKhoa});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gcSinhVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMaSinhVien
            // 
            this.colMaSinhVien.FieldName = "MaSinhVien";
            this.colMaSinhVien.MinWidth = 19;
            this.colMaSinhVien.Name = "colMaSinhVien";
            this.colMaSinhVien.Visible = true;
            this.colMaSinhVien.VisibleIndex = 0;
            this.colMaSinhVien.Width = 70;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 19;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 70;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 19;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 70;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.MinWidth = 19;
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 3;
            this.colPhai.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 19;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 4;
            this.colNgaySinh.Width = 70;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 19;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 70;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.MinWidth = 19;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 6;
            this.colSoDienThoai.Width = 70;
            // 
            // colMaDiaBan
            // 
            this.colMaDiaBan.FieldName = "MaDiaBan";
            this.colMaDiaBan.MinWidth = 19;
            this.colMaDiaBan.Name = "colMaDiaBan";
            this.colMaDiaBan.Visible = true;
            this.colMaDiaBan.VisibleIndex = 7;
            this.colMaDiaBan.Width = 70;
            // 
            // colMaNhom
            // 
            this.colMaNhom.FieldName = "MaNhom";
            this.colMaNhom.MinWidth = 19;
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.Visible = true;
            this.colMaNhom.VisibleIndex = 8;
            this.colMaNhom.Width = 70;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.MinWidth = 19;
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 9;
            this.colMaKhoa.Width = 70;
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(maKhoaLabel);
            this.panelNhapXuat.Controls.Add(this.cmbMaKhoa);
            this.panelNhapXuat.Controls.Add(maDiaBanLabel);
            this.panelNhapXuat.Controls.Add(this.cmbDiaBan);
            this.panelNhapXuat.Controls.Add(soDienThoaiLabel);
            this.panelNhapXuat.Controls.Add(this.txtSDT);
            this.panelNhapXuat.Controls.Add(diaChiLabel);
            this.panelNhapXuat.Controls.Add(this.txtDiaChi);
            this.panelNhapXuat.Controls.Add(ngaySinhLabel);
            this.panelNhapXuat.Controls.Add(this.dNgaySinh);
            this.panelNhapXuat.Controls.Add(phaiLabel);
            this.panelNhapXuat.Controls.Add(this.cmbPhai);
            this.panelNhapXuat.Controls.Add(this.txtTen);
            this.panelNhapXuat.Controls.Add(hoLabel);
            this.panelNhapXuat.Controls.Add(this.txtHo);
            this.panelNhapXuat.Controls.Add(maSinhVienLabel);
            this.panelNhapXuat.Controls.Add(this.txtMaSV);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 299);
            this.panelNhapXuat.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(1015, 297);
            this.panelNhapXuat.TabIndex = 22;
            this.panelNhapXuat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MaKhoa", true));
            this.cmbMaKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(860, 100);
            this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(147, 27);
            this.cmbMaKhoa.TabIndex = 17;
            // 
            // cmbDiaBan
            // 
            this.cmbDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiaBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MaDiaBan", true));
            this.cmbDiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(860, 27);
            this.cmbDiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(147, 27);
            this.cmbDiaBan.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "SoDienThoai", true));
            this.txtSDT.Location = new System.Drawing.Point(155, 168);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.MenuManager = this.barManager2;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(154, 26);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DiaChi", true));
            this.txtDiaChi.Location = new System.Drawing.Point(155, 234);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.MenuManager = this.barManager2;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(409, 26);
            this.txtDiaChi.TabIndex = 11;
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NgaySinh", true));
            this.dNgaySinh.EditValue = null;
            this.dNgaySinh.Location = new System.Drawing.Point(155, 98);
            this.dNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dNgaySinh.MenuManager = this.barManager2;
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgaySinh.Size = new System.Drawing.Size(154, 26);
            this.dNgaySinh.TabIndex = 9;
            // 
            // cmbPhai
            // 
            this.cmbPhai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "Phai", true));
            this.cmbPhai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Location = new System.Drawing.Point(460, 98);
            this.cmbPhai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(104, 27);
            this.cmbPhai.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "Ten", true));
            this.txtTen.Location = new System.Drawing.Point(618, 29);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.MenuManager = this.barManager2;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(94, 26);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "Ho", true));
            this.txtHo.Location = new System.Drawing.Point(460, 29);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.MenuManager = this.barManager2;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(154, 26);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MaSinhVien", true));
            this.txtMaSV.Location = new System.Drawing.Point(155, 27);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.MenuManager = this.barManager2;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(154, 26);
            this.txtMaSV.TabIndex = 1;
            // 
            // bdsXA
            // 
            this.bdsXA.DataMember = "FK_Xa_DoiPho";
            this.bdsXA.DataSource = this.bdsSinhVien;
            // 
            // xaTableAdapter
            // 
            this.xaTableAdapter.ClearBeforeFill = true;
            // 
            // bdsNhom
            // 
            this.bdsNhom.DataMember = "FK_Nhom_SinhVien";
            this.bdsNhom.DataSource = this.bdsSinhVien;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // bdsKhenThuong
            // 
            this.bdsKhenThuong.DataMember = "FK_KhenThuong_SinhVien";
            this.bdsKhenThuong.DataSource = this.bdsSinhVien;
            // 
            // khenThuongTableAdapter
            // 
            this.khenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 596);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhenThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar barSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnThemSV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnSuaSV;
        private DevExpress.XtraBars.BarButtonItem btnGhiSV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnXoaSV;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiSV;
        private DevExpress.XtraBars.BarButtonItem btnLamMoiSV;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachSV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private MuaHeXanhDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.ComboBox cmbDiaBan;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.DateEdit dNgaySinh;
        private System.Windows.Forms.ComboBox cmbPhai;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsXA;
        private MuaHeXanhDataSetTableAdapters.XaTableAdapter xaTableAdapter;
        private System.Windows.Forms.BindingSource bdsNhom;
        private MuaHeXanhDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private System.Windows.Forms.BindingSource bdsKhenThuong;
        private MuaHeXanhDataSetTableAdapters.KhenThuongTableAdapter khenThuongTableAdapter;
    }
}