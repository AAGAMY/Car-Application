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
using DevExpress.XtraEditors;
using LibraryApp.DAL;
using RealClass_lib;
using System.Data.SqlClient;
using CarApp.Reportes;
using NumberstoAlpha;

namespace CarApp.Operations
{
    public partial class ReceiptForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة إيصال جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TextClear(this, grb_Shifts);
                _Valid.TextClear(this, grb_Search);
            }
            #endregion

        }

        private void ReceiptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ ايصال جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_Receipt_Name.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم المستلم ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    if (txt_Receipt_From.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم المستلم منة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    if (txt_Receipt_Salary_NO.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال مبلغ الأستلام", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    #endregion

                    #region SaveData

                    Retrive_Data.executenonquery("SP_ReceiptInsert",
         new Pararmeter("@Receipt_Name", SqlDbType.NVarChar, txt_Receipt_Name.Text),
         new Pararmeter("@Receipt_From", SqlDbType.NVarChar, txt_Receipt_From.Text),
         new Pararmeter("@Receipt_Salary_NO", SqlDbType.Decimal, decimal.Parse(txt_Receipt_Salary_NO.Text)),
         new Pararmeter("@Receipt_Salary_WO", SqlDbType.NVarChar, txt_Receipt_Salary_WO.Text),
         new Pararmeter("@Receipt_For", SqlDbType.NVarChar, txt_Receipt_For.Text),
         new Pararmeter("@Receipt_Month", SqlDbType.NVarChar, txt_Receipt_Month.Text),
         new Pararmeter("@Receipt_Date", SqlDbType.Date, Dt_Receipt_Date.Text));


                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.receiptTableAdapter.Fill(this.carDBDataSet.Receipt);

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
                    XtraMessageBox.Show("من فضلك إختار رقم الأيصال اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_ReceiptSellectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Receipt_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Receipt_ID"].ToString();
                        txt_Receipt_Name.Text = dt.Rows[0]["Receipt_Name"].ToString();
                        txt_Receipt_From.Text = dt.Rows[0]["Receipt_From"].ToString();
                        txt_Receipt_Salary_NO.Text = dt.Rows[0]["Receipt_Salary_NO"].ToString();
                        txt_Receipt_Salary_WO.Text = dt.Rows[0]["Receipt_Salary_WO"].ToString();
                        txt_Receipt_For.Text = dt.Rows[0]["Receipt_For"].ToString();
                        txt_Receipt_Month.Text = dt.Rows[0]["Receipt_Month"].ToString();
                        Dt_Receipt_Date.Text = dt.Rows[0]["Receipt_Date"].ToString();

                    }
                    else
                    {
                        XtraMessageBox.Show("هذالإيصال غير مسجل", "تحذير", MessageBoxButtons.OK,
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

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region Data_Validation
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار رقم الأيصال من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion
                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذاالإيصال ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        Retrive_Data.executenonquery("SP_ReceiptUpdate",
         new Pararmeter("@Receipt_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Receipt_Name", SqlDbType.NVarChar, txt_Receipt_Name.Text),
         new Pararmeter("@Receipt_From", SqlDbType.NVarChar, txt_Receipt_From.Text),
         new Pararmeter("@Receipt_Salary_NO", SqlDbType.Decimal, decimal.Parse(txt_Receipt_Salary_NO.Text)),
         new Pararmeter("@Receipt_Salary_WO", SqlDbType.NVarChar, txt_Receipt_Salary_WO.Text),
         new Pararmeter("@Receipt_For", SqlDbType.NVarChar, txt_Receipt_For.Text),
         new Pararmeter("@Receipt_Month", SqlDbType.NVarChar, txt_Receipt_Month.Text),
         new Pararmeter("@Receipt_Date", SqlDbType.Date, Dt_Receipt_Date.Text));



                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
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
        LibraryApp.DAL.DBConnection _con = new LibraryApp.DAL.DBConnection();
        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("هل تريد طباعة الإيصال ؟", "امر طباعة", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _con.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                    _con.CMD.CommandType = CommandType.StoredProcedure;
                    _con.CMD.CommandText = "SP_ReceiptSelectMax";
                    SqlDataAdapter da = new SqlDataAdapter(_con.CMD);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "BillIReceipt");
                    Cry_Receipt rpt = new Cry_Receipt();
                    rpt.SetDataSource(ds.Tables["BillIReceipt"]);
                    ReceiptPrintForm f_Report = new ReceiptPrintForm();
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

        private void txt_Receipt_Salary_NO_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txt_Receipt_Salary_NO.Text);
                txt_Receipt_Salary_WO.Text = a.GetNumberAr();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("من فضلك قم بكتابة ارقام فقط", "تحذير", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txt_Receipt_Salary_NO.SelectAll();
                return;

            }
        }

        private void txt_Receipt_Salary_WO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}