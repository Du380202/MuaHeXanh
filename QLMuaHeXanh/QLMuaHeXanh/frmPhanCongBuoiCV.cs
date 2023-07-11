using DevExpress.CodeParser;
using QLMuaHeXanh.MuaHeXanhDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    public partial class frmPhanCongBuoiCV : Form
    {
        int viTri = 0;
        public frmPhanCongBuoiCV()
        {
            InitializeComponent();
        }

        private void PhanCongBuoiCV_Load(object sender, EventArgs e)
        {
            muaHeXanhDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.VIEW_PHANCONG' table. You can move, or remove it, as needed.
            this.vIEW_PHANCONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vIEW_PHANCONGTableAdapter.Fill(this.muaHeXanhDataSet.VIEW_PHANCONG);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.NHOMKHOA' table. You can move, or remove it, as needed.
            this.nHOMKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHOMKHOATableAdapter.Fill(this.muaHeXanhDataSet.NHOMKHOA);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.PhanCong' table. You can move, or remove it, as needed.
            this.phanCongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phanCongTableAdapter.Fill(this.muaHeXanhDataSet.PhanCong);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomTableAdapter.Fill(this.muaHeXanhDataSet.Nhom);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.BuoiCV' table. You can move, or remove it, as needed.
            this.buoiCVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.buoiCVTableAdapter.Fill(this.muaHeXanhDataSet.BuoiCV);
   
            BindingSource bindingSourceBuoi = new BindingSource();
            DataTable dtBuoi = new DataTable();

            SqlDataAdapter daBuoi = new SqlDataAdapter("SELECT * FROM BUOICV", Program.connectstrDB);
            daBuoi.Fill(dtBuoi);
            bindingSourceBuoi.DataSource = dtBuoi;
            cmbBuoi.DataSource = bindingSourceBuoi;
            cmbBuoi.DisplayMember = "TenBuoi";
            cmbBuoi.ValueMember = "MaBuoi";

            BindingSource bindingSourceKhoa = new BindingSource();
            DataTable dtKhoa = new DataTable();

            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT * FROM KHOA", Program.connectstrDB);
            daKhoa.Fill(dtKhoa);
            bindingSourceKhoa.DataSource = dtKhoa;
            cmbKhoa.DataSource = bindingSourceKhoa;
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MAKHOA";

            if (Program.role == "QUANTRI")
            {
                btnDelete.Enabled = btnInsert.Enabled = btnSave.Enabled = btnReload.Enabled = btnUndo.Enabled = false;
                panelNhapXuat.Enabled = false;
                gcNhomKhoa.Enabled = vIEW_PHANCONGGridControl.Enabled =  true;
                cmbKhoa.Enabled = true;
                this.nHOMKHOATableAdapter.Fill(this.muaHeXanhDataSet.NHOMKHOA);
            }
            if (Program.role == "GIAMSAT")
            {
                cmbKhoa.Enabled = false;
            }
            if (Program.role =="KHOA")
            {
                this.nHOMKHOATableAdapter.Fill(this.muaHeXanhDataSet.NHOMKHOA);
                cmbKhoa.Enabled = true;
            }
            btnSave.Enabled = btnUndo.Enabled =panelNhapXuat.Enabled =false;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.role == "GIAMSAT")
            {
                this.nHOMKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.nHOMKHOATableAdapter.FillByKhoa(this.muaHeXanhDataSet.NHOMKHOA, Program.MaKhoa);
                this.vIEW_PHANCONGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vIEW_PHANCONGTableAdapter.FillByMaKhoa(this.muaHeXanhDataSet.VIEW_PHANCONG, Program.MaKhoa);
            }
            else
            {
                if (cmbKhoa.SelectedIndex >= 0)
                {
                    string maKhoa = cmbKhoa.SelectedValue.ToString();
                    this.nHOMKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHOMKHOATableAdapter.FillByKhoa(this.muaHeXanhDataSet.NHOMKHOA, maKhoa);
                    this.vIEW_PHANCONGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vIEW_PHANCONGTableAdapter.FillByMaKhoa(this.muaHeXanhDataSet.VIEW_PHANCONG, Program.MaKhoa);
                }
            }

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmbKhoa.Enabled = false;
            panelNhapXuat.Enabled  = true;
            gcNhomKhoa.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBuoi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn buổi làm việc!", "", MessageBoxButtons.OK);
                cmbBuoi.Focus();
                return;
            }

            try
            {
                string maNhom = ((DataRowView)bdsNhomKhoa[bdsNhomKhoa.Position])["MaNhom"].ToString();
                string sqlLenh = "EXEC SPPHANCONG '" + cmbBuoi.SelectedValue.ToString() + "', '" + maNhom + "', '" + txtGhiChu.Text + "'";
                int check = Program.ExecSqlNonQuery(sqlLenh);
                if (Program.role == "GIAMSAT")
                {
                    this.nHOMKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHOMKHOATableAdapter.FillByKhoa(this.muaHeXanhDataSet.NHOMKHOA, Program.MaKhoa);
                    this.vIEW_PHANCONGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vIEW_PHANCONGTableAdapter.FillByMaKhoa(this.muaHeXanhDataSet.VIEW_PHANCONG, Program.MaKhoa);
                }
                else
                {
                    if (cmbKhoa.SelectedIndex >= 0)
                    {
                        string maKhoa = cmbKhoa.SelectedValue.ToString();
                        this.nHOMKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nHOMKHOATableAdapter.FillByKhoa(this.muaHeXanhDataSet.NHOMKHOA, maKhoa);
                        this.vIEW_PHANCONGTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vIEW_PHANCONGTableAdapter.FillByMaKhoa(this.muaHeXanhDataSet.VIEW_PHANCONG, Program.MaKhoa);
                    }
                }
                if (check != 0)
                {
                    MessageBox.Show("Phân công thành công!", "", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhóm!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhomKhoa.Enabled = true;
            btnInsert.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maSV = "";
            String id = ((DataRowView)bdsVPhanCong[bdsVPhanCong.Position])["IDPhanCong"].ToString();
            if (Program.CheckValueExists(Program.connstr, "ThucHienCongViec", "IDPhanCong", id))
            {
                MessageBox.Show("Không thể xóa khi đã thực hiện công việc!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = ((DataRowView)bdsVPhanCong[bdsVPhanCong.Position])["IDPhanCong"].ToString();
                    string sqlLenh = "EXEC XoaPhanCong " + maSV;
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.vIEW_PHANCONGTableAdapter.Fill(this.muaHeXanhDataSet.VIEW_PHANCONG);
                    if (check != 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            
            gcNhomKhoa.Enabled = true;
            panelNhapXuat.Enabled = false;
            btnInsert.Enabled = btnDelete.Enabled = btnReload.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled =  false;
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.role == "GIAMSAT"){
                    this.vIEW_PHANCONGTableAdapter.FillByMaKhoa(this.muaHeXanhDataSet.VIEW_PHANCONG, Program.MaKhoa);
                    this.nHOMKHOATableAdapter.FillByKhoa(this.muaHeXanhDataSet.NHOMKHOA, Program.MaKhoa);
                    this.gcNhomKhoa.Enabled = true;
                }
                else
                {
                    this.vIEW_PHANCONGTableAdapter.Fill(this.muaHeXanhDataSet.VIEW_PHANCONG);
                    this.nHOMKHOATableAdapter.Fill(this.muaHeXanhDataSet.NHOMKHOA);
                    this.gcNhomKhoa.Enabled = true;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

     
    }
}
