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
using RealClass_lib;
using DevExpress.XtraEditors;

namespace CarApp.Forms
{
    public partial class UserInfoForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UserInfoForm()
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

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_User_InfoFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "UserName";
            com_Search.Properties.ValueMember = "UserInfo_ID";
            //com_Search.Text = "";
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void UserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة مستخدم جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_UserName.Select();
                _AddNew = true;
                _Valid.TextClear(this, grb__Record);
                _Valid.TextClear(this, grb_Search);
                lbl_ID.Text = "0";
                
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ بيانات جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_UserName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم المستخدم ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (txt_PWD.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال كلمة المرور", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_User_InfoInsert",
                new Pararmeter("@UserName", SqlDbType.NVarChar, txt_UserName.Text),
                new Pararmeter("@Password", SqlDbType.NVarChar, txt_PWD.Text),
                new Pararmeter("@Admin", SqlDbType.Bit, checkAdmin.Checked));


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
                    XtraMessageBox.Show("قم بأختيار اسم المستخدم من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذا المستخدم ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_User_InfoUpdate",
                    new Pararmeter("@UserInfo_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                    new Pararmeter("@UserName", SqlDbType.NVarChar, txt_UserName.Text),
                    new Pararmeter("@Password", SqlDbType.NVarChar, txt_PWD.Text),
                    new Pararmeter("@Admin", SqlDbType.Bit, checkAdmin.Checked));


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
                    XtraMessageBox.Show("قم بأختيار اسم المستخدم من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذا المستخدم ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_User_InfoDelete",
                            new Pararmeter("@UserInfo_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;

                        BindComboSearch();
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
                    XtraMessageBox.Show("من فضلك إختار اسم المستخدم", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_User_InfoSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@UserInfo_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["UserInfo_ID"].ToString();
                    txt_UserName.Text = dt.Rows[0]["UserName"].ToString();
                    txt_PWD.Text = dt.Rows[0]["Password"].ToString();
                    checkAdmin.Checked = bool.Parse(dt.Rows[0]["Admin"].ToString());

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