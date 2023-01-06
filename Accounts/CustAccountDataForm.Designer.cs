
namespace CarApp.Accounts
{
    partial class CustAccountDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustAccountDataForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb_Account = new DevExpress.XtraEditors.GroupControl();
            this.Dt_Date = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPayedValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemainValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Account)).BeginInit();
            this.grb_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(469, 30);
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(12, 357);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(445, 54);
            this.panel_btn.TabIndex = 81;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(299, 10);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 35);
            this.btn_New.TabIndex = 7;
            this.btn_New.Text = "جديـد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(19, 9);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(126, 34);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(159, 10);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 35);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grb_Account
            // 
            this.grb_Account.Controls.Add(this.Dt_Date);
            this.grb_Account.Controls.Add(this.labelControl5);
            this.grb_Account.Controls.Add(this.txtPayedValue);
            this.grb_Account.Controls.Add(this.labelControl3);
            this.grb_Account.Controls.Add(this.txtRemainValue);
            this.grb_Account.Controls.Add(this.labelControl6);
            this.grb_Account.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Account.Location = new System.Drawing.Point(31, 152);
            this.grb_Account.Name = "grb_Account";
            this.grb_Account.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Account.Size = new System.Drawing.Size(407, 193);
            this.grb_Account.TabIndex = 80;
            this.grb_Account.Text = "تسجيل المدفوعات";
            // 
            // Dt_Date
            // 
            this.Dt_Date.EditValue = null;
            this.Dt_Date.Location = new System.Drawing.Point(21, 137);
            this.Dt_Date.Name = "Dt_Date";
            this.Dt_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Date.Size = new System.Drawing.Size(265, 26);
            this.Dt_Date.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(292, 143);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 17);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "التـاريـــــــــــخ";
            // 
            // txtPayedValue
            // 
            this.txtPayedValue.EditValue = "0";
            this.txtPayedValue.Location = new System.Drawing.Point(21, 93);
            this.txtPayedValue.Name = "txtPayedValue";
            this.txtPayedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayedValue.Properties.Appearance.Options.UseFont = true;
            this.txtPayedValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPayedValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPayedValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPayedValue.Properties.MaskSettings.Set("mask", "f");
            this.txtPayedValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPayedValue.Size = new System.Drawing.Size(265, 26);
            this.txtPayedValue.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(292, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 17);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "المبلغ المدفوع";
            // 
            // txtRemainValue
            // 
            this.txtRemainValue.EditValue = "0";
            this.txtRemainValue.Location = new System.Drawing.Point(21, 41);
            this.txtRemainValue.Name = "txtRemainValue";
            this.txtRemainValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtRemainValue.Properties.Appearance.Options.UseFont = true;
            this.txtRemainValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRemainValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRemainValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtRemainValue.Properties.MaskSettings.Set("mask", "f");
            this.txtRemainValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemainValue.Size = new System.Drawing.Size(265, 26);
            this.txtRemainValue.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(292, 44);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(93, 17);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "المبلغ المتبقي";
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(30, 48);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(408, 91);
            this.grb_Search.TabIndex = 79;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(14, 42);
            this.com_Search.MenuManager = this.ribbon;
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
            this.com_Search.Size = new System.Drawing.Size(265, 26);
            this.com_Search.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(285, 34);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 36);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // CustAccountDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 427);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb_Account);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustAccountDataForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــة مدفوعـــات العمـــلاء";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustAccountDataForm_FormClosed);
            this.Load += new System.EventHandler(this.CustAccountDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grb_Account)).EndInit();
            this.grb_Account.ResumeLayout(false);
            this.grb_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.GroupControl grb_Account;
        private DevExpress.XtraEditors.DateEdit Dt_Date;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPayedValue;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRemainValue;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
    }
}