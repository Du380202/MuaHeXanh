using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLMuaHeXanh.Report
{
    public partial class ThongKeSVTungDiaBan : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeSVTungDiaBan()
        {
            InitializeComponent();
        }

        public ThongKeSVTungDiaBan(string madb)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = madb;
            this.sqlDataSource1.Fill();
            lbDB.Text = madb;

        }

    }
}
