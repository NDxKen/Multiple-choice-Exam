using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT
{
    public partial class rptDSDKTHI1 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSDKTHI1(string ngay1, string ngay2)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngay1;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngay2;
            this.sqlDataSource1.Fill();
        }

    }
}
