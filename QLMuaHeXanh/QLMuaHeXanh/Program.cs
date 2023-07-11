using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr = "";
        public static String connectstrDB = "Data Source=DESKTOP-HVVRFMR;Initial Catalog=MuaHeXanh;Integrated Security=True";
        public static SqlDataReader myReader;
        public static frmMain formMain;
        public static frmLogin formLogin;
        public static BindingSource bindingSource = new BindingSource();
        public static BindingSource bindingSourcePhai = new BindingSource();
        public static String serverName="";
        public static String userName="";
        public static String MaKhoa = "";
        public static String MaNhom = "";
        public static String loginName = "";
        public static String loginPass="";
        public static String database= "MuaHeXanh";

        public static String currentLogin = "";
        public static String currentPassword = "";

        public static String hoTen = "";
        public static String role = "";


        public static int ketNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.loginName + ";password=" + Program.loginPass;
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static bool CheckValueExists(string connectionString, string tableName, string columnName, string valueToCheck)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @valueToCheck";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@valueToCheck", valueToCheck);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi\nChi tiết: " + ex.Message, "", MessageBoxButtons.OK);
                conn.Close();
                return 0;
            }
        }

    
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {
            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }

        //Mới (Thứ 7)
        public static int ExecSqlCheck(String tenSP, String a, string b)
        {
            String sql = $"DECLARE @return_value int EXEC @return_value = [dbo].[{tenSP}] @a, @b SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            sqlCommand.Parameters.AddWithValue("@b", b);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return -1;
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain main = new frmMain();
            Program.formMain = main;
            main.WindowState = FormWindowState.Maximized;
            Application.Run(main);
           
        }
    }
}
