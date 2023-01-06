namespace CarApp.Reportes
{
    partial class OffersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffersForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.Com_Car_Type = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_Notes = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Shift_Go_Back = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Shift_system = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Offer_To = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Com_Car_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Notes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_Go_Back.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_system.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Offer_To.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
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
            this.ribbon.Size = new System.Drawing.Size(1005, 30);
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.Com_Car_Type);
            this.grb__Record.Controls.Add(this.txt_Notes);
            this.grb__Record.Controls.Add(this.labelControl6);
            this.grb__Record.Controls.Add(this.txt_Shift_Go_Back);
            this.grb__Record.Controls.Add(this.labelControl5);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.txt_Shift_system);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.labelControl4);
            this.grb__Record.Controls.Add(this.txt_Offer_To);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(10, 145);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(985, 219);
            this.grb__Record.TabIndex = 19;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // Com_Car_Type
            // 
            this.Com_Car_Type.Location = new System.Drawing.Point(14, 37);
            this.Com_Car_Type.Name = "Com_Car_Type";
            this.Com_Car_Type.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Com_Car_Type.Properties.Appearance.Options.UseFont = true;
            this.Com_Car_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Com_Car_Type.Properties.NullText = "";
            this.Com_Car_Type.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.Com_Car_Type.Properties.ShowHeader = false;
            this.Com_Car_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Com_Car_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Car_Type.Size = new System.Drawing.Size(398, 30);
            this.Com_Car_Type.TabIndex = 33;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(14, 123);
            this.txt_Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Notes.MenuManager = this.ribbon;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Properties.Appearance.Options.UseFont = true;
            this.txt_Notes.Size = new System.Drawing.Size(859, 78);
            this.txt_Notes.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(876, 90);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 17);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "(ذهاب وعودة)";
            // 
            // txt_Shift_Go_Back
            // 
            this.txt_Shift_Go_Back.Location = new System.Drawing.Point(507, 76);
            this.txt_Shift_Go_Back.Name = "txt_Shift_Go_Back";
            this.txt_Shift_Go_Back.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Shift_Go_Back.Properties.Appearance.Options.UseFont = true;
            this.txt_Shift_Go_Back.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Shift_Go_Back.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Shift_Go_Back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Shift_Go_Back.Size = new System.Drawing.Size(365, 30);
            this.txt_Shift_Go_Back.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(884, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "وردية نهاري";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(417, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "نوع السيارة";
            // 
            // txt_Shift_system
            // 
            this.txt_Shift_system.Location = new System.Drawing.Point(14, 76);
            this.txt_Shift_system.Name = "txt_Shift_system";
            this.txt_Shift_system.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Shift_system.Properties.Appearance.Options.UseFont = true;
            this.txt_Shift_system.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Shift_system.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Shift_system.Properties.Mask.BeepOnError = true;
            this.txt_Shift_system.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Shift_system.Size = new System.Drawing.Size(399, 30);
            this.txt_Shift_system.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(413, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 17);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "نظام ورديتين";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(884, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 17);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "ملاحظـــــات";
            // 
            // txt_Offer_To
            // 
            this.txt_Offer_To.Location = new System.Drawing.Point(507, 36);
            this.txt_Offer_To.Name = "txt_Offer_To";
            this.txt_Offer_To.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Offer_To.Properties.Appearance.Options.UseFont = true;
            this.txt_Offer_To.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Offer_To.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Offer_To.Properties.Mask.BeepOnError = true;
            this.txt_Offer_To.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_Offer_To.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_Offer_To.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Offer_To.Size = new System.Drawing.Size(365, 30);
            this.txt_Offer_To.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(882, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 17);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "الســـــــــــادة";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(825, 69);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(8, 16);
            this.lbl_ID.TabIndex = 77;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(242, 47);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(522, 91);
            this.grb_Search.TabIndex = 75;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(366, 39);
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
            this.com_Search.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_Search.Properties.Appearance.Options.UseFont = true;
            this.com_Search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.com_Search.Properties.NullText = "";
            this.com_Search.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Search.Properties.ShowHeader = false;
            this.com_Search.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Search.Size = new System.Drawing.Size(292, 30);
            this.com_Search.TabIndex = 20;
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
            this.panel_btn.Location = new System.Drawing.Point(131, 381);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(743, 72);
            this.panel_btn.TabIndex = 78;
            // 
            // btn_Print
            // 
            this.btn_Print.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Print.Appearance.Options.UseFont = true;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
            this.btn_Print.Location = new System.Drawing.Point(164, 20);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(127, 35);
            this.btn_Print.TabIndex = 76;
            this.btn_Print.Text = "طباعــــة  ";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(309, 20);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 35);
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
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(599, 20);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 35);
            this.btn_New.TabIndex = 11;
            this.btn_New.Text = "جديـد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
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
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(456, 20);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 35);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // OffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 468);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OffersForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعـــة عـــروض الأسعــــار";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OffersForm_FormClosed);
            this.Load += new System.EventHandler(this.OffersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Com_Car_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Notes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_Go_Back.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Shift_system.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Offer_To.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.panel_btn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Shift_system;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Offer_To;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Shift_Go_Back;
        private DevExpress.XtraEditors.MemoEdit txt_Notes;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.LookUpEdit Com_Car_Type;
    }
}