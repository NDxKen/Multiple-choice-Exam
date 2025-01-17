﻿using DevExpress.XtraEditors;
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
    public partial class FormGV : DevExpress.XtraEditors.XtraForm
    {
        Stack<String> myStack = new Stack<string>();
        private DataTable dt = new DataTable();
        private String maKH = "";
        private Boolean isAdding = false;
        private Boolean isEditting = false;
        public FormGV()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connStr;
            this.bODETableAdapter.Fill(this.DS.BODE);

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TEN_COSO";
            cbCoSo.ValueMember = "TEN_SERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;

            dt = Program.execSqlDataTable("EXEC SP_GETKHOA");
            cbKhoa.ValueMember = "MAKH";
            cbKhoa.DataSource = dt;
            cbKhoa.DisplayMember = "TENKH";
            cbKhoa.SelectedIndex = 0;

            maKH = cbKhoa.SelectedValue.ToString().Trim();
            this.bdsGV.Filter = "maKH = '" + maKH + "'";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = false;
            pcBottom.Enabled = false;

            if (Program.mNhom == "COSO")
            {
                cbCoSo.Enabled = false;
            }
            else if (Program.mNhom == "TRUONG" || Program.mNhom == "GIANGVIEN")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCoSo.SelectedValue == null) return;
            if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if (cbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            Program.serverName = cbCoSo.SelectedValue.ToString();
            if (Program.ketNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                // TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
                this.bODETableAdapter.Connection.ConnectionString = Program.connStr;
                this.bODETableAdapter.Fill(this.DS.BODE);


                dt = Program.execSqlDataTable("EXEC SP_GETKHOA");
                cbKhoa.DataSource = dt;
                cbKhoa.DisplayMember = "TENKH";
                cbKhoa.ValueMember = "MAKH";
                cbKhoa.SelectedIndex = 0;

                maKH = cbKhoa.SelectedValue.ToString().Trim();
                this.bdsGV.Filter = "MAKH ='" + maKH + "'";
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Data.DataRowView
            maKH = cbKhoa.SelectedValue.ToString().Trim();
            this.bdsGV.Filter = "MAKH ='" + maKH + "'";
        }

        private void setupButtonFirst()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gcGV.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pcBottom.Enabled = true;
        }

        private void setupButtonLast()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = gcGV.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            pcBottom.Enabled = false;
        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setupButtonFirst();
            isAdding = true;
            this.bdsGV.AddNew();
            txtMaKhoa.Text = maKH;
            txtMaGV.Focus();

            cbKhoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsGV.Count == 0)
            {
                MessageBox.Show("Không có giáo viên để sửa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            myStack.Push("EXEC SP_RESTORESUAGV '" + txtMaGV.Text.Trim() + "','" + txtHo.Text + "','" + txtTen.Text + "','" + txtHocVi.Text + "','" + txtMaKhoa.Text + "'");
            setupButtonFirst();
            isEditting = true;
            txtMaGV.Enabled = false;
            txtHo.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsGV.Count == 0)
            {
                MessageBox.Show("Không có giáo viên nào để xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (this.bdsGVDK.Count != 0)
            {
                MessageBox.Show("Giáo viên đã đăng ký lịch thi, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (this.bdsBoDe.Count != 0)
            {
                MessageBox.Show("Giáo viên có câu hỏi trong bộ đề, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String maGV = "";
                try
                {
                    maGV = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
                    myStack.Push("EXEC SP_RESTOREXOAGV '" + txtMaGV.Text.Trim() + "','" + txtHo.Text.Trim() + "','" + txtTen.Text.Trim() + "','" + txtHocVi.Text.Trim() + "','" + txtMaKhoa.Text.Trim() + "'");
                    this.bdsGV.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                    this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                    this.bdsGV.Position = this.bdsGV.Find("MAGV", maGV);
                    return;
                }
            }
            //if (this.bdsGV.Count == 0)
            //{
            //    btnXoa.Enabled = btnSua.Enabled = false;
            //}
            btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtHocVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Học vị không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtHocVi.Focus();
                return;
            }

            if (isAdding)
            {
                String strCheckTrungMaGV = "exec SP_CHECKTRUNGMAGV '" + txtMaGV.Text.Trim() + "'";
                if (Program.execNonQuery(strCheckTrungMaGV) == 1)
                {
                    txtMaGV.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        this.bdsGV.EndEdit();
                        this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                        myStack.Push("EXEC SP_RESTORETHEMGV '" + txtMaGV.Text + "'");
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi ghi giáo viên", "Thông Báo", MessageBoxButtons.OK);
                        this.bdsGV.CancelEdit();
                    }
                    isAdding = false;
                    cbKhoa.Enabled = true;
                }

            }
            else if (isEditting)
            {
                try
                {
                    this.bdsGV.EndEdit();
                    this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Lỗi ghi giáo viên", "Thông Báo", MessageBoxButtons.OK);
                    this.bdsGV.CancelEdit();
                }
                txtMaGV.Enabled = true;
                isEditting = false;
            }
            setupButtonLast();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                txtMaGV.Text = txtHo.Text = txtTen.Text = txtHocVi.Text = "";
                txtMaGV.Focus();
            }
            else if (isEditting)
            {
                txtHo.Text = txtTen.Text = txtHocVi.Text = "";
                txtHo.Focus();
            }
            else
            {
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsGV.CancelEdit();
            setupButtonLast();
            isAdding = isEditting = false;

            txtMaGV.Enabled = true;
            cbKhoa.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (myStack.Count == 0)
            {
                MessageBox.Show("Đã phục hồi hết các thao tác, không thể phục hồi thêm");
                return;
            }  
            String sql = myStack.Pop();
            if (Program.execNonQuery(sql) != 0) return;
            gIAOVIENTableAdapter.Fill(DS.GIAOVIEN);
            MessageBox.Show("Phục hồi thành công!");
        }
    }
    
}