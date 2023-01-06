
namespace CarApp.Accounts
{
    partial class CustAccountPopUpForm
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
            this.dgv_ShowVenAccount = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cust_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Payed_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remain_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date_Payed = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowVenAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(814, 30);
            // 
            // dgv_ShowVenAccount
            // 
            this.dgv_ShowVenAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ShowVenAccount.Location = new System.Drawing.Point(0, 30);
            this.dgv_ShowVenAccount.MainView = this.gridView1;
            this.dgv_ShowVenAccount.MenuManager = this.ribbon;
            this.dgv_ShowVenAccount.Name = "dgv_ShowVenAccount";
            this.dgv_ShowVenAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_ShowVenAccount.Size = new System.Drawing.Size(814, 462);
            this.dgv_ShowVenAccount.TabIndex = 4;
            this.dgv_ShowVenAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.FontSizeDelta = 2;
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("El Messiri SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.gridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cust_Name,
            this.Payed_Value,
            this.Remain_value,
            this.Date_Payed});
            this.gridView1.GridControl = this.dgv_ShowVenAccount;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Cust_Name
            // 
            this.Cust_Name.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_Name.AppearanceCell.Options.UseFont = true;
            this.Cust_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Cust_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cust_Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Cust_Name.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_Name.AppearanceHeader.Options.UseFont = true;
            this.Cust_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Cust_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cust_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Cust_Name.Caption = "اسم العميـــل";
            this.Cust_Name.FieldName = "Cust_Name";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.Visible = true;
            this.Cust_Name.VisibleIndex = 0;
            // 
            // Payed_Value
            // 
            this.Payed_Value.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Payed_Value.AppearanceCell.Options.UseFont = true;
            this.Payed_Value.AppearanceCell.Options.UseTextOptions = true;
            this.Payed_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Payed_Value.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Payed_Value.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Payed_Value.AppearanceHeader.Options.UseFont = true;
            this.Payed_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Payed_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Payed_Value.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Payed_Value.Caption = "المبلغ المدفوع";
            this.Payed_Value.FieldName = "Payed_Value";
            this.Payed_Value.Name = "Payed_Value";
            this.Payed_Value.Visible = true;
            this.Payed_Value.VisibleIndex = 1;
            // 
            // Remain_value
            // 
            this.Remain_value.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Remain_value.AppearanceCell.Options.UseFont = true;
            this.Remain_value.AppearanceCell.Options.UseTextOptions = true;
            this.Remain_value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Remain_value.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Remain_value.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Remain_value.AppearanceHeader.Options.UseFont = true;
            this.Remain_value.AppearanceHeader.Options.UseTextOptions = true;
            this.Remain_value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Remain_value.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Remain_value.Caption = "المبلغ المتبقي";
            this.Remain_value.FieldName = "Remain_value";
            this.Remain_value.Name = "Remain_value";
            this.Remain_value.Visible = true;
            this.Remain_value.VisibleIndex = 2;
            // 
            // Date_Payed
            // 
            this.Date_Payed.AppearanceCell.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.Date_Payed.AppearanceCell.Options.UseFont = true;
            this.Date_Payed.AppearanceCell.Options.UseTextOptions = true;
            this.Date_Payed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date_Payed.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Date_Payed.AppearanceHeader.Font = new System.Drawing.Font("El Messiri SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Date_Payed.AppearanceHeader.Options.UseFont = true;
            this.Date_Payed.AppearanceHeader.Options.UseTextOptions = true;
            this.Date_Payed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date_Payed.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Date_Payed.Caption = "تاريخ السداد";
            this.Date_Payed.FieldName = "Date_Payed";
            this.Date_Payed.Name = "Date_Payed";
            this.Date_Payed.Visible = true;
            this.Date_Payed.VisibleIndex = 3;
            // 
            // CustAccountPopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.dgv_ShowVenAccount);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustAccountPopUpForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــة عـرض كشــف حسابــات العمـــــلاء";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustAccountPopUpForm_FormClosed);
            this.Load += new System.EventHandler(this.CustAccountPopUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowVenAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraGrid.GridControl dgv_ShowVenAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Cust_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Payed_Value;
        private DevExpress.XtraGrid.Columns.GridColumn Remain_value;
        private DevExpress.XtraGrid.Columns.GridColumn Date_Payed;
    }
}