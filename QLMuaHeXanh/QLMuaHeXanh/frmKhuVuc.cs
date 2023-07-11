using DevExpress.ChartRangeControlClient.Core;
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
    public partial class frmKhuVuc : Form
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            
            muaHeXanhDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.DiaBan' table. You can move, or remove it, as needed.
            this.diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.diaBanTableAdapter.Fill(this.muaHeXanhDataSet.DiaBan);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Xa' table. You can move, or remove it, as needed.
            this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.muaHeXanhDataSet.Xa);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Ap' table. You can move, or remove it, as needed.
            this.apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Fill(this.muaHeXanhDataSet.Ap);
            if (Program.role == "QUANTRI")
            {
                panelNhapDiaBan.Enabled = panelNhapAp.Enabled = panelNhapXa.Enabled = false;
                gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
                btnDiaBan.Enabled = btnAp.Enabled = btnXa.Enabled = btnHoanTac.Enabled = false;
            }

        }
        private void btnDiaBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapDiaBan.Enabled = gcDiaBan.Enabled = true;
            panelNhapAp.Enabled = panelNhapXa.Enabled = false;
            gcAp.Enabled = gcXa.Enabled = false;
            btnAp.Enabled= btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = true;
        }

        private void btnXa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapXa.Enabled = true;
            panelNhapDiaBan.Enabled = panelNhapAp.Enabled = false;
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true ;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled= true;
        }

        private void btnAp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapAp.Enabled = true;
            panelNhapDiaBan.Enabled = panelNhapXa.Enabled = false;
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = true;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapDiaBan.Enabled = panelNhapXa.Enabled = panelNhapAp.Enabled = false;
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = true;
        }

        private void btnThemDB_Click(object sender, EventArgs e)
        {
            panelNhapDiaBan.Enabled =  true;
            bdsDiaBan.AddNew();
            panelNhapAp.Enabled = panelNhapXa.Enabled = false;
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled  = false;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = false;
            btnHoanTac.Enabled = btnLuuDB.Enabled=  true;
        }
        private void btnLuuDB_Click(object sender, EventArgs e)
        {
            if (txtDiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Mã địa bàn không thể để trống!", "", MessageBoxButtons.OK);
                txtDiaBan.Focus();
                return;
            }
            if (txtTenDB.Text.Trim() == "")
            {
                MessageBox.Show("Tên địa bàn không thể để trống!", "", MessageBoxButtons.OK);
                txtTenDB.Focus();
                return;
            }

            try
            {
                bdsDiaBan.EndEdit();
                bdsDiaBan.ResetCurrentItem();
                this.diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.diaBanTableAdapter.Update(this.muaHeXanhDataSet.DiaBan);
                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm địa bàn!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = btnLuuDB.Enabled = false;

            panelNhapDiaBan.Enabled = false;
        }

        private void btnXoaDB_Click(object sender, EventArgs e)
        {
            String maDB = "";
            /*if (bdsXa.Count > 0)
            {
                MessageBox.Show("Không thể xóa địa bàn đã có xã!", "", MessageBoxButtons.OK); return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maDB = ((DataRowView)bdsDiaBan[bdsDiaBan.Position])["MaDiaBan"].ToString();
                    bdsDiaBan.RemoveCurrent();
                    this.diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.diaBanTableAdapter.Update(this.muaHeXanhDataSet.DiaBan);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa địa bàn.\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.diaBanTableAdapter.Fill(muaHeXanhDataSet.DiaBan);
                    bdsDiaBan.Position = bdsDiaBan.Find("MaDiaBan", maDB);
                    return;
                }
            }
        }

        private void btnThemXa_Click(object sender, EventArgs e)
        {
            panelNhapXa.Enabled = true;
            bdsXa.AddNew();
            cmbDiaBan.Text = ((DataRowView)bdsDiaBan[bdsDiaBan.Position])[0].ToString().Trim();
            panelNhapAp.Enabled = panelNhapDiaBan.Enabled = false;
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = false;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = btnLuuXa.Enabled = true;
            cmbDiaBan.Enabled = false;
        }

        private void btnLuuXa_Click(object sender, EventArgs e)
        {
            if (txtMaXa.Text.Trim() == "")
            {
                MessageBox.Show("Mã địa bàn không thể để trống!", "", MessageBoxButtons.OK);
                txtDiaBan.Focus();
                return;
            }
            if (txtTenXa.Text.Trim() == "")
            {
                MessageBox.Show("Tên địa bàn không thể để trống!", "", MessageBoxButtons.OK);
                txtTenDB.Focus();
                return;
            }

            try
            {
                bdsXa.EndEdit();
                bdsXa.ResetCurrentItem();
                this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.xaTableAdapter.Update(this.muaHeXanhDataSet.Xa);
                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm địa bàn!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = btnLuuXa.Enabled = false;

            panelNhapXa.Enabled = false;
        }

        private void btnXoaXa_Click(object sender, EventArgs e)
        {
            String maXa = "";
           /* if (apBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa xã đã có ấp!", "", MessageBoxButtons.OK); return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maXa = ((DataRowView)bdsXa[bdsXa.Position])["MaXa"].ToString();
                    bdsXa.RemoveCurrent();
                    this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.xaTableAdapter.Update(this.muaHeXanhDataSet.Xa);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa xã.\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.xaTableAdapter.Fill(muaHeXanhDataSet.Xa);
                    bdsXa.Position = bdsXa.Find("MaXa", maXa);
                    return;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.diaBanTableAdapter.Fill(this.muaHeXanhDataSet.DiaBan);
                this.xaTableAdapter.Fill(this.muaHeXanhDataSet.Xa);
                this.apTableAdapter.Fill(this.muaHeXanhDataSet.Ap);
                btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
                gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaAp_Click(object sender, EventArgs e)
        {
            String maAp = "";
            /* if (apBindingSource.Count > 0)
             {
                 MessageBox.Show("Không thể xóa xã đã có ấp!", "", MessageBoxButtons.OK); return;
             }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maAp = ((DataRowView)apBindingSource[apBindingSource.Position])["MaAp"].ToString();
                    bdsXa.RemoveCurrent();
                    this.apTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.apTableAdapter.Update(this.muaHeXanhDataSet.Ap);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa ấp.\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.apTableAdapter.Fill(muaHeXanhDataSet.Ap);
                    bdsXa.Position = bdsXa.Find("MaAp", maAp);
                    return;
                }
            }
        }

        private void btnThemAp_Click(object sender, EventArgs e)
        {
            panelNhapAp.Enabled = true;
            apBindingSource.AddNew();
            cmbDiaBan.Text = ((DataRowView)bdsXa[bdsXa.Position])[0].ToString().Trim();
            panelNhapXa.Enabled = panelNhapDiaBan.Enabled = false;
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = btnLuuXa.Enabled = true;
            cmbXa1.Enabled = false;
        }

        private void btnLuuAp_Click(object sender, EventArgs e)
        {
            if (txtMaAp1.Text.Trim() == "")
            {
                MessageBox.Show("Mã ấp không thể để trống!", "", MessageBoxButtons.OK);
                txtMaAp1.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên ấp không thể để trống!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            try
            {
                apBindingSource.EndEdit();
                apBindingSource.ResetCurrentItem();
                this.apTableAdapter.Connection.ConnectionString = Program.connstr;
                this.apTableAdapter.Update(this.muaHeXanhDataSet.Ap);
                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm ấp!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcAp.Enabled = gcDiaBan.Enabled = gcXa.Enabled = true;
            btnAp.Enabled = btnXa.Enabled = btnDiaBan.Enabled = true;
            btnHoanTac.Enabled = btnLuuXa.Enabled = false;

            panelNhapXa.Enabled = false;
        }
    }
}
