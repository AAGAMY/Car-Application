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
    public partial class CarsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CarsForm()
        {
            InitializeComponent();
        }
        #region Validate
        Cl_Validate _Valid = new Cl_Validate();
        bool _AddNew = false;
        #endregion
        #region BindCombolstLicense
        void BindComboCarType()
        {
            List<string> lstC_Type = new List<string>();
            lstC_Type.Add("اتوبيس");
            lstC_Type.Add("ميكروباص");
            lstC_Type.Add("ملاكي");
            com_Car_Type.Properties.DataSource = lstC_Type;
        }

        #endregion
        #region BindComboSearch
        void BindComboSearch()
        {

            Com_CompName.Properties.DataSource = Retrive_Data.executequery("SP_CompaniesFillCombo", CommandType.StoredProcedure);
            Com_CompName.Properties.DisplayMember = "Com_Name";
            Com_CompName.Properties.ValueMember = "Com_ID";
            //com_Search.Text = "";
        }
        #endregion
        #region BindCompCarNo
        void BindCompCarNo()
        {
            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Car_No";
            com_Search.Properties.ValueMember = "Car_ID";
            //com_Search.Text = "";

        }
        #endregion
        #region BindGrid
        void BindGrid()
        {

            dgv_Cars.DataSource = Retrive_Data.executequery("SP_CarsSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }
        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Cars.DataSource = Retrive_Data.executequery("SP_CarsSelectAll", CommandType.StoredProcedure);
        }

        
        #endregion

        private void CarsForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboCarType();
            BindComboSearch();
            BindCompCarNo();
            BindGridAll();
        }

        private void CarsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة سيارة جديدة ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_CarName.Select();
                _AddNew = true;
                _Valid.TextClear(this, grb__Record);
                lbl_ID.Text = "0";
                //BindGridAll();
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
                    XtraMessageBox.Show("من فضلك إختار اسم الشركة اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_CarsSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["Car_ID"].ToString();
                    txt_CarName.Text = dt.Rows[0]["Car_No"].ToString();
                    com_Car_Type.Text = dt.Rows[0]["Car_Type"].ToString();
                    txt_License_No.Text = dt.Rows[0]["License_No"].ToString();
                    Dt_Expiry_date.Text = dt.Rows[0]["Expiry_date"].ToString();
                    Com_CompName.Text = dt.Rows[0]["Com_Name"].ToString();

                    BindGrid();

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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ بيانات سيارة جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_CarName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل رقم السيارة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (txt_License_No.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال رقم رخصة السيارة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (Com_CompName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال إسم الشركة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;


                    }

                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_CarsInsert",
                new Pararmeter("@Car_No", SqlDbType.NVarChar, txt_CarName.Text),
                new Pararmeter("@Car_Type", SqlDbType.NVarChar, com_Car_Type.Text),
                new Pararmeter("@License_No", SqlDbType.NVarChar, txt_License_No.Text),
                new Pararmeter("@Expiry_date", SqlDbType.Date, Dt_Expiry_date.Text),
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(Com_CompName.EditValue.ToString())));


                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindComboSearch();
                    //BindGrid();
                    BindGridAll();
                    BindCompCarNo();

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
                    XtraMessageBox.Show("قم بأختيار رقم السيارة من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذة السيارة ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_CarsUpdate",
                    new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                    new Pararmeter("@Car_No", SqlDbType.NVarChar, txt_CarName.Text),
                    new Pararmeter("@Car_Type", SqlDbType.NVarChar, com_Car_Type.Text),
                    new Pararmeter("@License_No", SqlDbType.NVarChar, txt_License_No.Text),
                    new Pararmeter("@Expiry_date", SqlDbType.Date, Dt_Expiry_date.Text),
                    new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(Com_CompName.EditValue.ToString())));


                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;

                        BindComboSearch();
                        BindGrid();
                        BindGridAll();
                        BindCompCarNo();

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
                    XtraMessageBox.Show("قم بأختيار رقم السيارة من قائمةالبحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذة السيارة ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_CarsDelete",
                            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;

                        BindComboSearch();
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb__Record);
                        BindGridAll();
                        BindCompCarNo();

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