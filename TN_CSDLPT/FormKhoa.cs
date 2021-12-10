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
        private BindingSource bdsCoSo = new BindingSource();
        private string maKH = "";
        private bool isThemKH = false;
        private bool isThemLop = false;
        private bool isDangThem = false;
        private bool isDangSua = false;
        private bool suaKH = false;
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
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
          
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connStr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.lOPTableAdapter.Fill(this.DS.LOP);


            DataTable dt = new DataTable();
            dt = Program.execSqlDataTable("SELECT MACS, TENCS FROM COSO");
            bdsCoSo.DataSource = dt;
            textMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();

            cmbCoSo.DataSource = Program.bdsDSPM;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            maKH = ((DataRowView)bdsKhoa[0])["MAKH"].ToString();
            this.bdsLop.Filter = "MAKH = '" + maKH + "'";

            if (Program.mNhom == "TRUONG")
                cmbCoSo.Enabled = true;
            else
                cmbCoSo.Enabled = false;
            if (Program.mNhom == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            else if (Program.mNhom == "TRUONG" || Program.mNhom == "GIANGVIEN")
            {
                subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            }

            gc2.Enabled = false;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            groupControl2.Enabled = false;
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

                // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
                this.KHOATableAdapter.Connection.ConnectionString = Program.connStr;
                this.KHOATableAdapter.Fill(this.DS.KHOA);
                // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
                this.lOPTableAdapter.Fill(this.DS.LOP);

                // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connStr;
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvKhoa.IsFocusedView)
            {
                String maKH = "";
                if (Program.mNhom == "TRUONG")
                {
                    MessageBox.Show("Bạn không được phép xóa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (bdsKhoa.Count == 0)
                {
                    MessageBox.Show("Không có khoa nào để xóa!\n", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else if (bdsGV.Count != 0)
                {
                    MessageBox.Show("Khoa đã có giáo viên, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else if (bdsLop.Count != 0)
                {
                    MessageBox.Show("Khoa đã có lớp, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maKH = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
                        bdsKhoa.RemoveCurrent();
                        this.KHOATableAdapter.Connection.ConnectionString = Program.connStr;
                        this.KHOATableAdapter.Update(this.DS.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.KHOATableAdapter.Fill(this.DS.KHOA);
                        bdsKhoa.Position = bdsKhoa.Find("MAKH", maKH);
                        return;
                    }
                }
            }
            else if (gvLop.IsFocusedView)
            {
                String maLop = "";
                if (Program.mNhom == "TRUONG" || Program.mNhom == "GIANGVIEN")
                {
                    MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (bdsLop.Count == 0)
                {
                    MessageBox.Show("Không có lớp nào để xóa!\n", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else if (bdsSV.Count != 0)
                {
                    MessageBox.Show("Lớp đã có sinh viên, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                else if (bdsGVDK.Count != 0)
                {
                    MessageBox.Show("Lớp đã được giáo viên đăng ký lịch thi, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                        bdsLop.RemoveCurrent();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
                        this.lOPTableAdapter.Update(this.DS.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa lớp. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.lOPTableAdapter.Fill(this.DS.LOP);
                        bdsLop.Position = bdsLop.Find("MALOP", maLop);
                        return;
                    }
                }

            }
            if (bdsLop.Count == 0 && bdsKhoa.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            bdsLop.CancelEdit();

            this.KHOATableAdapter.Connection.ConnectionString = Program.connStr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);

            //this.LOPTableAdapter.Connection.ConnectionString = Program.connStr;
            //this.LOPTableAdapter.Fill(this.DS.LOP);

            gc2.Enabled = false;
            subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;

            textMaKhoa.Enabled =  textTenKH.Enabled = textMaCS.Enabled = true;
            txtMaLop.Enabled = txtTenLopHoc.Enabled = textMaKhoaLop.Enabled = true;
            gcKhoa.Enabled = gcLop.Enabled = true;
            isThemKH = isThemLop = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (isThemKH)
            {
                if (textMaKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                    textMaKhoa.Focus();
                    return;
                }
                if ( textTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                     textTenKH.Focus();
                    return;
                }
                textMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();
                try
                {
                    string sql;
                    int ketQua;
                    if (isDangThem)
                    {
                        sql = "exec [dbo].[SP_TRUNGMAKHOA] '" + textMaKhoa.Text + "'";
                        ketQua = Program.execNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                            textMaKhoa.Focus();
                            return;
                        }

                        sql = "exec [dbo].[SP_TRUNGTENKHOA] '" +  textTenKH.Text + "'";
                        ketQua = Program.execNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                             textTenKH.Focus();
                            return;
                        }
                    }
                    //isDangSua = true
                    else if (isDangSua)
                    {
                        sql = "exec [dbo].[SP_TRUNGTENKHOA] '" +  textTenKH.Text + "'";
                        ketQua = Program.execNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                             textTenKH.Focus();
                            return;

                        }
                    }

                    bdsKhoa.EndEdit();
                    bdsKhoa.ResetCurrentItem();
                    this.KHOATableAdapter.Update(this.DS.KHOA);
                    isThemKH = isDangSua = isDangThem = false;

                    gc2.Enabled = false;
                    subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = false;

                    textMaKhoa.Enabled =  textTenKH.Enabled = textMaCS.Enabled = true;
                       txtMaLop.Enabled =  txtTenLopHoc.Enabled = textMaKhoaLop.Enabled = true;
                    gcKhoa.Enabled = gcLop.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khoa\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                }
            }
            else if (isThemLop)
            {
                if (txtMaLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                       txtMaLop.Focus();
                    return;
                }
                if ( txtTenLopHoc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                     txtTenLopHoc.Focus();
                    return;
                }
                if (textMaKhoaLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                    textMaKhoaLop.Focus();
                    return;
                }
                if (!suaKH)
                {
                    textMaKhoaLop.Text = gvKhoa.GetRowCellValue(gvKhoa.FocusedRowHandle, "MAKH").ToString().Trim();
                }
                try
                {
                    string sql;
                    int ketQua;
                    if (isDangThem)
                    {
                        sql = "exec [dbo].[SP_TRUNGMALOP] '" + txtMaLop.Text + "'";
                        ketQua = Program.execNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                           txtMaLop.Focus();
                            return;
                        }

                        sql = "exec [dbo].[SP_TRUNGTENLOP] '" +  txtTenLopHoc.Text + "'";
                        ketQua = Program.execNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                             txtTenLopHoc.Focus();
                            return;
                        }
                    }
                    //isDangSua = true
                    else if (isDangSua)
                    {
                        sql = "exec [dbo].[SP_TRUNGTENLOP] '" +  txtTenLopHoc.Text + "'";
                        ketQua = Program.execNonQuery(sql);
                        //nếu như chạy sp ko thành công
                        if (ketQua == 1)
                        {
                             txtTenLopHoc.Focus();
                            return;

                        }
                    }

                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Update(this.DS.LOP);
                    isThemLop = isDangSua = isDangThem = false;
                    suaKH = false;
                    gc2.Enabled = false;
                    subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = false;

                    textMaKhoa.Enabled =  textTenKH.Enabled = textMaCS.Enabled = true;
                    txtMaLop.Enabled =  txtTenLopHoc.Enabled = textMaKhoaLop.Enabled = true;
                    gcKhoa.Enabled = gcLop.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (Program.mNhom == "TRUONG" || Program.mNhom ==  "GIANGVIEN")
            {
                MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (gvKhoa.IsFocusedView)
            {
                if (gvKhoa.IsEmpty)
                {
                    MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                isThemKH = isDangSua = true;
                gc2.Enabled = true;
                textMaKhoa.Focus();

                textMaKhoa.Enabled = false;
                subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;

                txtMaLop.Enabled =  txtTenLopHoc.Enabled = textMaKhoaLop.Enabled = false;
                gcKhoa.Enabled = gcLop.Enabled = false;
            }
            else if (gvLop.IsFocusedView)
            {
                if (gvLop.IsEmpty)
                {
                    MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                isThemLop = isDangSua = true;
                gc2.Enabled = true;
                 txtTenLopHoc.Focus();
                suaKH = true;
                txtMaLop.Enabled = false;
                textMaKhoaLop.Enabled = true;
                subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;

                textMaKhoa.Enabled = textTenKH.Enabled = textMaCS.Enabled = false;
                gcKhoa.Enabled = gcLop.Enabled = false;
            }
            gc2.Enabled = true;
            subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gcKhoa.Enabled = gcLop.Enabled = false;
        }

        private void cmbMaCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gcKhoa_Click(object sender, EventArgs e)
        {

        }

        private void gvKhoa_Click(object sender, EventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            maKH = gvKhoa.GetRowCellValue(gvKhoa.FocusedRowHandle, "MAKH").ToString();
            this.bdsLop.Filter = "MAKH = '" + maKH + "'";
        }

        private void gvKhoa_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void btnAddKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (Program.mNhom == "TRUONG" || Program.mNhom ==  "GIANGVIEN")
            {
                MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            isThemKH = isDangThem = true;
            gc2.Enabled = true;
            bdsKhoa.AddNew();
            textMaKhoa.Focus();
            textMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();
            textMaKhoa.Enabled = true;
            subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;

            txtMaLop.Enabled =  txtTenLopHoc.Enabled = textMaKhoaLop.Enabled = false;
            gcKhoa.Enabled = gcLop.Enabled = false;

        }

        private void btnAddLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl2.Enabled = true;
            if (Program.mNhom == "TRUONG" || Program.mNhom ==  "GIANGVIEN")
            {
                MessageBox.Show("Bạn không có quyền này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            isThemLop = isDangThem = true;
            gc2.Enabled = true;
            bdsLop.AddNew();
            txtMaLop.Focus();

            textMaKhoaLop.Text = gvKhoa.GetRowCellValue(gvKhoa.FocusedRowHandle, "MAKH").ToString().Trim();
            txtMaLop.Enabled = true;
            subThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;

            textMaKhoa.Enabled =  textTenKH.Enabled = textMaCS.Enabled = false;
            gcKhoa.Enabled = gcLop.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connStr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
        }
    }
}
