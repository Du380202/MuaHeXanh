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
    public partial class frmChiTietCongViec : Form
    {
        int vt = 0;
        public frmChiTietCongViec()
        {
            InitializeComponent();
        }
        private void frmChiTietCongViec_Load(object sender, EventArgs e)
        {
            
            muaHeXanhDataSet.EnforceConstraints = false;

            this.apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Fill(this.muaHeXanhDataSet.Ap);

            this.congViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congViecTableAdapter.Fill(this.muaHeXanhDataSet.CongViec);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.VChiTietCV' table. You can move, or remove it, as needed.
            this.vChiTietCVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vChiTietCVTableAdapter.Fill(this.muaHeXanhDataSet.VChiTietCV);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.ChiTietAp' table. You can move, or remove it, as needed.
            this.chiTietApTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietApTableAdapter.Fill(this.muaHeXanhDataSet.ChiTietAp);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.ThucHienCongViec' table. You can move, or remove it, as needed.
            this.thucHienCongViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thucHienCongViecTableAdapter.Fill(this.muaHeXanhDataSet.ThucHienCongViec);

            BindingSource bindingSourceKhoa = new BindingSource();
            DataTable dtKhoa = new DataTable();

            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT * FROM DiaBan", Program.connectstrDB);
            daKhoa.Fill(dtKhoa);
            bindingSourceKhoa.DataSource = dtKhoa;
            cmbDiaBan.DataSource = bindingSourceKhoa;
            cmbDiaBan.DisplayMember = "TenDiaBan";
            cmbDiaBan.ValueMember = "MADiaBan";
            if (Program.role == "QUANTRI")
            {
                btnDelete.Enabled = btnInsert.Enabled = btnEdit.Enabled = false;
                btnReload.Enabled = btnUndo.Enabled = btnSave.Enabled = false;
                panelNhapXuat.Enabled = false;
                gcCongViec.Enabled = gcCTAp.Enabled = gcVCTCV.Enabled = true;
            }
            

        }

        private void cmbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiaBan.SelectedItem != null)
            {
               
                DataRowView selectedRow = cmbDiaBan.SelectedItem as DataRowView;
                string selectedValue = selectedRow["MADiaBan"].ToString();
                // Tạo đối tượng BindingSource và DataTable cho bảng "Xa"
                BindingSource bindingSourceXA = new BindingSource();
                DataTable dtXa = new DataTable();

                // Tạo đối tượng SqlDataAdapter và truy vấn dữ liệu từ bảng "Xa" với tham số truy vấn
                string query = "SELECT * FROM Xa WHERE MaDiaBan = @MaDiaBan";
                SqlDataAdapter daXa = new SqlDataAdapter(query, Program.connectstrDB);
                daXa.SelectCommand.Parameters.AddWithValue("@MaDiaBan", selectedValue);
                daXa.Fill(dtXa);

                // Gán dữ liệu vào BindingSource và liên kết với ComboBox "cmbXa"
                bindingSourceXA.DataSource = dtXa;
                cmbXa.DataSource = bindingSourceXA;
                cmbXa.DisplayMember = "TenXa";
                cmbXa.ValueMember = "MaXa";
            }
        }

        private void cmbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiaBan.SelectedValue != null)
            {
                string maXa = cmbXa.SelectedValue.ToString();
                this.chiTietApTableAdapter.FillByXa(muaHeXanhDataSet.ChiTietAp, maXa);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            vt = bdsVChiTiet.Position;
            gcCongViec.Enabled = gcCTAp.Enabled = true;
            bdsVChiTiet.AddNew();
            gcVCTCV.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnDelete.Enabled = false ;
            btnInsert.Enabled = btnEdit.Enabled = false;
            
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {
            bdsVChiTiet.CancelEdit();
            if (btnInsert.Enabled == false)
            {
                bdsVChiTiet.Position = vt;
            }
            gcCongViec.Enabled = gcCTAp.Enabled = true;
            btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCongViec.Text.Trim() == "")
            {
                MessageBox.Show("Công việc không thể để trống!", "", MessageBoxButtons.OK);
                txtCongViec.Focus();
                return;
            }

            if (txtTenAp.Text.Trim() == "")
            {
                MessageBox.Show("Ấp không thể để trống!", "", MessageBoxButtons.OK);
                txtTenAp.Focus();
                return;
            }

            if (dNgayBD.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không thể để trống!", "", MessageBoxButtons.OK);
                dNgayBD.Focus();
                return;
            }

            if (dNgayKT.Text.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc không thể để trống!", "", MessageBoxButtons.OK);
                dNgayKT.Focus();
                return;
            }
            string dateString1 = dNgayBD.Text;
            string dateString2 = dNgayKT.Text;

            DateTime date1 = DateTime.ParseExact(dateString1, "yyyy/MM/dd", null);
            DateTime date2 = DateTime.ParseExact(dateString2, "yyyy/MM/dd", null);
            if (date1 > date2)
            {
                MessageBox.Show("Ngày bắt đầu không được sau ngày kết thúc!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string maAp = ((DataRowView)bdsChiTietAp[bdsChiTietAp.Position])["MaAp"].ToString();
                string maCV = ((DataRowView)bdsCongViec[bdsCongViec.Position])["MaCongViec"].ToString();
                string sqlLenh = "EXEC INSERTCTCV '" + maCV + "', '" + maAp + "', '"
                    + dNgayBD.Text + "', '" + dNgayKT.Text + "'";
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

            gcCongViec.Enabled = gcCTAp.Enabled = true;
            gcVCTCV.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            btnDelete.Enabled = true;
            btnInsert.Enabled = btnEdit.Enabled = true;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            String maCV = "";
            maCV = ((DataRowView)bdsVChiTiet[bdsVChiTiet.Position])["IDChiTietCV"].ToString();
            /*   if (Program.CheckValueExists(Program.connstr, "ThucHienCongViec", "IDChiTietCV", maCV))
               {
                   MessageBox.Show("Không thể xóa công việc đã thực hiện trong chiến dịch!", "", MessageBoxButtons.OK);
                   return;
               }
   */

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maCV = ((DataRowView)bdsVChiTiet[bdsVChiTiet.Position])["IDChiTietCV"].ToString();
                    string sqlLenh = "EXEC DelChiTietCV " + maCV;
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maCV = ((DataRowView)bdsVChiTiet[bdsVChiTiet.Position])["IDChiTietCV"].ToString();
            if (Program.CheckValueExists(Program.connstr, "ThucHienCongViec", "IDChiTietCV", maCV))
            {
                MessageBox.Show("Không thể sửa công việc đã thực hiện trong chiến dịch!", "", MessageBoxButtons.OK);
                return;
            }
            else
            {

                vt = bdsVChiTiet.Position;
                gcCongViec.Enabled = gcCTAp.Enabled = true;
                btnSave.Enabled = btnUndo.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Enabled = btnEdit.Enabled = false;
            }
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.apTableAdapter.Fill(this.muaHeXanhDataSet.Ap);

                this.congViecTableAdapter.Fill(this.muaHeXanhDataSet.CongViec);
                this.vChiTietCVTableAdapter.Fill(this.muaHeXanhDataSet.VChiTietCV);
                this.chiTietApTableAdapter.Fill(this.muaHeXanhDataSet.ChiTietAp);
                this.thucHienCongViecTableAdapter.Fill(this.muaHeXanhDataSet.ThucHienCongViec);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcVCTCV.Enabled == false)
            {
                txtCongViec.Text = ((DataRowView)bdsCongViec[bdsCongViec.Position])["TenCongViec"].ToString();
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcVCTCV.Enabled == false)
            {
                txtTenAp.Text = ((DataRowView)bdsChiTietAp[bdsChiTietAp.Position])["TenAp"].ToString();
            }
        }
    }
}
