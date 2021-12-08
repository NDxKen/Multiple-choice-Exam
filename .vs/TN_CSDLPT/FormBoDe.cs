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
    public partial class FormBoDe : Form
    {
        PhucHoi phucHoi = new PhucHoi();
        private string maMonHoc = "";
        private string maCauHoi = "";
        Boolean isDangThem = false, isDangSua = false;
        public FormBoDe()
        {
            InitializeComponent();
        }

        private void BODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormBoDe_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.BODETableAdapter.Connection.ConnectionString = Program.connStr;
            this.BODETableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'DS.CT_BAITHI' table. You can move, or remove it, as needed.
            this.CT_BAITHITableAdapter.Connection.ConnectionString = Program.connStr;
           // this.CT_BAITHITableAdapter.Fill(this.DS.CT_BAITHI);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.

            cmb_TrinhDo.Items.Add("A");
            cmb_TrinhDo.Items.Add("B");
            cmb_TrinhDo.Items.Add("C");

            cmb_DapAn.Items.Add("A");
            cmb_DapAn.Items.Add("B");
            cmb_DapAn.Items.Add("C");
            cmb_DapAn.Items.Add("D");

            groupBox1.Enabled = false;

            if (Program.mNhom == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mNhom ==  "GIANGVIEN")
            {
                if (Program.userName != txtMaGV.Text)
                {
                    MessageBox.Show("Bạn không được hiệu chỉnh câu hỏi của người khác!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            if (bdsBoDe.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else if (bdsCTBT.Count != 0)
            {
                MessageBox.Show("Câu hỏi đã có trong chi tiết bài thi, không được xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else if (Program.mNhom ==  "GIANGVIEN")
            {
                if (Program.userName != txtMaGV.Text)
                {
                    MessageBox.Show("Bạn không được hiệu chỉnh câu hỏi của người khác!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            else
            {

                if (MessageBox.Show("Bạn có thật sự muốn xoá câu hỏi này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsBoDe.RemoveCurrent();
                        this.BODETableAdapter.Update(this.DS.BODE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thao tác xoá bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mNhom == "GIANGVIEN")
            {
                if (Program.userName != txtMaGV.Text)
                {
                    MessageBox.Show("Bạn không được hiệu chỉnh câu hỏi của người khác!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            isDangSua = true;

            txtMaGV.Text = txtMaGV.Text.Trim();
            txtMaMH.Text = txtMaMH.Text.Trim();
            txtNoiDung.Text = txtNoiDung.Text.Trim();
            txtA.Text = txtA.Text.Trim();
            txtB.Text = txtB.Text.Trim();
            txtC.Text = txtC.Text.Trim();
            txtD.Text = txtD.Text.Trim();

            txtCauHoi.Enabled = false;
            gcBoDe.Enabled = false;
            groupBox1.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled =  false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsBoDe.CancelEdit();
                if (isDangThem)
                {
                    bdsBoDe.RemoveCurrent();
                }
                isDangThem = isDangSua = false;
                gcBoDe.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled  = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác huỷ bị lỗi!\n" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaGV.Text = txtMaGV.Text.Trim();
            txtMaMH.Text = txtMaMH.Text.Trim();
            txtNoiDung.Text = txtNoiDung.Text.Trim();
            txtA.Text = txtA.Text.Trim();
            txtB.Text = txtB.Text.Trim();
            txtC.Text = txtC.Text.Trim();
            txtD.Text = txtD.Text.Trim();

            if (txtMaGV.Text.Equals(""))
            {
                MessageBox.Show("Mã giáo viên không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaMH.Text.Equals(""))
            {
                MessageBox.Show("Mã môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtNoiDung.Text.Equals(""))
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtA.Text.Equals(""))
            {
                MessageBox.Show("Nội dung câu A không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtB.Text.Equals(""))
            {
                MessageBox.Show("Nội dung câu B không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtC.Text.Equals(""))
            {
                MessageBox.Show("Nội dung câu C không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtD.Text.Equals(""))
            {
                MessageBox.Show("Nội dung câu D không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //nếu như tất cả đều ko rỗng
            try
            {
                string sql;
                int ketQua;
                sql = "exec [dbo].[SP_TONTAIMAMH] '" + txtMaMH.Text + "'";
                ketQua = Program.execNonQuery(sql);
                //nếu như chạy sp ko thành công
                if (ketQua == 1)
                {
                    txtMaMH.Focus();
                    return;
                }

                //nếu như tồn tại mã môn
                //nếu đang thêm thì tìm mã câu hỏi và thêm vào txtCauHoi trước khi kết thúc quá trình thêm
                if (isDangThem)
                {
                    string strLenh = "EXEC SP_TIMBODE";
                    Program.myReader = Program.execSqlDataReader(strLenh);
                    Program.myReader.Read();
                    txtCauHoi.Text = Program.myReader.GetInt32(0).ToString();
                    Program.myReader.Close();
                }

                isDangThem = isDangSua = false;
                bdsBoDe.EndEdit();
                bdsBoDe.ResetCurrentItem();
                //this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                this.BODETableAdapter.Update(this.DS.BODE);

                gcBoDe.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác lỗi!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);

            }
            MessageBox.Show("Thao tác thành công!", "Thông báo", MessageBoxButtons.OK);
        }

       

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                isDangThem = true;
                bdsBoDe.AddNew();

                gcBoDe.Enabled = false;
                groupBox1.Enabled = true;

                txtMaGV.Text = Program.userName;
                txtCauHoi.Enabled = txtMaGV.Enabled = false;
                cmb_TrinhDo.SelectedIndex = 1; cmb_TrinhDo.SelectedIndex = 0;
                cmb_DapAn.SelectedIndex = 1; cmb_DapAn.SelectedIndex = 0;
                txtNoiDung.Focus();

                btnGhi.Enabled = btnHuy.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled  = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm câu hỏi bộ đề! \n " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
