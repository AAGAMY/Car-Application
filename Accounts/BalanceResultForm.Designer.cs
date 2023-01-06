namespace CarApp.Accounts
{
    partial class BalanceResultForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_BalanceResult = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BalanceResutl_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompaniesTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransformTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DriversTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaintenanceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VendorsTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvestorsTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomersTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OverTimeRemainingTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BalanceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceResult)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1456, 36);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_BalanceResult);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 36);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(1456, 651);
            this.groupControl2.TabIndex = 76;
            this.groupControl2.Text = "كشف حسابات المصروفات والأربـــاح";
            // 
            // dgv_BalanceResult
            // 
            this.dgv_BalanceResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BalanceResult.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_BalanceResult.Location = new System.Drawing.Point(2, 33);
            this.dgv_BalanceResult.MainView = this.gridView1;
            this.dgv_BalanceResult.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_BalanceResult.Name = "dgv_BalanceResult";
            this.dgv_BalanceResult.Size = new System.Drawing.Size(1452, 616);
            this.dgv_BalanceResult.TabIndex = 0;
            this.dgv_BalanceResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.BalanceResutl_ID,
            this.CompaniesTotal,
            this.TransformTotal,
            this.DriversTotal,
            this.MaintenanceTotal,
            this.VendorsTotal,
            this.InvestorsTotal,
            this.CustomersTotal,
            this.OverTimeRemainingTotal,
            this.BalanceTotal});
            this.gridView1.GridControl = this.dgv_BalanceResult;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.MaintenanceTotal, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BalanceResutl_ID
            // 
            this.BalanceResutl_ID.AppearanceCell.Options.UseTextOptions = true;
            this.BalanceResutl_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BalanceResutl_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BalanceResutl_ID.AppearanceHeader.Options.UseFont = true;
            this.BalanceResutl_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.BalanceResutl_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BalanceResutl_ID.Caption = "BalanceResutl_ID";
            this.BalanceResutl_ID.FieldName = "BalanceResutl_ID";
            this.BalanceResutl_ID.MinWidth = 24;
            this.BalanceResutl_ID.Name = "BalanceResutl_ID";
            this.BalanceResutl_ID.Width = 94;
            // 
            // CompaniesTotal
            // 
            this.CompaniesTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.CompaniesTotal.AppearanceCell.Options.UseFont = true;
            this.CompaniesTotal.AppearanceCell.Options.UseTextOptions = true;
            this.CompaniesTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompaniesTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.CompaniesTotal.AppearanceHeader.Options.UseFont = true;
            this.CompaniesTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.CompaniesTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompaniesTotal.Caption = "مرتبات الشركات";
            this.CompaniesTotal.FieldName = "CompaniesTotal";
            this.CompaniesTotal.MinWidth = 24;
            this.CompaniesTotal.Name = "CompaniesTotal";
            this.CompaniesTotal.Visible = true;
            this.CompaniesTotal.VisibleIndex = 0;
            this.CompaniesTotal.Width = 160;
            // 
            // TransformTotal
            // 
            this.TransformTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransformTotal.AppearanceCell.Options.UseFont = true;
            this.TransformTotal.AppearanceCell.Options.UseTextOptions = true;
            this.TransformTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TransformTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransformTotal.AppearanceHeader.Options.UseFont = true;
            this.TransformTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.TransformTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TransformTotal.Caption = "مرتبات مكاتب النقل";
            this.TransformTotal.FieldName = "TransformTotal";
            this.TransformTotal.MinWidth = 24;
            this.TransformTotal.Name = "TransformTotal";
            this.TransformTotal.Visible = true;
            this.TransformTotal.VisibleIndex = 1;
            this.TransformTotal.Width = 160;
            // 
            // DriversTotal
            // 
            this.DriversTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.DriversTotal.AppearanceCell.Options.UseFont = true;
            this.DriversTotal.AppearanceCell.Options.UseTextOptions = true;
            this.DriversTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DriversTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DriversTotal.AppearanceHeader.Options.UseFont = true;
            this.DriversTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.DriversTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DriversTotal.Caption = "مرتبات السائقين";
            this.DriversTotal.FieldName = "DriversTotal";
            this.DriversTotal.MinWidth = 23;
            this.DriversTotal.Name = "DriversTotal";
            this.DriversTotal.Visible = true;
            this.DriversTotal.VisibleIndex = 2;
            this.DriversTotal.Width = 126;
            // 
            // MaintenanceTotal
            // 
            this.MaintenanceTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.MaintenanceTotal.AppearanceCell.Options.UseFont = true;
            this.MaintenanceTotal.AppearanceCell.Options.UseTextOptions = true;
            this.MaintenanceTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaintenanceTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.MaintenanceTotal.AppearanceHeader.Options.UseFont = true;
            this.MaintenanceTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.MaintenanceTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaintenanceTotal.Caption = "مصروفات الصيانة";
            this.MaintenanceTotal.FieldName = "MaintenanceTotal";
            this.MaintenanceTotal.MinWidth = 24;
            this.MaintenanceTotal.Name = "MaintenanceTotal";
            this.MaintenanceTotal.Visible = true;
            this.MaintenanceTotal.VisibleIndex = 3;
            this.MaintenanceTotal.Width = 160;
            // 
            // VendorsTotal
            // 
            this.VendorsTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.VendorsTotal.AppearanceCell.Options.UseFont = true;
            this.VendorsTotal.AppearanceCell.Options.UseTextOptions = true;
            this.VendorsTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorsTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.VendorsTotal.AppearanceHeader.Options.UseFont = true;
            this.VendorsTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.VendorsTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorsTotal.Caption = "مدفوعات الموردين";
            this.VendorsTotal.FieldName = "VendorsTotal";
            this.VendorsTotal.MinWidth = 24;
            this.VendorsTotal.Name = "VendorsTotal";
            this.VendorsTotal.Visible = true;
            this.VendorsTotal.VisibleIndex = 4;
            this.VendorsTotal.Width = 160;
            // 
            // InvestorsTotal
            // 
            this.InvestorsTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.InvestorsTotal.AppearanceCell.Options.UseFont = true;
            this.InvestorsTotal.AppearanceCell.Options.UseTextOptions = true;
            this.InvestorsTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.InvestorsTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.InvestorsTotal.AppearanceHeader.Options.UseFont = true;
            this.InvestorsTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.InvestorsTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.InvestorsTotal.Caption = "مدفوعات المستثمرين";
            this.InvestorsTotal.FieldName = "InvestorsTotal";
            this.InvestorsTotal.MinWidth = 24;
            this.InvestorsTotal.Name = "InvestorsTotal";
            this.InvestorsTotal.Visible = true;
            this.InvestorsTotal.VisibleIndex = 5;
            this.InvestorsTotal.Width = 160;
            // 
            // CustomersTotal
            // 
            this.CustomersTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.CustomersTotal.AppearanceCell.Options.UseFont = true;
            this.CustomersTotal.AppearanceCell.Options.UseTextOptions = true;
            this.CustomersTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustomersTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.CustomersTotal.AppearanceHeader.Options.UseFont = true;
            this.CustomersTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.CustomersTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustomersTotal.Caption = "مكاسب البيع";
            this.CustomersTotal.FieldName = "CustomersTotal";
            this.CustomersTotal.MinWidth = 24;
            this.CustomersTotal.Name = "CustomersTotal";
            this.CustomersTotal.Visible = true;
            this.CustomersTotal.VisibleIndex = 6;
            this.CustomersTotal.Width = 128;
            // 
            // OverTimeRemainingTotal
            // 
            this.OverTimeRemainingTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.OverTimeRemainingTotal.AppearanceCell.Options.UseFont = true;
            this.OverTimeRemainingTotal.AppearanceCell.Options.UseTextOptions = true;
            this.OverTimeRemainingTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OverTimeRemainingTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.OverTimeRemainingTotal.AppearanceHeader.Options.UseFont = true;
            this.OverTimeRemainingTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.OverTimeRemainingTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OverTimeRemainingTotal.Caption = "وردية أضافية";
            this.OverTimeRemainingTotal.FieldName = "OverTimeRemainingTotal";
            this.OverTimeRemainingTotal.MinWidth = 23;
            this.OverTimeRemainingTotal.Name = "OverTimeRemainingTotal";
            this.OverTimeRemainingTotal.Visible = true;
            this.OverTimeRemainingTotal.VisibleIndex = 7;
            this.OverTimeRemainingTotal.Width = 161;
            // 
            // BalanceTotal
            // 
            this.BalanceTotal.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.BalanceTotal.AppearanceCell.Options.UseFont = true;
            this.BalanceTotal.AppearanceCell.Options.UseTextOptions = true;
            this.BalanceTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BalanceTotal.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.BalanceTotal.AppearanceHeader.Options.UseFont = true;
            this.BalanceTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.BalanceTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BalanceTotal.Caption = "صافي الربح";
            this.BalanceTotal.FieldName = "BalanceTotal";
            this.BalanceTotal.MinWidth = 24;
            this.BalanceTotal.Name = "BalanceTotal";
            this.BalanceTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceTotal", "اجمالي الربح = {0:}")});
            this.BalanceTotal.Visible = true;
            this.BalanceTotal.VisibleIndex = 8;
            this.BalanceTotal.Width = 210;
            // 
            // BalanceResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 687);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BalanceResultForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشـــة المصروفات والأربـــاح";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BalanceResultForm_FormClosed);
            this.Load += new System.EventHandler(this.BalanceResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgv_BalanceResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BalanceResutl_ID;
        private DevExpress.XtraGrid.Columns.GridColumn TransformTotal;
        private DevExpress.XtraGrid.Columns.GridColumn DriversTotal;
        private DevExpress.XtraGrid.Columns.GridColumn MaintenanceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn VendorsTotal;
        private DevExpress.XtraGrid.Columns.GridColumn InvestorsTotal;
        private DevExpress.XtraGrid.Columns.GridColumn CustomersTotal;
        private DevExpress.XtraGrid.Columns.GridColumn BalanceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn CompaniesTotal;
        private DevExpress.XtraGrid.Columns.GridColumn OverTimeRemainingTotal;
    }
}