using DevExpress.XtraReports.UI;
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
    public partial class FormDSDKTHI : Form
    {
        public FormDSDKTHI()
        {
            InitializeComponent();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            rptDSDKTHI1 rpt = new rptDSDKTHI1(dptNgay1.Text.Trim(), dptNgay2.Text.Trim());
            rpt.lblCoSo.Text = ((DataRowView)Program.bdsDSPM[Program.mCoSo])["TEN_COSO"].ToString();
            rpt.lblNgay.Text = "TỪ NGÀY " + Program.FormatDate(dptNgay1.Text.Trim()) + " ĐẾN NGÀY " + Program.FormatDate(dptNgay2.Text.Trim());

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
