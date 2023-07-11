using DevExpress.XtraGrid.Views.Grid;
using QLMuaHeXanh.MuaHeXanhDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    public partial class frmTaoTK : Form
    {

        int viTri = 0;
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void TaoTKGV_Load(object sender, EventArgs e)
        {
            muaHeXanhDataSet.EnforceConstraints = false;

            BindingSource bindingSourceKhoa = new BindingSource();
            DataTable dtKhoa = new DataTable();
            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT * FROM KHOA", Program.connectstrDB);
            daKhoa.Fill(dtKhoa);
            DataRow nullRow = dtKhoa.NewRow();
            nullRow["MaKhoa"] = DBNull.Value;
            nullRow["TenKhoa"] = "ALL";
            dtKhoa.Rows.InsertAt(nullRow, 0);
            bindingSourceKhoa.DataSource = dtKhoa;
            cmbKhoa.DataSource = bindingSourceKhoa;
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MAKHOA";
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.view_LayGiaoVienVaSinhVienKhongCoTK' table. You can move, or remove it, as needed.
            this.view_LayGiaoVienVaSinhVienKhongCoTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.view_LayGiaoVienVaSinhVienKhongCoTKTableAdapter.Fill(this.muaHeXanhDataSet.view_LayGiaoVienVaSinhVienKhongCoTK);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ROLES", Program.connectstrDB);
            da.Fill(dt);
            Program.bindingSource.DataSource = dt;
            cmbRole.DataSource = Program.bindingSource;
            cmbRole.DisplayMember = "name";
            cmbRole.ValueMember = "name";
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == DBNull.Value)
            {
                try
                {
                    view_LayGiaoVienVaSinhVienKhongCoTKTableAdapter.Fill(this.muaHeXanhDataSet.view_LayGiaoVienVaSinhVienKhongCoTK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                string maKhoa = cmbKhoa.SelectedValue.ToString();
                view_LayGiaoVienVaSinhVienKhongCoTKTableAdapter.FillByMaKhoa(muaHeXanhDataSet.view_LayGiaoVienVaSinhVienKhongCoTK, maKhoa);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            viTri = bdsKhongTK.Position;
            panelNhapXuat.Enabled = true;
            gcThongTin.Enabled = false;
            panelbtn.Enabled = false;
            btnSave.Enabled = true;
            cmbRole.Enabled = true;
            if (Program.role == "QUANTRI")
            {
                cmbRole.Enabled = false;
                cmbRole.Text = "QUANTRI";
            }
            txtLoginName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string loginName = txtLoginName.Text.Trim();
            if (string.IsNullOrEmpty(loginName))
            {
                MessageBox.Show("Tên đăng nhập hợp lệ");
                txtLoginName.Focus();
                return;
            }

            string pass = txtPass.Text.Trim();
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                txtPass.Focus();
                return;
            }
            string Ma = (((DataRowView)bdsKhongTK[bdsKhongTK.Position])["Ma"]).ToString();
            string role = cmbRole.SelectedValue.ToString();
            String cauTruyVan =
                    "EXEC SP_TAOLOGIN '" + txtLoginName.Text + "', '" + txtPass.Text + "', '"
                    + Ma + "', '" + role + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {


                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    Program.conn.Close();
                    return;
                }
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                bdsKhongTK.EndEdit();
                bdsKhongTK.ResetCurrentItem();
                this.view_LayGiaoVienVaSinhVienKhongCoTKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.view_LayGiaoVienVaSinhVienKhongCoTKTableAdapter.Fill(this.muaHeXanhDataSet.view_LayGiaoVienVaSinhVienKhongCoTK);
                MessageBox.Show("Đăng kí tài khoản thành công\n " ,"", MessageBoxButtons.OK);
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            panelbtn.Enabled = true;
            btnSave.Enabled = false;
            panelNhapXuat.Enabled = false;
            gcThongTin.Enabled = true;
            txtLoginName.Clear();
            txtPass.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panelbtn.Enabled = true;
            panelNhapXuat.Enabled = false;
            gcThongTin.Enabled = true;

        }
    }
}
