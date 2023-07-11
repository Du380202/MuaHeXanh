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
    public partial class frmLich : Form
    {
        public frmLich()
        {
            InitializeComponent();
        }

        private void frmLich_Load(object sender, EventArgs e)
        {
            try
            {

                this.sp_CTCVNHOMTableAdapter.Fill(this.muaHeXanhDataSet.sp_CTCVNHOM, Program.userName);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


    }
}
