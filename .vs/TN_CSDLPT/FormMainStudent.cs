using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FormMainStudent : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMainStudent()
        {
            InitializeComponent();
        }

        private Form checkExists(Type ftype)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.GetType() == ftype)
                {
                    return frm;
                }
            }
            return null;
        }

        private void btnThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = checkExists(typeof(FormChonMonThi));
            if(frm != null)
            {
                frm.Activate();
            } else
            {
                Form f = new FormChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}