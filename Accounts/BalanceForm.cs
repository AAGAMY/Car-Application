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

namespace CarApp.Accounts
{
    public partial class BalanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BalanceForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CompaniesFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Com_Name";
            com_Search.Properties.ValueMember = "Com_ID";
        }
        #endregion
        #region BindCompanyName
        void BindCompanyName()
        {

            com_CompName.Properties.DataSource = Retrive_Data.executequery("SP_CompaniesFillCombo", CommandType.StoredProcedure);
            com_CompName.Properties.DisplayMember = "Com_Name";
            com_CompName.Properties.ValueMember = "Com_ID";
        }
        #endregion
        #region BindGridByID
        void BindGridByID()
        {

            dgv_Balance.DataSource = Retrive_Data.executequery("SP_BalanceSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Balance.DataSource = Retrive_Data.executequery("SP_BalanceSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        private void BalanceForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
            BindCompanyName();
            BindGridAll();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void BalanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة مستثمر جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TextClear(this, grb__Record);
                _Valid.TextClear(this, grb_Search);
                lbl_ID.Text = "0";
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ بيانات مستثمر جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (com_CompName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك اختر اسم الشركة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Balance.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل العائد الشهري ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_BalanceInsert",
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_CompName.EditValue.ToString())),
                new Pararmeter("@Balance", SqlDbType.Int, int.Parse(txt_Balance.Text)),
                new Pararmeter("@Balance_Date", SqlDbType.Date, Dt_Balance_Date.Text));


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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                #region Data_Validation
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم الشركة من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل رصيد هذة الشركة ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_BalanceUpdate",
             new Pararmeter("@Balance_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
             new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_CompName.EditValue.ToString())),
             new Pararmeter("@Balance", SqlDbType.Int, int.Parse(txt_Balance.Text)),
             new Pararmeter("@Balance_Date", SqlDbType.Date, Dt_Balance_Date.Text));

                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                #region Delete Record
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم الشركة من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف رصيد هذة الشركة ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_BalanceDelete",
                            new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        BindGridAll();
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb__Record);
                        _Valid.TextClear(this, grb_Search);
                    }

                }

                #endregion

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
                    XtraMessageBox.Show("من فضلك إختار اسم الشركة اولاً", "تحذير", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_BalanceSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Balance_ID"].ToString();
                        com_CompName.Text = dt.Rows[0]["Com_Name"].ToString();
                        txt_Balance.Text = dt.Rows[0]["Balance"].ToString();
                        Dt_Balance_Date.Text = dt.Rows[0]["Balance_Date"].ToString();
                        BindGridByID();
                    }
                    else
                    {
                        XtraMessageBox.Show("هذة الشركة ليست لها رصيد سابق مسجل", "تحذير", MessageBoxButtons.OK,
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