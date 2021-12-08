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
    public partial class FormChonLop : Form
    {
        public FormChonLop()
        {
            InitializeComponent();
        }

        private void LOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

        }
        private void gvLop_Click(object sender, EventArgs e)
        {
            FormLapLichThi.maLop = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString().Trim();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (FormLapLichThi.maLop == "")
            {
                MessageBox.Show("Chưa chọn lớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormLapLichThi.maLop = "";
            this.Close();
        }
    }
}
