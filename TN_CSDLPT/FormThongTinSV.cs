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
    public partial class FormThongTinSV : Form
    {
        public FormThongTinSV()
        {
            InitializeComponent();
            lblMSV.Text = Program.userName;
            lblHo.Text = Program.mHoTen;
            lblNgaySinh.Text = Program.FormatDate(Program.svNgaySinh);
            lblDiaChi.Text = Program.svDiaChi;
            lblMaLop.Text = Program.svMaLop;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
