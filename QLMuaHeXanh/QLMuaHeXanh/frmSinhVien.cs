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
    public partial class frmSinhVien : Form
    {

        int viTri = 0;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
            muaHeXanhDataSet.EnforceConstraints = false;
            BindingSource bindingSourceKhoa = new BindingSource();
            DataTable dtKhoa = new DataTable();

            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT * FROM KHOA", Program.connectstrDB);
            daKhoa.Fill(dtKhoa);
            DataRow nullRow = dtKhoa.NewRow();
            nullRow["MaKhoa"] = DBNull.Value;
            nullRow["TenKhoa"] = "Tất Cả Sinh Viên";
            dtKhoa.Rows.InsertAt(nullRow, 0);
            bindingSourceKhoa.DataSource = dtKhoa;
            cmbKhoa.DataSource = bindingSourceKhoa;
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MAKHOA";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHOA", Program.connectstrDB);
            da.Fill(dt);
            Program.bindingSource.DataSource = dt;
            cmbMaKhoa.DataSource = Program.bindingSource;
            cmbMaKhoa.DisplayMember = "MAKHOA";
            cmbMaKhoa.ValueMember = "MAKHOA";
            /*BindingSource bindingSourcePhai = new BindingSource();*/
            DataTable dtPhai = new DataTable();
            SqlDataAdapter daPhai = new SqlDataAdapter("select * from GioiTinh ", Program.connectstrDB);
            daPhai.Fill(dtPhai);
            Program.bindingSourcePhai.DataSource = dtPhai;
            cmbPhai.DataSource = Program.bindingSourcePhai;
            cmbPhai.DisplayMember = "Phai";
            cmbPhai.ValueMember = "Phai";

            BindingSource bindingSourceDiaBan = new BindingSource();
            DataTable dtDB = new DataTable();
            SqlDataAdapter daDB = new SqlDataAdapter("select * from DiaBan", Program.connectstrDB);
            daDB.Fill(dtDB);
            bindingSourceDiaBan.DataSource = dtDB;
            cmbDiaBan.DataSource = bindingSourceDiaBan;
            cmbDiaBan.DisplayMember = "MADIABAN";
            cmbDiaBan.ValueMember = "MADIABAN";
            this.sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.FillByIndex(this.muaHeXanhDataSet.SinhVien);

            this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.muaHeXanhDataSet.Xa);

            this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomTableAdapter.Fill(this.muaHeXanhDataSet.Nhom);

            this.khenThuongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khenThuongTableAdapter.Fill(this.muaHeXanhDataSet.KhenThuong);
            panelNhapXuat.Enabled = false;
            

            

            if (Program.role == "QUANTRI")
            {
                btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = false;
                btnLamMoiSV.Enabled = btnPhucHoiSV.Enabled =btnGhiSV.Enabled = false;
                panelNhapXuat.Enabled = false;
                gcSinhVien.Enabled =  true;
                cmbKhoa.Enabled = true;
            }
            btnPhucHoiSV.Enabled = btnGhiSV.Enabled = false;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == DBNull.Value)
            {
                try
                {
                    sinhVienTableAdapter.FillByIndex(this.muaHeXanhDataSet.SinhVien);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                string maKhoa = cmbKhoa.SelectedValue.ToString();
                sinhVienTableAdapter.FillByMaKhoa(muaHeXanhDataSet.SinhVien, maKhoa);
            }
        }


        private void btnThemSV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.Enabled = false;
            viTri = bdsSinhVien.Position;
            panelNhapXuat.Enabled = cmbDiaBan.Enabled = cmbMaKhoa.Enabled = true;
            bdsSinhVien.AddNew();
            cmbMaKhoa.Text = cmbKhoa.SelectedValue.ToString();
            cmbMaKhoa.Enabled = false;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnLamMoiSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSinhVien.Enabled = false;
        }


        private void btnSuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.Enabled = false;
            viTri = bdsSinhVien.Position;
            panelNhapXuat.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnLamMoiSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            cmbMaKhoa.Enabled = cmbDiaBan.Enabled =  true;
            gcSinhVien.Enabled = false;
        }

        private void btnPhucHoiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.Enabled = true;
            bdsSinhVien.CancelEdit();
            if (btnThemSV.Enabled == false)
            {
                bdsSinhVien.Position = viTri;
            }
            gcSinhVien.Enabled = true;
            panelNhapXuat.Enabled = false;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnLamMoiSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
            
        }

        private void btnLamMoiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sinhVienTableAdapter.FillByIndex(this.muaHeXanhDataSet.SinhVien);
                this.gcSinhVien.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không thể để trống!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không thể để trống!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không thể để trống!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            if (cmbPhai.Text.Trim() == "")
            {
                MessageBox.Show("Chọn giới tính của sinh viên!", "", MessageBoxButtons.OK);
                cmbPhai.Focus();
                return;
            }

            try
            {
                // VALUES (@MaSinhVien, @Ho, @Ten, @Phai, @NgaySinh, @DiaChi, @SoDienThoai, @MaDiaBan, @MaNhom, @MaKhoa);
                string sqlLenh = "EXEC sp_InsertSinhVien '" + txtMaSV.Text + "', '" + txtHo.Text + "', '" 
                    + txtTen.Text + "', '" + cmbPhai.Text + "', '" + dNgaySinh.Text + "', '" + txtDiaChi.Text
                    + "', '" + txtSDT.Text + "', '" + cmbDiaBan.Text + "', '" + "NULL" + "', '" + cmbKhoa.Text + "'";
                int check = Program.ExecSqlNonQuery(sqlLenh);
                this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
                
                /*bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                this.sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sinhVienTableAdapter.Update(this.muaHeXanhDataSet.SinhVien);
                MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcSinhVien.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnLamMoiSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
            panelNhapXuat.Enabled = false;
            cmbKhoa.Enabled = true;
        }

        private void btnXoaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSV = "";
            /*if (bdsXA.Count > 0 || bdsNhom.Count > 0 || bdsKhenThuong.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên đã tham gia hoạt động trong chiến dịch!", "", MessageBoxButtons.OK);
                return;
            }*/
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MaSinhVien"].ToString();
                    string sqlLenh = "exec XoaSinhVien '" + maSV + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
                    if (check != 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sinhVienTableAdapter.Fill(muaHeXanhDataSet.SinhVien);
                    bdsSinhVien.Position = bdsSinhVien.Find("MaSinhVien", maSV);
                    return;
                }
            }
            if (bdsSinhVien.Count == 0) btnXoaSV.Enabled = false;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hoLabel_Click(object sender, EventArgs e)
        {

        }

        private void gcSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
