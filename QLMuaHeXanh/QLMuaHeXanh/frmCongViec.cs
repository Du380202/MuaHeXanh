using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    public partial class frmCongViec : Form
    {
        int viTri = 0;
        public frmCongViec()
        {
            InitializeComponent();
        }


        private void frmCongViec_Load(object sender, EventArgs e)
        {
            muaHeXanhDataSet.EnforceConstraints = false;
            
            this.congViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congViecTableAdapter.Fill(this.muaHeXanhDataSet.CongViec);

            this.chiTietCongViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietCongViecTableAdapter.Fill(this.muaHeXanhDataSet.ChiTietCongViec);
            if (Program.role == "QUANTRI")
            {
                btnThemCV.Enabled = btnSuaCV.Enabled = btnXoaCV.Enabled = btnGhiCV.Enabled = false;
                btnReload.Enabled = btnUndo.Enabled = false;
                panelNhapXuat.Enabled = false;
            }
            btnUndo.Enabled = btnGhiCV.Enabled = false;
            panelNhapXuat.Enabled = false;


        }

        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            viTri = bdsCongViec.Position;
            panelNhapXuat.Enabled = true;
            bdsCongViec.AddNew();
            btnThemCV.Enabled = btnSuaCV.Enabled = btnXoaCV.Enabled = btnReload.Enabled = false;
            btnGhiCV.Enabled = btnUndo.Enabled = true;
            gcCongViec.Enabled = false;
        }

        private void btnSuaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsCongViec.Position;
            panelNhapXuat.Enabled = true;
            btnThemCV.Enabled = btnSuaCV.Enabled = btnXoaCV.Enabled = btnReload.Enabled = false;
            btnGhiCV.Enabled = btnUndo.Enabled = true;
            gcCongViec.Enabled = false;
        }

        private void btnGhiCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (txtMaCV.Text.Trim() == "")
            {
                MessageBox.Show("Mã công việc không thể để trống!", "", MessageBoxButtons.OK);
                txtMaCV.Focus();
                return;
            }

            if (txtTenCV.Text.Trim() == "")
            {
                MessageBox.Show("Tên công việc không thể để trống!", "", MessageBoxButtons.OK);
                txtTenCV.Focus();
                return;
            }

            try
            {
                bdsCongViec.EndEdit();
                bdsCongViec.ResetCurrentItem();
                this.congViecTableAdapter.Connection.ConnectionString = Program.connstr;
                this.congViecTableAdapter.Update(this.muaHeXanhDataSet.CongViec);
                MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm công việc!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcCongViec.Enabled = true;
            btnThemCV.Enabled = btnSuaCV.Enabled = btnXoaCV.Enabled = btnReload.Enabled = true;
            btnGhiCV.Enabled = btnUndo.Enabled = false;
            panelNhapXuat.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            bdsCongViec.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsCongViec.Position = viTri;
            }
            gcCongViec.Enabled = true;
            panelNhapXuat.Enabled = false;
            btnThemCV.Enabled = btnSuaCV.Enabled = btnXoaCV.Enabled = btnReload.Enabled = true;
            btnGhiCV.Enabled = btnUndo.Enabled = false;
            this.congViecTableAdapter.Fill(this.muaHeXanhDataSet.CongViec);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.congViecTableAdapter.Fill(this.muaHeXanhDataSet.CongViec);
                this.gcCongViec.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCV = "";
            /*if (bdsChiTietCV.Count > 0)
            {
                MessageBox.Show("Không thể xóa công viêc đã thực hiện trong chiến dịch!", "", MessageBoxButtons.OK);
                return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maCV = ((DataRowView)bdsCongViec[bdsCongViec.Position])["MaCongViec"].ToString();
                    bdsCongViec.RemoveCurrent();
                    this.congViecTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.congViecTableAdapter.Update(this.muaHeXanhDataSet.CongViec);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa công việc. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.congViecTableAdapter.Fill(muaHeXanhDataSet.CongViec);
                    bdsCongViec.Position = bdsCongViec.Find("MaCongViec", maCV);
                    return;
                }
            }
            if (bdsCongViec.Count == 0) btnXoaCV.Enabled = false;
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
