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
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FormKhoa()
        {
            InitializeComponent();
        }


        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connStr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TEN_COSO";
            cbCoSo.ValueMember = "TEN_SERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;

            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbCoSo.SelectedValue == null) return;
            if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.serverName = cbCoSo.SelectedValue.ToString();
            if(cbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            } else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if(Program.ketNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở mới", "Thông báo", MessageBoxButtons.OK);
            } else
            {
                // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Connection.ConnectionString = Program.connStr;
                this.kHOATableAdapter.Fill(this.DS.KHOA);
                // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            }
        }

        private void btnThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}