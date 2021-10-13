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
            //bdsGVDK.Filter = "NGAYTHI = '" + DateTime.Now.ToShortDateString() + "'";
            MessageBox.Show(DateTime.Now.ToShortDateString());
            MessageBox.Show(((DataRowView)bdsGVDK[0])["NGAYTHI"].ToString());
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
            if (bdsGVDK.Count == 0) return;
            FormThi.maMH = ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAMH"].ToString();
            FormThi.maLop = ((DataRowView)bdsGVDK[bdsGVDK.Position])["MALOP"].ToString();
            FormThi.trinhDo = gvGVDK.GetRowCellValue(gvGVDK.FocusedRowHandle, "TRINHDO").ToString();
            FormThi.ngayThi = ((DataRowView)bdsGVDK[bdsGVDK.Position])["NGAYTHI"].ToString();
            FormThi.lan = ((DataRowView)bdsGVDK[bdsGVDK.Position])["LAN"].ToString();
            FormThi.soCauThi = Int32.Parse(gvGVDK.GetRowCellValue(gvGVDK.FocusedRowHandle, "SOCAUTHI").ToString());
            FormThi.thoiGian = Int32.Parse(((DataRowView)bdsGVDK[bdsGVDK.Position])["THOIGIAN"].ToString());
            String strCHECKDATHI = "EXEC SP_CHECKDATHI '" + Program.userName + "','" + FormThi.maMH + "','" + FormThi.lan + "'";
            if (Program.execNonQuery(strCHECKDATHI) != 0) return;
            Form frm = new FormThi();
            frm.Activate();
            frm.Show();
            Program.formMainStudent.Visible = false;
        }
    }
}