
namespace CarApp.Operations
{
    partial class SalesDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDataForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grb_ItemDetails = new DevExpress.XtraEditors.GroupControl();
            this.lbl_SalDetID = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Com_ItemName = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grb_vendetail = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Com_CustName = new DevExpress.XtraEditors.LookUpEdit();
            this.Dt_Date = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Items = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_btn = new DevExpress.XtraEditors.PanelControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.com_Search = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.grb_InvoPrice = new DevExpress.XtraEditors.GroupControl();
            this.txtRemaining = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPayed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_ItemDetails)).BeginInit();
            this.grb_ItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Com_ItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_vendetail)).BeginInit();
            this.grb_vendetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Com_CustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_InvoPrice)).BeginInit();
            this.grb_InvoPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemaining.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(996, 36);
            // 
            // grb_ItemDetails
            // 
            this.grb_ItemDetails.Controls.Add(this.lbl_SalDetID);
            this.grb_ItemDetails.Controls.Add(this.lbl_ID);
            this.grb_ItemDetails.Controls.Add(this.txtValue);
            this.grb_ItemDetails.Controls.Add(this.labelControl5);
            this.grb_ItemDetails.Controls.Add(this.txtQuantity);
            this.grb_ItemDetails.Controls.Add(this.labelControl3);
            this.grb_ItemDetails.Controls.Add(this.Com_ItemName);
            this.grb_ItemDetails.Controls.Add(this.txtPrice);
            this.grb_ItemDetails.Controls.Add(this.labelControl1);
            this.grb_ItemDetails.Controls.Add(this.labelControl6);
            this.grb_ItemDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_ItemDetails.Location = new System.Drawing.Point(16, 146);
            this.grb_ItemDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_ItemDetails.Name = "grb_ItemDetails";
            this.grb_ItemDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_ItemDetails.Size = new System.Drawing.Size(965, 153);
            this.grb_ItemDetails.TabIndex = 67;
            this.grb_ItemDetails.Text = "تسجيل بيانات الأصناف";
            // 
            // lbl_SalDetID
            // 
            this.lbl_SalDetID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_SalDetID.Appearance.Options.UseFont = true;
            this.lbl_SalDetID.Location = new System.Drawing.Point(493, 12);
            this.lbl_SalDetID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_SalDetID.Name = "lbl_SalDetID";
            this.lbl_SalDetID.Size = new System.Drawing.Size(11, 21);
            this.lbl_SalDetID.TabIndex = 79;
            this.lbl_SalDetID.Text = "0";
            this.lbl_SalDetID.Visible = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(460, 12);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 21);
            this.lbl_ID.TabIndex = 78;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // txtValue
            // 
            this.txtValue.EditValue = "0";
            this.txtValue.Location = new System.Drawing.Point(7, 95);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtValue.Properties.Appearance.Options.UseFont = true;
            this.txtValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValue.Properties.MaskSettings.Set("mask", "f");
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValue.Size = new System.Drawing.Size(218, 30);
            this.txtValue.TabIndex = 6;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(232, 98);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 21);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "القيمة";
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = "0";
            this.txtQuantity.Location = new System.Drawing.Point(316, 95);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtQuantity.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtQuantity.Properties.MaskSettings.Set("placeholder", '0');
            this.txtQuantity.Properties.UseMaskAsDisplayFormat = true;
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.Size = new System.Drawing.Size(218, 30);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(541, 98);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 21);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "الكمية";
            // 
            // Com_ItemName
            // 
            this.Com_ItemName.Location = new System.Drawing.Point(8, 41);
            this.Com_ItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Com_ItemName.MenuManager = this.ribbon;
            this.Com_ItemName.Name = "Com_ItemName";
            this.Com_ItemName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Com_ItemName.Properties.Appearance.Options.UseFont = true;
            this.Com_ItemName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Com_ItemName.Properties.NullText = "";
            this.Com_ItemName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.Com_ItemName.Properties.ShowHeader = false;
            this.Com_ItemName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Com_ItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_ItemName.Size = new System.Drawing.Size(834, 30);
            this.Com_ItemName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = "0";
            this.txtPrice.Location = new System.Drawing.Point(624, 95);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("mask", "f");
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(218, 30);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.EditValueChanged += new System.EventHandler(this.txtPrice_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(849, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "اســم الصنف";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(849, 98);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 21);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "سعر الصنف";
            // 
            // grb_vendetail
            // 
            this.grb_vendetail.Controls.Add(this.labelControl11);
            this.grb_vendetail.Controls.Add(this.Com_CustName);
            this.grb_vendetail.Controls.Add(this.Dt_Date);
            this.grb_vendetail.Controls.Add(this.labelControl10);
            this.grb_vendetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_vendetail.Location = new System.Drawing.Point(16, 47);
            this.grb_vendetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_vendetail.Name = "grb_vendetail";
            this.grb_vendetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_vendetail.Size = new System.Drawing.Size(965, 92);
            this.grb_vendetail.TabIndex = 66;
            this.grb_vendetail.Text = "تسجيل بيانات العميل";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(850, 48);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(105, 21);
            this.labelControl11.TabIndex = 58;
            this.labelControl11.Text = "اســم العميل";
            // 
            // Com_CustName
            // 
            this.Com_CustName.Location = new System.Drawing.Point(493, 44);
            this.Com_CustName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Com_CustName.MenuManager = this.ribbon;
            this.Com_CustName.Name = "Com_CustName";
            this.Com_CustName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Com_CustName.Properties.Appearance.Options.UseFont = true;
            this.Com_CustName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Com_CustName.Properties.NullText = "";
            this.Com_CustName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.Com_CustName.Properties.ShowHeader = false;
            this.Com_CustName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Com_CustName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_CustName.Size = new System.Drawing.Size(350, 30);
            this.Com_CustName.TabIndex = 1;
            // 
            // Dt_Date
            // 
            this.Dt_Date.EditValue = null;
            this.Dt_Date.Location = new System.Drawing.Point(8, 41);
            this.Dt_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dt_Date.Name = "Dt_Date";
            this.Dt_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Dt_Date.Properties.Appearance.Options.UseFont = true;
            this.Dt_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dt_Date.Size = new System.Drawing.Size(350, 30);
            this.Dt_Date.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(364, 48);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(100, 21);
            this.labelControl10.TabIndex = 49;
            this.labelControl10.Text = "تاريــخ البيــع";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_Items);
            this.groupControl2.Location = new System.Drawing.Point(14, 306);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(969, 251);
            this.groupControl2.TabIndex = 69;
            this.groupControl2.Text = "عرض بيانات حركات البيــع";
            // 
            // dgv_Items
            // 
            this.dgv_Items.AllowUserToAddRows = false;
            this.dgv_Items.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Items.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Items.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Items.GridColor = System.Drawing.Color.White;
            this.dgv_Items.Location = new System.Drawing.Point(2, 33);
            this.dgv_Items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Items.Name = "dgv_Items";
            this.dgv_Items.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Items.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Items.RowHeadersWidth = 51;
            this.dgv_Items.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.dgv_Items.Size = new System.Drawing.Size(965, 216);
            this.dgv_Items.TabIndex = 1;
            this.dgv_Items.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_Items_RowsRemoved);
            this.dgv_Items.DoubleClick += new System.EventHandler(this.dgv_Items_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 50);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_Search);
            this.panel_btn.Controls.Add(this.com_Search);
            this.panel_btn.Controls.Add(this.btn_New);
            this.panel_btn.Controls.Add(this.btn_Exit);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Location = new System.Drawing.Point(14, 665);
            this.panel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(968, 66);
            this.panel_btn.TabIndex = 71;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(485, 14);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(148, 43);
            this.btn_Search.TabIndex = 36;
            this.btn_Search.Text = "بحــث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // com_Search
            // 
            this.com_Search.Location = new System.Drawing.Point(171, 21);
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
            this.com_Search.Size = new System.Drawing.Size(306, 30);
            this.com_Search.TabIndex = 35;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(801, 14);
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(148, 43);
            this.btn_New.TabIndex = 7;
            this.btn_New.Text = "جديـد";
            this.btn_New.ToolTip = "اضافة جديد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(13, 14);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 42);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "خــروج";
            this.btn_Exit.ToolTip = "خروج من النافذة";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(643, 14);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(148, 43);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "حفــظ";
            this.btn_Save.ToolTip = "حفظ البيان";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grb_InvoPrice
            // 
            this.grb_InvoPrice.Controls.Add(this.txtRemaining);
            this.grb_InvoPrice.Controls.Add(this.labelControl7);
            this.grb_InvoPrice.Controls.Add(this.txtPayed);
            this.grb_InvoPrice.Controls.Add(this.labelControl12);
            this.grb_InvoPrice.Controls.Add(this.txtTotal);
            this.grb_InvoPrice.Controls.Add(this.labelControl13);
            this.grb_InvoPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_InvoPrice.Location = new System.Drawing.Point(16, 572);
            this.grb_InvoPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_InvoPrice.Name = "grb_InvoPrice";
            this.grb_InvoPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_InvoPrice.Size = new System.Drawing.Size(967, 85);
            this.grb_InvoPrice.TabIndex = 70;
            this.grb_InvoPrice.Text = "تسجيل مبالغ الفاتورة";
            // 
            // txtRemaining
            // 
            this.txtRemaining.EditValue = "0";
            this.txtRemaining.Location = new System.Drawing.Point(12, 39);
            this.txtRemaining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtRemaining.Properties.Appearance.Options.UseFont = true;
            this.txtRemaining.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRemaining.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRemaining.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtRemaining.Properties.MaskSettings.Set("mask", "f");
            this.txtRemaining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemaining.Size = new System.Drawing.Size(218, 30);
            this.txtRemaining.TabIndex = 60;
            this.txtRemaining.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemaining_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(233, 46);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 21);
            this.labelControl7.TabIndex = 61;
            this.labelControl7.Text = "المتبقي";
            // 
            // txtPayed
            // 
            this.txtPayed.EditValue = "0";
            this.txtPayed.Location = new System.Drawing.Point(307, 41);
            this.txtPayed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayed.Properties.Appearance.Options.UseFont = true;
            this.txtPayed.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPayed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPayed.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPayed.Properties.MaskSettings.Set("mask", "f");
            this.txtPayed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPayed.Size = new System.Drawing.Size(218, 30);
            this.txtPayed.TabIndex = 7;
            this.txtPayed.EditValueChanged += new System.EventHandler(this.txtPayed_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(832, 44);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(125, 21);
            this.labelControl12.TabIndex = 30;
            this.labelControl12.Text = "اجمالى الفاتورة";
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(607, 41);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "f");
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(218, 30);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.EditValueChanged += new System.EventHandler(this.txtTotal_EditValueChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(532, 44);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(63, 21);
            this.labelControl13.TabIndex = 2;
            this.labelControl13.Text = "المدفوع";
            // 
            // SalesDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 743);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.grb_InvoPrice);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grb_ItemDetails);
            this.Controls.Add(this.grb_vendetail);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesDataForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشــة حركــــات البيــــع";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesDataForm_FormClosed);
            this.Load += new System.EventHandler(this.SalesDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_ItemDetails)).EndInit();
            this.grb_ItemDetails.ResumeLayout(false);
            this.grb_ItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Com_ItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_vendetail)).EndInit();
            this.grb_vendetail.ResumeLayout(false);
            this.grb_vendetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Com_CustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.com_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_InvoPrice)).EndInit();
            this.grb_InvoPrice.ResumeLayout(false);
            this.grb_InvoPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemaining.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraEditors.GroupControl grb_ItemDetails;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit Com_ItemName;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.GroupControl grb_vendetail;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit Com_CustName;
        private DevExpress.XtraEditors.DateEdit Dt_Date;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_Items;
        public DevExpress.XtraEditors.PanelControl panel_btn;
        public DevExpress.XtraEditors.SimpleButton btn_New;
        public DevExpress.XtraEditors.SimpleButton btn_Exit;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        public DevExpress.XtraEditors.GroupControl grb_InvoPrice;
        private DevExpress.XtraEditors.TextEdit txtRemaining;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPayed;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl lbl_SalDetID;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit com_Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}