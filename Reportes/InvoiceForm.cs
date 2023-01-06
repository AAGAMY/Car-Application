using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibraryApp.DAL;
using DevExpress.XtraEditors;
using RealClass_lib;
using System.Data.SqlClient;
using NumberstoAlpha;
using CarApp.Forms;

namespace CarApp.Reportes
{
    public partial class InvoiceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindCompanyName
        void BindCompanyName()
        {

            Com_CompName.Properties.DataSource = Retrive_Data.executequery("SP_CompaniesFillCombo", CommandType.StoredProcedure);
            Com_CompName.Properties.DisplayMember = "Com_Name";
            Com_CompName.Properties.ValueMember = "Com_ID";
        }
        #endregion
        #region CalcItemValue
        void CalcItemValue()
        {
            if (txt_Shift_Quantity.Text == "")
            {
                txt_Shift_Quantity.Text = "0";
            }
            if (txt_Inv_Salary.Text == "")
            {
                txt_Inv_Salary.Text = "0";
            }
            if (txt_Dayes_Quantity.Text == "")
            {
                txt_Dayes_Quantity.Text = "0";
            }
            txt_Inv_Value.Text = (double.Parse(txt_Shift_Quantity.Text) * double.Parse(txt_Inv_Salary.Text) * double.Parse(txt_Dayes_Quantity.Text)).ToString();
        }
        #endregion
        #region BindCombolstCarType
        void BindComboCarType()
        {
            List<string> lstCarType = new List<string>();
            lstCarType.Add("اتوبيس");
            lstCarType.Add("ميكروباص");
            lstCarType.Add("ملاكي");
            Com_Car_Type.Properties.DataSource = lstCarType;
        }

