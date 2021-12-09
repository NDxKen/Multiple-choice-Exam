
namespace TN_CSDLPT
{
    partial class FormLapLichThi
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapLichThi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThemKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DS = new TN_CSDLPT.DS();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.gcGVDK = new DevExpress.XtraGrid.GridControl();
            this.gvGVDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcInput = new DevExpress.XtraEditors.PanelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.spinThoiGian = new DevExpress.XtraEditors.SpinEdit();
            this.spinSoCauThi = new DevExpress.XtraEditors.SpinEdit();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.dateNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.btnMaLop = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaMH = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcInfo = new DevExpress.XtraEditors.PanelControl();
            mAGVLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInput)).BeginInit();
            this.pcInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoCauThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInfo)).BeginInit();
            this.pcInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(71, 31);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(48, 17);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(554, 92);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(68, 17);
            nGAYTHILabel.TabIndex = 10;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(554, 31);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(72, 17);
            tRINHDOLabel.TabIndex = 13;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(585, 144);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(37, 17);
            lANLabel.TabIndex = 14;
            lANLabel.Text = "LAN:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(1011, 33);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(78, 17);
            sOCAUTHILabel.TabIndex = 15;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(1015, 85);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(74, 17);
            tHOIGIANLabel.TabIndex = 16;
            tHOIGIANLabel.Text = "THOIGIAN:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(71, 89);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 17;
            mAMHLabel.Text = "MAMH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(71, 144);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 18;
            mALOPLabel.Text = "MALOP:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnRefresh,
            this.btnHuy,
            this.btnThemKhoa,
            this.btnThemLop,
            this.btnPhucHoi,
            this.btnThem});
            this.barManager1.MaxItemId = 14;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemLookUpEdit1});
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(231, 223);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 13;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SỬA";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "LÀM MỚI";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦY";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1333, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 843);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1333, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 813);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1333, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 813);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Caption = "Khoa";
            this.btnThemKhoa.Id = 10;
            this.btnThemKhoa.Name = "btnThemKhoa";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Caption = "Lớp";
            this.btnThemLop.Id = 11;
            this.btnThemLop.Name = "btnThemLop";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "PHỤC HỒI";
            this.btnPhucHoi.Id = 12;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbCoSo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1333, 51);
            this.panelControl1.TabIndex = 14;
            // 
            // cbCoSo
            // 
            this.cbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(106, 14);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(271, 24);
            this.cbCoSo.TabIndex = 1;
            this.cbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbCoSo_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CƠ SỞ";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.DS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gcGVDK
            // 
            this.gcGVDK.DataSource = this.bdsGVDK;
            this.gcGVDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGVDK.Location = new System.Drawing.Point(0, 81);
            this.gcGVDK.MainView = this.gvGVDK;
            this.gcGVDK.MenuManager = this.barManager1;
            this.gcGVDK.Name = "gcGVDK";
            this.gcGVDK.Size = new System.Drawing.Size(1333, 220);
            this.gcGVDK.TabIndex = 15;
            this.gcGVDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGVDK});
            // 
            // gvGVDK
            // 
            this.gvGVDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gvGVDK.GridControl = this.gcGVDK;
            this.gvGVDK.Name = "gvGVDK";
            this.gvGVDK.OptionsBehavior.Editable = false;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã GV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 94;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 94;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "Ngày thi";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 25;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 94;
            // 
            // colLAN
            // 
            this.colLAN.Caption = "Lần";
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 25;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 94;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.Caption = "Số câu thi";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 25;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 94;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Thời gian";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 25;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 94;
            // 
            // pcInput
            // 
            this.pcInput.Controls.Add(mALOPLabel);
            this.pcInput.Controls.Add(this.txtMaLop);
            this.pcInput.Controls.Add(mAMHLabel);
            this.pcInput.Controls.Add(this.txtMaMH);
            this.pcInput.Controls.Add(tHOIGIANLabel);
            this.pcInput.Controls.Add(this.spinThoiGian);
            this.pcInput.Controls.Add(sOCAUTHILabel);
            this.pcInput.Controls.Add(this.spinSoCauThi);
            this.pcInput.Controls.Add(lANLabel);
            this.pcInput.Controls.Add(this.cbLanThi);
            this.pcInput.Controls.Add(tRINHDOLabel);
            this.pcInput.Controls.Add(this.cbTrinhDo);
            this.pcInput.Controls.Add(nGAYTHILabel);
            this.pcInput.Controls.Add(this.dateNgayThi);
            this.pcInput.Controls.Add(this.btnMaLop);
            this.pcInput.Controls.Add(this.btnMaMH);
            this.pcInput.Controls.Add(mAGVLabel);
            this.pcInput.Controls.Add(this.txtMaGV);
            this.pcInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcInput.Location = new System.Drawing.Point(0, 301);
            this.pcInput.Name = "pcInput";
            this.pcInput.Size = new System.Drawing.Size(1333, 192);
            this.pcInput.TabIndex = 16;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(141, 141);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(152, 22);
            this.txtMaLop.TabIndex = 19;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(143, 86);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(152, 22);
            this.txtMaMH.TabIndex = 18;
            // 
            // spinThoiGian
            // 
            this.spinThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "THOIGIAN", true));
            this.spinThoiGian.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinThoiGian.Location = new System.Drawing.Point(1095, 82);
            this.spinThoiGian.MenuManager = this.barManager1;
            this.spinThoiGian.Name = "spinThoiGian";
            this.spinThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinThoiGian.Size = new System.Drawing.Size(131, 24);
            this.spinThoiGian.TabIndex = 17;
            // 
            // spinSoCauThi
            // 
            this.spinSoCauThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "SOCAUTHI", true));
            this.spinSoCauThi.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinSoCauThi.Location = new System.Drawing.Point(1095, 30);
            this.spinSoCauThi.MenuManager = this.barManager1;
            this.spinSoCauThi.Name = "spinSoCauThi";
            this.spinSoCauThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoCauThi.Size = new System.Drawing.Size(131, 24);
            this.spinSoCauThi.TabIndex = 16;
            // 
            // cbLanThi
            // 
            this.cbLanThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "LAN", true));
            this.cbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(632, 141);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(175, 24);
            this.cbLanThi.TabIndex = 15;
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "TRINHDO", true));
            this.cbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTrinhDo.Location = new System.Drawing.Point(632, 28);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(175, 24);
            this.cbTrinhDo.TabIndex = 14;
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "NGAYTHI", true));
            this.dateNgayThi.EditValue = null;
            this.dateNgayThi.Location = new System.Drawing.Point(632, 89);
            this.dateNgayThi.MenuManager = this.barManager1;
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateNgayThi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayThi.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateNgayThi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayThi.Size = new System.Drawing.Size(175, 22);
            this.dateNgayThi.TabIndex = 11;
            // 
            // btnMaLop
            // 
            this.btnMaLop.Location = new System.Drawing.Point(318, 137);
            this.btnMaLop.Name = "btnMaLop";
            this.btnMaLop.Size = new System.Drawing.Size(109, 29);
            this.btnMaLop.TabIndex = 7;
            this.btnMaLop.Text = "Chọn lớp";
            this.btnMaLop.Click += new System.EventHandler(this.btnMaLop_Click);
            // 
            // btnMaMH
            // 
            this.btnMaMH.Location = new System.Drawing.Point(318, 82);
            this.btnMaMH.Name = "btnMaMH";
            this.btnMaMH.Size = new System.Drawing.Size(109, 29);
            this.btnMaMH.TabIndex = 6;
            this.btnMaMH.Text = "Chọn môn học";
            this.btnMaMH.Click += new System.EventHandler(this.btnMaMH_Click);
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(141, 28);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(152, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMonHoc;
            this.gcMonHoc.Location = new System.Drawing.Point(12, 39);
            this.gcMonHoc.MainView = this.gvMonHoc;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(567, 241);
            this.gcMonHoc.TabIndex = 16;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonHoc});
            this.gcMonHoc.Click += new System.EventHandler(this.gcMonHoc_Click);
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH1,
            this.colTENMH});
            this.gvMonHoc.GridControl = this.gcMonHoc;
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.OptionsBehavior.Editable = false;
            // 
            // colMAMH1
            // 
            this.colMAMH1.Caption = "Mã môn học";
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 0;
            this.colMAMH1.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Location = new System.Drawing.Point(640, 39);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(586, 241);
            this.gcLop.TabIndex = 16;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            this.gcLop.Click += new System.EventHandler(this.gcLop_Click);
            // 
            // gvLop
            // 
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP1,
            this.colTENLOP,
            this.colMAKH});
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            this.gvLop.OptionsBehavior.Editable = false;
            // 
            // colMALOP1
            // 
            this.colMALOP1.Caption = "Mã lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 0;
            this.colMALOP1.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã Khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // pcInfo
            // 
            this.pcInfo.Controls.Add(this.gcMonHoc);
            this.pcInfo.Controls.Add(this.gcLop);
            this.pcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcInfo.Location = new System.Drawing.Point(0, 493);
            this.pcInfo.Name = "pcInfo";
            this.pcInfo.Size = new System.Drawing.Size(1333, 350);
            this.pcInfo.TabIndex = 17;
            // 
            // FormLapLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 863);
            this.Controls.Add(this.pcInfo);
            this.Controls.Add(this.pcInput);
            this.Controls.Add(this.gcGVDK);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Name = "FormLapLichThi";
            this.Text = "FormDKThi";
            this.Load += new System.EventHandler(this.FormLapLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInput)).EndInit();
            this.pcInput.ResumeLayout(false);
            this.pcInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoCauThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInfo)).EndInit();
            this.pcInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemKhoa;
        private DevExpress.XtraBars.BarButtonItem btnThemLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbCoSo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pcInput;
        private DevExpress.XtraEditors.SpinEdit spinThoiGian;
        private DevExpress.XtraEditors.SpinEdit spinSoCauThi;
        private System.Windows.Forms.ComboBox cbLanThi;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private DevExpress.XtraEditors.DateEdit dateNgayThi;
        private DevExpress.XtraEditors.SimpleButton btnMaLop;
        private DevExpress.XtraEditors.SimpleButton btnMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraGrid.GridControl gcGVDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGVDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonHoc;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraEditors.PanelControl pcInfo;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
    }
}