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

        private void FormChonMonThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            if (Program.mNhom == "SINHVIEN")
                bdsGVDK.Filter = "NGAYTHI >= '" + getSqlDate(DateTime.Now) + "' AND NGAYTHI <'" + getSqlDate(DateTime.Now.AddDays(1)) + "'";
        }

        private String getSqlDate(DateTime date)
        {
            String year = "" + date.Year;
            String month = (date.Month < 10) ? "0" + date.Month : "" + date.Month;
            String day = (date.Day < 10) ? "0" + date.Day : "" + date.Day;
            return year + "-" + month + "-" + day + " 00:00:00";
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if (bdsGVDK.Count == 0)
            {
                MessageBox.Show("Không có lịch thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            FormThi.maMH = ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAMH"].ToString();
            FormThi.maLop = ((DataRowView)bdsGVDK[bdsGVDK.Position])["MALOP"].ToString();
            FormThi.trinhDo = gvGVDK.GetRowCellValue(gvGVDK.FocusedRowHandle, "TRINHDO").ToString();
            FormThi.ngayThi = ((DataRowView)bdsGVDK[bdsGVDK.Position])["NGAYTHI"].ToString();
            /*FormThi.ngayThi = getSqlDate(FormThi.ngayThi);*/
            FormThi.lan = ((DataRowView)bdsGVDK[bdsGVDK.Position])["LAN"].ToString();
            FormThi.soCauThi = Int32.Parse(gvGVDK.GetRowCellValue(gvGVDK.FocusedRowHandle, "SOCAUTHI").ToString());
            FormThi.thoiGian = Int32.Parse(((DataRowView)bdsGVDK[bdsGVDK.Position])["THOIGIAN"].ToString());
            if (Program.mNhom == "SINHVIEN")
            {
                String strCHECKDATHI = "EXEC SP_CHECKDATHI '" + Program.userName + "','" + FormThi.maMH + "','" + FormThi.lan + "'";
                if (Program.execNonQuery(strCHECKDATHI) != 0) return;
            }
            Form frm = new FormThi();
            frm.Activate();
            frm.Show();
            if(Program.mNhom != "SINHVIEN")
            {
                Program.formMain.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(Program.mNhom == "SINHVIEN")
            {
                Application.Exit();
            } else
            {
                this.Close();
            }
            
        }


    }
}