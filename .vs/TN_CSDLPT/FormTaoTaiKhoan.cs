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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            if(Program.mNhom == "TRUONG")
            {
                cbRole.Items.Add("TRUONG");
            }else if(Program.mNhom == "COSO")
            {
                cbRole.Items.Add("COSO");
                cbRole.Items.Add("GIANGVIEN");
            }
            cbRole.SelectedIndex = 0;
            gcGV.Visible = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(txtLoginName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK);
                return;
            } else if(txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            } else if (txtUserName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn username", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            String sql = "EXEC SP_CREATETAIKHOAN '" + txtLoginName.Text + "','" + txtPassword.Text + "','" + txtUserName.Text + "','" + cbRole.Text + "'";
            if (Program.execNonQuery(sql) != 0) return;
            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
            gcGV.Visible = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            gcGV.Visible = true;
        }

        private void gcGV_Click(object sender, EventArgs e)
        {
            txtUserName.Text = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
        }
    }
}