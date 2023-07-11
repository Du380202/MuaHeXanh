using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    
    public partial class frmKhenThuong : Form
    {
        int vitri = 0;
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muaHeXanhDataSet);

        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
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

            // TODO: This line of code loads data into the 'muaHeXanhDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.FillByNotnull(this.muaHeXanhDataSet.SinhVien);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.ThanhTich' table. You can move, or remove it, as needed.
            this.thanhTichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thanhTichTableAdapter.Fill(this.muaHeXanhDataSet.ThanhTich);
            // TODO: This line of code loads data into the 'muaHeXanhDataSet.KhenThuong' table. You can move, or remove it, as needed.
            this.khenThuongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khenThuongTableAdapter.Fill(this.muaHeXanhDataSet.KhenThuong);

            
            if (Program.role == "QUANTRI")
            {
                btnInsert.Enabled =  btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
                btnSave.Enabled = btnUndo.Enabled = false;
                pnInput.Enabled = false;
            }


        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcKT.Enabled == false)
            {
                txtMaSV.Text = ((DataRowView)bdsSV[bdsSV.Position])["MaSinhVien"].ToString();
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gcKT.Enabled == false)
            {
                txtTT.Text = ((DataRowView)bdsThanhTich[bdsThanhTich.Position])["MaThanhTich"].ToString();
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == DBNull.Value)
            {
                try
                {
                    sinhVienTableAdapter.Fill(this.muaHeXanhDataSet.SinhVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                string maKhoa = cmbKhoa.SelectedValue.ToString();
                sinhVienTableAdapter.FillByMaKhoa(muaHeXanhDataSet.SinhVien, maKhoa);
            }
            btnSave.Enabled = btnUndo.Enabled = false;
            pnInput.Enabled = false;

        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            vitri = bdsKhenThuong.Position;
            gcSV.Enabled = gcTT.Enabled = true;
            gcKT.Enabled = false;
            pnInput.Enabled = true;
            bdsKhenThuong.AddNew();
            btnSave.Enabled = btnUndo.Enabled = true;
            btnDelete.Enabled = false;
            btnInsert.Enabled = btnEdit.Enabled = btnReload.Enabled = false;
            txtMaSV.Enabled = true;
            edNgayKT.Enabled = false;
            edNgayKT.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bdsKhenThuong.CancelEdit();
            if (btnInsert.Enabled == false)
            {
                bdsKhenThuong.Position = vitri;
            }
            gcSV.Enabled = gcTT.Enabled = true;
            gcKT.Enabled = true;
            btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled= true;
            btnUndo.Enabled = btnSave.Enabled = false;
            pnInput.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtTT.Text.Trim() == "")
            {

                MessageBox.Show("Thiếu mã thành tích");
                txtTT.Text = "";
                txtTT.Focus();
                return;
            }
            if (txtMaSV.Text.Trim() == "")
            {

                MessageBox.Show("Thiếu mã sinh viên cần khen thưởng");
                txtMaSV.Text = "";
                txtMaSV.Focus();
                return;
            }
            //string maTT = ((DataRowView)bdsThanhTich[bdsThanhTich.Position])["MaThanhTich"].ToString();
            //string maSV = ((DataRowView)bdsSV[bdsSV.Position])["MaSinhVien"].ToString();
            if (Program.ExecSqlCheck("usp_KIEMTRAKHENTHUONG", txtTT.Text.Trim(), txtMaSV.Text.Trim()) == 1)
            {
                MessageBox.Show("Đã khen thưởng sinh viên với thành tích này");
                return;
            }

            try
            {
                bdsKhenThuong.EndEdit();
                bdsKhenThuong.ResetCurrentItem();
               
                this.khenThuongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khenThuongTableAdapter.Update(this.muaHeXanhDataSet.KhenThuong);
                MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK);
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                
                return;
            }
            txtMaSV.Enabled = true;
            gcSV.Enabled = gcTT.Enabled = true;
            gcKT.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            btnDelete.Enabled = true;
            btnInsert.Enabled = btnEdit.Enabled = btnReload.Enabled = true;
            pnInput.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            vitri = bdsKhenThuong.Position;
            btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
            txtMaSV.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcSV.Enabled = gcTT.Enabled = true;
            gcKT.Enabled= false;
            pnInput.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.khenThuongTableAdapter.Fill(this.muaHeXanhDataSet.KhenThuong);
                this.gcKT.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            pnInput.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String iDKT = "";
            
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    iDKT = ((DataRowView)bdsKhenThuong[bdsKhenThuong.Position])["IDKhenThuong"].ToString();
                    string sqlLenh = "exec XoaKhenThuong '" + iDKT + "'";
                    int check = Program.ExecSqlNonQuery(sqlLenh);
                    this.khenThuongTableAdapter.Fill(this.muaHeXanhDataSet.KhenThuong);
                    if (check != 0)
                    {
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa thành tích. \nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                    this.khenThuongTableAdapter.Fill(muaHeXanhDataSet.KhenThuong);
                    bdsKhenThuong.Position = bdsKhenThuong.Find("IDKhenThuong", iDKT);
                    return;
                }
            }
            if (bdsKhenThuong.Count == 0) btnDelete.Enabled = false;
            pnInput.Enabled = false;
        }
    }

}
