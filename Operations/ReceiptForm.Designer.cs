namespace CarApp.Operations
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grb_Shifts = new DevExpress.XtraEditors.GroupControl();
            this.txt_Receipt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Dt_Receipt_Date = new DevExpress.XtraEditors.DateEdit();
            this.txt_Receipt_Month = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Receipt_Salary_WO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Receipt_For = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Receipt_Salary_NO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Receipt_From = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDBDataSet = new CarApp.CarDBDataSet();
            this.receiptTableAdapter = new CarApp.CarDBDataSetTableAdapters.ReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Shifts)).BeginInit();
            this.grb_Shifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Receipt_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Receipt_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Salary_WO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_For.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Salary_NO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_From.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(831, 30);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 440);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(831, 26);
            // 
            // grb_Shifts
            // 
            this.grb_Shifts.Controls.Add(this.txt_Receipt_Name);
            this.grb_Shifts.Controls.Add(this.labelControl8);
            this.grb_Shifts.Controls.Add(this.labelControl7);
            this.grb_Shifts.Controls.Add(this.Dt_Receipt_Date);
            this.grb_Shifts.Controls.Add(this.txt_Receipt_Month);
            this.grb_Shifts.Controls.Add(this.labelControl6);
            this.grb_Shifts.Controls.Add(this.txt_Receipt_Salary_WO);
            this.grb_Shifts.Controls.Add(this.labelControl5);
            this.grb_Shifts.Controls.Add(this.txt_Receipt_For);
            this.grb_Shifts.Controls.Add(this.labelControl4);
            this.grb_Shifts.Controls.Add(this.txt_Receipt_Salary_NO);
            this.grb_Shifts.Controls.Add(this.labelControl3);
            this.grb_Shifts.Controls.Add(this.txt_Receipt_From);
            this.grb_Shifts.Controls.Add(this.labelControl2);
            this.grb_Shifts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Shifts.Location = new System.Drawing.Point(12, 39);
            this.grb_Shifts.Name = "grb_Shifts";
            this.grb_Shifts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Shifts.Size = new System.Drawing.Size(811, 199);
            this.grb_Shifts.TabIndex = 69;
            this.grb_Shifts.Text = "ايصال استلام نقدية";
            // 
            // txt_Receipt_Name
            // 
            this.txt_Receipt_Name.Location = new System.Drawing.Point(411, 34);
            this.txt_Receipt_Name.Name = "txt_Receipt_Name";
            this.txt_Receipt_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Receipt_Name.Properties.Appearance.Options.UseFont = true;
            this.txt_Receipt_Name.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Receipt_Name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Receipt_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Receipt_Name.Size = new System.Drawing.Size(308, 26);
            this.txt_Receipt_Name.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(725, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 17);
            this.labelControl8.TabIndex = 75;
            this.labelControl8.Text = "أستلمت انا";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(329, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 17);
            this.labelControl7.TabIndex = 74;
            this.labelControl7.Text = "التــاريـــــخ";
            // 
            // Dt_Receipt_Date
            // 
            this.Dt_Receipt_Date.EditValue = null;
            this.Dt_Receipt_Date.Location = new System.Drawing.Point(15, 159);
            this.Dt_Receipt_Date.Name = "Dt_Receipt_Date";
            this.Dt_Receipt_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Receipt_Date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Receipt_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Receipt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Receipt_Date.Properties.MaskSettings.Set("mask", "d");
            this.Dt_Receipt_Date.Properties.UseMaskAsDisplayFormat = true;
            this.Dt_Receipt_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Receipt_Date.Size = new System.Drawing.Size(308, 26);
            this.Dt_Receipt_Date.TabIndex = 5;
            // 
            // txt_Receipt_Month
            // 
            this.txt_Receipt_Month.Location = new System.Drawing.Point(545, 156);
            this.txt_Receipt_Month.Name = "txt_Receipt_Month";
            this.txt_Receipt_Month.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Receipt_Month.Properties.Appearance.Options.UseFont = true;
            this.txt_Receipt_Month.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Receipt_Month.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Receipt_Month.Properties.UseMaskAsDisplayFormat = true;
            this.txt_Receipt_Month.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Receipt_Month.Size = new System.Drawing.Size(174, 26);
            this.txt_Receipt_Month.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(725, 159);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 17);
            this.labelControl6.TabIndex = 71;
            this.labelControl6.Text = "عن شهر";
            // 
            // txt_Receipt_Salary_WO
            // 
            this.txt_Receipt_Salary_WO.Location = new System.Drawing.Point(15, 78);
            this.txt_Receipt_Salary_WO.Name = "txt_Receipt_Salary_WO";
            this.txt_Receipt_Salary_WO.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Receipt_Salary_WO.Properties.Appearance.Options.UseFont = true;
            this.txt_Receipt_Salary_WO.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Receipt_Salary_WO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Receipt_Salary_WO.Properties.UseMaskAsDisplayFormat = true;
            this.txt_Receipt_Salary_WO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Receipt_Salary_WO.Size = new System.Drawing.Size(308, 26);
            this.txt_Receipt_Salary_WO.TabIndex = 5;
            this.txt_Receipt_Salary_WO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Receipt_Salary_WO_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(329, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 17);
            this.labelControl5.TabIndex = 69;
            this.labelControl5.Text = "المبلغ بالعربي";
            // 
            // txt_Receipt_For
            // 
            this.txt_Receipt_For.Location = new System.Drawing.Point(15, 118);
            this.txt_Receipt_For.Name = "txt_Receipt_For";
            this.txt_Receipt_For.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Receipt_For.Properties.Appearance.Options.UseFont = true;
            this.txt_Receipt_For.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Receipt_For.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Receipt_For.Properties.UseMaskAsDisplayFormat = true;
            this.txt_Receipt_For.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Receipt_For.Size = new System.Drawing.Size(704, 26);
            this.txt_Receipt_For.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(725, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 17);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "نظيــر";
            // 
            // txt_Receipt_Salary_NO
            // 
            this.txt_Receipt_Salary_NO.Location = new System.Drawing.Point(545, 76);
            this.txt_Receipt_Salary_NO.Name = "txt_Receipt_Salary_NO";
            this.txt_Receipt_Salary_NO.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Receipt_Salary_NO.Properties.Appearance.Options.UseFont = true;
            this.txt_Receipt_Salary_NO.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Receipt_Salary_NO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Receipt_Salary_NO.Properties.UseMaskAsDisplayFormat = true;
            this.txt_Receipt_Salary_NO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Receipt_Salary_NO.Size = new System.Drawing.Size(174, 26);
            this.txt_Receipt_Salary_NO.TabIndex = 2;
            this.txt_Receipt_Salary_NO.EditValueChanged += new System.EventHandler(this.txt_Receipt_Salary_NO_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(725, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 17);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "مبلــغ وقدرة";
            // 
            // txt_Receipt_From
            // 
            this.txt_Receipt_From.Location = new System.Drawing.Point(15, 34);
            this.txt_Receipt_From.Name = "txt_Receipt_From";
            this.txt_Receipt_From.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Receipt_From.Properties.Appearance.Options.UseFont = true;
            this.txt_Receipt_From.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Receipt_From.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Receipt_From.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Receipt_From.Size = new System.Drawing.Size(308, 26);
            this.txt_Receipt_From.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(329, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "من السيــد";
            // 
            // panel_btn
            // 
            this.panel_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_btn.Controls.Add(this.btn_Print);
            this.panel_btn.Controls.Add(this.btn_Edit);
            this.panel_btn.Controls.Add(this.simpleButton1);
            this.panel_btn.Controls.Add(this.labelControl9);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(43, 249);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(745, 62);
            this.panel_btn.TabIndex = 70;
            // 
            // btn_Print
            // 
            this.btn_Print.Appearance.Font = new System.Drawing.Font("Tajawal", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_Print.Appearance.Options.UseFont = true;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
            this.btn_Print.Location = new System.Drawing.Point(161, 14);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(133, 35);
            this.btn_Print.TabIndex = 78;
            this.btn_Print.Text = "طباعة الإيصال";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(311, 14);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 35);
            this.btn_Edit.TabIndex = 76;
            this.btn_Edit.Text = "تعديـل";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click_1);
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
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(601, 14);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 35);
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
            this.btn_Exit.Location = new System.Drawing.Point(17, 14);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(127, 35);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(457, 14);
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
            this.lbl_ID.Location = new System.Drawing.Point(694, 366);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(8, 16);
            this.lbl_ID.TabIndex = 75;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(141, 329);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(522, 91);
            this.grb_Search.TabIndex = 74;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(369, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 36);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(51, 42);
            this.com_Search.Name = "com_Search";
            this.com_Search.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.com_Search.Properties.Appearance.Options.UseFont = true;
            this.com_Search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_Search.Properties.DataSource = this.receiptBindingSource;
            this.com_Search.Properties.DisplayMember = "Receipt_ID";
            this.com_Search.Properties.NullText = "";
            this.com_Search.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Search.Properties.ShowHeader = false;
            this.com_Search.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Search.Properties.ValueMember = "Receipt_ID";
            this.com_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Search.Size = new System.Drawing.Size(292, 26);
            this.com_Search.TabIndex = 6;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.carDBDataSet;
            // 
            // carDBDataSet
            // 
            this.carDBDataSet.DataSetName = "CarDBDataSet";
            this.carDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 466);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb_Shifts);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ايصــال استلام نقديـــة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceiptForm_FormClosed);
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Shifts)).EndInit();
            this.grb_Shifts.ResumeLayout(false);
            this.grb_Shifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Receipt_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Receipt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Salary_WO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_For.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_Salary_NO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Receipt_From.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.panel_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraEditors.GroupControl grb_Shifts;
        private DevExpress.XtraEditors.TextEdit txt_Receipt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit Dt_Receipt_Date;
        private DevExpress.XtraEditors.TextEdit txt_Receipt_Month;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Receipt_Salary_WO;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Receipt_For;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Receipt_Salary_NO;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Receipt_From;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        private CarDBDataSet carDBDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private CarDBDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        public DevExpress.XtraEditors.SimpleButton btn_Print;
    }
}