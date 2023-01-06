using DevExpress.XtraBars;
using LibraryApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealClass_lib;
using DevExpress.XtraEditors;

namespace CarApp.Forms
{
    public partial class CompaniesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CompaniesForm()
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
            //com_Search.Text = "";
        }
        #endregion



        private void CompaniesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }



        private void CompaniesForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة شركة جديدة ؟", "تأكيد", MessageBoxButtons.YesNo,
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
                    XtraMessageBox.Show("من فضلك إختار اسم السائق اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_CompaniesSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["Com_ID"].ToString();
                    txt_CName.Text = dt.Rows[0]["Com_Name"].ToString();
                    txt_Caddress.Text = dt.Rows[0]["Com_Address"].ToString();
                    Dt_Contract_date.Text = dt.Rows[0]["Contract_date"].ToString();

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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ شركة جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_CName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم السائق ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_CompaniesInsert",
                new Pararmeter("@Com_Name", SqlDbType.NVarChar, txt_CName.Text),
                new Pararmeter("@Com_Address", SqlDbType.NVarChar, txt_Caddress.Text),
                new Pararmeter("@Contract_date", SqlDbType.Date, Dt_Contract_date.Text));

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
                    XtraMessageBox.Show("قم بأختيار اسم الشركة من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذةالشركة ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_CompaniesUpdate",
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                new Pararmeter("@Com_Name", SqlDbType.NVarChar, txt_CName.Text),
                new Pararmeter("@Com_Address", SqlDbType.NVarChar, txt_Caddress.Text),
                new Pararmeter("@Contract_date", SqlDbType.Date, Dt_Contract_date.Text));


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
                    XtraMessageBox.Show("قم بأختيار اسم الشركة من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذة الشركة ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_CompaniesDelete",
                            new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

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