using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TN_CSDLPT
{
    public partial class FormSV : DevExpress.XtraEditors.XtraForm
    {
        private int index = 0;
        private string maLop = "";
        private string tenLop = "";
        private int vitri;
        private DataTable dt = new DataTable();
        private PhucHoi phucHoi = new PhucHoi();
        private Boolean isDangThem = false, isDangSua = false, suaLop = false;
        public FormSV()
        {
            InitializeComponent();
        }
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connStr;
            this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            dt = Program.execSqlDataTable("SELECT MALOP, TENLOP FROM LOP");
            cmbMaLop.DataSource = dt;
            cmbMaLop.DisplayMember = "TENLOP";
            cmbMaLop.ValueMember = "MALOP";
            cmbMaLop.SelectedIndex = 0;

            maLop = cmbMaLop.SelectedValue.ToString().Trim();
            this.bdsSV.Filter = "MALOP = '" + maLop + "'";

            cmbCoSo.DataSource = Program.bdsDSPM;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;
            if (Program.mNhom == "TRUONG")
                cmbCoSo.Enabled = true;
            else
                cmbCoSo.Enabled = false;
           groupControl2.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            if (Program.mNhom == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            else if (Program.mNhom == "TRUONG" || Program.mNhom == "GIANGVIEN")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            }
            if (bdsSV.Count == 0)
                btnXoa.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (Program.mNhom == "TRUONG" || Program.mNhom ==  "GIANGVIEN")
            {
                MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            isDangThem = true;
            vitri = bdsSV.Position;
            bdsSV.AddNew();
            txtMaSV.Focus();
            txtMaLop.Text = maLop;
            dtpNgaySinh.EditValue = "";

            txtMaSV.Enabled = true;
      //      groupControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = true;
            gcSinhVien.Enabled = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.ketNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                // TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed.
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connStr;
                this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

                dt = Program.execSqlDataTable("SELECT MALOP, TENLOP FROM LOP");
                cmbMaLop.DataSource = dt;
                cmbMaLop.DisplayMember = "TENLOP";
                cmbMaLop.ValueMember = "MALOP";
                cmbMaLop.SelectedIndex = 0;
                if (cmbMaLop.SelectedValue != null)
                {
                    maLop = cmbMaLop.SelectedValue.ToString().Trim();
                }

                this.bdsSV.Filter = "MALOP = '" + maLop + "'";


            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            groupControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcSinhVien.Enabled = true;
            isDangThem = isDangSua = false;
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedValue != null)
            {
                maLop = cmbMaLop.SelectedValue.ToString().Trim();
                tenLop = cmbMaLop.GetItemText(cmbMaLop.SelectedItem);
                index = cmbMaLop.SelectedIndex;
            }
            this.bdsSV.Filter = "MALOP = '" + maLop + "'";
            cmbMaLop.Text = tenLop;
            return;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (dtpNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày sinh không được trống!", "Lỗi", MessageBoxButtons.OK);
                dtpNgaySinh.Focus();
                return;
            }
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (!suaLop)
                txtMaLop.Text = maLop;
            try
            {
                string sql;
                int ketQua;
                if (isDangThem)
                {
                    sql = "exec [dbo].[SP_TRUNGMASV] '" + txtMaSV.Text + "'";
                    ketQua = Program.execNonQuery(sql);
                    //nếu như chạy sp ko thành công
                    if (ketQua == 1)
                    {
                        txtMaSV.Focus();
                        return;
                    }
                }

                if (isDangThem)
                {
                    phucHoi.PushStack_ThemSV(txtMaSV.Text);
                    isDangThem = false;
                }
                else if (isDangSua)
                {
                    phucHoi.PushStack_SuaSV(txtMaSV.Text);
                    isDangSua = false;
                }
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);

          //      groupControl2.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gcSinhVien.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 maSV = 0;
            if (Program.mNhom == "TRUONG" || Program.mNhom == "GIANGVIEN")
            {
                MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsSV.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK);
                btnXoa.Enabled = false;
            }
            else if (bdsBangDiem.Count != 0)
            {
                MessageBox.Show("Sinh viên đang có bảng điểm, không được xoá!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        phucHoi.PushStack_XoaSV(txtMaSV.Text, txtHo.Text, txtTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtPassWord.Text, maLop);
                        maSV = int.Parse(((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString());
                        bdsSV.RemoveCurrent();
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                        this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                        bdsSV.Position = bdsSV.Find("MASV", maSV);
                        return;
                    }
                }
            }
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable sinh viên
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                cmbMaLop.DataSource = dt;
                cmbMaLop.DisplayMember = "TENLOP";
                cmbMaLop.ValueMember = "MALOP";
                cmbMaLop.SelectedIndex = index;
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                btnPhucHoi.Enabled = false;
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            cmbMaLop.DataSource = dt;
            cmbMaLop.DisplayMember = "TENLOP";
            cmbMaLop.ValueMember = "MALOP";
            cmbMaLop.SelectedIndex = index;

        //    groupControl2.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gcSinhVien.Enabled = true;
            if (bdsSV.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (Program.mNhom == "TRUONG" || Program.mNhom ==  "GIANGVIEN")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = false;
                MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            isDangSua = true;
            suaLop = true;
            phucHoi.Save_OldSVs(txtHo.Text, txtTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtPassWord.Text, cmbMaLop.SelectedValue.ToString());
           
            txtMaSV.Enabled = false;
            txtMaLop.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = true;
            gcSinhVien.Enabled = true;
        }

       
    }
}
