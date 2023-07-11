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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLMuaHeXanh
{
    public partial class frmNhaDan : Form
    {
        int viTri = 0;
        int vt = 0;
        public frmNhaDan()
        {
            InitializeComponent();
        }

        private void frmNhaDan_Load(object sender, EventArgs e)
        {

            muaHeXanhDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Ap' table. You can move, or remove it, as needed.
            this.apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Fill(this.muaHeXanhDataSet.Ap);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.NhaDan' table. You can move, or remove it, as needed.
            this.nhaDanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhaDan);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.NhomChuaCoNhaDan' table. You can move, or remove it, as needed.
            this.nhomChuaCoNhaDanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomChuaCoNhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhomChuaCoNhaDan);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomTableAdapter.Fill(this.muaHeXanhDataSet.Nhom);

            if (Program.role == "QUANTRI")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnDelete.Enabled = btnInsert.Enabled = btnGhi.Enabled = false;
                btnLamMoi.Enabled = btnPhucHoi.Enabled = false;
                btnSave.Enabled = btnUndo.Enabled = false;
                panelNhapXuat.Enabled = false;
                gcAp.Enabled = gcNhaDan.Enabled = gcNhom.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhaDan.Position;
            panelNhapXuat.Enabled = true;
            bdsNhaDan.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhaDan.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhaDan.Position;
            panelNhapXuat.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhaDan.Enabled = false;
           
        }


        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhaDan.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsNhaDan.Position = viTri;
            }
            gcNhaDan.Enabled = true;
            panelNhapXuat.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }



        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhaDan);
                this.apTableAdapter.Fill(this.muaHeXanhDataSet.Ap);
                this.gcNhaDan.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà dân không thể để trống!", "", MessageBoxButtons.OK);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhà dân không thể để trống!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
         
            try
            {

                bdsNhaDan.EndEdit();
                bdsNhaDan.ResetCurrentItem();
                this.nhaDanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhaDanTableAdapter.Update(this.muaHeXanhDataSet.NhaDan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhà dân!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhaDan.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            panelNhapXuat.Enabled = false;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maND = "";
            /*if (nhomBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhà dân đã có nhóm!", "", MessageBoxButtons.OK); return;
            }*/
           
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maND = ((DataRowView)bdsNhaDan[bdsNhaDan.Position])["MANHADAN"].ToString();
                    string sqlLenh = "exec XoaNhaDan '" + maND + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.nhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhaDan);
                    if (check != 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhà dân. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (bdsNhaDan.Count == 0) btnXoa.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            vt = bdsNhom.Position;
            gcNhom.Enabled = true;
            btnSave.Enabled = true;
            btnUndo.Enabled = true;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = 
                btnLamMoi.Enabled =btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcAp.Enabled = gcNhaDan.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    string maND = ((DataRowView)bdsNhaDan[bdsNhaDan.Position])["MANHADAN"].ToString();
                    string maNhom = ((DataRowView)bdsNhaDan[bdsNhaDan.Position])["MaNhom"].ToString();
                    string sqlLenh = "exec DELNHADAN '" + maNhom + "', '" + maND + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.nhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhaDan);
                    this.nhomChuaCoNhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhomChuaCoNhaDan);
                    if (check > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhóm!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maND = ((DataRowView)bdsNhaDan[bdsNhaDan.Position])["MANHADAN"].ToString();
            string maNhom = ((DataRowView)bdsNhom[bdsNhom.Position])["MaNhom"].ToString();
            string sqlLenh = "exec ADDNHADAN '" + maNhom + "', '" + maND + "', @ERRORCODE OUTPUT";
            SqlCommand cmd = new SqlCommand(sqlLenh, Program.conn);
            cmd.Parameters.Add("@ERRORCODE", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                int errorCode = Convert.ToInt32(cmd.Parameters["@ERRORCODE"].Value);

                if (errorCode == 0)
                {
                    MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                    this.nhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhaDan);
                    this.nhomChuaCoNhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhomChuaCoNhaDan);
                }
                else if (errorCode == -1)
                {
                    MessageBox.Show("Nhà dân đã có nhóm!", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "", MessageBoxButtons.OK);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
                btnLamMoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcAp.Enabled = gcNhaDan.Enabled = true;
            gcNhom.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bdsNhom.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsNhom.Position = vt;
            }
            gcNhom.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnSave.Enabled  = false;
            btnInsert.Enabled = btnDelete.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.nhomChuaCoNhaDanTableAdapter.Fill(this.muaHeXanhDataSet.NhomChuaCoNhaDan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
