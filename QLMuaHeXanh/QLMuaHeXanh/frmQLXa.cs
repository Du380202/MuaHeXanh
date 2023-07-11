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
    public partial class frmQLXa : Form
    {
        int vt = 0;
        string maKhoa1, maKhoa2, makhoadt, makhoadp;
        public frmQLXa()
        {
            InitializeComponent();
        }

        private void frmQLXa_Load(object sender, EventArgs e)
        {

            muaHeXanhDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'muaHeXanhDataSet.view_GVGiamSat' table. You can move, or remove it, as needed.
            this.view_GVGiamSatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_GVGiamSatTableAdapter.Fill(this.muaHeXanhDataSet.view_GVGiamSat);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.view_SVGiamSat' table. You can move, or remove it, as needed.
            this.view_SVGiamSatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_SVGiamSatTableAdapter.Fill(this.muaHeXanhDataSet.view_SVGiamSat);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.view_Xa' table. You can move, or remove it, as needed.
            this.view_XaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_XaTableAdapter.Fill(this.muaHeXanhDataSet.view_Xa);


            if (Program.role == "QUANTRI")
            {
                btnInsert.Enabled =  btnSave.Enabled = false;
                btnUndo.Enabled = btnReload.Enabled = false;
                panelControl2.Enabled = false;
                gcGVGS.Enabled = gcSVGS.Enabled = gcXa.Enabled = true;
            }

        }

        private void txtGS2_Enter(object sender, EventArgs e)
        {
            if (gcXa.Enabled == false && gridView1.SelectedRowsCount > 0)
            {
                int rowIndex = gridView1.GetSelectedRows()[0];

                string maGiaoVien = gridView1.GetRowCellValue(rowIndex, "MaGiaoVien").ToString();
                maKhoa2 = gridView1.GetRowCellValue(rowIndex, "MaKhoa").ToString();
                txtGS2.Text = maGiaoVien;
            }
        }

        private void txtGS1_Enter(object sender, EventArgs e)
        {
            if (gcXa.Enabled == false && gridView1.SelectedRowsCount > 0)
            {
                int rowIndex = gridView1.GetSelectedRows()[0];

                string maGiaoVien = gridView1.GetRowCellValue(rowIndex, "MaGiaoVien").ToString();
                maKhoa1 = gridView1.GetRowCellValue(rowIndex, "MaKhoa").ToString();              
                txtGS1.Text = maGiaoVien;
            }
        }
        private void txtDTruong_Enter(object sender, EventArgs e)
        {
            if (gcXa.Enabled == false && gridView2.SelectedRowsCount > 0)
            {
                
                int rowIndex = gridView2.GetSelectedRows()[0];

                string maSinhVien = gridView2.GetRowCellValue(rowIndex, "MaSinhVien").ToString();
                makhoadt = gridView2.GetRowCellValue(rowIndex, "MaKhoa").ToString();
                txtDTruong.Text = maSinhVien;
            }
        }

        private void txtDPho_Enter(object sender, EventArgs e)
        {
            if (gcXa.Enabled == false && gridView2.SelectedRowsCount > 0)
            {
   
                int rowIndex = gridView2.GetSelectedRows()[0];

                string maSinhVien = gridView2.GetRowCellValue(rowIndex, "MaSinhVien").ToString();
                makhoadp = gridView2.GetRowCellValue(rowIndex, "MaKhoa").ToString();
 
                txtDPho.Text = maSinhVien;
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
                txtDTruong.Enter += txtDTruong_Enter;
                txtDPho.Enter += txtDPho_Enter;
       
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
               txtGS2.Enter += txtGS2_Enter;
               txtGS1.Enter += txtGS1_Enter;   
         
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            vt = bdsXa.Position;
            gcXa.Enabled  = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnInsert.Enabled =  false;
            gcGVGS.Enabled = gcSVGS.Enabled = true;
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtGS1.Text.Trim() == "")
            {
                MessageBox.Show("Thêm giám sát 1!", "", MessageBoxButtons.OK);
                txtGS1.Focus();
                return;
            }

            if (txtGS2.Text.Trim() == "")
            {
                MessageBox.Show("Thêm giám sát 2!", "", MessageBoxButtons.OK);
                txtGS2.Focus();
                return;
            }

            if (txtDTruong.Text.Trim() == "")
            {
                MessageBox.Show("Mã đội trưởng không thể để trống!", "", MessageBoxButtons.OK);
                txtDTruong.Focus();
                return;
            }

            if (txtDPho.Text.Trim() == "")
            {
                MessageBox.Show("Mã đội phó không thể để trống!", "", MessageBoxButtons.OK);
                txtDPho.Focus();
                return;
            }
            
            if (txtGS1.Text == txtGS2.Text)
            {
                MessageBox.Show("Mã giám sát 1 và 2 không thể giống nhau!", "", MessageBoxButtons.OK);
                txtGS1.Focus();
                return;
            }

            if (txtDTruong.Text == txtDPho.Text)
            {
                MessageBox.Show("Mã đội trưởng và mã đội phó không thể giống nhau!", "", MessageBoxButtons.OK);
                txtDTruong.Focus();
                return;
            }

            if (maKhoa1 != maKhoa2)
            {
                MessageBox.Show("2 giám sát phải cùng một khoa!", "", MessageBoxButtons.OK);
  
                return;
            }
            if (makhoadp != makhoadt)
            {
                MessageBox.Show("Đội trưởng và đội phó phải cùng khoa!", "", MessageBoxButtons.OK);
   
                return;
            }
           

            try
            {
                string sqlLenh = "EXEC UPDATEXA '" + txtMaXa.Text + "','" + txtGS1.Text + "','" 
                    + txtGS2.Text + "','" + txtDTruong.Text + "','" + txtDPho.Text + "'";
                int check = Program.ExecSqlNonQuery(sqlLenh);
                this.view_XaTableAdapter.Fill(this.muaHeXanhDataSet.view_Xa);
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

            gcXa.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            btnInsert.Enabled =  true;
            gcGVGS.Enabled = gcSVGS.Enabled = false;
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {
            bdsXa.CancelEdit();
            if (btnInsert.Enabled == false)
            {
                bdsXa.Position = vt;
            }
            gcXa.Enabled = true;
            btnInsert.Enabled = true;
            gcGVGS.Enabled = gcSVGS.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.view_GVGiamSatTableAdapter.Fill(this.muaHeXanhDataSet.view_GVGiamSat);
                this.view_SVGiamSatTableAdapter.Fill(this.muaHeXanhDataSet.view_SVGiamSat);
                this.view_XaTableAdapter.Fill(this.muaHeXanhDataSet.view_Xa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
