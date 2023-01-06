
namespace CarApp.Operations
{
    partial class MaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.txt_Maintenance_amount = new DevExpress.XtraEditors.TextEdit();
            this.com_CarNo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Maintenance_Type = new DevExpress.XtraEditors.TextEdit();
            this.Dt_Maintenance_Date = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Maintenance = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Main_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Car_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maintenance_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maintenance_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maintenance_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Maintenance_amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_CarNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Maintenance_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Maintenance_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Maintenance_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(920, 36);
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.txt_Maintenance_amount);
            this.grb__Record.Controls.Add(this.com_CarNo);
            this.grb__Record.Controls.Add(this.labelControl4);
            this.grb__Record.Controls.Add(this.txt_Maintenance_Type);
            this.grb__Record.Controls.Add(this.Dt_Maintenance_Date);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.labelControl7);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(13, 47);
            this.grb__Record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(895, 153);
            this.grb__Record.TabIndex = 21;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // txt_Maintenance_amount
            // 
            this.txt_Maintenance_amount.Location = new System.Drawing.Point(472, 98);
            this.txt_Maintenance_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Maintenance_amount.Name = "txt_Maintenance_amount";
            this.txt_Maintenance_amount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Maintenance_amount.Properties.Appearance.Options.UseFont = true;
            this.txt_Maintenance_amount.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Maintenance_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Maintenance_amount.Properties.Mask.BeepOnError = true;
            this.txt_Maintenance_amount.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_Maintenance_amount.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_Maintenance_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Maintenance_amount.Size = new System.Drawing.Size(286, 30);
            this.txt_Maintenance_amount.TabIndex = 61;
            this.txt_Maintenance_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Maintenance_amount_KeyPress);
            // 
            // com_CarNo
            // 
            this.com_CarNo.Location = new System.Drawing.Point(472, 42);
            this.com_CarNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_CarNo.Name = "com_CarNo";
            this.com_CarNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_CarNo.Properties.Appearance.Options.UseFont = true;
            this.com_CarNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_CarNo.Properties.NullText = "";
            this.com_CarNo.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_CarNo.Properties.ShowHeader = false;
            this.com_CarNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_CarNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_CarNo.Size = new System.Drawing.Size(286, 30);
            this.com_CarNo.TabIndex = 46;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(773, 101);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 21);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "مبلغ الصــيانة";
            // 
            // txt_Maintenance_Type
            // 
            this.txt_Maintenance_Type.Location = new System.Drawing.Point(15, 39);
            this.txt_Maintenance_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Maintenance_Type.Name = "txt_Maintenance_Type";
            this.txt_Maintenance_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Maintenance_Type.Properties.Appearance.Options.UseFont = true;
            this.txt_Maintenance_Type.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Maintenance_Type.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Maintenance_Type.Properties.Mask.BeepOnError = true;
            this.txt_Maintenance_Type.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_Maintenance_Type.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_Maintenance_Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Maintenance_Type.Size = new System.Drawing.Size(286, 30);
            this.txt_Maintenance_Type.TabIndex = 42;
            // 
            // Dt_Maintenance_Date
            // 
            this.Dt_Maintenance_Date.EditValue = null;
            this.Dt_Maintenance_Date.Location = new System.Drawing.Point(15, 98);
            this.Dt_Maintenance_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dt_Maintenance_Date.Name = "Dt_Maintenance_Date";
            this.Dt_Maintenance_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Maintenance_Date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Maintenance_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Maintenance_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Maintenance_Date.Properties.MaskSettings.Set("mask", "d");
            this.Dt_Maintenance_Date.Properties.UseMaskAsDisplayFormat = true;
            this.Dt_Maintenance_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Maintenance_Date.Size = new System.Drawing.Size(286, 30);
            this.Dt_Maintenance_Date.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(315, 42);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 21);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "نوع الصيــــانة";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(310, 101);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 21);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "تاريخ الصيــــانة";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(773, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 21);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "رقم السيارة";
            // 
            // panel_btn
            // 
            this.panel_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_btn.Controls.Add(this.btn_Edit);
            this.panel_btn.Controls.Add(this.simpleButton1);
            this.panel_btn.Controls.Add(this.labelControl9);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Delete);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(27, 219);
            this.panel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(867, 89);
            this.panel_btn.TabIndex = 69;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(360, 25);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(148, 43);
            this.btn_Edit.TabIndex = 75;
            this.btn_Edit.Text = "تعديـل";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(-174, -7);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 42);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "تحميل صورة";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(1024, 7);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(11, 21);
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
            this.btn_New.Location = new System.Drawing.Point(699, 25);
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(148, 43);
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
            this.btn_Exit.Location = new System.Drawing.Point(22, 25);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 42);
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
            this.btn_Delete.Location = new System.Drawing.Point(191, 25);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(147, 42);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حــذف";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(532, 25);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(148, 43);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(771, 389);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 21);
            this.lbl_ID.TabIndex = 74;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(206, 320);
            this.grb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(509, 112);
            this.grb_Search.TabIndex = 73;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(353, 44);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(28, 52);
            this.com_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.com_Search.Size = new System.Drawing.Size(314, 30);
            this.com_Search.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_Maintenance);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 451);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(920, 276);
            this.groupControl2.TabIndex = 75;
            this.groupControl2.Text = "عرض بيانات صيانة السيارات";
            // 
            // dgv_Maintenance
            // 
            this.dgv_Maintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Maintenance.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Maintenance.Location = new System.Drawing.Point(2, 33);
            this.dgv_Maintenance.MainView = this.gridView1;
            this.dgv_Maintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Maintenance.Name = "dgv_Maintenance";
            this.dgv_Maintenance.Size = new System.Drawing.Size(916, 241);
            this.dgv_Maintenance.TabIndex = 0;
            this.dgv_Maintenance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.Main_ID,
            this.Car_No,
            this.Maintenance_Type,
            this.Maintenance_Date,
            this.Maintenance_amount});
            this.gridView1.GridControl = this.dgv_Maintenance;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.Maintenance_Date, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Main_ID
            // 
            this.Main_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Main_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Main_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Main_ID.AppearanceHeader.Options.UseFont = true;
            this.Main_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Main_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Main_ID.Caption = "Main_ID";
            this.Main_ID.FieldName = "Main_ID";
            this.Main_ID.MinWidth = 24;
            this.Main_ID.Name = "Main_ID";
            this.Main_ID.Width = 94;
            // 
            // Car_No
            // 
            this.Car_No.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_No.AppearanceCell.Options.UseFont = true;
            this.Car_No.AppearanceCell.Options.UseTextOptions = true;
            this.Car_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_No.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_No.AppearanceHeader.Options.UseFont = true;
            this.Car_No.AppearanceHeader.Options.UseTextOptions = true;
            this.Car_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Car_No.Caption = "رقم السيــارة";
            this.Car_No.FieldName = "Car_No";
            this.Car_No.MinWidth = 24;
            this.Car_No.Name = "Car_No";
            this.Car_No.Visible = true;
            this.Car_No.VisibleIndex = 0;
            this.Car_No.Width = 94;
            // 
            // Maintenance_Type
            // 
            this.Maintenance_Type.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Maintenance_Type.AppearanceCell.Options.UseFont = true;
            this.Maintenance_Type.AppearanceCell.Options.UseTextOptions = true;
            this.Maintenance_Type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Maintenance_Type.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Maintenance_Type.AppearanceHeader.Options.UseFont = true;
            this.Maintenance_Type.AppearanceHeader.Options.UseTextOptions = true;
            this.Maintenance_Type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Maintenance_Type.Caption = "نوع الصــيانة";
            this.Maintenance_Type.FieldName = "Maintenance_Type";
            this.Maintenance_Type.MinWidth = 24;
            this.Maintenance_Type.Name = "Maintenance_Type";
            this.Maintenance_Type.Visible = true;
            this.Maintenance_Type.VisibleIndex = 1;
            this.Maintenance_Type.Width = 87;
            // 
            // Maintenance_Date
            // 
            this.Maintenance_Date.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Maintenance_Date.AppearanceCell.Options.UseFont = true;
            this.Maintenance_Date.AppearanceCell.Options.UseTextOptions = true;
            this.Maintenance_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Maintenance_Date.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Maintenance_Date.AppearanceHeader.Options.UseFont = true;
            this.Maintenance_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.Maintenance_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Maintenance_Date.Caption = "تاريــخ الصــيانة";
            this.Maintenance_Date.FieldName = "Maintenance_Date";
            this.Maintenance_Date.MinWidth = 24;
            this.Maintenance_Date.Name = "Maintenance_Date";
            this.Maintenance_Date.Visible = true;
            this.Maintenance_Date.VisibleIndex = 2;
            this.Maintenance_Date.Width = 94;
            // 
            // Maintenance_amount
            // 
            this.Maintenance_amount.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Maintenance_amount.AppearanceCell.Options.UseFont = true;
            this.Maintenance_amount.AppearanceCell.Options.UseTextOptions = true;
            this.Maintenance_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Maintenance_amount.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Maintenance_amount.AppearanceHeader.Options.UseFont = true;
            this.Maintenance_amount.AppearanceHeader.Options.UseTextOptions = true;
            this.Maintenance_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Maintenance_amount.Caption = "مبلــغ الصـــيانة";
            this.Maintenance_amount.FieldName = "Maintenance_amount";
            this.Maintenance_amount.MinWidth = 24;
            this.Maintenance_amount.Name = "Maintenance_amount";
            this.Maintenance_amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Maintenance_amount", "اجمالي الصيانة = {0:}")});
            this.Maintenance_amount.Visible = true;
            this.Maintenance_amount.VisibleIndex = 3;
            this.Maintenance_amount.Width = 100;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 727);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــة تسجيـــل بيانــات الصيـــانــة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaintenanceForm_FormClosed);
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Maintenance_amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_CarNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Maintenance_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Maintenance_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Maintenance_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.panel_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Maintenance_Type;
        private DevExpress.XtraEditors.DateEdit Dt_Maintenance_Date;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit com_CarNo;
        private DevExpress.XtraEditors.TextEdit txt_Maintenance_amount;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Maintenance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Main_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Car_No;
        private DevExpress.XtraGrid.Columns.GridColumn Maintenance_Type;
        private DevExpress.XtraGrid.Columns.GridColumn Maintenance_Date;
        private DevExpress.XtraGrid.Columns.GridColumn Maintenance_amount;
    }
}