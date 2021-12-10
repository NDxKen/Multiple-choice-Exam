namespace TN_CSDLPT
{
    partial class FormKhoa
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
            System.Windows.Forms.Label mAKHLabel1;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.subThem = new DevExpress.XtraBars.BarSubItem();
            this.btnAddKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gc1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TN_CSDLPT.DS();
            this.KHOATableAdapter = new TN_CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.GIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.GIAOVIENTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIENTableAdapter();
            this.SINHVIENTableAdapter = new TN_CSDLPT.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.gc2 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaKH_Lop = new DevExpress.XtraEditors.TextEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.grcKhoa = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textMaKhoaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLopHoc = new DevExpress.XtraEditors.TextEdit();
            this.textLop = new DevExpress.XtraEditors.TextEdit();
            this.textMaCS = new DevExpress.XtraEditors.TextEdit();
            this.textTenKH = new DevExpress.XtraEditors.TextEdit();
            this.textMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.gc_Lop = new DevExpress.XtraGrid.GridControl();
            this.gv_Lop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gvKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLop = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaKhoa_Lop = new DevExpress.XtraEditors.TextEdit();
            this.textTenLop = new DevExpress.XtraEditors.TextEdit();
            this.textMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtCoSo = new DevExpress.XtraEditors.TextEdit();
            this.textTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            mAKHLabel1 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            this.gc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc2)).BeginInit();
            this.gc2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH_Lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhoa)).BeginInit();
            this.grcKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaKhoaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLopHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcLop)).BeginInit();
            this.grcLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa_Lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(498, 88);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(59, 17);
            mAKHLabel1.TabIndex = 10;
            mAKHLabel1.Text = "Mã khoa";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(210, 88);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 17);
            tENLOPLabel.TabIndex = 8;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(26, 90);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 17);
            mALOPLabel.TabIndex = 7;
            mALOPLabel.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(498, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 17);
            label2.TabIndex = 6;
            label2.Text = "Mã cơ sở";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(210, 34);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(65, 17);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "Tên khoa";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(26, 34);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(59, 17);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "Mã khoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(569, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 17);
            label3.TabIndex = 10;
            label3.Text = "Mã khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(240, 88);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 17);
            label4.TabIndex = 8;
            label4.Text = "Tên lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(30, 90);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 17);
            label5.TabIndex = 7;
            label5.Text = "Mã lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(569, 34);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 17);
            label6.TabIndex = 6;
            label6.Text = "Mã cơ sở";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(240, 34);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 17);
            label7.TabIndex = 2;
            label7.Text = "Tên khoa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(30, 34);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(59, 17);
            label8.TabIndex = 0;
            label8.Text = "Mã khoa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(569, 88);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 17);
            label9.TabIndex = 10;
            label9.Text = "Mã khoa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(240, 88);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(53, 17);
            label10.TabIndex = 8;
            label10.Text = "Tên lớp";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(30, 90);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(47, 17);
            label11.TabIndex = 7;
            label11.Text = "Mã lớp";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(569, 34);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(62, 17);
            label12.TabIndex = 6;
            label12.Text = "Mã cơ sở";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(240, 34);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(65, 17);
            label13.TabIndex = 2;
            label13.Text = "Tên khoa";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(30, 34);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(59, 17);
            label14.TabIndex = 0;
            label14.Text = "Mã khoa";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnHuy,
            this.subThem,
            this.btnAddKhoa,
            this.btnAddLop,
            this.btnThoat,
            this.btnRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.subThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // subThem
            // 
            this.subThem.Caption = "Thêm";
            this.subThem.Id = 5;
            this.subThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("subThem.ImageOptions.SvgImage")));
            this.subThem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddLop)});
            this.subThem.Name = "subThem";
            this.subThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnAddKhoa
            // 
            this.btnAddKhoa.Caption = "Khoa";
            this.btnAddKhoa.Id = 6;
            this.btnAddKhoa.Name = "btnAddKhoa";
            this.btnAddKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddKhoa_ItemClick);
            // 
            // btnAddLop
            // 
            this.btnAddLop.Caption = "Lớp";
            this.btnAddLop.Id = 7;
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddLop_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 9;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1408, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 894);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1408, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 843);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1408, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 843);
            // 
            // btnThem
            // 
            this.btnThem.ActAsDropDown = true;
            this.btnThem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnThem.Caption = "Thêm";
            this.btnThem.DropDownControl = this.popupMenu1;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // gc1
            // 
            this.gc1.Controls.Add(this.label1);
            this.gc1.Controls.Add(this.cmbCoSo);
            this.gc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc1.Location = new System.Drawing.Point(0, 51);
            this.gc1.Name = "gc1";
            this.gc1.Size = new System.Drawing.Size(1408, 82);
            this.gc1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(58, 31);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(106, 24);
            this.cmbCoSo.TabIndex = 0;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHOATableAdapter
            // 
            this.KHOATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = this.KHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GIAOVIEN_DANGKYTableAdapter
            // 
            this.GIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // GIAOVIENTableAdapter
            // 
            this.GIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGV.DataSource = this.bdsKhoa;
            // 
            // gc2
            // 
            this.gc2.Controls.Add(mAKHLabel1);
            this.gc2.Controls.Add(this.txtMaKH_Lop);
            this.gc2.Controls.Add(tENLOPLabel);
            this.gc2.Controls.Add(this.txtTenLop);
            this.gc2.Controls.Add(mALOPLabel);
            this.gc2.Controls.Add(this.txtMaLop);
            this.gc2.Controls.Add(this.txtMaCS);
            this.gc2.Controls.Add(label2);
            this.gc2.Controls.Add(tENKHLabel);
            this.gc2.Controls.Add(this.txtTenKH);
            this.gc2.Controls.Add(mAKHLabel);
            this.gc2.Controls.Add(this.txtMaKH);
            this.gc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc2.Location = new System.Drawing.Point(0, 133);
            this.gc2.Name = "gc2";
            this.gc2.Size = new System.Drawing.Size(1408, 761);
            this.gc2.TabIndex = 12;
            // 
            // txtMaKH_Lop
            // 
            this.txtMaKH_Lop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaKH_Lop.Location = new System.Drawing.Point(0, 0);
            this.txtMaKH_Lop.Name = "txtMaKH_Lop";
            this.txtMaKH_Lop.Size = new System.Drawing.Size(125, 22);
            this.txtMaKH_Lop.TabIndex = 11;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(0, 0);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(125, 22);
            this.txtTenLop.TabIndex = 12;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(0, 0);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(125, 22);
            this.txtMaLop.TabIndex = 13;
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaCS.Location = new System.Drawing.Point(0, 0);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(125, 22);
            this.txtMaCS.TabIndex = 14;
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtTenKH.Location = new System.Drawing.Point(0, 0);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(125, 22);
            this.txtTenKH.TabIndex = 15;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaKH.Location = new System.Drawing.Point(0, 0);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(125, 22);
            this.txtMaKH.TabIndex = 16;
            // 
            // grcKhoa
            // 
            this.grcKhoa.Controls.Add(this.groupControl2);
            this.grcKhoa.Controls.Add(this.gcKhoa);
            this.grcKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcKhoa.Location = new System.Drawing.Point(0, 133);
            this.grcKhoa.Name = "grcKhoa";
            this.grcKhoa.Size = new System.Drawing.Size(1408, 6458);
            this.grcKhoa.TabIndex = 17;
            this.grcKhoa.Text = "Khoa";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.gc_Lop);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 160);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1404, 601);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Lớp";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(label9);
            this.groupControl3.Controls.Add(this.textMaKhoaLop);
            this.groupControl3.Controls.Add(label10);
            this.groupControl3.Controls.Add(this.txtTenLopHoc);
            this.groupControl3.Controls.Add(label11);
            this.groupControl3.Controls.Add(this.textLop);
            this.groupControl3.Controls.Add(this.textMaCS);
            this.groupControl3.Controls.Add(label12);
            this.groupControl3.Controls.Add(label13);
            this.groupControl3.Controls.Add(this.textTenKH);
            this.groupControl3.Controls.Add(label14);
            this.groupControl3.Controls.Add(this.textMaKhoa);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 333);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1400, 266);
            this.groupControl3.TabIndex = 8;
            // 
            // textMaKhoaLop
            // 
            this.textMaKhoaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKH", true));
            this.textMaKhoaLop.Location = new System.Drawing.Point(637, 85);
            this.textMaKhoaLop.MenuManager = this.barManager1;
            this.textMaKhoaLop.Name = "textMaKhoaLop";
            this.textMaKhoaLop.Size = new System.Drawing.Size(125, 22);
            this.textMaKhoaLop.TabIndex = 11;
            // 
            // txtTenLopHoc
            // 
            this.txtTenLopHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTenLopHoc.Location = new System.Drawing.Point(311, 87);
            this.txtTenLopHoc.MenuManager = this.barManager1;
            this.txtTenLopHoc.Name = "txtTenLopHoc";
            this.txtTenLopHoc.Size = new System.Drawing.Size(232, 22);
            this.txtTenLopHoc.TabIndex = 9;
            // 
            // textLop
            // 
            this.textLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.textLop.Location = new System.Drawing.Point(95, 87);
            this.textLop.MenuManager = this.barManager1;
            this.textLop.Name = "textLop";
            this.textLop.Size = new System.Drawing.Size(125, 22);
            this.textLop.TabIndex = 8;
            // 
            // textMaCS
            // 
            this.textMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.textMaCS.Location = new System.Drawing.Point(637, 31);
            this.textMaCS.MenuManager = this.barManager1;
            this.textMaCS.Name = "textMaCS";
            this.textMaCS.Properties.ReadOnly = true;
            this.textMaCS.Size = new System.Drawing.Size(125, 22);
            this.textMaCS.TabIndex = 7;
            // 
            // textTenKH
            // 
            this.textTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.textTenKH.Location = new System.Drawing.Point(311, 31);
            this.textTenKH.MenuManager = this.barManager1;
            this.textTenKH.Name = "textTenKH";
            this.textTenKH.Size = new System.Drawing.Size(232, 22);
            this.textTenKH.TabIndex = 3;
            // 
            // textMaKhoa
            // 
            this.textMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.textMaKhoa.Location = new System.Drawing.Point(95, 31);
            this.textMaKhoa.MenuManager = this.barManager1;
            this.textMaKhoa.Name = "textMaKhoa";
            this.textMaKhoa.Size = new System.Drawing.Size(125, 22);
            this.textMaKhoa.TabIndex = 1;
            // 
            // gc_Lop
            // 
            this.gc_Lop.DataSource = this.bdsLop;
            this.gc_Lop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_Lop.Location = new System.Drawing.Point(2, 28);
            this.gc_Lop.MainView = this.gv_Lop;
            this.gc_Lop.MenuManager = this.barManager1;
            this.gc_Lop.Name = "gc_Lop";
            this.gc_Lop.Size = new System.Drawing.Size(1400, 259);
            this.gc_Lop.TabIndex = 0;
            this.gc_Lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Lop});
            // 
            // gv_Lop
            // 
            this.gv_Lop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_Lop.GridControl = this.gc_Lop;
            this.gv_Lop.Name = "gv_Lop";
            this.gv_Lop.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lớp";
            this.gridColumn1.FieldName = "MALOP";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp";
            this.gridColumn2.FieldName = "TENLOP";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã khoa";
            this.gridColumn3.FieldName = "MAKH";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhoa.Location = new System.Drawing.Point(2, 28);
            this.gcKhoa.MainView = this.gvKhoa;
            this.gcKhoa.MenuManager = this.barManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(1404, 132);
            this.gcKhoa.TabIndex = 11;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoa});
            this.gcKhoa.Click += new System.EventHandler(this.gcKhoa_Click);
            // 
            // gvKhoa
            // 
            this.gvKhoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gvKhoa.GridControl = this.gcKhoa;
            this.gvKhoa.Name = "gvKhoa";
            this.gvKhoa.OptionsBehavior.Editable = false;
            this.gvKhoa.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvKhoa_SelectionChanged);
            this.gvKhoa.Click += new System.EventHandler(this.gvKhoa_Click);
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 22;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 84;
            // 
            // colTENKH
            // 
            this.colTENKH.Caption = "Tên khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 22;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 82;
            // 
            // colMACS
            // 
            this.colMACS.Caption = "Mã cơ sở";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 22;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 82;
            // 
            // grcLop
            // 
            this.grcLop.Controls.Add(this.groupControl1);
            this.grcLop.Controls.Add(this.gcLop);
            this.grcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcLop.Location = new System.Drawing.Point(2, 199);
            this.grcLop.Name = "grcLop";
            this.grcLop.Size = new System.Drawing.Size(1459, 601);
            this.grcLop.TabIndex = 18;
            this.grcLop.Text = "Lớp";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(label3);
            this.groupControl1.Controls.Add(this.txtMaKhoa_Lop);
            this.groupControl1.Controls.Add(label4);
            this.groupControl1.Controls.Add(this.textTenLop);
            this.groupControl1.Controls.Add(label5);
            this.groupControl1.Controls.Add(this.textMaLop);
            this.groupControl1.Controls.Add(this.txtCoSo);
            this.groupControl1.Controls.Add(label6);
            this.groupControl1.Controls.Add(label7);
            this.groupControl1.Controls.Add(this.textTenKhoa);
            this.groupControl1.Controls.Add(label8);
            this.groupControl1.Controls.Add(this.txtMaKhoa);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 214);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1455, 385);
            this.groupControl1.TabIndex = 13;
            // 
            // txtMaKhoa_Lop
            // 
            this.txtMaKhoa_Lop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKH", true));
            this.txtMaKhoa_Lop.Location = new System.Drawing.Point(637, 85);
            this.txtMaKhoa_Lop.MenuManager = this.barManager1;
            this.txtMaKhoa_Lop.Name = "txtMaKhoa_Lop";
            this.txtMaKhoa_Lop.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhoa_Lop.TabIndex = 11;
            // 
            // textTenLop
            // 
            this.textTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.textTenLop.Location = new System.Drawing.Point(311, 87);
            this.textTenLop.MenuManager = this.barManager1;
            this.textTenLop.Name = "textTenLop";
            this.textTenLop.Size = new System.Drawing.Size(232, 22);
            this.textTenLop.TabIndex = 9;
            // 
            // textMaLop
            // 
            this.textMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.textMaLop.Location = new System.Drawing.Point(95, 87);
            this.textMaLop.MenuManager = this.barManager1;
            this.textMaLop.Name = "textMaLop";
            this.textMaLop.Size = new System.Drawing.Size(125, 22);
            this.textMaLop.TabIndex = 8;
            // 
            // txtCoSo
            // 
            this.txtCoSo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtCoSo.Location = new System.Drawing.Point(637, 31);
            this.txtCoSo.MenuManager = this.barManager1;
            this.txtCoSo.Name = "txtCoSo";
            this.txtCoSo.Properties.ReadOnly = true;
            this.txtCoSo.Size = new System.Drawing.Size(125, 22);
            this.txtCoSo.TabIndex = 7;
            // 
            // textTenKhoa
            // 
            this.textTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.textTenKhoa.Location = new System.Drawing.Point(311, 31);
            this.textTenKhoa.MenuManager = this.barManager1;
            this.textTenKhoa.Name = "textTenKhoa";
            this.textTenKhoa.Size = new System.Drawing.Size(232, 22);
            this.textTenKhoa.TabIndex = 3;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(95, 31);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // gcLop
            // 
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.Location = new System.Drawing.Point(2, 28);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1455, 180);
            this.gcLop.TabIndex = 12;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            // 
            // gvLop
            // 
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH1});
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 22;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 84;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 22;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 82;
            // 
            // colMAKH1
            // 
            this.colMAKH1.Caption = "Mã khoa";
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 22;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            this.colMAKH1.Width = 82;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // FormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 914);
            this.Controls.Add(this.grcKhoa);
            this.Controls.Add(this.gc2);
            this.Controls.Add(this.gc1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKhoa";
            this.Text = "FormKhoa";
            this.Load += new System.EventHandler(this.FormKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            this.gc1.ResumeLayout(false);
            this.gc1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc2)).EndInit();
            this.gc2.ResumeLayout(false);
            this.gc2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH_Lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhoa)).EndInit();
            this.grcKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaKhoaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLopHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcLop)).EndInit();
            this.grcLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa_Lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem subThem;
        private DevExpress.XtraBars.BarButtonItem btnAddKhoa;
        private DevExpress.XtraBars.BarButtonItem btnAddLop;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraEditors.GroupControl gc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DSTableAdapters.KHOATableAdapter KHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gc2;
        private DevExpress.XtraEditors.TextEdit txtMaKH_Lop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter GIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.GIAOVIENTableAdapter GIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsGV;
        private DevExpress.XtraEditors.GroupControl grcKhoa;
        private DevExpress.XtraEditors.GroupControl grcLop;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa_Lop;
        private DevExpress.XtraEditors.TextEdit textTenLop;
        private DevExpress.XtraEditors.TextEdit textMaLop;
        private DevExpress.XtraEditors.TextEdit txtCoSo;
        private DevExpress.XtraEditors.TextEdit textTenKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_Lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Lop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit textMaKhoaLop;
        private DevExpress.XtraEditors.TextEdit txtTenLopHoc;
        private DevExpress.XtraEditors.TextEdit textLop;
        private DevExpress.XtraEditors.TextEdit textMaCS;
        private DevExpress.XtraEditors.TextEdit textTenKH;
        private DevExpress.XtraEditors.TextEdit textMaKhoa;
    }
}