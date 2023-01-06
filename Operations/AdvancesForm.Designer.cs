
namespace CarApp.Operations
{
    partial class AdvancesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancesForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.com_DriverSalary = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.com_Dname = new DevExpress.XtraEditors.LookUpEdit();
            this.Dt_Advance_date = new DevExpress.XtraEditors.DateEdit();
            this.txt_Advance_amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Advances = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Advance_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Shift_Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Advance_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.btnDeleteOne = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_DriverSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Dname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Advance_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Advance_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Advance_amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Size = new System.Drawing.Size(767, 30);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(122, 262);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(522, 91);
            this.grb_Search.TabIndex = 25;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(366, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 36);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(48, 42);
            this.com_Search.Name = "com_Search";
            this.com_Search.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_Search.Properties.Appearance.Options.UseFont = true;
            this.com_Search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_Search.Properties.NullText = "";
            this.com_Search.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Search.Properties.ShowHeader = false;
            this.com_Search.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Search.Size = new System.Drawing.Size(292, 26);
            this.com_Search.TabIndex = 20;
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.com_DriverSalary);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.com_Dname);
            this.grb__Record.Controls.Add(this.Dt_Advance_date);
            this.grb__Record.Controls.Add(this.txt_Advance_amount);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.labelControl7);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(43, 38);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(680, 120);
            this.grb__Record.TabIndex = 26;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // com_DriverSalary
            // 
            this.com_DriverSalary.Location = new System.Drawing.Point(14, 33);
            this.com_DriverSalary.Name = "com_DriverSalary";
            this.com_DriverSalary.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_DriverSalary.Properties.Appearance.Options.UseFont = true;
            this.com_DriverSalary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_DriverSalary.Properties.NullText = "";
            this.com_DriverSalary.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_DriverSalary.Properties.ShowHeader = false;
            this.com_DriverSalary.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_DriverSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_DriverSalary.Size = new System.Drawing.Size(218, 26);
            this.com_DriverSalary.TabIndex = 44;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(237, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 17);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "المرتــب";
            // 
            // com_Dname
            // 
            this.com_Dname.Location = new System.Drawing.Point(315, 32);
            this.com_Dname.Name = "com_Dname";
            this.com_Dname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_Dname.Properties.Appearance.Options.UseFont = true;
            this.com_Dname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_Dname.Properties.NullText = "";
            this.com_Dname.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Dname.Properties.ShowHeader = false;
            this.com_Dname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Dname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Dname.Size = new System.Drawing.Size(245, 26);
            this.com_Dname.TabIndex = 41;
            this.com_Dname.EditValueChanged += new System.EventHandler(this.com_Dname_EditValueChanged);
            // 
            // Dt_Advance_date
            // 
            this.Dt_Advance_date.EditValue = null;
            this.Dt_Advance_date.Location = new System.Drawing.Point(315, 77);
            this.Dt_Advance_date.Name = "Dt_Advance_date";
            this.Dt_Advance_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Advance_date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Advance_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Advance_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Advance_date.Properties.MaskSettings.Set("mask", "d");
            this.Dt_Advance_date.Properties.UseMaskAsDisplayFormat = true;
            this.Dt_Advance_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Advance_date.Size = new System.Drawing.Size(245, 26);
            this.Dt_Advance_date.TabIndex = 4;
            // 
            // txt_Advance_amount
            // 
            this.txt_Advance_amount.Location = new System.Drawing.Point(14, 75);
            this.txt_Advance_amount.Name = "txt_Advance_amount";
            this.txt_Advance_amount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Advance_amount.Properties.Appearance.Options.UseFont = true;
            this.txt_Advance_amount.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Advance_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Advance_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Advance_amount.Size = new System.Drawing.Size(218, 26);
            this.txt_Advance_amount.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(237, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "السلفــة";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(566, 80);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 17);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "تاريخ السلفــة";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(563, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "إسم السـائق";
            // 
            // panel_btn
            // 
            this.panel_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_btn.Controls.Add(this.btnDeleteOne);
            this.panel_btn.Controls.Add(this.simpleButton1);
            this.panel_btn.Controls.Add(this.labelControl9);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Delete);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(23, 176);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(721, 72);
            this.panel_btn.TabIndex = 69;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(-149, -6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 34);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "تحميل صورة";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(878, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(8, 16);
            this.labelControl9.TabIndex = 35;
            this.labelControl9.Text = "0";
            this.labelControl9.Visible = false;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(579, 21);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(126, 34);
            this.btn_New.TabIndex = 11;
            this.btn_New.Text = "جديـد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(12, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(126, 34);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(154, 20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 34);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حذف الكل";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(435, 21);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(126, 34);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_Advances);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 374);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(767, 170);
            this.groupControl2.TabIndex = 71;
            this.groupControl2.Text = "عرض بيانات السائقيـــن";
            // 
            // dgv_Advances
            // 
            this.dgv_Advances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Advances.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Advances.Location = new System.Drawing.Point(2, 27);
            this.dgv_Advances.MainView = this.gridView1;
            this.dgv_Advances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Advances.Name = "dgv_Advances";
            this.dgv_Advances.Size = new System.Drawing.Size(763, 141);
            this.dgv_Advances.TabIndex = 0;
            this.dgv_Advances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv_Advances.Click += new System.EventHandler(this.dgv_Advances_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("El Messiri SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Advance_ID,
            this.Driver_Name,
            this.Shift_Salary,
            this.Advance_Date});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.dgv_Advances;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.Advance_Date, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Advance_ID
            // 
            this.Advance_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Advance_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Advance_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Advance_ID.AppearanceHeader.Options.UseFont = true;
            this.Advance_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Advance_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Advance_ID.Caption = "Advance_ID";
            this.Advance_ID.FieldName = "Advance_ID";
            this.Advance_ID.MinWidth = 21;
            this.Advance_ID.Name = "Advance_ID";
            this.Advance_ID.Width = 81;
            // 
            // Driver_Name
            // 
            this.Driver_Name.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Name.AppearanceCell.Options.UseFont = true;
            this.Driver_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Driver_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Driver_Name.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Name.AppearanceHeader.Options.UseFont = true;
            this.Driver_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Driver_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Driver_Name.Caption = "اسم السائــق";
            this.Driver_Name.FieldName = "Driver_Name";
            this.Driver_Name.MinWidth = 21;
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.Visible = true;
            this.Driver_Name.VisibleIndex = 0;
            this.Driver_Name.Width = 81;
            // 
            // Shift_Salary
            // 
            this.Shift_Salary.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Shift_Salary.AppearanceCell.Options.UseFont = true;
            this.Shift_Salary.AppearanceCell.Options.UseTextOptions = true;
            this.Shift_Salary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_Salary.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Shift_Salary.AppearanceHeader.Options.UseFont = true;
            this.Shift_Salary.AppearanceHeader.Options.UseTextOptions = true;
            this.Shift_Salary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_Salary.Caption = "السلفـــة";
            this.Shift_Salary.FieldName = "Advance_amount";
            this.Shift_Salary.MinWidth = 21;
            this.Shift_Salary.Name = "Shift_Salary";
            this.Shift_Salary.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Advance_amount", "اجمالي السلــف = {0:}")});
            this.Shift_Salary.Visible = true;
            this.Shift_Salary.VisibleIndex = 1;
            this.Shift_Salary.Width = 81;
            // 
            // Advance_Date
            // 
            this.Advance_Date.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Advance_Date.AppearanceCell.Options.UseFont = true;
            this.Advance_Date.AppearanceCell.Options.UseTextOptions = true;
            this.Advance_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Advance_Date.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Advance_Date.AppearanceHeader.Options.UseFont = true;
            this.Advance_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.Advance_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Advance_Date.Caption = "تاريــخ السلفـــة";
            this.Advance_Date.FieldName = "Advance_Date";
            this.Advance_Date.MinWidth = 21;
            this.Advance_Date.Name = "Advance_Date";
            this.Advance_Date.Visible = true;
            this.Advance_Date.VisibleIndex = 2;
            this.Advance_Date.Width = 81;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(711, 299);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(8, 16);
            this.lbl_ID.TabIndex = 74;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOne.Appearance.Options.UseFont = true;
            this.btnDeleteOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDeleteOne.Location = new System.Drawing.Point(294, 21);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(126, 34);
            this.btnDeleteOne.TabIndex = 36;
            this.btnDeleteOne.Text = "حذف واحد";
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // AdvancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 544);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancesForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشـــة تسجيـــــل الســلـف";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdvancesForm_FormClosed);
            this.Load += new System.EventHandler(this.AdvancesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_DriverSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Dname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Advance_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Advance_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Advance_amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.panel_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.DateEdit Dt_Advance_date;
        private DevExpress.XtraEditors.TextEdit txt_Advance_amount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit com_Dname;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Advances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Advance_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Driver_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Shift_Salary;
        private DevExpress.XtraGrid.Columns.GridColumn Advance_Date;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit com_DriverSalary;
        public DevExpress.XtraEditors.SimpleButton btnDeleteOne;
    }
}