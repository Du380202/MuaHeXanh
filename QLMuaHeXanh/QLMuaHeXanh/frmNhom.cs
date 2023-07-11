using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Drawing.Internal.Fonts;
using DevExpress.XtraGrid;
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
    public partial class frmNhom : Form
    {
        int vitri = 0;
        public frmNhom()
        {
            InitializeComponent();
        }

        private void frmNhom_Load(object sender, EventArgs e)
        {

            muaHeXanhDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomTableAdapter.Fill(this.muaHeXanhDataSet.Nhom);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.SINHVIENKHONGNHOM' table. You can move, or remove it, as needed.
            this.SINHVIENKHONGNHOMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENKHONGNHOMTableAdapter.Fill(this.muaHeXanhDataSet.SINHVIENKHONGNHOM);

            if (gcSVNhom.Enabled == true)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }

            if (Program.role == "QUANTRI")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnDelete.Enabled = btnInsert.Enabled = btnGhi.Enabled = false;
                btnLamMoi.Enabled = btnSave.Enabled = btnUndo.Enabled = btnPhucHoi.Enabled = false;
                panelNhapNhom.Enabled = false;
                gcNhom.Enabled = gcSVKNhom.Enabled = gcSVNhom.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhom.Position;
            panelNhapNhom.Enabled = gcSVKNhom.Enabled = true;
            bdsNhom.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            txtNhomTruong.Text = ((DataRowView)bdsSinhVienKhongNhom[bdsSinhVienKhongNhom.Position])["MaSinhVien"].ToString();
            gcNhom.Enabled = gcSVNhom.Enabled =  false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhom.Position;
            panelNhapNhom.Enabled = gcSVKNhom.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhom.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNhom.Text.Trim() == "")
            {
                MessageBox.Show("Mã Nhóm không thể để trống!", "", MessageBoxButtons.OK);
                txtMaNhom.Focus();
                return;
            }
            if (txtTenNhom.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhóm không thể để trống!", "", MessageBoxButtons.OK);
                txtTenNhom.Focus();
                return;
            }
            if (txtNhomTruong.Text.Trim() == "")
            {
                MessageBox.Show("Thêm nhóm trưởng không thể để trống!", "", MessageBoxButtons.OK);
                txtNhomTruong.Focus();
                return;
            }


            try
            {
                string sqlLenh = "EXEC UpdateNhomByMaSinhVien '" + txtNhomTruong.Text + "', '" + txtMaNhom.Text + "'";
                bdsNhom.EndEdit();
                bdsNhom.ResetCurrentItem();
                ((DataRowView)bdsNhom[bdsNhom.Position])["MaNhomTruong"] = txtNhomTruong.Text;
                this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhomTableAdapter.Update(this.muaHeXanhDataSet.Nhom);
                Program.ExecSqlNonQuery(sqlLenh);
                this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhóm!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhom.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            panelNhapNhom.Enabled = gcSVKNhom.Enabled =  false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            /*if (bdsSinhVienNhom.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhóm đã có thành viên!", "", MessageBoxButtons.OK); return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maGV = ((DataRowView)bdsNhom[bdsNhom.Position])["MaNhom"].ToString();
                    bdsNhom.RemoveCurrent();
                    this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhomTableAdapter.Update(this.muaHeXanhDataSet.Nhom);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhóm. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.nhomTableAdapter.Fill(muaHeXanhDataSet.Nhom);
                    bdsNhom.Position = bdsNhom.Find("MaNhom", maGV);
                    return;
                }
            }
            if (bdsNhom.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhom.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsNhom.Position = vitri;
            }
            gcNhom.Enabled = true;
            panelNhapNhom.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnDelete.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhomTableAdapter.Fill(this.muaHeXanhDataSet.Nhom);
                this.gcNhom.Enabled = true;
                this.gcSVKNhom.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            vitri = bdsSinhVienNhom.Position;
            gcSVKNhom.Enabled = gcSVNhom.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcNhom.Enabled = panelNhapNhom.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = 
                btnLamMoi.Enabled  = btnDelete.Enabled = btnUndo.Enabled = false;
            btnPhucHoi.Enabled = btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ma = ((DataRowView)bdsSinhVienNhom[bdsSinhVienNhom.Position])["MaSinhVien"].ToString();
            if (ma == ((DataRowView)bdsNhom[bdsNhom.Position])["MaNhomTruong"].ToString())
            {
                MessageBox.Show("Không thể xóa nhóm trưởng", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string maSV = ((DataRowView)bdsSinhVienNhom[bdsSinhVienNhom.Position])["MaSinhVien"].ToString();
                string sqlLenh = "EXEC UpdateNhomByMaSinhVien '" + maSV + "', " + "NULL";
                int check = Program.ExecSqlNonQuery(sqlLenh);
                this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
                this.SINHVIENKHONGNHOMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENKHONGNHOMTableAdapter.Fill(this.muaHeXanhDataSet.SINHVIENKHONGNHOM);
                if (check == 1)
                {
                    MessageBox.Show("Xóa khỏi nhóm thành công!", "", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại! \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (bdsSinhVienNhom.Count == 0) btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string maKhoaNhom = ((DataRowView)bdsSinhVienNhom[bdsSinhVienNhom.Position])["MaKhoa"].ToString();
                string maKhoaKNhom = ((DataRowView)bdsSinhVienKhongNhom[bdsSinhVienKhongNhom.Position])["MaKhoa"].ToString();
                if (maKhoaKNhom != maKhoaNhom) 
                {
                    MessageBox.Show("Sinh viên khác khoa không thể cùng nhóm!");
                    return;
                }
                else
                {
                    string sqlLenh = "EXEC UpdateNhomByMaSinhVien '" + txtNhomTruong.Text + "', '" + txtMaNhom.Text + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
                    this.SINHVIENKHONGNHOMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENKHONGNHOMTableAdapter.Fill(this.muaHeXanhDataSet.SINHVIENKHONGNHOM);
                    if (check == 1)
                    {
                        MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại! \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void txtNhomTruong_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcSVKNhom.Enabled == false)
            {
                txtNhomTruong.Text = ((DataRowView)bdsNhom[bdsNhom.Position])["MaNhomTruong"].ToString();
            }
            if (bdsSinhVienNhom.Count < 6)
            {
                btnInsert.Enabled = true;
            }
            else
            {
                btnInsert.Enabled = false;
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcSVKNhom.Enabled == false && gcNhom.Enabled == false)
            {
                txtNhomTruong.Text = ((DataRowView)bdsNhom[bdsNhom.Position])["MaNhomTruong"].ToString();
            }


        }
    }
}
