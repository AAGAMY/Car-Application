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

namespace CarApp.Operations
{
    public partial class OverTimeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public OverTimeForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();

        #region txtValidation
        void txtValidation()
        {

            txt_Real_OverTime.Text = "0";
            txt_Real_DriverSalary.Text = "0";
            txt_Result.Text = "0";
            txt_Oile.Text = "0";
            txt_Remaining.Text = "0";

        }

        #endregion
        #region CalcItemValue
        void CalcItemValue()
        {
            try
            {


                txt_Real_DriverSalary.Text = (double.Parse(txt_Real_OverTime.Text) / double.Parse(txt_Calc.Text)).ToString();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("من فضلك ادخل نسبة الخصم", "تحذير", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txt_Calc.Select();
            }

        }
        #endregion
        #region CalcTxTResult
        void CalcTxTResult()
        {
            txt_Result.Text = (double.Parse(txt_Real_OverTime.Text) - double.Parse(txt_Real_DriverSalary.Text)).ToString();
        }

        #endregion
        #region CalcTxTRemaining
        void CalcTxTRemaining()
        {
            try
            {
                txt_Remaining.Text = (double.Parse(txt_Result.Text) - double.Parse(txt_Oile.Text)).ToString();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("من فضلك ادخل قيمة البنزين", "تحذير", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txt_Oile.Select();

            }
        }

        #endregion
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_DriversFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Driver_Name";
            com_Search.Properties.ValueMember = "Driver_ID";
            //com_Search.Text = "";
        }
        #endregion
        #region BindComboDriverName
        void BindComboDriverName()
        {

            com_Dname.Properties.DataSource = Retrive_Data.executequery("SP_DriversFillCombo", CommandType.StoredProcedure);
            com_Dname.Properties.DisplayMember = "Driver_Name";
            com_Dname.Properties.ValueMember = "Driver_ID";
        }
        #endregion
        #region BindGridByID
        void BindGridByID()
        {

            dgv_Shifts.DataSource = Retrive_Data.executequery("SP_OverTimeSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Shifts.DataSource = Retrive_Data.executequery("SP_OverTimeSelectAll", CommandType.StoredProcedure);
        }

        #endregion


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void OverTimeForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
            BindComboDriverName();
            txtValidation();
            BindGridAll();


        }

        private void txt_Calc_EditValueChanged(object sender, EventArgs e)
        {
            CalcItemValue();
            CalcTxTResult();
        }

        private void txt_Oile_EditValueChanged(object sender, EventArgs e)
        {
            CalcTxTRemaining();
            if (decimal.Parse(txt_Oile.Text) > decimal.Parse(txt_Result.Text))
            {
                XtraMessageBox.Show("مبلغ البنزين اكبر من المبلغ قبل البنزين", "تحذير", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txt_Oile.Select();
                txt_Oile.ForeColor = Color.Red;
                return;
            }
            else
            {
                txt_Oile.ForeColor = Color.FromArgb(40, 40, 40);

            }

        }

        private void OverTimeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة سائق جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                com_Dname.Text = "";
                txt_Calc.Text = "0";
                Dt_Over_Date.Text = "";
                _Valid.TextClear(this, grb_Search);
                txtValidation();
                BindGridAll();
            }
            #endregion

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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ وردية جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (com_Dname.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم السائق ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    if (txt_Real_OverTime.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال مبلغ الوردية", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    if (txt_Calc.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال نسبة الخصم", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    if (txt_Oile.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال مبلغ البنزين", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    #endregion

                    #region SaveData

                    Retrive_Data.executenonquery("SP_OverTimeInsert",
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())),
         new Pararmeter("@Real_OverTime", SqlDbType.Decimal, decimal.Parse(txt_Real_OverTime.Text)),
         new Pararmeter("@Real_DriverSalary", SqlDbType.Decimal, decimal.Parse(txt_Real_DriverSalary.Text.Trim())),
         new Pararmeter("@Result", SqlDbType.Decimal, decimal.Parse(txt_Result.Text.Trim())),
         new Pararmeter("@Oile", SqlDbType.Decimal, decimal.Parse(txt_Oile.Text.Trim())),
         new Pararmeter("@Remaining", SqlDbType.Decimal, decimal.Parse(txt_Remaining.Text.Trim())),
         new Pararmeter("@Over_Date", SqlDbType.Date, Dt_Over_Date.Text));



                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindComboSearch();
                    BindGridAll();

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
                    XtraMessageBox.Show("من فضلك إختار اسم السائق اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_OverTimeSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["OverTime_ID"].ToString();
                        com_Dname.Text = dt.Rows[0]["Driver_Name"].ToString();
                        txt_Real_OverTime.Text = dt.Rows[0]["Real_OverTime"].ToString();
                        txt_Real_DriverSalary.Text = dt.Rows[0]["Real_DriverSalary"].ToString();
                        txt_Result.Text = dt.Rows[0]["Result"].ToString();
                        txt_Oile.Text = dt.Rows[0]["Oile"].ToString();
                        txt_Remaining.Text = dt.Rows[0]["Remaining"].ToString();
                        Dt_Over_Date.Text = dt.Rows[0]["Over_Date"].ToString();

                        BindGridByID();
                    }
                    else
                    {
                        XtraMessageBox.Show("هذالسائق غير مسجل", "تحذير", MessageBoxButtons.OK,
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                #region Delete Record
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم السائق من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذاالسائق ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_OverTimeDelete",
                            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        lbl_ID.Text = "0";
                        com_Dname.Text = "";
                        txt_Calc.Text = "0";
                        _Valid.TextClear(this, grb_Search);
                        txtValidation();
                        BindGridAll();
                    }

                }

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_Real_OverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void dgv_Shifts_Click(object sender, EventArgs e)
        {
            try
            {
                com_Dname.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Driver_Name") + "");
                txt_Real_OverTime.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Real_OverTime") + "");
                txt_Real_DriverSalary.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Real_DriverSalary") + "");
                txt_Result.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Result") + "");
                txt_Oile.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Oile") + "");
                txt_Remaining.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Remaining") + "");
                Dt_Over_Date.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Over_Date") + "");
                lbl_ID.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OverTime_ID") + "");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            try
            {
                #region Data_Validation
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم السائق من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                #endregion
                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيان واحد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        Retrive_Data.executenonquery("SP_OverTimeDeleteOne",
         new Pararmeter("@OverTime_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Real_DriverSalary", SqlDbType.Decimal, decimal.Parse(txt_Real_DriverSalary.Text.Trim())));



                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        BindGridByID();

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