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
    public partial class FormLapLichThi : DevExpress.XtraEditors.XtraForm
    {
        private Boolean isAdding = false;
        private Boolean isEditing = false;
        public FormLapLichThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormLapLichThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connStr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TEN_COSO";
            cbCoSo.ValueMember = "TEN_SERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;


            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled  = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            pcInput.Enabled = false;
            pcInfo.Visible = false;
            txtMaGV.ReadOnly = txtMaLop.ReadOnly = txtMaMH.ReadOnly = true;

            if (Program.mNhom == "COSO")
            {
                cbCoSo.Enabled = false;
            }
            else if (Program.mNhom == "TRUONG" || Program.mNhom == "GIANGVIEN")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
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
            Program.serverName = cbCoSo.SelectedValue.ToString();
            if (Program.ketNoi() == 0)
            {
                return;
            }
            else
            {
                // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.connStr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connStr;
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            }

        }

        private void setupButtonFirst()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gcGVDK.Enabled = false;
            pcInput.Enabled = true;
        }
        private void setupButtonLast()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcGVDK.Enabled = true;
            pcInput.Enabled = false;
        }

        private void btnMaMH_Click(object sender, EventArgs e)
        {
            pcInfo.Visible = true;
            gcMonHoc.Visible = true;
            gcLop.Visible = false;
            gcMonHoc.Dock = DockStyle.Fill;
        }

        private void btnMaLop_Click(object sender, EventArgs e)
        {
            pcInfo.Visible = true;
            gcLop.Visible = true;
            gcMonHoc.Visible = false;
            gcLop.Dock = DockStyle.Fill;
        }

        private void gcMonHoc_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "MAMH").ToString();
        }

        private void gcLop_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setupButtonFirst();
            bdsGVDK.AddNew();
            isAdding = true;
            txtMaGV.Text = Program.userName;
            dateNgayThi.DateTime = DateTime.Now;
            spinSoCauThi.Value = spinThoiGian.Value = 15;
            cbTrinhDo.SelectedIndex = cbLanThi.SelectedIndex = 1;
            cbTrinhDo.SelectedIndex = cbLanThi.SelectedIndex = 0;
            txtMaMH.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsGVDK.Count == 0)
            {
                MessageBox.Show("Không còn lịch để sửa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            setupButtonFirst();
            isEditing = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            if (bdsGVDK.Count == 0)
            {
                MessageBox.Show("Không có lịch để xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
             if(MessageBox.Show("Bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) ==DialogResult.OK)
            {
                try
                {
                    maGV = gvGVDK.GetRowCellValue(gvGVDK.FocusedRowHandle, "MAGV").ToString();
                    bdsGVDK.RemoveCurrent();
                    gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                    gIAOVIEN_DANGKYTableAdapter.Update(DS.GIAOVIEN_DANGKY);
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên đăng ký\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    gIAOVIEN_DANGKYTableAdapter.Fill(DS.GIAOVIEN_DANGKY);
                    bdsGVDK.Position = bdsGVDK.Find("MAGV", maGV);
                }
            }
            setupButtonLast();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaGV.Focus();// fix trường hợp spin dư dấu chấm => bug
            if (txtMaMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn vui lòng chọn mã môn học", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn vui lòng chọn mã lớp", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (isAdding)
            {
                // kiểm tra ngày tháng đk, lịch thi tồn tại, đk l2 kt l1 thi chưa, time l2 > l1
                String strCHECKLAPLICHTHI = "EXEC SP_CHECKLAPLICHTHI '" + txtMaMH.Text + "', '" + txtMaLop.Text + "', '" + cbLanThi.SelectedItem.ToString() + "' , '" + dateNgayThi.Text + "'";
                if (Program.execNonQuery(strCHECKLAPLICHTHI) != 0) return;
                //thiếu SP check đủ câu hỏi chưa
                String strCHECKDUCAUHOITHI = "EXEC SP_CHECKDUCAUHOITHI '" + txtMaMH.Text +"','" + cbTrinhDo.Text + "','" + spinSoCauThi.Text + "'";
                if (Program.execNonQuery(strCHECKDUCAUHOITHI) != 0) return;
                
                try
                {
                    bdsGVDK.EndEdit();
                    gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                    gIAOVIEN_DANGKYTableAdapter.Update(DS.GIAOVIEN_DANGKY);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
                isAdding = false;
            }
            else if (isEditing)
            {
                try
                {
                    bdsGVDK.EndEdit();
                    gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                    gIAOVIEN_DANGKYTableAdapter.Update(DS.GIAOVIEN_DANGKY);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                } catch(Exception ex)
                {
                    MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
                isEditing = false;
            }
            pcInfo.Visible = false;
            setupButtonLast();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                txtMaMH.Text = txtMaLop.Text = "";
                cbTrinhDo.SelectedIndex = cbLanThi.SelectedIndex = 0;
                dateNgayThi.DateTime = DateTime.Now;
                spinSoCauThi.Value = spinThoiGian.Value = 15;
            }
            else if (isEditing)
            {
                txtMaMH.Text = txtMaLop.Text = "";
                cbTrinhDo.SelectedIndex = cbLanThi.SelectedIndex = 0;
                dateNgayThi.DateTime = DateTime.Now;
                spinSoCauThi.Value = spinThoiGian.Value = 15;
            }
            else
            {
                gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connStr;
                gIAOVIEN_DANGKYTableAdapter.Fill(DS.GIAOVIEN_DANGKY);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGVDK.CancelEdit();
            setupButtonLast();
            isAdding = isEditing = false;
            pcInfo.Visible = false;
        }
    }
}