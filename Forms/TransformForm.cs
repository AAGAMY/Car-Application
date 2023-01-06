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
    public partial class TransformForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TransformForm()
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

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_TransformFillComboFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Transform_Name";
            com_Search.Properties.ValueMember = "Transform_ID";
            //com_Search.Text = "";
        }
        #endregion
        #region BindCompCarNo
        void BindCompCarNo()
        {
            com_Car_ID_No.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_Car_ID_No.Properties.DisplayMember = "Car_No";
            com_Car_ID_No.Properties.ValueMember = "Car_ID";

        }
        #endregion
        #region BindComboCompany
        void BindComboCompany()
        {

            com_CompName.Properties.DataSource = Retrive_Data.executequery("SP_CompaniesFillCombo", CommandType.StoredProcedure);
            com_CompName.Properties.DisplayMember = "Com_Name";
            com_CompName.Properties.ValueMember = "Com_ID";
        }
        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Transform.DataSource = Retrive_Data.executequery("SP_TransformSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        #region BindGridByID
        void BindGridByID()
        {
            dgv_Transform.DataSource = Retrive_Data.executequery("SP_TransformSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion



        private void TransformForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
            BindCompCarNo();
            BindGridAll();
            BindComboCompany();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void TransformForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة مكتب نقل جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ عميل جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_TraName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم المكتب ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (com_Car_ID_No.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال رقم السيارة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (com_CompName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال إسم الشركة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;


                    }

                    #endregion

                    #region SaveData

                    Retrive_Data.executenonquery("SP_TransformInsert",
                new Pararmeter("@Transform_Name", SqlDbType.NVarChar, txt_TraName.Text),
                new Pararmeter("@Transform_Address", SqlDbType.NVarChar, txt_Tranaddress.Text),
                new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Car_ID_No.EditValue.ToString())),
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_CompName.EditValue.ToString())));

                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindCompCarNo();
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
                    XtraMessageBox.Show("قم بأختيار اسم المكتب من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذاالمكتب ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        Retrive_Data.executenonquery("SP_TransformUpdate",
                new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                new Pararmeter("@Transform_Name", SqlDbType.NVarChar, txt_TraName.Text),
                new Pararmeter("@Transform_Address", SqlDbType.NVarChar, txt_Tranaddress.Text),
                new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Car_ID_No.EditValue.ToString())),
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_CompName.EditValue.ToString())));


                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboCompany();
                        BindCompCarNo();
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
                    XtraMessageBox.Show("قم بأختيار اسم المكتب من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذاالمكتب ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_TransformDelete",
                            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb__Record);
                        _Valid.TextClear(this, grb_Search);
                        BindComboCompany();
                        BindCompCarNo();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم المكتب اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_TransformSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["Transform_ID"].ToString();
                    txt_TraName.Text = dt.Rows[0]["Transform_Name"].ToString();
                    txt_Tranaddress.Text = dt.Rows[0]["Transform_Address"].ToString();
                    com_Car_ID_No.Text = dt.Rows[0]["Car_No"].ToString();
                    com_CompName.Text = dt.Rows[0]["Com_Name"].ToString();
                    BindGridByID();
                }

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void com_Car_ID_No_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (com_Car_ID_No.EditValue.ToString() != "System.Data.DataRowView")
                {
                    com_CompName.Properties.DataSource = Retrive_Data.executequery("Sp_CompSelectByCar_ID", CommandType.StoredProcedure,
            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Car_ID_No.EditValue.ToString())));
                    com_CompName.Properties.DisplayMember = "Com_Name";
                    com_CompName.Properties.ValueMember = "Com_ID";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}