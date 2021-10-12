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
        private String maLop = "", maSV = "", maMH = "";
        private int lanThi = 0;
        public FormXemKetQua()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

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
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            gcLop.Hide();
            gcSinhVien.Hide();
            gcMonHoc.Hide();
            cbLanThi.SelectedIndex = 0;
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            gcLop.Show();
            gcSinhVien.Hide();
            gcMonHoc.Hide();
            gcLop.Dock = DockStyle.Fill;
            maLop = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString();
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            if(maLop.CompareTo("") == 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp", "Thống báo", MessageBoxButtons.OK);
                return;
            }
            gcLop.Hide();
            gcSinhVien.Show();
            gcMonHoc.Hide();
            gcSinhVien.Dock = DockStyle.Fill;
            bdsSinhVien.Filter = "MALOP = '" + maLop + "'";
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
            maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            maSV = ((DataRowView)bdsSinhVien[bdsLop.Position])["MASV"].ToString();
            maMH = ((DataRowView)bdsMonHoc[bdsLop.Position])["MAMH"].ToString();
            lanThi = Int32.Parse(cbLanThi.SelectedItem.ToString());

            if (Program.execNonQuery("EXEC SP_CHECKXEMKETQUANULL '" + maSV + "','" + maMH + "','" + lanThi + "'") == 1) return;

            rpt_XemKetQua rpt = new rpt_XemKetQua(maSV, maMH, lanThi);
            rpt.lbLop.Text = txtLop.Text;
            rpt.lbHoTen.Text= txtHoTen.Text;
            rpt.lbMonThi.Text = txtMonThi.Text;
            rpt.lbLanThi.Text = lanThi.ToString();
            String strNgayThi = "EXEC SP_LAYNGAYTHI '" + maSV + "','" + maMH + "','" + lanThi + "'";
            Program.myReader = Program.execSqlDataReader(strNgayThi);
            Program.myReader.Read();
            rpt.lbNgayThi.Text = Program.myReader.GetString(0).ToString();
            Program.myReader.Close();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void gcLop_Click(object sender, EventArgs e)
        {
            txtLop.Text = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "TENLOP").ToString();
        }

        private void gcSinhVien_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = gvSinhVien.GetRowCellValue(gvSinhVien.FocusedRowHandle, "HO").ToString() + " " + gvSinhVien.GetRowCellValue(gvSinhVien.FocusedRowHandle, "TEN").ToString();
        }

        private void gcMonHoc_Click(object sender, EventArgs e)
        {
            txtMonThi.Text = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "TENMH").ToString();
        }
    }
}