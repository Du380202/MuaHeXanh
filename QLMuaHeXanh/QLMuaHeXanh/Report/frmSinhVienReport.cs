using DevExpress.XtraReports.UI;
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

namespace QLMuaHeXanh.Report
{
    public partial class frmSinhVienReport : Form
    {
        public frmSinhVienReport()
        {
            InitializeComponent();
        }


        private void frmSinhVienReport_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DiaBan", Program.connectstrDB);
            da.Fill(dt);
            Program.bindingSource.DataSource = dt;
            cmbDiaBan.DataSource = Program.bindingSource;
            cmbDiaBan.DisplayMember = "TenDiaBan";
            cmbDiaBan.ValueMember = "MADiaBan";
            cmbDiaBan.Enabled = false;
        }

        private void rbtAllDiaBan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Ma = cmbDiaBan.SelectedValue.ToString();
                if (rbtDSKhoa.Checked)
                {

                    SinhVienReport rpt = new SinhVienReport();


                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }
                else if (rbtAllDiaBan.Checked)
                {
                    ThongKeSinhVienTatCaDiaBanReport rpt = new ThongKeSinhVienTatCaDiaBanReport();


                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }
                else
                {
                    ThongKeSVTungDiaBan rpt = new ThongKeSVTungDiaBan(Ma);
                    rpt.lbTitle.Text = "Danh Sách Sinh Viên Trên Địa Bàn " + cmbDiaBan.Text.ToString();

                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void rbtDiaBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDiaBan.Checked)
            {
                cmbDiaBan.Enabled = true;
            }
            else
            {
                cmbDiaBan.Enabled = false;
            }
        }
    }
}
