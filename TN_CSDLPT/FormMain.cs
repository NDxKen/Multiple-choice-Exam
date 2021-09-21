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

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
