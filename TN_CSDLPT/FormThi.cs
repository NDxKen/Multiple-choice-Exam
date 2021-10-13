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
using DevExpress.XtraEditors.Controls;

namespace TN_CSDLPT
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        public static String maMH = "";
        public static String maLop = "";
        public static String trinhDo = "";
        public static String ngayThi = "";
        public static String lan = "";
        public static int soCauThi = 0;       
        public static int thoiGian = 0;


        private static int second = 0;
        private static int minute = 0;
        private static double diemMoiCau = 0;
        private static double diemThi = 0;

        Dictionary<int, DeThi> dictionary = new Dictionary<int, DeThi>();
        BindingSource bdsDeThi;
        
        public FormThi()
        {
            InitializeComponent();            
        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            // set time
            minute = thoiGian - 1;
            second = 60;

            DataTable dt = new DataTable();
            String str = "EXEC SP_THI '" + trinhDo + "','" + maMH + "','" + soCauThi + "'" ;          
            try
            {
                dt = Program.execSqlDataTable(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải câu hỏi\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            bdsDeThi = new BindingSource();
            bdsDeThi.DataSource = dt;
            for (int i = 0; i < bdsDeThi.Count; i++)
            {
                rdbCauSo.Properties.Items.Add(new RadioGroupItem(i + 1, "" + (i + 1)));
                dictionary.Add(i + 1, getBoDeFromBDS(i));
            }
            diemMoiCau = 10.0 / soCauThi;
            timer.Start();
            btnThoat.Enabled = false;
            tabControlMain.TabPages.Remove(tabPageKetQua);
            rdbCauSo.SelectedIndex = 0;
        }

        private DeThi getBoDeFromBDS(int position)
        {
            DeThi d = new DeThi();
            d.A = ((DataRowView)bdsDeThi[position])["A"].ToString();
            d.B = ((DataRowView)bdsDeThi[position])["B"].ToString();
            d.C = ((DataRowView)bdsDeThi[position])["C"].ToString();
            d.D = ((DataRowView)bdsDeThi[position])["D"].ToString();
            d.CauHoi = ((DataRowView)bdsDeThi[position])["CAUHOI"].ToString();
            d.NoiDung = ((DataRowView)bdsDeThi[position])["NOIDUNG"].ToString();
            d.DapAn = ((DataRowView)bdsDeThi[position])["DAP_AN"].ToString();
            d.DaChon = "X";
            return d;
        }

        

        private void rdbCauSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbLuaChon.Properties.Items.Clear();
            lbCauHoi.Text = "Câu " + rdbCauSo.EditValue + ": " + dictionary[rdbCauSo.SelectedIndex + 1].NoiDung;
            rdbLuaChon.Properties.Items.Add(new RadioGroupItem("A", "A. " + dictionary[rdbCauSo.SelectedIndex + 1].A));
            rdbLuaChon.Properties.Items.Add(new RadioGroupItem("B", "B. " + dictionary[rdbCauSo.SelectedIndex + 1].B));
            rdbLuaChon.Properties.Items.Add(new RadioGroupItem("C", "C. " + dictionary[rdbCauSo.SelectedIndex + 1].C));
            rdbLuaChon.Properties.Items.Add(new RadioGroupItem("D", "D. " + dictionary[rdbCauSo.SelectedIndex + 1].D));
            if (dictionary[rdbCauSo.SelectedIndex + 1].DaChon == "X")
            {
                rdbLuaChon.SelectedIndex = -1;
            }
        }

        private void rdbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbLuaChon.SelectedIndex != -1)
            {
                dictionary[rdbCauSo.SelectedIndex + 1].DaChon = rdbLuaChon.EditValue.ToString();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second--;            
            if (second == 0 && minute != 0)
            {
                minute--;
                second = 59;
            }
            if(second == 0 && minute == 0)
            {
                timer.Stop();
                calculateScore();               
                lbDiemThi.Text = diemThi.ToString();
                saveIntoBangDiem();
                navButton();
            }
            showTime();
        }

        private void showTime()
        {
            if (minute < 10)
            {
                if (second < 10)
                {
                    lbTime.Text = "0" + minute + ":0" + second;
                } else
                {
                    lbTime.Text = "0" + minute + ":" + second;
                }
            }
            else
            {
                if(second < 10)
                {
                    lbTime.Text = minute + ":0" + second;
                } else
                {
                    lbTime.Text = minute + ":" + second;
                }
            }
        }

        private void calculateScore()
        {
            foreach(KeyValuePair<int, DeThi> item in dictionary)
            {
                if(item.Value.DaChon == item.Value.DapAn)
                {
                    diemThi += diemMoiCau;
                }
            }
            diemThi = Math.Round(diemThi, 2);
        }


        private void btnNopBai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(checkFullDapAn())
            {
                calculateScore();
                lbDiemThi.Text = diemThi.ToString();
                saveIntoBangDiem();
                navButton();
            } else
            {
                if(MessageBox.Show("Bạn chưa chọn hết đáp án, bạn chắc chắn muốn nộp bài không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    calculateScore();
                    lbDiemThi.Text = diemThi.ToString();
                    saveIntoBangDiem();
                    navButton();
                }
            }
        }

        private void navButton()
        {
            tabControlMain.TabPages.Add(tabPageKetQua);
            tabControlMain.TabPages.Remove(tabPageThi);
            btnThoat.Enabled = true;
            btnNopBai.Enabled = false;
            timer.Stop();
        }

        private Boolean checkFullDapAn()
        {
            foreach(KeyValuePair<int, DeThi> item in dictionary)
            {
                if(item.Value.DaChon.Equals("X")) {
                    return false;
                }
            }
            return true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formMainStudent.Visible = true;
            this.Close();
        }

        private void saveIntoBangDiem()
        {
            String str = "EXEC SP_INSERTBANGDIEM '" + Program.userName + "', '" + maMH + "', '" + lan + "', '" + ngayThi + "', '" + diemThi + "'";
            if (Program.execNonQuery(str) != 0) return;

            str = "EXEC SP_GETBAITHIFROMBANGDIEM '" + Program.userName + "', '" + maMH + "', '" + lan + "'";
            Program.myReader = Program.execSqlDataReader(str);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String baiThi = Program.myReader.GetInt32(0).ToString();
            Program.myReader.Close();           
            foreach(KeyValuePair<int, DeThi> item in dictionary)
            {
                 str = "EXEC SP_INSERTCTBAITHI '" + baiThi + "', '" + item.Value.CauHoi + "', '" + item.Key + "', '" + item.Value.DaChon + "'";
                try
                {
                    Program.execNonQuery(str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào bảng CT_BAITHI \n" + ex.Message);
                    return;
                }
            }
        }
    }

   
}