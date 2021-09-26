using DevExpress.XtraEditors;
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
    public partial class FormChonMonThi : DevExpress.XtraEditors.XtraForm
    {
        public FormChonMonThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonMonThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

        }

        private Form checkExists(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            //Form frm = checkExists(typeof(FormThi));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    Form f = new FormThi();
            //    f = this.MdiParent;
            //    f.Show();
            //}

            Form frm = new FormThi();
            frm.Activate();
            frm.Show();
            Program.formMainStudent.Visible = false;

        }
    }
}