        #endregion
        #region PrepareData
        DataTable PrepareData()
        {
            if (dgv_Items.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;

                dt.Columns.Add("Shift_Quantity", typeof(int));
                dt.Columns.Add("Inv_Salary", typeof(decimal));
                dt.Columns.Add("Dayes_Quantity", typeof(int));
                dt.Columns.Add("Car_Type", typeof(string));
                dt.Columns.Add("From_Date", typeof(DateTime));
                dt.Columns.Add("To_Date", typeof(DateTime));
                dt.Columns.Add("Inv_Value", typeof(decimal));
                dt.Columns.Add("Inv_Note", typeof(string));

                for (int i = 0; i < dgv_Items.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = dgv_Items.Rows[i].Cells[2].Value.ToString();
                    dr[1] = dgv_Items.Rows[i].Cells[3].Value.ToString();
                    dr[2] = dgv_Items.Rows[i].Cells[4].Value.ToString();
                    dr[3] = dgv_Items.Rows[i].Cells[5].Value.ToString();
                    dr[4] = dgv_Items.Rows[i].Cells[6].Value.ToString();
                    dr[5] = dgv_Items.Rows[i].Cells[7].Value.ToString();
                    dr[6] = dgv_Items.Rows[i].Cells[8].Value.ToString();
                    dr[7] = dgv_Items.Rows[i].Cells[9].Value.ToString();

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
        #region Total_val
        void Total_val()
        {
            txt_Total_value.Text =
             (from DataGridViewRow _row in dgv_Items.Rows
              where _row.Cells[8].FormattedValue.ToString() != string.Empty
              select Convert.ToDouble(_row.Cells[8].FormattedValue)).Sum().ToString();
        }

        #endregion
        #region BindGrid
        void BindGrid()
        {

            dgv_Items.DataSource = Retrive_Data.executequery("SP_InvoiceSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Invoice_ID", SqlDbType.Int, int.Parse(txtInvoiceNum.Text)));

        }

        #endregion


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
            FormOpened.IsMyFormOpened = false;

        }

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                #region AddNew
                if (XtraMessageBox.Show("هل تريد أضافة فاتورة جديدة ؟", "تأكيد", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _AddNew = true;
                    _Valid.TextClear(this, grb__Record);

                    if (dgv_Items.DataSource != null)
                    {
                        var dt = dgv_Items.DataSource as DataTable;
                        dt.Rows.Clear();
                        dgv_Items.DataSource = dt;

                    }


                }
                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }          
            //DataTable dt = new DataTable();
            //dt = Retrive_Data.executequery("SP_InvoiceSelectLastInvoic", CommandType.StoredProcedure);
            //txtInvoiceNum.Text = dt.Rows[0][0].ToString();

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindCompanyName();
            BindComboCarType();
            txtInvoiceNum.Select();
            CreateDataTable();
            dgv_Items.Columns[0].Visible = false;
            dgv_Items.Columns[1].Visible = false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AddNew == false)
                {
                    XtraMessageBox.Show("من فضلك إضغط على مفتاح جديد اولاً", "تحذير", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (XtraMessageBox.Show("هل انت متأكد من حفظ فاتورة جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData
                    if (dt.Rows.Count == 0)
                    {
                        if (Com_CompName.Text == "")
                        {
                            XtraMessageBox.Show("من فضلك ادخل اسم الشركة ", "تنبية", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        if (txt_Shift_Quantity.Text == "")
                        {
                            XtraMessageBox.Show("من فضلك ادخل عدد الورديات ", "تنبية", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        if (txt_Inv_Salary.Text == "")
                        {
                            XtraMessageBox.Show("من فضلك ادخل سعر الوردية ", "تنبية", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        if (txt_Dayes_Quantity.Text == "")
                        {
                            XtraMessageBox.Show("من فضلك ادخل عدد الأيام ", "تنبية", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        return;
                    }
                    #endregion

                    #region SaveData



                  if (dgv_Items.Rows.Count > 0)
                    {
                        DataTable dt = PrepareData();
                        _con.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                        _con.CMD.CommandType = CommandType.StoredProcedure;
                        _con.CMD.CommandText = "SP_InvoiceInsert";
                        _con.CMD.Parameters.Clear();
                        _con.CMD.Parameters.AddWithValue("@Com_ID", int.Parse(Com_CompName.EditValue.ToString()));
                        _con.CMD.Parameters.AddWithValue("@Invoice_Total", txt_Total_value.Text);
                        _con.CMD.Parameters.AddWithValue("@Invoice_Total_AR", txt_Arabic_Word.Text);
                        _con.CMD.Parameters.AddWithValue("@InvoiceDataTable", dt);
                        _con.CMD.ExecuteNonQuery();


                        XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        _AddNew = false;

                    }

                    #endregion
                   
                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
}

        private void Txt_Dayes_Quantity_EditValueChanged(object sender, EventArgs e)
        {
            CalcItemValue();
        }
        LibraryApp.DAL.DBConnection _con = new LibraryApp.DAL.DBConnection();

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            RealClass_lib.DBConnection _Conn = new RealClass_lib.DBConnection();
            try
            {

                if (XtraMessageBox.Show("هل تريد طباعة فاتورة البيع", "امر طباعة", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _Conn.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                    _Conn.CMD.CommandType = CommandType.StoredProcedure;
                    _Conn.CMD.CommandText = "SP_InvoiceSelectMax";
                    SqlDataAdapter da = new SqlDataAdapter(_Conn.CMD);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "BillInvoice");
                    Cry_Invoice rpt = new Cry_Invoice();
                    rpt.SetDataSource(ds.Tables["BillInvoice"]);
                    InvoicePrintForm f_Report = new InvoicePrintForm();
                    f_Report.crystalReportViewer1.ReportSource = rpt;
                    f_Report.crystalReportViewer1.Refresh();
                    //f_Report.MdiParent = this;
                    f_Report.ShowDialog();
                }

        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
}





        private void txt_Inv_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        DataTable dt = new DataTable();
        void CreateDataTable()
        {
            dt.Columns.Add("رقم الفاتورة");
            dt.Columns.Add("رقم طلب الفاتورة");
            dt.Columns.Add("عدد الورديات");
            dt.Columns.Add("سعر الوردية");
            dt.Columns.Add("عدد الأيام");
            dt.Columns.Add("نوع السيارة");
            dt.Columns.Add("من تاريخ");
            dt.Columns.Add("الى تاريخ");
            dt.Columns.Add("القيمة");
            dt.Columns.Add("ملاحظات");
            dgv_Items.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region AddToGrid

            //DataGridViewRow row = new DataGridViewRow();
            //DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel5 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel6 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel7 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel8 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel9 = new DataGridViewTextBoxCell();
            //DataGridViewCell cel10 = new DataGridViewTextBoxCell();


            //row.Cells.Add(cel1);
            //row.Cells.Add(cel2);
            //row.Cells.Add(cel3);
            //row.Cells.Add(cel4);
            //row.Cells.Add(cel5);
            //row.Cells.Add(cel6);
            //row.Cells.Add(cel7);
            //row.Cells.Add(cel8);
            //row.Cells.Add(cel9);
            //row.Cells.Add(cel10);


            //row.Cells[2].Value = txt_Shift_Quantity.Text; //Item_ID
            //row.Cells[3].Value = txt_Inv_Salary.Text; //Item_Name
            //row.Cells[4].Value = txt_Dayes_Quantity.Text; //Price
            //row.Cells[5].Value = Com_Car_Type.Text; //Quantity
            //row.Cells[6].Value = Dt_From_Date.Text; //Value
            //row.Cells[7].Value = Dt_To_Date.Text;
            //row.Cells[8].Value = txt_Inv_Value.Text;
            //row.Cells[9].Value = txt_Inv_Note.Text;


            //dgv_Items.Rows.Add(row);

            DataRow row = dt.NewRow();
            row[2] = txt_Shift_Quantity.Text; //Item_ID
            row[3] = txt_Inv_Salary.Text; //Item_Name
            row[4] = txt_Dayes_Quantity.Text; //Price
            row[5] = Com_Car_Type.Text; //Quantity
            row[6] = Dt_From_Date.Text; //Value
            row[7] = Dt_To_Date.Text;
            row[8] = txt_Inv_Value.Text;
            row[9] = txt_Inv_Note.Text;
            
            dt.Rows.Add(row);
            dgv_Items.DataSource = dt;

            dgv_Items.Columns[0].Visible = false;
            dgv_Items.Columns[1].Visible = false;

            _Valid.TextClear(this, grb__Record);

            #endregion

            Total_val();
            //Convert numbers to arabic word
            ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txt_Total_value.Text);
            txt_Arabic_Word.Text = a.GetNumberAr() + "فقط لاغير";



        }

        private void dgv_Items_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Total_val();

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
                    _Valid.TextClear(this, grb__Record);
                    lbl_InvOrID.Text = this.dgv_Items.CurrentRow.Cells[0].Value.ToString();
                    dgv_Items.Rows.RemoveAt(dgv_Items.CurrentRow.Index);

                    //Convert numbers to arabic word
                    ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txt_Total_value.Text);
                    txt_Arabic_Word.Text = a.GetNumberAr();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }



        private void txt_Total_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Arabic_Word_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

                    Retrive_Data.executenonquery("Sp_Invoice_Delete",
                        new Pararmeter("@Invoice_order_ID", SqlDbType.Int, int.Parse(lbl_InvOrID.Text.ToString())));


                    lbl_InvOrID.Text = "0";

                    #endregion


                    #region Update Record
                    DataTable dt = PrepareData();
                    _con.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                    _con.CMD.CommandType = CommandType.StoredProcedure;
                    _con.CMD.CommandText = "SP_InvoiceUpdate";
                    _con.CMD.Parameters.Clear();
                    _con.CMD.Parameters.AddWithValue("@Invoice_ID", lbl_ID.Text);
                    _con.CMD.Parameters.AddWithValue("@Com_ID", int.Parse(Com_CompName.EditValue.ToString()));
                    _con.CMD.Parameters.AddWithValue("@Inv_Total", txt_Total_value.Text);
                    _con.CMD.Parameters.AddWithValue("@Invoice_Total_AR", txt_Arabic_Word.Text);
                    _con.CMD.Parameters.AddWithValue("@InvoiceDataTable", dt);
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
                if (txtInvoiceNum.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار رقم الفاتور اولاً من قائمة البحث", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    txtInvoiceNum.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_Invoice_DetailsByID", CommandType.StoredProcedure,
                        new Pararmeter("@Invoice_ID", SqlDbType.Int, int.Parse(txtInvoiceNum.Text)));


                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Invoice_ID"].ToString();
                        lbl_InvOrID.Text = dt.Rows[0]["Invoice_order_ID"].ToString();
                        Com_CompName.Text = dt.Rows[0]["Com_Name"].ToString();
                        txt_Shift_Quantity.Text = dt.Rows[0]["Shift_Quantity"].ToString();
                        txt_Inv_Salary.Text = dt.Rows[0]["Inv_Salary"].ToString();
                        txt_Dayes_Quantity.Text = dt.Rows[0]["Dayes_Quantity"].ToString();
                        Com_Car_Type.Text = dt.Rows[0]["Car_Type"].ToString();
                        Dt_From_Date.Text = dt.Rows[0]["From_Date"].ToString();
                        Dt_To_Date.Text = dt.Rows[0]["To_Date"].ToString();
                        txt_Inv_Value.Text = dt.Rows[0]["Inv_Value"].ToString();
                        txt_Inv_Note.Text = dt.Rows[0]["Inv_Note"].ToString();
                        txt_Total_value.Text = dt.Rows[0]["Invoice_Total"].ToString();
                        txt_Arabic_Word.Text = dt.Rows[0]["Invoice_Total_AR"].ToString();



                        BindGrid();
                        Total_val();
                        _AddNew = true;
                        dgv_Items.Columns[0].Visible = false;
                        dgv_Items.Columns[1].Visible = false;

                    }
                    else
                    {
                        XtraMessageBox.Show("هذه الفاتورة غير مسجلة", "تحذير", MessageBoxButtons.OK,
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

        private void txtInvoiceNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    #region Search
                    if (txtInvoiceNum.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك إختار رقم الفاتور اولاً من قائمة البحث", "تحذير", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                        txtInvoiceNum.Select();
                        return;

                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt = Retrive_Data.executequery("SP_Invoice_DetailsByID", CommandType.StoredProcedure,
                            new Pararmeter("@Invoice_ID", SqlDbType.Int, int.Parse(txtInvoiceNum.Text)));


                        if (dt.Rows.Count > 0)
                        {

                            lbl_ID.Text = dt.Rows[0]["Invoice_ID"].ToString();
                            lbl_InvOrID.Text = dt.Rows[0]["Invoice_order_ID"].ToString();
                            Com_CompName.Text = dt.Rows[0]["Com_Name"].ToString();
                            txt_Shift_Quantity.Text = dt.Rows[0]["Shift_Quantity"].ToString();
                            txt_Inv_Salary.Text = dt.Rows[0]["Inv_Salary"].ToString();
                            txt_Dayes_Quantity.Text = dt.Rows[0]["Dayes_Quantity"].ToString();
                            Com_Car_Type.Text = dt.Rows[0]["Car_Type"].ToString();
                            Dt_From_Date.Text = dt.Rows[0]["From_Date"].ToString();
                            Dt_To_Date.Text = dt.Rows[0]["To_Date"].ToString();
                            txt_Inv_Value.Text = dt.Rows[0]["Inv_Value"].ToString();
                            txt_Inv_Note.Text = dt.Rows[0]["Inv_Note"].ToString();
                            txt_Total_value.Text = dt.Rows[0]["Invoice_Total"].ToString();
                            txt_Arabic_Word.Text = dt.Rows[0]["Invoice_Total_AR"].ToString();



                            BindGrid();
                            Total_val();
                            _AddNew = true;
                            dgv_Items.Columns[0].Visible = false;
                            dgv_Items.Columns[1].Visible = false;

                        }
                        else
                        {
                            XtraMessageBox.Show("هذه الفاتورة غير مسجلة", "تحذير", MessageBoxButtons.OK,
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

        }


    }
}