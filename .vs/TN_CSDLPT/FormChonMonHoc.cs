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
    public partial class FormChonMonHoc : Form
    {
        public FormChonMonHoc()
        {
            InitializeComponent();
        }

        private void MONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connStr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

        }
        private void gvMonHoc_Click(object sender, EventArgs e)
        {
             FormLapLichThi.maMH = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "MAMH").ToString().Trim();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (FormLapLichThi.maMH == "")
            {
                MessageBox.Show("Chưa chọn môn học!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormLapLichThi.maMH = "";
            this.Close();
        }
    }
}
