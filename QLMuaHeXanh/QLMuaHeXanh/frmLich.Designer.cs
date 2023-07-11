namespace QLMuaHeXanh
{
    partial class frmLich
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
            this.muaHeXanhDataSet = new QLMuaHeXanh.MuaHeXanhDataSet();
            this.sp_CTCVNHOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_CTCVNHOMTableAdapter = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.sp_CTCVNHOMTableAdapter();
            this.tableAdapterManager = new QLMuaHeXanh.MuaHeXanhDataSetTableAdapters.TableAdapterManager();
            this.sp_CTCVNHOMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThucHien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTCVNHOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTCVNHOMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // muaHeXanhDataSet
            // 
            this.muaHeXanhDataSet.DataSetName = "MuaHeXanhDataSet";
            this.muaHeXanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_CTCVNHOMBindingSource
            // 
            this.sp_CTCVNHOMBindingSource.DataMember = "sp_CTCVNHOM";
            this.sp_CTCVNHOMBindingSource.DataSource = this.muaHeXanhDataSet;
            // 
            // sp_CTCVNHOMTableAdapter
            // 
            this.sp_CTCVNHOMTableAdapter.ClearBeforeFill = true;
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
            // sp_CTCVNHOMGridControl
            // 
            this.sp_CTCVNHOMGridControl.DataSource = this.sp_CTCVNHOMBindingSource;
            this.sp_CTCVNHOMGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sp_CTCVNHOMGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_CTCVNHOMGridControl.Location = new System.Drawing.Point(0, 0);
            this.sp_CTCVNHOMGridControl.MainView = this.gridView1;
            this.sp_CTCVNHOMGridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_CTCVNHOMGridControl.Name = "sp_CTCVNHOMGridControl";
            this.sp_CTCVNHOMGridControl.Size = new System.Drawing.Size(702, 214);
            this.sp_CTCVNHOMGridControl.TabIndex = 3;
            this.sp_CTCVNHOMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenAp,
            this.colTenXa,
            this.colTenNhom,
            this.colTenCongViec,
            this.colTenBuoi,
            this.colNgayThucHien});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.sp_CTCVNHOMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTenAp
            // 
            this.colTenAp.FieldName = "TenAp";
            this.colTenAp.MinWidth = 19;
            this.colTenAp.Name = "colTenAp";
            this.colTenAp.Visible = true;
            this.colTenAp.VisibleIndex = 0;
            this.colTenAp.Width = 70;
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
            // colTenNhom
            // 
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.MinWidth = 19;
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 2;
            this.colTenNhom.Width = 70;
            // 
            // colTenCongViec
            // 
            this.colTenCongViec.FieldName = "TenCongViec";
            this.colTenCongViec.MinWidth = 19;
            this.colTenCongViec.Name = "colTenCongViec";
            this.colTenCongViec.Visible = true;
            this.colTenCongViec.VisibleIndex = 3;
            this.colTenCongViec.Width = 70;
            // 
            // colTenBuoi
            // 
            this.colTenBuoi.FieldName = "TenBuoi";
            this.colTenBuoi.MinWidth = 19;
            this.colTenBuoi.Name = "colTenBuoi";
            this.colTenBuoi.Visible = true;
            this.colTenBuoi.VisibleIndex = 4;
            this.colTenBuoi.Width = 70;
            // 
            // colNgayThucHien
            // 
            this.colNgayThucHien.FieldName = "NgayThucHien";
            this.colNgayThucHien.MinWidth = 19;
            this.colNgayThucHien.Name = "colNgayThucHien";
            this.colNgayThucHien.Visible = true;
            this.colNgayThucHien.VisibleIndex = 5;
            this.colNgayThucHien.Width = 70;
            // 
            // frmLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 402);
            this.Controls.Add(this.sp_CTCVNHOMGridControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLich";
            this.Text = "Lịch";
            this.Load += new System.EventHandler(this.frmLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muaHeXanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTCVNHOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTCVNHOMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MuaHeXanhDataSet muaHeXanhDataSet;
        private System.Windows.Forms.BindingSource sp_CTCVNHOMBindingSource;
        private MuaHeXanhDataSetTableAdapters.sp_CTCVNHOMTableAdapter sp_CTCVNHOMTableAdapter;
        private MuaHeXanhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_CTCVNHOMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenXa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThucHien;
    }
}