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
    public partial class frmThanhTich : Form
    {
        int viTri = 0;
        public frmThanhTich()
        {
            InitializeComponent();
        }

        private void thanhTichBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsThanhTich.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muaHeXanhDataSet);

        }

        private void thanhTichBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsThanhTich.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muaHeXanhDataSet);

        }

        private void frmThanhTich_Load(object sender, EventArgs e)
        {
            muaHeXanhDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.ThanhTich' table. You can move, or remove it, as needed.
            this.thanhTichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thanhTichTableAdapter.Fill(this.muaHeXanhDataSet.ThanhTich);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.KhenThuong' table. You can move, or remove it, as needed.

          

            this.khenThuongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khenThuongTableAdapter.Fill(this.muaHeXanhDataSet.KhenThuong);
            btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            pnInput.Enabled = false;
            if (Program.role == "QUANTRI")
            {
                btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
                btnSave.Enabled = btnUndo.Enabled = false;
                pnInput.Enabled = false;
            }


        }

        private void btnThemTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsThanhTich.Position;
            pnInput.Enabled = true;
            bdsThanhTich.AddNew();
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcThanhTich.Enabled = false;
            pnInput.Enabled = true;
        }

        private void btnSuaTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsThanhTich.Position;
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcThanhTich.Enabled = false;
            pnInput.Enabled = true;

        }

        private void btnPhucHoiTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsThanhTich.CancelEdit();
            if (btnInsert.Enabled == false)
            {
                bdsThanhTich.Position = viTri;
            }
            gcThanhTich.Enabled = true;
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            this.thanhTichTableAdapter.Fill(this.muaHeXanhDataSet.ThanhTich);
            pnInput.Enabled = false;

        }

        private void btnLamMoiTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.thanhTichTableAdapter.Fill(this.muaHeXanhDataSet.ThanhTich);
                this.gcThanhTich.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            pnInput.Enabled = false;
        }

        private void btnGhiTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaTT.Text.Trim() == "")
            {
                MessageBox.Show("Mã thành tích không thể để trống!", "", MessageBoxButtons.OK);
                txtTenTT.Focus();
                return;
            }
            if (txtTenTT.Text.Trim() == "")
            {
                MessageBox.Show("Tên thành tích không thể để trống!", "", MessageBoxButtons.OK);
                txtTenTT.Focus();
                return;
            }
            try
            {
                bdsThanhTich.EndEdit();
                bdsThanhTich.ResetCurrentItem();
                this.thanhTichTableAdapter.Connection.ConnectionString = Program.connstr;
                this.thanhTichTableAdapter.Update(this.muaHeXanhDataSet.ThanhTich);
                MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm thành tích!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcThanhTich.Enabled = true;
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled =   true;
            btnSave.Enabled = btnUndo.Enabled = false;
            pnInput.Enabled = false;

        }

        private void btnXoaTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maTT = "";
            if (bdsKhenThuong.Count > 0 )
            {
                MessageBox.Show("Không thể xóa thành tích đã khen thưởng cho sinh viên!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maTT = ((DataRowView)bdsThanhTich[bdsThanhTich.Position])["MaThanhTich"].ToString();
                    string sqlLenh = "exec XoaThanhTich '" + maTT + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.thanhTichTableAdapter.Fill(this.muaHeXanhDataSet.ThanhTich);
                    if (check != 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa thành tích. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.thanhTichTableAdapter.Fill(muaHeXanhDataSet.ThanhTich);
                    bdsThanhTich.Position = bdsThanhTich.Find("MaThanhTich", maTT);
                    return;
                }
            }
            if (bdsThanhTich.Count == 0) btnDelete.Enabled = false;
            pnInput.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
