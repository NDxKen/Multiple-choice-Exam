using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            if(Program.mNhom == "GIANGVIEN")
            {
                btnKhoaLop.Enabled = btnSinhVien.Enabled = btnMonHoc.Enabled = btnDSDK.Enabled
                    = btnBangDiem.Enabled = btnCreateAccount.Enabled = btnGV.Enabled = false;
            }
        }

        private Form checkExists(Type ftype)
        {
            foreach(Form f in this.MdiChildren) {
                if(f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

   

        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormGV));
            if (frm != null) frm.Activate();
            else
            {
                Form f = new FormGV();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.checkExists(typeof(FormSV));
            if (frm != null) frm.Activate();

            else
            {
                Form f = new FormSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FormKhoa f = new FormKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.checkExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();

            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnBoDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.checkExists(typeof(FormBoDe));
            if (frm != null) frm.Activate();

            else
            {
                FormBoDe f = new FormBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.userName = "";
                Program.mLogin = "";
                Program.password = "";
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.ShowInTaskbar)
                        frm.Close();
                }
                Program.formMain.Close();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLapLichThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormLapLichThi));
            if(frm != null)
            {
                frm.Activate();
            } else
            {
                FormLapLichThi f = new FormLapLichThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormXemKetQua));
            if(frm != null)
            {
                frm.Activate();
            } else
            {
                Form f = new FormXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Form f = new FormTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormChonMonThi));
            if (frm != null) frm.Activate();
            else
            {
                Form f = new FormChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }
      
        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = this.checkExists(typeof(FormXEMBANGDIEM));
            if (frm != null) frm.Activate();

            else
            {
                FormXEMBANGDIEM f = new FormXEMBANGDIEM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormDSDKTHI));
            if (frm != null) frm.Activate();

            else
            {
                FormDSDKTHI f = new FormDSDKTHI();
                f.MdiParent = this;
                f.Show();
            }
        }

        
    }
}
