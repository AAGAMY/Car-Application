using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LibraryApp.DAL;
using RealClass_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp.Operations
{
    public partial class PurchasesDataForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PurchasesDataForm()
        {
            InitializeComponent();
        }

        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();


        #region BindCom_VenName
        void BindCom_VenName()
        {
            Com_VenName.Properties.DataSource = Retrive_Data.executequery("SP_VendorsFillCombo", CommandType.StoredProcedure);
            Com_VenName.Properties.DisplayMember = "Vendor_Name";
            Com_VenName.Properties.ValueMember = "Ven_ID";
            //com_CarNo.Text = "";

        }
        #endregion
        #region BindCom_ItemName
        void BindCom_ItemName()
        {
            Com_ItemName.Properties.DataSource = Retrive_Data.executequery("SP_ItemsFillCombo", CommandType.StoredProcedure);
            Com_ItemName.Properties.DisplayMember = "Item_Name";
            Com_ItemName.Properties.ValueMember = "Item_ID";
            //com_CarNo.Text = "";

        }
        #endregion
        #region BindCom_Search
        void BindCom_Search()
        {
            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_VendorsFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Vendor_Name";
            com_Search.Properties.ValueMember = "Ven_ID";
        }
        #endregion
        #region CalcItemValue
        void CalcItemValue()
        {
       
                if (txtPrice.Text == "")
                {
                    txtPrice.Text = "0";
                }
                if (txtQuantity.Text == "")
                {
                txtQuantity.Text = "0";
                }
            txtValue.Text = (double.Parse(txtPrice.Text) * double.Parse(txtQuantity.Text)).ToString();
        }

        #endregion
        // القيمة لوضعها بداخل تكست الأجمالى Cell على loop عمل 
        #region CalcTotalValue
        void CalcTotalValue()
        {
            try
            {
                if (txtTotal.Text == "")
                {
                    txtTotal.Text = "0";
                }
                double _total = 0;
                for (int i = 0; i < dgv_Items.Rows.Count; i++)
                {
                    _total = (double.Parse(txtTotal.Text) + double.Parse(dgv_Items.Rows[i].Cells[4].Value.ToString()));
                }
                txtTotal.Text = _total.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        //طرح القيمة المتبقية من القيمة الأجمالية
        #region CalcRemain
        void CalcRemain()
        {
            try
            {
                if (txtPayed.Text == "")
                {
                    txtPayed.Text = "0";
                }
            if (txtTotal.Text == "")
            {
                txtTotal.Text = "0";
            }
            if (double.Parse(txtPayed.Text) > double.Parse(txtTotal.Text))
                {
                    return;
                }
                txtRemaining.Text = (double.Parse(txtTotal.Text) - double.Parse(txtPayed.Text)).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        // Prepare Data 
        #region PrepareData
        DataTable PrepareData()
        {
            if (dgv_Items.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                
                dt.Columns.Add("Item_ID", typeof(int));
                dt.Columns.Add("Purchases_Price", typeof(decimal));
                dt.Columns.Add("Item_Quantity", typeof(int));
                dt.Columns.Add("Item_Value", typeof(decimal));


                for (int i = 0; i < dgv_Items.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = dgv_Items.Rows[i].Cells[0].Value.ToString();
                    dr[1] = dgv_Items.Rows[i].Cells[3].Value.ToString();
                    dr[2] = dgv_Items.Rows[i].Cells[4].Value.ToString();
                    dr[3] = dgv_Items.Rows[i].Cells[5].Value.ToString();
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        #endregion
        #region BindGrid
        void BindGrid()
        {

            dgv_Items.DataSource = Retrive_Data.executequery("Sp_Main_PurchasesSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
            new Pararmeter("@Purchases_Date", SqlDbType.Date, Dt_Date.DateTime.Date));

        }

        #endregion
        #region Total_val
        void Total_val()
        {
            txtTotal.Text =
     (from DataGridViewRow row in dgv_Items.Rows
      where row.Cells[5].FormattedValue.ToString() != string.Empty
      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

        }

        #endregion
        #region HideColumns
        void HideColumns()
        {
            dgv_Items.Columns[0].Visible = false;
            dgv_Items.Columns[2].Visible = false;
            dgv_Items.Columns[6].Visible = false;
            dgv_Items.Columns[7].Visible = false;

        }

        #endregion
        private void PurchasesDataForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindCom_VenName();
            BindCom_ItemName();
            BindCom_Search();
            CreateDataTable();
            HideColumns();


        }

        private void PurchasesDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            // هنا قمت بالتأكيد على المستخدم بعملية اضافة صنف جديد
            if (XtraMessageBox.Show("هل تريد أضافة صنف جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TextClear(this, grb_vendetail);
                _Valid.TextClear(this, grb_ItemDetails);
                _Valid.TextClear(this, grb_InvoPrice);
                Com_VenName.Select();
                _AddNew = true;

                // remove datagridview content
                if (dgv_Items.DataSource != null)
                {
                    var dt = dgv_Items.DataSource as DataTable;
                    dt.Rows.Clear();
                    dgv_Items.DataSource = dt;
                }

            }


            #endregion

        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            CalcItemValue();

        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            CalcItemValue();

        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {
            CalcRemain();

        }

        private void txtPayed_EditValueChanged(object sender, EventArgs e)
        {
            CalcRemain();

        }

        LibraryApp.DAL.DBConnection _con = new LibraryApp.DAL.DBConnection();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AddNew == false)
                {
                    XtraMessageBox.Show("من فضلك إضغط على مفتاح جديد اولاً", "تحذير", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (XtraMessageBox.Show("هل انت متأكد من حفظ حركة شراء جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)

                    #region Save Method
                    if (_AddNew == true)
                {
                    if (Com_VenName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك إدخل اسم المورد", "تحذير", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                        return;

                    }
                    if (Dt_Date.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك إدخل تاريخ الشراء", "تحذير", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                        return;

                    }
                    if (dgv_Items.Rows.Count > 0)
                    {
                        DataTable dt = PrepareData();
                        _con.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                        _con.CMD.CommandType = CommandType.StoredProcedure;
                        _con.CMD.CommandText = "Sp_Main_PurchasesInsert";
                        _con.CMD.Parameters.Clear();
                        _con.CMD.Parameters.AddWithValue("@Ven_ID", int.Parse(Com_VenName.EditValue.ToString()));
                        _con.CMD.Parameters.AddWithValue("@Purchases_Date", Dt_Date.DateTime.Date);
                        _con.CMD.Parameters.AddWithValue("@Total_value", txtTotal.Text);
                        _con.CMD.Parameters.AddWithValue("@Payed_Value", txtPayed.Text);
                        _con.CMD.Parameters.AddWithValue("@Remain_Value", txtRemaining.Text);
                        _con.CMD.Parameters.AddWithValue("@PurchasDataTable", dt);
                        _con.CMD.ExecuteNonQuery();


                        XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        _AddNew = false;
                    }
                }

            #endregion

        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
}


        private void dgv_Items_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                //Com_ItemName.Text = this.dgv_Items.CurrentRow.Cells[2].Value.ToString();
                //txtPrice.Text = this.dgv_Items.CurrentRow.Cells[3].Value.ToString();
                //txtQuantity.Text = this.dgv_Items.CurrentRow.Cells[4].Value.ToString();
                //txtValue.Text = this.dgv_Items.CurrentRow.Cells[5].Value.ToString();
                if (_AddNew == false)
            {
                return;

            }
            else
            {
                _Valid.TextClear(this, grb_ItemDetails);
                lbl_PurDetID.Text = this.dgv_Items.CurrentRow.Cells[6].Value.ToString();
                dgv_Items.Rows.RemoveAt(dgv_Items.CurrentRow.Index);
                if (dgv_Items.Rows.Count == 0)
                    _Valid.TextClear(this, grb_InvoPrice);
            }


        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

     }

        DataTable dt = new DataTable();
        void CreateDataTable()
        {

            try
            {
                dt.Columns.Add("Item_ID");
                dt.Columns.Add("اسم الصنف");
                dt.Columns.Add("Ven_ID");
                dt.Columns.Add("سعر الصنف");
                dt.Columns.Add("الكمية");
                dt.Columns.Add("القيمة");
                dt.Columns.Add("Purchases_Details_ID");
                dt.Columns.Add("Purchases_ID");

                dgv_Items.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                try
                {

                    for (int i = 0; i < dgv_Items.Rows.Count ; i++)
                    {
                        if (dgv_Items.Rows[i].Cells[0].Value.ToString() == Com_ItemName.EditValue.ToString())
                        {
                            if (XtraMessageBox.Show("هذا الصنف موجود مسبقاٌ", "تحذير", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning) == DialogResult.OK)
                                return;
                        }

                    }


                    #region SureData
                    if (Com_ItemName.Text == "")
                    {
                        XtraMessageBox.Show("قم بأختيار اسم الصنف اولاً", "خطأ", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtValue.Text == "0")
                    {
                        XtraMessageBox.Show("من فضلك ادخل السعر او الكمية", "خطأ", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                        return;
                    }

                    #endregion

                    #region AddToGrid


                    DataRow row = dt.NewRow();
                    row[0] = Com_ItemName.EditValue.ToString(); //Item_ID
                    row[1] = Com_ItemName.Text; //Item_Name
                    row[3] = txtPrice.Text; //Price
                    row[4] = txtQuantity.Text; //Quantity
                    row[5] = txtValue.Text; //Value

                    dt.Rows.Add(row);
                    dgv_Items.DataSource = dt;

                    HideColumns();



                    #endregion

                }
                catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
                Total_val();
            }
        }

        private void dgv_Items_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Total_val();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //dgv_Items_DoubleClick(sender, e);
                if (_AddNew == false)
            {
                XtraMessageBox.Show("من فضلك إضغط على مفتاح بحث اولاً", "تحذير", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dgv_Items.Rows.Count > 0)
                {

                    #region Delete Record

                Retrive_Data.executenonquery("Sp_Purchases_DetailsDelete",
                    new Pararmeter("@Purchases_Details_ID", SqlDbType.Int, int.Parse(lbl_PurDetID.Text.ToString())));


                lbl_PurDetID.Text = "0";

                    #endregion


                    #region Update Record
                    DataTable dt = PrepareData();
                    _con.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                    _con.CMD.CommandType = CommandType.StoredProcedure;
                    _con.CMD.CommandText = "Sp_Main_PurchasesUpdate";
                    _con.CMD.Parameters.Clear();
                    _con.CMD.Parameters.AddWithValue("@Purchases_ID", lbl_ID.Text);
                    _con.CMD.Parameters.AddWithValue("@Ven_ID", int.Parse(Com_VenName.EditValue.ToString()));
                    _con.CMD.Parameters.AddWithValue("@Total_value", txtTotal.Text);
                    _con.CMD.Parameters.AddWithValue("@Payed_Value", txtPayed.Text);
                    _con.CMD.Parameters.AddWithValue("@Remain_Value", txtRemaining.Text);
                    _con.CMD.Parameters.AddWithValue("@PurchasDataTable", dt);
                    _con.CMD.ExecuteNonQuery();

                    XtraMessageBox.Show("تم التعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    _AddNew = false;

                    #endregion
                }
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
}


        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم المورد اولاً من قائمة البحث", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
            if (Dt_Date.Text == "")
            {
                XtraMessageBox.Show("من فضلك إختار تاريخ الشراء", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                Dt_Date.Select();
                return;

            }
            else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("Sp_Purchases_DetailsByID", CommandType.StoredProcedure,
                        new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
                        new Pararmeter("@Purchases_Date", SqlDbType.Date,Dt_Date.DateTime.Date));


                if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Purchases_ID"].ToString();
                        lbl_PurDetID.Text = dt.Rows[0]["Purchases_Details_ID"].ToString();
                        Com_VenName.Text = dt.Rows[0]["Vendor_Name"].ToString();
                        Com_ItemName.Text = dt.Rows[0]["Item_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["Purchases_Price"].ToString();
                        txtQuantity.Text = dt.Rows[0]["Item_Quantity"].ToString();
                        txtValue.Text = dt.Rows[0]["Item_Value"].ToString();
                        txtTotal.Text = dt.Rows[0]["Total_value"].ToString();
                        txtPayed.Text = dt.Rows[0]["Payed_Value"].ToString();
                        txtRemaining.Text = dt.Rows[0]["Remain_Value"].ToString();


                        BindGrid();
                        Total_val();

                    _AddNew = true;
                        //HideColumns();
                    }
                    else
                    {
                        XtraMessageBox.Show("هذالمورد غير مسجل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                        return;

                    }
                }

                #endregion


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRemaining_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}