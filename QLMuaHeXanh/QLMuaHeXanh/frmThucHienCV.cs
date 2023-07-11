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
    public partial class frmThucHienCV : Form
    {
        int viTri = 0;
        public frmThucHienCV()
        {
            InitializeComponent();
        }

        private void frmThucHienCV_Load(object sender, EventArgs e)
        {
            muaHeXanhDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.ThucHien' table. You can move, or remove it, as needed.
            this.thucHienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thucHienTableAdapter.Fill(this.muaHeXanhDataSet.ThucHien);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.View_ChiTietPhanCong' table. You can move, or remove it, as needed.
            this.view_ChiTietPhanCongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_ChiTietPhanCongTableAdapter.Fill(this.muaHeXanhDataSet.View_ChiTietPhanCong);
            
            if (Program.role == "QUANTRI")
            {
                btnDelete.Enabled = btnInsert.Enabled = btnUndo.Enabled = btnSave.Enabled = btnReload.Enabled = false;
                gcThucHien.Enabled = gcVCTCV.Enabled = gcVCTPC.Enabled = true;
            }
            if (Program.role == "GIAMSAT")
            {
                this.vChiTietCVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vChiTietCVTableAdapter.FillByMa(this.muaHeXanhDataSet.VChiTietCV, Program.userName);
                this.view_ChiTietPhanCongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.view_ChiTietPhanCongTableAdapter.FillByMA(this.muaHeXanhDataSet.View_ChiTietPhanCong, Program.userName);
            }
            else
            {
                // TODO: This line of code loads data into the 'muaHeXanhDataSet.VChiTietCV' table. You can move, or remove it, as needed.
                this.vChiTietCVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vChiTietCVTableAdapter.Fill(this.muaHeXanhDataSet.VChiTietCV);
                this.view_ChiTietPhanCongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.view_ChiTietPhanCongTableAdapter.Fill(this.muaHeXanhDataSet.View_ChiTietPhanCong);
            }
            btnSave.Enabled = btnUndo.Enabled = panelNhapXuat.Enabled = false;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            viTri = bdsThucHien.Position;
            panelNhapXuat.Enabled = true;
            gcThucHien.Enabled = false;
            bdsThucHien.AddNew();
            btnInsert.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DateTime date1 = (DateTime)((DataRowView)bdsThucHien[bdsThucHien.Position])["NgayThucHien"];
            DateTime date2 = DateTime.Now;
            viTri = bdsThucHien.Position;
            panelNhapXuat.Enabled = true;
            gcThucHien.Enabled = false;
            btnInsert.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            if (date1 < date2)
            {
                dThucHien.Enabled = false;
            }
            else
            {
                dThucHien.Enabled = true;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DateTime date1 = (DateTime)((DataRowView)bdsThucHien[bdsThucHien.Position])["NgayThucHien"];
            DateTime ngayHienTai = DateTime.Now;
            if (date1 <= ngayHienTai)
            {
                MessageBox.Show("Không thể xóa công việc đã được thực hiện!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string maCV = ((DataRowView)bdsThucHien[bdsThucHien.Position])["IDThucHien"].ToString();
                    string sqlLenh = "EXEC sp_DelThucHienCongViec '" + maCV + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.vChiTietCVTableAdapter.Fill(this.muaHeXanhDataSet.VChiTietCV);
                    if (check != 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNhom.Text.Trim() == "")
            {
                MessageBox.Show("Công việc không thể để trống!", "", MessageBoxButtons.OK);
                txtNhom.Focus();
                return;
            }

            if (txtAp.Text.Trim() == "")
            {
                MessageBox.Show("Ấp không thể để trống!", "", MessageBoxButtons.OK);
                txtAp.Focus();
                return;
            }

            if (dThucHien.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không thể để trống!", "", MessageBoxButtons.OK);
                dThucHien.Focus();
                return;
            }
            string dateTH = dThucHien.Text;

            DateTime date1 = (DateTime)((DataRowView)bdsVCTCV[bdsVCTCV.Position])["NgayBatDau"];
            DateTime date2 = (DateTime)((DataRowView)bdsVCTCV[bdsVCTCV.Position])["NgayKetThuc"];
            DateTime date3 = DateTime.ParseExact(dateTH, "yyyy/MM/dd", null);
            if (date1 > date3 || date2 < date3)
            {
                MessageBox.Show("Ngày thực hiện phải trong khoảng ngày bắt đầu và ngày kết thúc!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string idCV = ((DataRowView)bdsVCTCV[bdsVCTCV.Position])["IDChiTietCV"].ToString();
                string idPhanCong = ((DataRowView)bdsCTPC[bdsCTPC.Position])["IDPhanCong"].ToString();
                string sqlLenh = "EXEC sp_AddThucHienCongViec '" + idPhanCong + "', '" + idCV + "','"
                    + dThucHien.Text + "'";
                int check = Program.ExecSqlNonQuery(sqlLenh);
                this.vChiTietCVTableAdapter.Fill(this.muaHeXanhDataSet.VChiTietCV);
                if (check != 0)
                {
                    MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            panelNhapXuat.Enabled = false;
            gcThucHien.Enabled = true;
            bdsThucHien.AddNew();
            btnInsert.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bdsThucHien.CancelEdit();
            if (btnInsert.Enabled == false)
            {
                bdsThucHien.Position = viTri;
            }
            gcThucHien.Enabled = true;
            btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.role == "GIAMSAT")
                {
                    this.vChiTietCVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vChiTietCVTableAdapter.FillByMa(this.muaHeXanhDataSet.VChiTietCV, Program.userName);
                    this.view_ChiTietPhanCongTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.view_ChiTietPhanCongTableAdapter.FillByMA(this.muaHeXanhDataSet.View_ChiTietPhanCong, Program.userName);
                }
                else
                {
                    // TODO: This line of code loads data into the 'muaHeXanhDataSet.VChiTietCV' table. You can move, or remove it, as needed.
                    this.vChiTietCVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vChiTietCVTableAdapter.Fill(this.muaHeXanhDataSet.VChiTietCV);
                    this.view_ChiTietPhanCongTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.view_ChiTietPhanCongTableAdapter.Fill(this.muaHeXanhDataSet.View_ChiTietPhanCong);
                }
                this.thucHienTableAdapter.Fill(this.muaHeXanhDataSet.ThucHien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcThucHien.Enabled == false)
            {
                txtAp.Text = ((DataRowView)bdsVCTCV[bdsVCTCV.Position])["TenAp"].ToString();
                txtCongViec.Text = ((DataRowView)bdsVCTCV[bdsVCTCV.Position])["TenCongViec"].ToString();
            }
            string ma = ((DataRowView)bdsVCTCV[bdsVCTCV.Position])["MaXa"].ToString();
            this.view_ChiTietPhanCongTableAdapter.FillByXa(this.muaHeXanhDataSet.View_ChiTietPhanCong, ma);
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcThucHien.Enabled == false)
            {
                txtNhom.Text = ((DataRowView)bdsCTPC[bdsCTPC.Position])["TenNhom"].ToString();
                txtBuoi.Text = ((DataRowView)bdsCTPC[bdsCTPC.Position])["TenBuoi"].ToString();
            }
        }
    }
}
