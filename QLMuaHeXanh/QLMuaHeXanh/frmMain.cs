using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLMuaHeXanh.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaHeXanh
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmLogin));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmLogin form = new frmLogin();
                form.MdiParent = this;
                form.Show();
            }
        }
        public void HienThiMenu()
        {
            btnLogin.Enabled = false;
            btnDangXuat.Enabled = true;
            btnTaoTK.Enabled = false;
            pageSaoLuu.Visible = false;
            
            if (Program.role == "QUANTRI" || Program.role == "KHOA")
            {
                pageQuanLy.Visible = true;
                pagePhanCong.Visible = true;
                pageBaoCao.Visible = true;
                btnTaoTK.Enabled = true;
                btnChiTietCV.Enabled = true;
                pageXemLich.Visible = false;
                if (Program.role == "QUANTRI")
                {
                    pageSaoLuu.Visible = true;
                    pageXemLich.Visible = false;
                }
            }
            if (Program.role == "GIAMSAT")
            {
                pageQuanLy.Visible = false ;
                pagePhanCong.Visible = true;
                pageBaoCao.Visible = false;
                btnTaoTK.Enabled = false;
                pageXemLich.Visible = false;
                btnChiTietCV.Enabled  = btnKhenThuong.Enabled = false;
            }
            if (Program.role == "SINHVIEN")
            {
                pageXemLich.Visible = true;
            }

        }
        private void MaSV_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();

            btnLogin.Enabled = true;
            btnDangXuat.Enabled = false;
            btnTaoTK.Enabled=false;
            pageSaoLuu.Visible = false;
            pageQuanLy.Visible = false;
            pageBaoCao.Visible = pagePhanCong.Visible =false;
            Form f = this.CheckExists(typeof(frmLogin));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmLogin form = new frmLogin();
                form.MdiParent = this;
                form.Show();
            }

            Program.formMain.MaUser.Text = "Mã:";
            Program.formMain.HoTen.Text = "Họ Tên:";
            Program.formMain.Role.Text = "Quyền:";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pageQuanLy.Visible = pagePhanCong.Visible = pageBaoCao.Visible = pageSaoLuu.Visible = false;
            pageXemLich.Visible = false;
        }

        private void ribbonMain_Click(object sender, EventArgs e)
        {

        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmSinhVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmSinhVien form = new frmSinhVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmGiaoVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmGiaoVien form = new frmGiaoVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmTaoTK));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmTaoTK form = new frmTaoTK();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmKhuVuc));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmKhuVuc form = new frmKhuVuc();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnNhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmNhom));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmNhom form = new frmNhom();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmCongViec));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmCongViec form = new frmCongViec();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnBuoicv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhanCongBuoiCV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmPhanCongBuoiCV form = new frmPhanCongBuoiCV();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Khoa));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Khoa form = new Khoa();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnNhaDan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmNhaDan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmNhaDan form = new frmNhaDan();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnChiTietCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmChiTietCongViec));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmChiTietCongViec form = new frmChiTietCongViec();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmSaoLuu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmSaoLuu form = new frmSaoLuu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnThucHien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmThucHienCV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmThucHienCV form = new frmThucHienCV();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmRestore));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmRestore form = new frmRestore();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnQLXa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmQLXa));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmQLXa form = new frmQLXa();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmSinhVienReport));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmSinhVienReport form = new frmSinhVienReport();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnLich_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmLich));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmLich form = new frmLich();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnBCCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmCongViecReport));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmCongViecReport form = new frmCongViecReport();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKhenThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmKhenThuong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmKhenThuong form = new frmKhenThuong();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmThanhTich));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmThanhTich form = new frmThanhTich();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}