using DevExpress.ChartRangeControlClient.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLMuaHeXanh
{
    public partial class frmGiaoVien : Form
    {
        int viTri = 0;
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void giaoVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiaoVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muaHeXanhDataSet);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            
            muaHeXanhDataSet.EnforceConstraints = false;


            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter.Fill(this.muaHeXanhDataSet.Khoa);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaoVienTableAdapter.FillByIndex(this.muaHeXanhDataSet.GiaoVien);

            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Xa' table. You can move, or remove it, as needed.
            this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.muaHeXanhDataSet.Xa);
            if (Program.role == "QUANTRI")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnPhucHoi.Enabled = btnGhi.Enabled = false;
                gcGiaoVien.Enabled = gcKhoa.Enabled = btnLamMoi.Enabled =  true;
                panelNhapXuat.Enabled = false;
            }
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHOA", Program.connectstrDB);
            da.Fill(dt);
            Program.bindingSource.DataSource = dt;
            cmbMaKhoa.DataSource = Program.bindingSource;
            cmbMaKhoa.DisplayMember = "MAKHOA";
            cmbMaKhoa.ValueMember = "MAKHOA";

            
            DataTable dtPhai = new DataTable();
            SqlDataAdapter daPhai = new SqlDataAdapter("select * from GioiTinh ", Program.connectstrDB);
            daPhai.Fill(dtPhai);
            Program.bindingSourcePhai.DataSource = dtPhai;
            cmbPhai.DataSource = Program.bindingSourcePhai;
            cmbPhai.DisplayMember = "Phai";
            cmbPhai.ValueMember = "Phai";

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsGiaoVien.Position;
            panelNhapXuat.Enabled = true;
            bdsGiaoVien.AddNew();
            cmbMaKhoa.Text = ((DataRowView)bdsKhoa[bdsKhoa.Position])[0].ToString().Trim();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbMaKhoa.Enabled = false;
            gcGiaoVien.Enabled = false;
            gcKhoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsGiaoVien.Position;
            panelNhapXuat.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbMaKhoa.Enabled = true;
            gcGiaoVien.Enabled = false;
            gcKhoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không thể để trống!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ giáo viên không thể để trống!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên giáo viên không thể để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            if (cmbPhai.Text.Trim() == "")
            {
                MessageBox.Show("Chọn giới tính của giáo viên!", "", MessageBoxButtons.OK);
                cmbPhai.Focus();
                return;
            }

            try
            {

                bdsGiaoVien.EndEdit();
                bdsGiaoVien.ResetCurrentItem();
                this.giaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.giaoVienTableAdapter.Update(this.muaHeXanhDataSet.GiaoVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giáo viên!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcGiaoVien.Enabled = true;
            gcKhoa.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            panelNhapXuat.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGiaoVien.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsGiaoVien.Position = viTri;
            }
            gcGiaoVien.Enabled = true;
            gcKhoa.Enabled = true;
            panelNhapXuat.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            cmbMaKhoa.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.giaoVienTableAdapter.FillByIndex(this.muaHeXanhDataSet.GiaoVien);
                this.gcGiaoVien.Enabled = true;
                this.gcKhoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            /*if (xaBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên đã giám sát!", "", MessageBoxButtons.OK); return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maGV = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAGIAOVIEN"].ToString();
                    bdsGiaoVien.RemoveCurrent();
                    this.giaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.giaoVienTableAdapter.Update(this.muaHeXanhDataSet.GiaoVien);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.giaoVienTableAdapter.Fill(muaHeXanhDataSet.GiaoVien);
                    bdsGiaoVien.Position = bdsGiaoVien.Find("MAGIAOVIEN", maGV);
                    return;
                }
            }
            if (bdsGiaoVien.Count == 0) btnXoa.Enabled = false;
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maKhoa = ((DataRowView)bdsKhoa[bdsKhoa.Position])[0].ToString().Trim();

            // Lấy danh sách giáo viên theo mã khoa
            this.giaoVienTableAdapter.FillByMaKhoa(this.muaHeXanhDataSet.GiaoVien, maKhoa);
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muaHeXanhDataSet);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
