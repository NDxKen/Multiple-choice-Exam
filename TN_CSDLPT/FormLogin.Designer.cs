
namespace TN_CSDLPT
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdbGV = new System.Windows.Forms.RadioButton();
            this.rdbSV = new System.Windows.Forms.RadioButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.dS_DSPM = new TN_CSDLPT.DS_DSPM();
            this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
            this.getSubcribersTableAdapter = new TN_CSDLPT.DS_DSPMTableAdapters.getSubcribersTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DS_DSPMTableAdapters.TableAdapterManager();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cơ sở";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tài khoản";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(180, 77);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(306, 23);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "001";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "123";
            // 
            // rdbGV
            // 
            this.rdbGV.AutoSize = true;
            this.rdbGV.Checked = true;
            this.rdbGV.Location = new System.Drawing.Point(180, 193);
            this.rdbGV.Name = "rdbGV";
            this.rdbGV.Size = new System.Drawing.Size(92, 21);
            this.rdbGV.TabIndex = 6;
            this.rdbGV.TabStop = true;
            this.rdbGV.Text = "Giảng Viên";
            this.rdbGV.UseVisualStyleBackColor = true;
            // 
            // rdbSV
            // 
            this.rdbSV.AutoSize = true;
            this.rdbSV.Location = new System.Drawing.Point(313, 193);
            this.rdbSV.Name = "rdbSV";
            this.rdbSV.Size = new System.Drawing.Size(84, 21);
            this.rdbSV.TabIndex = 7;
            this.rdbSV.TabStop = true;
            this.rdbSV.Text = "Sinh Viên";
            this.rdbSV.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(180, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(205, 42);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSPM
            // 
            this.bdsDSPM.DataMember = "getSubcribers";
            this.bdsDSPM.DataSource = this.dS_DSPM;
            // 
            // getSubcribersTableAdapter
            // 
            this.getSubcribersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbCoSo
            // 
            this.cbCoSo.DataSource = this.bdsDSPM;
            this.cbCoSo.DisplayMember = "TEN_COSO";
            this.cbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(180, 26);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(306, 24);
            this.cbCoSo.TabIndex = 10;
            this.cbCoSo.ValueMember = "TEN_SERVER";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 314);
            this.Controls.Add(this.cbCoSo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdbSV);
            this.Controls.Add(this.rdbGV);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormLogin";
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdbGV;
        private System.Windows.Forms.RadioButton rdbSV;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource bdsDSPM;
        private DS_DSPMTableAdapters.getSubcribersTableAdapter getSubcribersTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbCoSo;
    }
}