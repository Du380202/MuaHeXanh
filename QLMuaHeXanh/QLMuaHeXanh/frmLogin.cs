using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    public partial class frmLogin : Form
    {
        private SqlConnection connPublisher = new SqlConnection();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formMain.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            Program.loginName = txtTaiKhoan.Text;
            Program.loginPass = txtMatKhau.Text;
            if (Program.ketNoi() == 0) return;

            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPass;
            String strLenh = "Exec SPKiemTraDangNhap '" + Program.loginName + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.userName = Program.myReader.GetString(0);
            if(Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Login của bạn không có quyền truy cập");
            }
            Program.hoTen = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);
            Program.MaKhoa = Program.myReader.GetString(3);
            Program.myReader.Close();
            Program.conn.Close();
            Program.formMain.MaUser.Text = "Mã: " + Program.userName;
            Program.formMain.HoTen.Text = "Họ Tên: " + Program.hoTen;
            Program.formMain.Role.Text = "Quyền: " + Program.role;

            this.Visible = false;
            Program.formMain.HienThiMenu();

        }

        private int KetNoi_CSDLGoc()
        {

            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
            {
                connPublisher.Close();
            }
            try
            {
                connPublisher.ConnectionString = Program.connectstrDB;
                connPublisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu gốc.\nXem lại tên server và tên CSDL trong chuỗi kết nối");
                return 0;   
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
