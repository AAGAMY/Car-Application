
namespace CarApp.Forms
{
    partial class TransformForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransformForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.com_Car_ID_No = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.com_CompName = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_Tranaddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TraName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Transform = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Transform_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Transform_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Transform_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Car_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Com_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Car_ID_No.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_CompName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tranaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TraName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transform)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1004, 36);
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.com_Car_ID_No);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.com_CompName);
            this.grb__Record.Controls.Add(this.txt_Tranaddress);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.labelControl4);
            this.grb__Record.Controls.Add(this.txt_TraName);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(13, 47);
            this.grb__Record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(978, 146);
            this.grb__Record.TabIndex = 19;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // com_Car_ID_No
            // 
            this.com_Car_ID_No.Location = new System.Drawing.Point(514, 96);
            this.com_Car_ID_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_Car_ID_No.Name = "com_Car_ID_No";
            this.com_Car_ID_No.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_Car_ID_No.Properties.Appearance.Options.UseFont = true;
            this.com_Car_ID_No.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_Car_ID_No.Properties.NullText = "";
            this.com_Car_ID_No.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Car_ID_No.Properties.ShowHeader = false;
            this.com_Car_ID_No.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Car_ID_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Car_ID_No.Size = new System.Drawing.Size(339, 30);
            this.com_Car_ID_No.TabIndex = 43;
            this.com_Car_ID_No.EditValueChanged += new System.EventHandler(this.com_Car_ID_No_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(861, 98);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 21);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "رقم السيـارة";
            // 
            // com_CompName
            // 
            this.com_CompName.Location = new System.Drawing.Point(16, 95);
            this.com_CompName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_CompName.Name = "com_CompName";
            this.com_CompName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_CompName.Properties.Appearance.Options.UseFont = true;
            this.com_CompName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_CompName.Properties.NullText = "";
            this.com_CompName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_CompName.Properties.ShowHeader = false;
            this.com_CompName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_CompName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_CompName.Size = new System.Drawing.Size(339, 30);
            this.com_CompName.TabIndex = 5;
            // 
            // txt_Tranaddress
            // 
            this.txt_Tranaddress.Location = new System.Drawing.Point(16, 36);
            this.txt_Tranaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tranaddress.Name = "txt_Tranaddress";
            this.txt_Tranaddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Tranaddress.Properties.Appearance.Options.UseFont = true;
            this.txt_Tranaddress.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Tranaddress.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Tranaddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Tranaddress.Size = new System.Drawing.Size(341, 30);
            this.txt_Tranaddress.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(369, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 21);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "العنــــوان";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(364, 98);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 21);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "اسم الشركة";
            // 
            // txt_TraName
            // 
            this.txt_TraName.Location = new System.Drawing.Point(514, 41);
            this.txt_TraName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TraName.Name = "txt_TraName";
            this.txt_TraName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_TraName.Properties.Appearance.Options.UseFont = true;
            this.txt_TraName.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TraName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_TraName.Properties.Mask.BeepOnError = true;
            this.txt_TraName.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_TraName.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_TraName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TraName.Size = new System.Drawing.Size(339, 30);
            this.txt_TraName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(861, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 21);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "اسم المكتب";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(960, 236);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 21);
            this.lbl_ID.TabIndex = 34;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // panel_btn
            // 
            this.panel_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_btn.Controls.Add(this.simpleButton1);
            this.panel_btn.Controls.Add(this.labelControl9);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Delete);
            this.panel_btn.Controls.Add(this.btn_Edit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(72, 202);
            this.panel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(861, 89);
            this.panel_btn.TabIndex = 33;
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
            this.btn_New.Location = new System.Drawing.Point(692, 23);
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
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(357, 23);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(148, 43);
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
            this.btn_Save.Location = new System.Drawing.Point(524, 23);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(148, 43);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(198, 299);
            this.grb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(609, 112);
            this.grb_Search.TabIndex = 35;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(430, 46);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(59, 52);
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
            this.com_Search.Size = new System.Drawing.Size(341, 30);
            this.com_Search.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_Transform);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 421);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(1004, 276);
            this.groupControl2.TabIndex = 76;
            this.groupControl2.Text = "عرض بيانات مكاتب النقل";
            // 
            // dgv_Transform
            // 
            this.dgv_Transform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Transform.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Transform.Location = new System.Drawing.Point(2, 33);
            this.dgv_Transform.MainView = this.gridView1;
            this.dgv_Transform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Transform.Name = "dgv_Transform";
            this.dgv_Transform.Size = new System.Drawing.Size(1000, 241);
            this.dgv_Transform.TabIndex = 0;
            this.dgv_Transform.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Transform_ID,
            this.Transform_Name,
            this.Transform_Address,
            this.Car_No,
            this.Com_Name});
            this.gridView1.GridControl = this.dgv_Transform;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.Transform_Address, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Transform_ID
            // 
            this.Transform_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Transform_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Transform_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Transform_ID.AppearanceHeader.Options.UseFont = true;
            this.Transform_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Transform_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Transform_ID.Caption = "Transform_ID";
            this.Transform_ID.FieldName = "Transform_ID";
            this.Transform_ID.MinWidth = 24;
            this.Transform_ID.Name = "Transform_ID";
            this.Transform_ID.Width = 94;
            // 
            // Transform_Name
            // 
            this.Transform_Name.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Transform_Name.AppearanceCell.Options.UseFont = true;
            this.Transform_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Transform_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Transform_Name.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Transform_Name.AppearanceHeader.Options.UseFont = true;
            this.Transform_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Transform_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Transform_Name.Caption = "اسم مكتب النقل";
            this.Transform_Name.FieldName = "Transform_Name";
            this.Transform_Name.MinWidth = 24;
            this.Transform_Name.Name = "Transform_Name";
            this.Transform_Name.Visible = true;
            this.Transform_Name.VisibleIndex = 0;
            this.Transform_Name.Width = 87;
            // 
            // Transform_Address
            // 
            this.Transform_Address.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Transform_Address.AppearanceCell.Options.UseFont = true;
            this.Transform_Address.AppearanceCell.Options.UseTextOptions = true;
            this.Transform_Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Transform_Address.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Transform_Address.AppearanceHeader.Options.UseFont = true;
            this.Transform_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Transform_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Transform_Address.Caption = "العنـــوان";
            this.Transform_Address.FieldName = "Transform_Address";
            this.Transform_Address.MinWidth = 24;
            this.Transform_Address.Name = "Transform_Address";
            this.Transform_Address.Visible = true;
            this.Transform_Address.VisibleIndex = 1;
            this.Transform_Address.Width = 94;
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
            this.Car_No.VisibleIndex = 2;
            this.Car_No.Width = 94;
            // 
            // Com_Name
            // 
            this.Com_Name.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Com_Name.AppearanceCell.Options.UseFont = true;
            this.Com_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Com_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Com_Name.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Com_Name.AppearanceHeader.Options.UseFont = true;
            this.Com_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Com_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Com_Name.Caption = "اســم الشركــة";
            this.Com_Name.FieldName = "Com_Name";
            this.Com_Name.MinWidth = 24;
            this.Com_Name.Name = "Com_Name";
            this.Com_Name.Visible = true;
            this.Com_Name.VisibleIndex = 3;
            this.Com_Name.Width = 100;
            // 
            // TransformForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 697);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransformForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشـــة تسجيـــل بيانـات مكاتــب النقـــل";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransformForm_FormClosed);
            this.Load += new System.EventHandler(this.TransformForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Car_ID_No.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_CompName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tranaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TraName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.panel_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.LookUpEdit com_CompName;
        private DevExpress.XtraEditors.TextEdit txt_Tranaddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TraName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit com_Car_ID_No;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Transform;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Transform_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Car_No;
        private DevExpress.XtraGrid.Columns.GridColumn Transform_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Transform_Address;
        private DevExpress.XtraGrid.Columns.GridColumn Com_Name;
    }
}