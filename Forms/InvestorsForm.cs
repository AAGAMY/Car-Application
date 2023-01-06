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

namespace CarApp.Forms
{
    public partial class InvestorsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public InvestorsForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_InvestorsFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Investor_Name";
            com_Search.Properties.ValueMember = "Investor_ID";
            //com_Search.Text = "";
        }
        #endregion
        private void InvestorsForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
        }

        private void InvestorsForm_FormClosed(object sender, FormClosedEventArgs e)
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
                lbl_ID.Text = "0";

            }
            #endregion

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم المستثمر اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_InvestorsSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Investor_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["Investor_ID"].ToString();
                    txt_InvName.Text = dt.Rows[0]["Investor_Name"].ToString();
                    Dt_SContract_date.Text = dt.Rows[0]["Contract_Date"].ToString();
                    Dt_EContract_date.Text = dt.Rows[0]["Expiry_date"].ToString();
                    txt_Contract_balance.Text = dt.Rows[0]["Contract_balance"].ToString();
                }

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ بيانات مستثمر جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_InvName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم المستثمر ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_InvestorsInsert",
                new Pararmeter("@Investor_Name", SqlDbType.NVarChar, txt_InvName.Text),
                new Pararmeter("@Contract_Date", SqlDbType.Date, Dt_SContract_date.Text),
                new Pararmeter("@Expiry_date", SqlDbType.Date, Dt_EContract_date.Text),
                new Pararmeter("@Contract_balance", SqlDbType.Int, int.Parse(txt_Contract_balance.Text)));

                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindComboSearch();
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
                    XtraMessageBox.Show("قم بأختيار اسم المستثمر من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذا المستثمر ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_InvestorsUpdate",
                new Pararmeter("@Investor_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                new Pararmeter("@Investor_Name", SqlDbType.NVarChar, txt_InvName.Text),
                new Pararmeter("@Contract_Date", SqlDbType.Date, Dt_SContract_date.Text),
                new Pararmeter("@Expiry_date", SqlDbType.Date, Dt_EContract_date.Text),
                new Pararmeter("@Contract_balance", SqlDbType.NVarChar, txt_Contract_balance.Text));

                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
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
                    XtraMessageBox.Show("قم بأختيار اسم المستثمر من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذا المستثمر ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_InvestorsDelete",
                            new Pararmeter("@Investor_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb__Record);
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