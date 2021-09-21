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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        

        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.getSubcribers' table. You can move, or remove it, as needed.
            this.getSubcribersTableAdapter.Fill(this.dS_DSPM.getSubcribers);
            Program.serverName = cbCoSo.SelectedValue.ToString();
            //MessageBox.Show(cbCoSo.SelectedValue.ToString()); // server site
            //MessageBox.Show(cbCoSo.DisplayMember); //TEN_COSO
            //MessageBox.Show(cbCoSo.SelectedIndex.ToString()); // vị trí 0 - 1
            //MessageBox.Show(cbCoSo.ValueMember); // TEN_SERVER
            //MessageBox.Show(cbCoSo.DataSource.ToString());
        }

        private void cbTenCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbCoSo.SelectedValue != null)
            {
                Program.serverName = cbCoSo.SelectedValue.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            try 
            {
                if(rdbGV.Checked)
                {
                    Program.mLogin = txtLogin.Text;
                    Program.password = txtPassword.Text;
                    if (Program.ketNoi() == 0) return;
                    Program.bdsDSPM = bdsDSPM;
                    Program.mCoSo = cbCoSo.SelectedIndex;
                    Program.mLoginDN = Program.mLogin;
                    Program.passwordDN = Program.password;

                    String str = "exec SP_GetLoginInfomation '" + Program.mLogin + "'"; //SP Lấy thông tin đăng nhập
                    Program.myReader = Program.execSqlDataReader(str);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();

                    Program.userName = Program.myReader.GetString(0);
                    Program.mHoTen = Program.myReader.GetString(1);
                    Program.mNhom = Program.myReader.GetString(2);
                    if(Convert.IsDBNull(Program.userName))
                    {
                        MessageBox.Show("userName bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại userName, password", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    Program.formMain = new FormMain();

                    Program.formMain.MAGV.Text = "Mã GV: " + Program.userName;
                    Program.formMain.HOTEN.Text = "Họ tên: " + Program.mHoTen;
                    Program.formMain.NHOM.Text = "Nhóm: " + Program.mNhom;

                    this.Hide();
                    Program.formMain.Activate();
                    Program.formMain.Show();
                    Program.myReader.Close();
                    Program.conn.Close();
                }
                if(rdbSV.Checked)
                {
                    Program.mLogin = "SV";
                    Program.password = "147258369";
                    if (Program.ketNoi() == 0) return;
                    Program.bdsDSPM = bdsDSPM;
                    Program.mCoSo = cbCoSo.SelectedIndex;
                    Program.mLoginDN = Program.mLogin;
                    Program.passwordDN = Program.password;

                    String str = "exec SP_GetLoginInfomation '" + Program.mLogin + "'";
                    Program.myReader = Program.execSqlDataReader(str);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();                   
                    Program.mNhom = Program.myReader.GetString(2);
                    Program.myReader.Close();

                    //check tài khoản user,pass
                    String strCheckAccount = "exec SP_CheckAccountStudent '" + txtLogin.Text.Trim() + "','" + txtPassword.Text.Trim() + "'";
                    if(Program.execNonQuery(strCheckAccount) == 1)
                    {
                        return;
                    }

                    String strTimSV = "exec SP_FindStudent '" + txtLogin.Text.Trim() + "'"; //SP Tìm SV dựa vào mã
                    Program.myReader = Program.execSqlDataReader(strTimSV);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();

                    Program.userName = Program.myReader.GetString(0);
                    Program.mHoTen = Program.myReader.GetString(1) + " " + Program.myReader.GetString(2);
                    Program.svMaLop = Program.myReader.GetString(5);
                    Program.svTenLop = Program.myReader.GetString(6);

                    if (Convert.IsDBNull(Program.userName))
                    {
                        MessageBox.Show("userName bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại userName, password", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    Program.formMainStudent = new FormMainStudent();
                    Program.formMainStudent.MASV.Text = "Mã SV: " + Program.userName;
                    Program.formMainStudent.HOTEN.Text = "Họ tên: " + Program.mHoTen;
                    Program.formMainStudent.NHOM.Text = "Nhóm: " + Program.mNhom;
                    Program.formMainStudent.TENLOP.Text = "Lớp: " + Program.svTenLop;
                    
                    this.Hide();
                    Program.formMainStudent.Activate();
                    Program.formMainStudent.Show();
                    Program.conn.Close();
                    Program.myReader.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}