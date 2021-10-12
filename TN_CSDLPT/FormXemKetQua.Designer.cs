﻿
namespace TN_CSDLPT
{
    partial class FormXemKetQua
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMonThi = new System.Windows.Forms.TextBox();
            this.btnLop = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnHoTen = new DevExpress.XtraEditors.SimpleButton();
            this.btnMonThi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TN_CSDLPT.DS();
            this.gvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.gvSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.SINHVIENTableAdapter = new TN_CSDLPT.DSTableAdapters.SINHVIENTableAdapter();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(158, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(158, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Họ tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(157, 144);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Môn thi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(158, 197);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Lần thi";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(240, 32);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(229, 23);
            this.txtLop.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(240, 87);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(229, 23);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtMonThi
            // 
            this.txtMonThi.Location = new System.Drawing.Point(240, 143);
            this.txtMonThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonThi.Name = "txtMonThi";
            this.txtMonThi.ReadOnly = true;
            this.txtMonThi.Size = new System.Drawing.Size(229, 23);
            this.txtMonThi.TabIndex = 6;
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(508, 24);
            this.btnLop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(118, 38);
            this.btnLop.TabIndex = 8;
            this.btnLop.Text = "Chọn";
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(293, 258);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(222, 60);
            this.btnPreview.TabIndex = 12;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(508, 80);
            this.btnHoTen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(118, 36);
            this.btnHoTen.TabIndex = 13;
            this.btnHoTen.Text = "Chọn";
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnMonThi
            // 
            this.btnMonThi.Location = new System.Drawing.Point(508, 136);
            this.btnMonThi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMonThi.Name = "btnMonThi";
            this.btnMonThi.Size = new System.Drawing.Size(118, 36);
            this.btnMonThi.TabIndex = 14;
            this.btnMonThi.Text = "Chọn";
            this.btnMonThi.Click += new System.EventHandler(this.btnMonThi_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1131, 425);
            this.panelControl1.TabIndex = 15;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcMonHoc);
            this.panelControl2.Controls.Add(this.gcSinhVien);
            this.panelControl2.Controls.Add(this.gcLop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 425);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1131, 317);
            this.panelControl2.TabIndex = 16;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMonHoc;
            this.gcMonHoc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcMonHoc.Location = new System.Drawing.Point(734, 31);
            this.gcMonHoc.MainView = this.gvMonHoc;
            this.gcMonHoc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(351, 234);
            this.gcMonHoc.TabIndex = 2;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonHoc});
            this.gcMonHoc.Click += new System.EventHandler(this.gcMonHoc_Click);
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gvMonHoc.DetailHeight = 546;
            this.gvMonHoc.GridControl = this.gcMonHoc;
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 31;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 117;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "TÊN MÔN HỌC";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 31;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 117;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcSinhVien.Location = new System.Drawing.Point(360, 31);
            this.gcSinhVien.MainView = this.gvSinhVien;
            this.gcSinhVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(325, 234);
            this.gcSinhVien.TabIndex = 1;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSinhVien});
            this.gcSinhVien.Click += new System.EventHandler(this.gcSinhVien_Click);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.DS;
            // 
            // gvSinhVien
            // 
            this.gvSinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN});
            this.gvSinhVien.DetailHeight = 546;
            this.gvSinhVien.GridControl = this.gcSinhVien;
            this.gvSinhVien.Name = "gvSinhVien";
            this.gvSinhVien.OptionsBehavior.Editable = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "MÃ SINH VIÊN";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 31;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 117;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 31;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 117;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcLop.Location = new System.Drawing.Point(46, 31);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(288, 234);
            this.gcLop.TabIndex = 0;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            this.gcLop.Click += new System.EventHandler(this.gcLop_Click);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // gvLop
            // 
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gvLop.DetailHeight = 546;
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            this.gvLop.OptionsBehavior.Editable = false;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 31;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 117;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "TEN LỚP";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 31;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 117;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 31;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 117;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.cbLanThi);
            this.panelControl3.Controls.Add(this.txtHoTen);
            this.panelControl3.Controls.Add(this.txtLop);
            this.panelControl3.Controls.Add(this.btnMonThi);
            this.panelControl3.Controls.Add(this.txtMonThi);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.btnLop);
            this.panelControl3.Controls.Add(this.btnHoTen);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.btnPreview);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Location = new System.Drawing.Point(120, 30);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(804, 386);
            this.panelControl3.TabIndex = 15;
            // 
            // cbLanThi
            // 
            this.cbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(240, 194);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(107, 24);
            this.cbLanThi.TabIndex = 15;
            // 
            // FormXemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 742);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormXemKetQua";
            this.Text = "FrptXemKetQua";
            this.Load += new System.EventHandler(this.FrptXemKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMonThi;
        private DevExpress.XtraEditors.SimpleButton btnLop;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnHoTen;
        private DevExpress.XtraEditors.SimpleButton btnMonThi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSinhVien;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.ComboBox cbLanThi;
    }
}