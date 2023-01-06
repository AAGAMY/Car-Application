
namespace CarApp.Operations
{
    partial class CurrentlyCounterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentlyCounterForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.com_CarNo = new DevExpress.XtraEditors.LookUpEdit();
            this.Dt_date = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Small_Counter = new DevExpress.XtraEditors.TextEdit();
            this.txt_Big_Counter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Big_Mini = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Small_Mini = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_CarNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Small_Counter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Big_Counter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(825, 36);
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.com_CarNo);
            this.grb__Record.Controls.Add(this.Dt_date);
            this.grb__Record.Controls.Add(this.labelControl7);
            this.grb__Record.Controls.Add(this.txt_Small_Counter);
            this.grb__Record.Controls.Add(this.txt_Big_Counter);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(16, 190);
            this.grb__Record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(793, 148);
            this.grb__Record.TabIndex = 27;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // com_CarNo
            // 
            this.com_CarNo.Location = new System.Drawing.Point(402, 41);
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
            this.com_CarNo.Size = new System.Drawing.Size(265, 30);
            this.com_CarNo.TabIndex = 33;
            // 
            // Dt_date
            // 
            this.Dt_date.EditValue = null;
            this.Dt_date.Location = new System.Drawing.Point(10, 98);
            this.Dt_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.Dt_date.Size = new System.Drawing.Size(264, 30);
            this.Dt_date.TabIndex = 47;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(280, 101);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 21);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "التــاريــــخ";
            // 
            // txt_Small_Counter
            // 
            this.txt_Small_Counter.EditValue = "";
            this.txt_Small_Counter.Location = new System.Drawing.Point(402, 98);
            this.txt_Small_Counter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Small_Counter.Name = "txt_Small_Counter";
            this.txt_Small_Counter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Small_Counter.Properties.Appearance.Options.UseFont = true;
            this.txt_Small_Counter.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Small_Counter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Small_Counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Small_Counter.Size = new System.Drawing.Size(264, 30);
            this.txt_Small_Counter.TabIndex = 42;
            // 
            // txt_Big_Counter
            // 
            this.txt_Big_Counter.EditValue = "";
            this.txt_Big_Counter.Location = new System.Drawing.Point(10, 42);
            this.txt_Big_Counter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Big_Counter.Name = "txt_Big_Counter";
            this.txt_Big_Counter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Big_Counter.Properties.Appearance.Options.UseFont = true;
            this.txt_Big_Counter.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Big_Counter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Big_Counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Big_Counter.Size = new System.Drawing.Size(264, 30);
            this.txt_Big_Counter.TabIndex = 43;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(280, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 21);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "العداد الكبيـــر";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(672, 101);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 21);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "العداد الصغيـر";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(673, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 21);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "رقم السيـــارة";
            // 
            // panel_btn
            // 
            this.panel_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_btn.Controls.Add(this.btn_Edit);
            this.panel_btn.Controls.Add(this.simpleButton1);
            this.panel_btn.Controls.Add(this.labelControl9);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(19, 361);
            this.panel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(787, 89);
            this.panel_btn.TabIndex = 70;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(226, 25);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(148, 43);
            this.btn_Edit.TabIndex = 72;
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
            this.btn_New.Location = new System.Drawing.Point(583, 25);
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(147, 42);
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
            this.btn_Exit.Location = new System.Drawing.Point(56, 25);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 42);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(404, 25);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(147, 42);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(157, 58);
            this.grb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(509, 112);
            this.grb_Search.TabIndex = 71;
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
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(87, 92);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 21);
            this.lbl_ID.TabIndex = 72;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // lbl_Big_Mini
            // 
            this.lbl_Big_Mini.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Big_Mini.Appearance.Options.UseFont = true;
            this.lbl_Big_Mini.Location = new System.Drawing.Point(708, 89);
            this.lbl_Big_Mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_Big_Mini.Name = "lbl_Big_Mini";
            this.lbl_Big_Mini.Size = new System.Drawing.Size(11, 21);
            this.lbl_Big_Mini.TabIndex = 73;
            this.lbl_Big_Mini.Text = "0";
            this.lbl_Big_Mini.Visible = false;
            // 
            // lbl_Small_Mini
            // 
            this.lbl_Small_Mini.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Small_Mini.Appearance.Options.UseFont = true;
            this.lbl_Small_Mini.Location = new System.Drawing.Point(708, 135);
            this.lbl_Small_Mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_Small_Mini.Name = "lbl_Small_Mini";
            this.lbl_Small_Mini.Size = new System.Drawing.Size(11, 21);
            this.lbl_Small_Mini.TabIndex = 74;
            this.lbl_Small_Mini.Text = "0";
            this.lbl_Small_Mini.Visible = false;
            // 
            // CurrentlyCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 466);
            this.Controls.Add(this.lbl_Small_Mini);
            this.Controls.Add(this.lbl_Big_Mini);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentlyCounterForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــة تسجيــل القراءة الحاليـــة للعــدادات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentlyCounterForm_FormClosed);
            this.Load += new System.EventHandler(this.CurrentlyCounterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_CarNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Small_Counter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Big_Counter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.panel_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.TextEdit txt_Small_Counter;
        private DevExpress.XtraEditors.TextEdit txt_Big_Counter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit Dt_date;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        private DevExpress.XtraEditors.LabelControl lbl_Big_Mini;
        private DevExpress.XtraEditors.LabelControl lbl_Small_Mini;
        private DevExpress.XtraEditors.LookUpEdit com_CarNo;
    }
}