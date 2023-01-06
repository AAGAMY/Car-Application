
namespace CarApp.Forms
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.Com_CompName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_License_No = new DevExpress.XtraEditors.TextEdit();
            this.Dt_Expiry_date = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.com_Car_Type = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CarName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Cars = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Car_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Car_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Car_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.License_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Expiry_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Com_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Com_CompName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_License_No.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Expiry_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Expiry_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Car_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CarName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cars)).BeginInit();
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
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(790, 30);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.Com_CompName);
            this.grb__Record.Controls.Add(this.labelControl4);
            this.grb__Record.Controls.Add(this.txt_License_No);
            this.grb__Record.Controls.Add(this.Dt_Expiry_date);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.labelControl7);
            this.grb__Record.Controls.Add(this.com_Car_Type);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.txt_CarName);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(12, 44);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(767, 190);
            this.grb__Record.TabIndex = 20;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // Com_CompName
            // 
            this.Com_CompName.Location = new System.Drawing.Point(400, 138);
            this.Com_CompName.Name = "Com_CompName";
            this.Com_CompName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Com_CompName.Properties.Appearance.Options.UseFont = true;
            this.Com_CompName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Com_CompName.Properties.NullText = "";
            this.Com_CompName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.Com_CompName.Properties.ShowHeader = false;
            this.Com_CompName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Com_CompName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_CompName.Size = new System.Drawing.Size(257, 26);
            this.Com_CompName.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(668, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "اسم الشركة";
            // 
            // txt_License_No
            // 
            this.txt_License_No.Location = new System.Drawing.Point(400, 90);
            this.txt_License_No.Name = "txt_License_No";
            this.txt_License_No.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_License_No.Properties.Appearance.Options.UseFont = true;
            this.txt_License_No.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_License_No.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_License_No.Properties.Mask.BeepOnError = true;
            this.txt_License_No.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_License_No.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_License_No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_License_No.Size = new System.Drawing.Size(257, 26);
            this.txt_License_No.TabIndex = 2;
            // 
            // Dt_Expiry_date
            // 
            this.Dt_Expiry_date.EditValue = null;
            this.Dt_Expiry_date.Location = new System.Drawing.Point(20, 90);
            this.Dt_Expiry_date.Name = "Dt_Expiry_date";
            this.Dt_Expiry_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Expiry_date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Expiry_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Expiry_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Expiry_date.Properties.MaskSettings.Set("mask", "d");
            this.Dt_Expiry_date.Properties.UseMaskAsDisplayFormat = true;
            this.Dt_Expiry_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Expiry_date.Size = new System.Drawing.Size(253, 26);
            this.Dt_Expiry_date.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(672, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 17);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "رقم الرخصة";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(288, 93);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 17);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "تاريخ الإنتهاء";
            // 
            // com_Car_Type
            // 
            this.com_Car_Type.Location = new System.Drawing.Point(20, 33);
            this.com_Car_Type.Name = "com_Car_Type";
            this.com_Car_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_Car_Type.Properties.Appearance.Options.UseFont = true;
            this.com_Car_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_Car_Type.Properties.NullText = "";
            this.com_Car_Type.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Car_Type.Properties.ShowHeader = false;
            this.com_Car_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Car_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Car_Type.Size = new System.Drawing.Size(257, 26);
            this.com_Car_Type.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(288, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "نوع السيارة";
            // 
            // txt_CarName
            // 
            this.txt_CarName.Location = new System.Drawing.Point(400, 33);
            this.txt_CarName.Name = "txt_CarName";
            this.txt_CarName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_CarName.Properties.Appearance.Options.UseFont = true;
            this.txt_CarName.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_CarName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_CarName.Properties.Mask.BeepOnError = true;
            this.txt_CarName.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_CarName.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_CarName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CarName.Size = new System.Drawing.Size(257, 26);
            this.txt_CarName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(674, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "رقم السيارة";
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Delete);
            this.panel_btn.Controls.Add(this.btn_Edit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(24, 250);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(738, 72);
            this.panel_btn.TabIndex = 24;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(593, 19);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 35);
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
            this.btn_Exit.Location = new System.Drawing.Point(19, 20);
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
            this.btn_Delete.Location = new System.Drawing.Point(164, 20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 34);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حــذف";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(306, 19);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 35);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "تعديـل";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(449, 19);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 35);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(678, 367);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(8, 16);
            this.lbl_ID.TabIndex = 35;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(111, 337);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(522, 91);
            this.grb_Search.TabIndex = 34;
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_Cars);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 466);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(790, 155);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "عرض بيانات السيـــارات";
            // 
            // dgv_Cars
            // 
            this.dgv_Cars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cars.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Cars.Location = new System.Drawing.Point(2, 27);
            this.dgv_Cars.MainView = this.gridView1;
            this.dgv_Cars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Cars.Name = "dgv_Cars";
            this.dgv_Cars.Size = new System.Drawing.Size(786, 126);
            this.dgv_Cars.TabIndex = 0;
            this.dgv_Cars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Car_ID,
            this.Car_No,
            this.Car_Type,
            this.License_No,
            this.Expiry_date,
            this.Com_Name});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.dgv_Cars;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Car_ID
            // 
            this.Car_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Car_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Car_ID.AppearanceHeader.Options.UseFont = true;
            this.Car_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Car_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_ID.Caption = "Car_ID";
            this.Car_ID.FieldName = "Car_ID";
            this.Car_ID.MinWidth = 21;
            this.Car_ID.Name = "Car_ID";
            this.Car_ID.Width = 81;
            // 
            // Car_No
            // 
            this.Car_No.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_No.AppearanceCell.Options.UseFont = true;
            this.Car_No.AppearanceCell.Options.UseTextOptions = true;
            this.Car_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_No.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_No.AppearanceHeader.Options.UseFont = true;
            this.Car_No.AppearanceHeader.Options.UseTextOptions = true;
            this.Car_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_No.Caption = "رقم السيارة";
            this.Car_No.FieldName = "Car_No";
            this.Car_No.MinWidth = 21;
            this.Car_No.Name = "Car_No";
            this.Car_No.Visible = true;
            this.Car_No.VisibleIndex = 0;
            this.Car_No.Width = 81;
            // 
            // Car_Type
            // 
            this.Car_Type.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold);
            this.Car_Type.AppearanceCell.Options.UseFont = true;
            this.Car_Type.AppearanceCell.Options.UseTextOptions = true;
            this.Car_Type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_Type.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Car_Type.AppearanceHeader.Options.UseFont = true;
            this.Car_Type.AppearanceHeader.Options.UseTextOptions = true;
            this.Car_Type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_Type.Caption = "نوع السيارة";
            this.Car_Type.FieldName = "Car_Type";
            this.Car_Type.MinWidth = 21;
            this.Car_Type.Name = "Car_Type";
            this.Car_Type.Visible = true;
            this.Car_Type.VisibleIndex = 1;
            this.Car_Type.Width = 81;
            // 
            // License_No
            // 
            this.License_No.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold);
            this.License_No.AppearanceCell.Options.UseFont = true;
            this.License_No.AppearanceCell.Options.UseTextOptions = true;
            this.License_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.License_No.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.License_No.AppearanceHeader.Options.UseFont = true;
            this.License_No.AppearanceHeader.Options.UseTextOptions = true;
            this.License_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.License_No.Caption = "رقم الرخصة";
            this.License_No.FieldName = "License_No";
            this.License_No.MinWidth = 21;
            this.License_No.Name = "License_No";
            this.License_No.Visible = true;
            this.License_No.VisibleIndex = 2;
            this.License_No.Width = 81;
            // 
            // Expiry_date
            // 
            this.Expiry_date.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold);
            this.Expiry_date.AppearanceCell.Options.UseFont = true;
            this.Expiry_date.AppearanceCell.Options.UseTextOptions = true;
            this.Expiry_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Expiry_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Expiry_date.AppearanceHeader.Options.UseFont = true;
            this.Expiry_date.AppearanceHeader.Options.UseTextOptions = true;
            this.Expiry_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Expiry_date.Caption = "تاريخ انتهاء الرخصة";
            this.Expiry_date.FieldName = "Expiry_date";
            this.Expiry_date.MinWidth = 21;
            this.Expiry_date.Name = "Expiry_date";
            this.Expiry_date.Visible = true;
            this.Expiry_date.VisibleIndex = 3;
            this.Expiry_date.Width = 81;
            // 
            // Com_Name
            // 
            this.Com_Name.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold);
            this.Com_Name.AppearanceCell.Options.UseFont = true;
            this.Com_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Com_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Com_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Com_Name.AppearanceHeader.Options.UseFont = true;
            this.Com_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Com_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Com_Name.Caption = "اسم الشركة";
            this.Com_Name.FieldName = "Com_Name";
            this.Com_Name.MinWidth = 21;
            this.Com_Name.Name = "Com_Name";
            this.Com_Name.Visible = true;
            this.Com_Name.VisibleIndex = 4;
            this.Com_Name.Width = 81;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 621);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarsForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات السيارات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarsForm_FormClosed);
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Com_CompName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_License_No.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Expiry_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Expiry_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Car_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CarName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.DateEdit Dt_Expiry_date;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_CarName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit com_Car_Type;
        private DevExpress.XtraEditors.TextEdit txt_License_No;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit Com_CompName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Cars;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Car_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Car_Type;
        private DevExpress.XtraGrid.Columns.GridColumn License_No;
        private DevExpress.XtraGrid.Columns.GridColumn Expiry_date;
        private DevExpress.XtraGrid.Columns.GridColumn Com_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Car_No;
    }
}