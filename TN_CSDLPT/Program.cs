using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace TN_CSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connStr = "";
        public static String connstr_publisher = "Data Source=LAPTOP-1T0MKR0F;Initial Catalog=TN_CSDLPT;Integrated Security=true";
        public static SqlDataReader myReader;

        public static String serverName = "";
        public static String userName = "";
        public static String mLogin = "";
        public static String password = "";

        public static String database = "TN_CSDLPT";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "147258369";
        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mHoTen = "";
        public static String mNhom = "";
        public static String svMaLop = "";
        public static String svTenLop = "";
        public static int mCoSo = 0;

        public static BindingSource bdsDSPM = new BindingSource();
        public static FormMain formMain;
        public static FormChonMonThi fCMT;

        public static int ketNoi()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connStr = "Data Source=" + Program.serverName + ";Initial Catalog=" + Program.database +
                    ";User ID=" + Program.mLogin + ";password=" + Program.password ;
                Program.conn.ConnectionString = Program.connStr;
                Program.conn.Open();
                return 1;
            } catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\n Bạn cần xem lại userName và password\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader execSqlDataReader(String str)
        {
            SqlDataReader myReader;
            SqlCommand sqlCmd = new SqlCommand(str, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            if(Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myReader = sqlCmd.ExecuteReader();
                return myReader;
            }
            catch(Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable execSqlDataTable(String str)
        {
            DataTable dt = new DataTable();
            if(Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(str, Program.conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int execNonQuery(String str)
        {
            SqlCommand sqlCmd = new SqlCommand(str, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            if(Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                sqlCmd.ExecuteNonQuery();
                return 0;
            }catch(SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua (mã số thứ 3)
            }
        }

        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
