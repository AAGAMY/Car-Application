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
    public partial class CustomersForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CustomersForm()
        {
            InitializeComponent();
        }
        #region Validate
        Cl_Validate _Valid = new Cl_Validate();
        bool _AddNew = false;

        #endregion
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CustomersFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Cust_Name";
            com_Search.Properties.ValueMember = "Cust_ID";
            //com_Search.Text = "";
        }
        #endregion
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
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
            if (XtraMessageBox.Show("هل تريد أضافة مورد جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TextClear(this, grb__Record);
                lbl_ID.Text = "0";
                com_Search.Text = "";

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
                    XtraMessageBox.Show("من فضلك إختار اسم العميل اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_CustomersSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["Cust_ID"].ToString();
                    txt_CustName.Text = dt.Rows[0]["Cust_Name"].ToString();
                    txt_Custaddress.Text = dt.Rows[0]["Cust_Address"].ToString();

                }

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ عميل جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_CustName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم العميل ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    #endregion

                    #region SaveData
                    Retrive_Data.executenonquery("Sp_CustomersInsert",
                new Pararmeter("@Cust_Name", SqlDbType.NVarChar, txt_CustName.Text),
                new Pararmeter("@Cust_Address", SqlDbType.NVarChar, txt_Custaddress.Text));

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
                    XtraMessageBox.Show("قم بأختيار اسم العميل من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذا العميل ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("Sp_CustomersUpdate",
                new Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                new Pararmeter("@Cust_Name", SqlDbType.NVarChar, txt_CustName.Text),
                new Pararmeter("@Cust_Address", SqlDbType.NVarChar, txt_Custaddress.Text));


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
                    XtraMessageBox.Show("قم بأختيار اسم العميل من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذا العميل ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_CustomersDelete",
                            new Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

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