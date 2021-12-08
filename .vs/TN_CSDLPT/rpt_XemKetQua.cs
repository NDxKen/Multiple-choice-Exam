using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT
{
    public partial class rpt_XemKetQua : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_XemKetQua(String maSV, String maMH, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
