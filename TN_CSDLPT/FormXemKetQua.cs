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
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT
{
    public partial class FormXemKetQua : DevExpress.XtraEditors.XtraForm
    {
        private String maSV = "", maMH = "";
        private int lanThi = 0;
        public FormXemKetQua()
        {
            InitializeComponent();
        }

        private void FrptXemKetQua_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connStr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            gcLop.Hide();
            gcSinhVien.Hide();
            gcMonHoc.Hide();
            cbLanThi.SelectedIndex = 0;

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TEN_COSO";
            cbCoSo.ValueMember = "TEN_SERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mNhom == "COSO")
                cbCoSo.Enabled = false;
        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if(cbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            } else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            Program.serverName = cbCoSo.SelectedValue.ToString();
            if (Program.ketNoi() == 0) return;
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connStr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            txtHoTen.Text = "";
            txtMonThi.Text = "";
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            gcLop.Show();
            gcSinhVien.Hide();
            gcMonHoc.Hide();
            gcLop.Dock = DockStyle.Fill;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            gcLop.Hide();
            gcSinhVien.Show();
            gcMonHoc.Hide();
            gcSinhVien.Dock = DockStyle.Fill;
        }

        private void btnMonThi_Click(object sender, EventArgs e)
        {
            gcLop.Hide();
            gcSinhVien.Hide();
            gcMonHoc.Show();
            gcMonHoc.Dock = DockStyle.Fill;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên", "thông báo", MessageBoxButtons.OK);
                return;
            } else if (txtMonThi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn thi", "thông báo", MessageBoxButtons.OK);
                return;
            }
            maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
            lanThi = Int32.Parse(cbLanThi.SelectedItem.ToString());
            if (Program.execNonQuery("EXEC SP_CHECKXEMKETQUANULL '" + maSV + "','" + maMH + "','" + lanThi + "'") == 1) return;

            rpt_XemKetQua rpt = new rpt_XemKetQua(maSV, maMH, lanThi);
            rpt.lbHoTen.Text= txtHoTen.Text;
            rpt.lbMonThi.Text = txtMonThi.Text;
            rpt.lbLanThi.Text = lanThi.ToString();
            String strNgayThi = "EXEC SP_GETNGAYTHI '" + maSV + "','" + maMH + "','" + lanThi + "'";
            Program.myReader = Program.execSqlDataReader(strNgayThi);
            Program.myReader.Read();
            rpt.lbNgayThi.Text = Program.myReader.GetString(0).ToString();
            Program.myReader.Close();
            String strGETLOPFROMSINHVIEN = "EXEC SP_GETLOPFROMSINHVIEN '" + maSV + "'";
            Program.myReader = Program.execSqlDataReader(strGETLOPFROMSINHVIEN);
            Program.myReader.Read();
            rpt.lbLop.Text = Program.myReader.GetString(0).ToString().Trim();
            Program.myReader.Close();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void gcSinhVien_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = gvSinhVien.GetRowCellValue(gvSinhVien.FocusedRowHandle, "HO").ToString() + " " + gvSinhVien.GetRowCellValue(gvSinhVien.FocusedRowHandle, "TEN").ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcMonHoc_Click(object sender, EventArgs e)
        {
            txtMonThi.Text = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "TENMH").ToString();
        }
    }
}