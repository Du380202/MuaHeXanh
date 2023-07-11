using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    public partial class Khoa : Form
    {
        int viTri = 0;
        public Khoa()
        {
            InitializeComponent();
        }


        private void frmKhoa_Load(object sender, EventArgs e)
        {
            muaHeXanhDataSet.EnforceConstraints = false;

            this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter.Fill(this.muaHeXanhDataSet.Khoa);

            this.sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);

            this.giaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaoVienTableAdapter.Fill(this.muaHeXanhDataSet.GiaoVien);

            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            panelNhapXuat.Enabled = false;
            if (Program.role == "QUANTRI")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnLamMoi.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled =  false;
                panelNhapXuat.Enabled = false;
            }


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKhoa.Position;
            panelNhapXuat.Enabled = true;
            bdsKhoa.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcKhoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKhoa.Position;
            panelNhapXuat.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcKhoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã công việc không thể để trống!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }

            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Tên công việc không thể để trống!", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return;
            }

            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoaTableAdapter.Update(this.muaHeXanhDataSet.Khoa);
                MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm công việc!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcKhoa.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelNhapXuat.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCV = "";
            /*if (bdsGiaoVien.Count > 0 || bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa đã có sinh viên hay giáo viên!", "", MessageBoxButtons.OK);
                return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maCV = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MaKhoa"].ToString();
                    bdsKhoa.RemoveCurrent();
                    this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoaTableAdapter.Update(this.muaHeXanhDataSet.Khoa);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.khoaTableAdapter.Fill(muaHeXanhDataSet.Khoa);
                    bdsKhoa.Position = bdsKhoa.Find("MaKhoa", maCV);
                    return;
                }
            }
            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsKhoa.Position = viTri;
            }
            gcKhoa.Enabled = true;
            panelNhapXuat.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            this.khoaTableAdapter.Fill(this.muaHeXanhDataSet.Khoa);
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoaTableAdapter.Fill(this.muaHeXanhDataSet.Khoa);
                this.gcKhoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
