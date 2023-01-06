
namespace CarApp.Operations
{
    partial class ShiftsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftsForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.com_Dname = new DevExpress.XtraEditors.LookUpEdit();
            this.grb_Shifts = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Dt_date = new DevExpress.XtraEditors.DateEdit();
            this.txt_Shift_Quantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Shift_Salary = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteOne = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Shifts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Shift_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Shift_Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Shift_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Shift_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Dname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Shifts)).BeginInit();
            this.grb_Shifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_Quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_Salary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shifts)).BeginInit();
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
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(972, 36);
            // 
            // com_Dname
            // 
            this.com_Dname.Location = new System.Drawing.Point(468, 44);
            this.com_Dname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.com_Dname.Size = new System.Drawing.Size(286, 30);
            this.com_Dname.TabIndex = 21;
            // 
            // grb_Shifts
            // 
            this.grb_Shifts.Controls.Add(this.labelControl7);
            this.grb_Shifts.Controls.Add(this.Dt_date);
            this.grb_Shifts.Controls.Add(this.txt_Shift_Quantity);
            this.grb_Shifts.Controls.Add(this.labelControl3);
            this.grb_Shifts.Controls.Add(this.txt_Shift_Salary);
            this.grb_Shifts.Controls.Add(this.labelControl2);
            this.grb_Shifts.Controls.Add(this.labelControl1);
            this.grb_Shifts.Controls.Add(this.com_Dname);
            this.grb_Shifts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Shifts.Location = new System.Drawing.Point(35, 49);
            this.grb_Shifts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Shifts.Name = "grb_Shifts";
            this.grb_Shifts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Shifts.Size = new System.Drawing.Size(903, 170);
            this.grb_Shifts.TabIndex = 67;
            this.grb_Shifts.Text = "تسجيل بيانات الورديـــات";
            this.grb_Shifts.ToolTipController = this.toolTipController1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(318, 121);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 21);
            this.labelControl7.TabIndex = 69;
            this.labelControl7.Text = "التــاريـــــخ";
            // 
            // Dt_date
            // 
            this.Dt_date.EditValue = null;
            this.Dt_date.Location = new System.Drawing.Point(21, 114);
            this.Dt_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dt_date.Name = "Dt_date";
            this.Dt_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_date.Properties.Appearance.Options.UseFont = true;
            this.Dt_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_date.Properties.MaskSettings.Set("mask", "d");
            this.Dt_date.Properties.UseMaskAsDisplayFormat = true;
            this.Dt_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_date.Size = new System.Drawing.Size(286, 30);
            this.Dt_date.TabIndex = 68;
            // 
            // txt_Shift_Quantity
            // 
            this.txt_Shift_Quantity.Location = new System.Drawing.Point(468, 114);
            this.txt_Shift_Quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Shift_Quantity.Name = "txt_Shift_Quantity";
            this.txt_Shift_Quantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Shift_Quantity.Properties.Appearance.Options.UseFont = true;
            this.txt_Shift_Quantity.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Shift_Quantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Shift_Quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Shift_Quantity.Size = new System.Drawing.Size(286, 30);
            this.txt_Shift_Quantity.TabIndex = 66;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(760, 117);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 21);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "عدد الورديات";
            // 
            // txt_Shift_Salary
            // 
            this.txt_Shift_Salary.Location = new System.Drawing.Point(21, 44);
            this.txt_Shift_Salary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Shift_Salary.Name = "txt_Shift_Salary";
            this.txt_Shift_Salary.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Shift_Salary.Properties.Appearance.Options.UseFont = true;
            this.txt_Shift_Salary.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Shift_Salary.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Shift_Salary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Shift_Salary.Size = new System.Drawing.Size(286, 30);
            this.txt_Shift_Salary.TabIndex = 64;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(313, 47);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 21);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "مبــلغ الورديــة";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(760, 47);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 21);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "إســم السائــق";
            // 
            // panel_btn
            // 
            this.panel_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_btn.Controls.Add(this.btnDeleteOne);
            this.panel_btn.Controls.Add(this.simpleButton1);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Delete);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(55, 233);
            this.panel_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(862, 89);
            this.panel_btn.TabIndex = 68;
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOne.Appearance.Options.UseFont = true;
            this.btnDeleteOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOne.ImageOptions.Image")));
            this.btnDeleteOne.Location = new System.Drawing.Point(358, 25);
            this.btnDeleteOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(147, 42);
            this.btnDeleteOne.TabIndex = 77;
            this.btnDeleteOne.Text = "حذف واحد";
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(1115, 259);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(148, 43);
            toolTipTitleItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Text = "معلومات التعديل";
            toolTipItem1.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipItem1.Appearance.Options.UseFont = true;
            toolTipItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipItem1.Text = "احذف عدد الورديات الزيادة ثم اضغط تعديل";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btn_Edit.SuperTip = superToolTip1;
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
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 42);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "تحميل صورة";
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(691, 25);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(148, 43);
            this.btn_New.TabIndex = 11;
            this.btn_New.Text = "جديـد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(21, 25);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(148, 43);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(188, 26);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(148, 43);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حذف الكل";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(523, 25);
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
            this.grb_Search.Location = new System.Drawing.Point(182, 336);
            this.grb_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(609, 112);
            this.grb_Search.TabIndex = 69;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(430, 46);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(59, 52);
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
            this.com_Search.Size = new System.Drawing.Size(341, 30);
            this.com_Search.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_Shifts);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 457);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(972, 230);
            this.groupControl2.TabIndex = 70;
            this.groupControl2.Text = "عرض بيانات السائقيـــن";
            // 
            // dgv_Shifts
            // 
            this.dgv_Shifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Shifts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Shifts.Location = new System.Drawing.Point(2, 33);
            this.dgv_Shifts.MainView = this.gridView1;
            this.dgv_Shifts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Shifts.Name = "dgv_Shifts";
            this.dgv_Shifts.Size = new System.Drawing.Size(968, 195);
            this.dgv_Shifts.TabIndex = 0;
            this.dgv_Shifts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv_Shifts.Click += new System.EventHandler(this.dgv_Shifts_Click);
            this.dgv_Shifts.DoubleClick += new System.EventHandler(this.dgv_Shifts_DoubleClick);
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
            this.Shift_ID,
            this.Driver_Name,
            this.Shift_Salary,
            this.Shift_Quantity,
            this.Shift_Date});
            this.gridView1.GridControl = this.dgv_Shifts;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.Shift_Quantity, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Shift_ID
            // 
            this.Shift_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Shift_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Shift_ID.AppearanceHeader.Options.UseFont = true;
            this.Shift_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Shift_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_ID.Caption = "Shift_ID";
            this.Shift_ID.FieldName = "Shift_ID";
            this.Shift_ID.MinWidth = 24;
            this.Shift_ID.Name = "Shift_ID";
            this.Shift_ID.Width = 94;
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
            this.Driver_Name.MinWidth = 24;
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.Visible = true;
            this.Driver_Name.VisibleIndex = 0;
            this.Driver_Name.Width = 94;
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
            this.Shift_Salary.Caption = "مبلغ الوردية";
            this.Shift_Salary.FieldName = "Shift_Salary";
            this.Shift_Salary.MinWidth = 24;
            this.Shift_Salary.Name = "Shift_Salary";
            this.Shift_Salary.Visible = true;
            this.Shift_Salary.VisibleIndex = 1;
            this.Shift_Salary.Width = 94;
            // 
            // Shift_Quantity
            // 
            this.Shift_Quantity.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Shift_Quantity.AppearanceCell.Options.UseFont = true;
            this.Shift_Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Shift_Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_Quantity.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Shift_Quantity.AppearanceHeader.Options.UseFont = true;
            this.Shift_Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Shift_Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_Quantity.Caption = "عدد الورديات";
            this.Shift_Quantity.FieldName = "Shift_Quantity";
            this.Shift_Quantity.MinWidth = 24;
            this.Shift_Quantity.Name = "Shift_Quantity";
            this.Shift_Quantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Shift_Quantity", "اجمالي الورديات = {0:}", "<Null>")});
            this.Shift_Quantity.Visible = true;
            this.Shift_Quantity.VisibleIndex = 2;
            this.Shift_Quantity.Width = 94;
            // 
            // Shift_Date
            // 
            this.Shift_Date.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Shift_Date.AppearanceCell.Options.UseFont = true;
            this.Shift_Date.AppearanceCell.Options.UseTextOptions = true;
            this.Shift_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_Date.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Shift_Date.AppearanceHeader.Options.UseFont = true;
            this.Shift_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.Shift_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Shift_Date.Caption = "التاريــخ";
            this.Shift_Date.FieldName = "Shift_Date";
            this.Shift_Date.MinWidth = 24;
            this.Shift_Date.Name = "Shift_Date";
            this.Shift_Date.Visible = true;
            this.Shift_Date.VisibleIndex = 3;
            this.Shift_Date.Width = 94;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(883, 370);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 21);
            this.lbl_ID.TabIndex = 73;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // ShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 687);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb_Shifts);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftsForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشـــة تسجيــل الورديـــات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsForm_FormClosed);
            this.Load += new System.EventHandler(this.ShiftsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_Dname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Shifts)).EndInit();
            this.grb_Shifts.ResumeLayout(false);
            this.grb_Shifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_Quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_Salary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.LookUpEdit com_Dname;
        public DevExpress.XtraEditors.GroupControl grb_Shifts;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Shift_Salary;
        private DevExpress.XtraEditors.TextEdit txt_Shift_Quantity;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit Dt_date;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Shifts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Shift_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Driver_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Shift_Salary;
        private DevExpress.XtraGrid.Columns.GridColumn Shift_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Shift_Date;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.Utils.ToolTipController toolTipController1;
        public DevExpress.XtraEditors.SimpleButton btnDeleteOne;
    }
}