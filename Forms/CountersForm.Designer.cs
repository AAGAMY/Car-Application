
namespace CarApp.Forms
{
    partial class CountersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountersForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Small_Mini = new DevExpress.XtraEditors.TextEdit();
            this.txt_Big_Mini = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.com_Car_ID_No = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_Small_Counter = new DevExpress.XtraEditors.TextEdit();
            this.txt_Big_Counter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Salaries = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Counter_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Car_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Big_Counter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Big_Mini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Small_Counter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Small_Mini = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Small_Mini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Big_Mini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Car_ID_No.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Small_Counter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Big_Counter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Size = new System.Drawing.Size(999, 36);
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.labelControl7);
            this.grb__Record.Controls.Add(this.txt_Small_Mini);
            this.grb__Record.Controls.Add(this.txt_Big_Mini);
            this.grb__Record.Controls.Add(this.labelControl5);
            this.grb__Record.Controls.Add(this.com_Car_ID_No);
            this.grb__Record.Controls.Add(this.txt_Small_Counter);
            this.grb__Record.Controls.Add(this.txt_Big_Counter);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(21, 48);
            this.grb__Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(955, 197);
            this.grb__Record.TabIndex = 27;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(354, 148);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 21);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "حد الطلـــب";
            // 
            // txt_Small_Mini
            // 
            this.txt_Small_Mini.Location = new System.Drawing.Point(20, 144);
            this.txt_Small_Mini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Small_Mini.Name = "txt_Small_Mini";
            this.txt_Small_Mini.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Small_Mini.Properties.Appearance.Options.UseFont = true;
            this.txt_Small_Mini.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Small_Mini.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Small_Mini.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Small_Mini.Size = new System.Drawing.Size(327, 30);
            this.txt_Small_Mini.TabIndex = 4;
            // 
            // txt_Big_Mini
            // 
            this.txt_Big_Mini.Location = new System.Drawing.Point(20, 95);
            this.txt_Big_Mini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Big_Mini.Name = "txt_Big_Mini";
            this.txt_Big_Mini.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Big_Mini.Properties.Appearance.Options.UseFont = true;
            this.txt_Big_Mini.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Big_Mini.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Big_Mini.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Big_Mini.Size = new System.Drawing.Size(327, 30);
            this.txt_Big_Mini.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(354, 97);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 21);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "حد الطلـــب";
            // 
            // com_Car_ID_No
            // 
            this.com_Car_ID_No.Location = new System.Drawing.Point(485, 43);
            this.com_Car_ID_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.com_Car_ID_No.Size = new System.Drawing.Size(329, 30);
            this.com_Car_ID_No.TabIndex = 0;
            // 
            // txt_Small_Counter
            // 
            this.txt_Small_Counter.Location = new System.Drawing.Point(485, 142);
            this.txt_Small_Counter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Small_Counter.Name = "txt_Small_Counter";
            this.txt_Small_Counter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Small_Counter.Properties.Appearance.Options.UseFont = true;
            this.txt_Small_Counter.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Small_Counter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Small_Counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Small_Counter.Size = new System.Drawing.Size(327, 30);
            this.txt_Small_Counter.TabIndex = 3;
            // 
            // txt_Big_Counter
            // 
            this.txt_Big_Counter.Location = new System.Drawing.Point(485, 91);
            this.txt_Big_Counter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Big_Counter.Name = "txt_Big_Counter";
            this.txt_Big_Counter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Big_Counter.Properties.Appearance.Options.UseFont = true;
            this.txt_Big_Counter.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Big_Counter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Big_Counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Big_Counter.Size = new System.Drawing.Size(327, 30);
            this.txt_Big_Counter.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(818, 94);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 21);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "العداد الكبيـــر";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(817, 144);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 21);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "العداد الصغيـــر";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(821, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 21);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "رقم السيـــارة";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(941, 278);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 21);
            this.lbl_ID.TabIndex = 35;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Delete);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Edit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(69, 268);
            this.panel_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(861, 89);
            this.panel_btn.TabIndex = 28;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(696, 30);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(148, 43);
            this.btn_New.TabIndex = 11;
            this.btn_New.Text = "جديـد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(189, 31);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(147, 42);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حــذف";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(18, 31);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 42);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(359, 30);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Save.Location = new System.Drawing.Point(530, 30);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.grb_Search.Location = new System.Drawing.Point(245, 382);
            this.grb_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(509, 112);
            this.grb_Search.TabIndex = 29;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(354, 44);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(28, 52);
            this.com_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupControl2.Controls.Add(this.dgv_Salaries);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 516);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(999, 240);
            this.groupControl2.TabIndex = 73;
            this.groupControl2.Text = "عرض بيانات عدادات السيارات";
            // 
            // dgv_Salaries
            // 
            this.dgv_Salaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Salaries.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Salaries.Location = new System.Drawing.Point(2, 33);
            this.dgv_Salaries.MainView = this.gridView1;
            this.dgv_Salaries.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Salaries.Name = "dgv_Salaries";
            this.dgv_Salaries.Size = new System.Drawing.Size(995, 205);
            this.dgv_Salaries.TabIndex = 0;
            this.dgv_Salaries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Counter_ID,
            this.Car_No,
            this.Big_Counter,
            this.Big_Mini,
            this.Small_Counter,
            this.Small_Mini});
            this.gridView1.GridControl = this.dgv_Salaries;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.Small_Counter, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Counter_ID
            // 
            this.Counter_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Counter_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Counter_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Counter_ID.AppearanceHeader.Options.UseFont = true;
            this.Counter_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Counter_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Counter_ID.Caption = "Counter_ID";
            this.Counter_ID.FieldName = "Counter_ID";
            this.Counter_ID.MinWidth = 24;
            this.Counter_ID.Name = "Counter_ID";
            this.Counter_ID.Width = 94;
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
            // Big_Counter
            // 
            this.Big_Counter.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Big_Counter.AppearanceCell.Options.UseFont = true;
            this.Big_Counter.AppearanceCell.Options.UseTextOptions = true;
            this.Big_Counter.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Big_Counter.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Big_Counter.AppearanceHeader.Options.UseFont = true;
            this.Big_Counter.AppearanceHeader.Options.UseTextOptions = true;
            this.Big_Counter.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Big_Counter.Caption = "رقم العداد الكبيــر";
            this.Big_Counter.FieldName = "Big_Counter";
            this.Big_Counter.MinWidth = 23;
            this.Big_Counter.Name = "Big_Counter";
            this.Big_Counter.Visible = true;
            this.Big_Counter.VisibleIndex = 1;
            // 
            // Big_Mini
            // 
            this.Big_Mini.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Big_Mini.AppearanceCell.Options.UseFont = true;
            this.Big_Mini.AppearanceCell.Options.UseTextOptions = true;
            this.Big_Mini.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Big_Mini.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Big_Mini.AppearanceHeader.Options.UseFont = true;
            this.Big_Mini.AppearanceHeader.Options.UseTextOptions = true;
            this.Big_Mini.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Big_Mini.Caption = "حد الطلب الكبير";
            this.Big_Mini.FieldName = "Big_Mini";
            this.Big_Mini.MinWidth = 24;
            this.Big_Mini.Name = "Big_Mini";
            this.Big_Mini.Visible = true;
            this.Big_Mini.VisibleIndex = 2;
            this.Big_Mini.Width = 87;
            // 
            // Small_Counter
            // 
            this.Small_Counter.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Small_Counter.AppearanceCell.Options.UseFont = true;
            this.Small_Counter.AppearanceCell.Options.UseTextOptions = true;
            this.Small_Counter.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Small_Counter.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Small_Counter.AppearanceHeader.Options.UseFont = true;
            this.Small_Counter.AppearanceHeader.Options.UseTextOptions = true;
            this.Small_Counter.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Small_Counter.Caption = "رقم العداد الصغيــر";
            this.Small_Counter.FieldName = "Small_Counter";
            this.Small_Counter.MinWidth = 24;
            this.Small_Counter.Name = "Small_Counter";
            this.Small_Counter.Visible = true;
            this.Small_Counter.VisibleIndex = 3;
            this.Small_Counter.Width = 94;
            // 
            // Small_Mini
            // 
            this.Small_Mini.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Small_Mini.AppearanceCell.Options.UseFont = true;
            this.Small_Mini.AppearanceCell.Options.UseTextOptions = true;
            this.Small_Mini.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Small_Mini.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Small_Mini.AppearanceHeader.Options.UseFont = true;
            this.Small_Mini.AppearanceHeader.Options.UseTextOptions = true;
            this.Small_Mini.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Small_Mini.Caption = "حد الطلب الصغيـــر";
            this.Small_Mini.FieldName = "Small_Mini";
            this.Small_Mini.MinWidth = 24;
            this.Small_Mini.Name = "Small_Mini";
            this.Small_Mini.Visible = true;
            this.Small_Mini.VisibleIndex = 4;
            this.Small_Mini.Width = 87;
            // 
            // CountersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 756);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountersForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشـــة تسجيـــــل قـراءة عدادات السيــــارة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CountersForm_FormClosed);
            this.Load += new System.EventHandler(this.CountersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Small_Mini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Big_Mini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Car_ID_No.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Small_Counter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Big_Counter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        private DevExpress.XtraEditors.LookUpEdit com_Car_ID_No;
        private DevExpress.XtraEditors.TextEdit txt_Big_Counter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Salaries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Counter_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Car_No;
        private DevExpress.XtraGrid.Columns.GridColumn Big_Counter;
        private DevExpress.XtraGrid.Columns.GridColumn Small_Counter;
        private DevExpress.XtraEditors.TextEdit txt_Small_Counter;
        private DevExpress.XtraEditors.TextEdit txt_Small_Mini;
        private DevExpress.XtraEditors.TextEdit txt_Big_Mini;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn Big_Mini;
        private DevExpress.XtraGrid.Columns.GridColumn Small_Mini;
    }
}