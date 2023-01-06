﻿namespace CarApp.Accounts
{
    partial class BalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb__Record = new DevExpress.XtraEditors.GroupControl();
            this.com_CompName = new DevExpress.XtraEditors.LookUpEdit();
            this.Dt_Balance_Date = new DevExpress.XtraEditors.DateEdit();
            this.txt_Balance = new DevExpress.XtraEditors.TextEdit();
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
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Balance = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Balance_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Com_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Balance_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).BeginInit();
            this.grb__Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_CompName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Balance_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Balance_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Balance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).BeginInit();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Balance)).BeginInit();
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
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(626, 32);
            // 
            // grb__Record
            // 
            this.grb__Record.AutoSize = true;
            this.grb__Record.Controls.Add(this.com_CompName);
            this.grb__Record.Controls.Add(this.Dt_Balance_Date);
            this.grb__Record.Controls.Add(this.txt_Balance);
            this.grb__Record.Controls.Add(this.labelControl2);
            this.grb__Record.Controls.Add(this.labelControl3);
            this.grb__Record.Controls.Add(this.labelControl1);
            this.grb__Record.Location = new System.Drawing.Point(14, 38);
            this.grb__Record.Name = "grb__Record";
            this.grb__Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb__Record.Size = new System.Drawing.Size(436, 183);
            this.grb__Record.TabIndex = 27;
            this.grb__Record.Text = "عمليات التسجيل";
            // 
            // com_CompName
            // 
            this.com_CompName.Location = new System.Drawing.Point(24, 43);
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
            this.com_CompName.Size = new System.Drawing.Size(282, 26);
            this.com_CompName.TabIndex = 0;
            // 
            // Dt_Balance_Date
            // 
            this.Dt_Balance_Date.EditValue = null;
            this.Dt_Balance_Date.Location = new System.Drawing.Point(24, 130);
            this.Dt_Balance_Date.Name = "Dt_Balance_Date";
            this.Dt_Balance_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Balance_Date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Balance_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Balance_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Balance_Date.Properties.MaskSettings.Set("mask", "d");
            this.Dt_Balance_Date.Properties.UseMaskAsDisplayFormat = true;
            this.Dt_Balance_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Balance_Date.Size = new System.Drawing.Size(282, 26);
            this.Dt_Balance_Date.TabIndex = 2;
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(24, 87);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Balance.Properties.Appearance.Options.UseFont = true;
            this.txt_Balance.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_Balance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_Balance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Balance.Size = new System.Drawing.Size(282, 26);
            this.txt_Balance.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(311, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "العائـد الشهـري";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(320, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 17);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "تاريخ الإستلام";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(312, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 17);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "إسـم الشركــــة";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(2, 161);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(8, 16);
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
            this.panel_btn.Location = new System.Drawing.Point(456, 38);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(157, 280);
            this.panel_btn.TabIndex = 28;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(15, 18);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 35);
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
            this.btn_Delete.Location = new System.Drawing.Point(15, 176);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 34);
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
            this.btn_Exit.Location = new System.Drawing.Point(16, 228);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(126, 34);
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
            this.btn_Edit.Location = new System.Drawing.Point(15, 123);
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
            this.btn_Save.Location = new System.Drawing.Point(15, 72);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 35);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.com_Search);
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_Search.Location = new System.Drawing.Point(14, 227);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(436, 91);
            this.grb_Search.TabIndex = 36;
            this.grb_Search.Text = "عمليات البحث";
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(24, 41);
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
            this.com_Search.Size = new System.Drawing.Size(273, 26);
            this.com_Search.TabIndex = 33;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(303, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 36);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_Balance);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 324);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(626, 194);
            this.groupControl2.TabIndex = 73;
            this.groupControl2.Text = "عرض الرصيـــــــد";
            // 
            // dgv_Balance
            // 
            this.dgv_Balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Balance.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Balance.Location = new System.Drawing.Point(2, 23);
            this.dgv_Balance.MainView = this.gridView1;
            this.dgv_Balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Balance.Name = "dgv_Balance";
            this.dgv_Balance.Size = new System.Drawing.Size(622, 169);
            this.dgv_Balance.TabIndex = 0;
            this.dgv_Balance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Balance_ID,
            this.Com_Name,
            this.Balance,
            this.Balance_Date});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.dgv_Balance;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.Balance_Date, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Balance_ID
            // 
            this.Balance_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Balance_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Balance_ID.AppearanceHeader.Options.UseFont = true;
            this.Balance_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Balance_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance_ID.Caption = "Balance_ID";
            this.Balance_ID.FieldName = "Balance_ID";
            this.Balance_ID.MinWidth = 21;
            this.Balance_ID.Name = "Balance_ID";
            this.Balance_ID.Width = 81;
            // 
            // Com_Name
            // 
            this.Com_Name.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Com_Name.AppearanceCell.Options.UseFont = true;
            this.Com_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Com_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Com_Name.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Com_Name.AppearanceHeader.Options.UseFont = true;
            this.Com_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Com_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Com_Name.Caption = "إســم الشركــــة";
            this.Com_Name.FieldName = "Com_Name";
            this.Com_Name.MinWidth = 21;
            this.Com_Name.Name = "Com_Name";
            this.Com_Name.Visible = true;
            this.Com_Name.VisibleIndex = 0;
            this.Com_Name.Width = 81;
            // 
            // Balance
            // 
            this.Balance.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Balance.AppearanceCell.Options.UseFont = true;
            this.Balance.AppearanceCell.Options.UseTextOptions = true;
            this.Balance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Balance.AppearanceHeader.Options.UseFont = true;
            this.Balance.AppearanceHeader.Options.UseTextOptions = true;
            this.Balance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance.Caption = "الرصيــــــــد";
            this.Balance.FieldName = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance", "اجمالي الرصيد = {0:}")});
            this.Balance.Visible = true;
            this.Balance.VisibleIndex = 1;
            this.Balance.Width = 64;
            // 
            // Balance_Date
            // 
            this.Balance_Date.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Balance_Date.AppearanceCell.Options.UseFont = true;
            this.Balance_Date.AppearanceCell.Options.UseTextOptions = true;
            this.Balance_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance_Date.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Balance_Date.AppearanceHeader.Options.UseFont = true;
            this.Balance_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.Balance_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance_Date.Caption = "تاريـخ الإستـــلام";
            this.Balance_Date.FieldName = "Balance_Date";
            this.Balance_Date.MinWidth = 21;
            this.Balance_Date.Name = "Balance_Date";
            this.Balance_Date.Visible = true;
            this.Balance_Date.VisibleIndex = 2;
            this.Balance_Date.Width = 81;
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 518);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb__Record);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BalanceForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــــة الرصيـــــــــــــــد";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BalanceForm_FormClosed);
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb__Record)).EndInit();
            this.grb__Record.ResumeLayout(false);
            this.grb__Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_CompName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Balance_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Balance_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Balance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grb_Search)).EndInit();
            this.grb_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl grb__Record;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        private DevExpress.XtraEditors.LookUpEdit com_CompName;
        private DevExpress.XtraEditors.DateEdit Dt_Balance_Date;
        private DevExpress.XtraEditors.TextEdit txt_Balance;
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_Balance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Balance_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Com_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Balance;
        private DevExpress.XtraGrid.Columns.GridColumn Balance_Date;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
    }
}