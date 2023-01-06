
namespace CarApp.Forms
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb_Search = new DevExpress.XtraEditors.GroupControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.txt_Custaddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CustName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Custaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CustName.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(868, 32);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(173, 46);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(522, 91);
            this.grb_Search.TabIndex = 39;
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
            this.com_Search.Properties.NullText = "";
            this.com_Search.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.com_Search.Properties.ShowHeader = false;
            this.com_Search.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.com_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Search.Size = new System.Drawing.Size(292, 26);
            this.com_Search.TabIndex = 20;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_New);
            this.panelControl1.Controls.Add(this.btn_Exit);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_Edit);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Location = new System.Drawing.Point(65, 257);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(738, 72);
            this.panelControl1.TabIndex = 41;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(596, 19);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 35);
            this.btn_New.TabIndex = 42;
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
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.txt_Custaddress);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.txt_CustName);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(15, 151);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(838, 82);
            this.grb__Record.TabIndex = 40;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // txt_Custaddress
            // 
            this.txt_Custaddress.Location = new System.Drawing.Point(14, 39);
            this.txt_Custaddress.Name = "txt_Custaddress";
            this.txt_Custaddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Custaddress.Properties.Appearance.Options.UseFont = true;
            this.txt_Custaddress.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Custaddress.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Custaddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Custaddress.Size = new System.Drawing.Size(292, 26);
            this.txt_Custaddress.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(316, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "العنــــوان";
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(441, 43);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_CustName.Properties.Appearance.Options.UseFont = true;
            this.txt_CustName.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_CustName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_CustName.Properties.Mask.BeepOnError = true;
            this.txt_CustName.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txt_CustName.Properties.MaskSettings.Set("ignoreMaskBlank", false);
            this.txt_CustName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CustName.Size = new System.Drawing.Size(291, 26);
            this.txt_CustName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(738, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 17);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "اسم العميــل";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(778, 91);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(8, 16);
            this.lbl_ID.TabIndex = 42;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 343);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــة تسجيـــل بيانـــات العمـــلاء";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomersForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Custaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CustName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraEditors.GroupControl grb_Search;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Delete;
        public DevExpress.XtraEditors.SimpleButton btn_Edit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.TextEdit txt_Custaddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_CustName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
    }
}