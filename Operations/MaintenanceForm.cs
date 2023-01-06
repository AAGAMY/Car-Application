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

namespace CarApp.Operations
{
    public partial class MaintenanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MaintenanceForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindGridByID
        void BindGridByID()
        {

            dgv_Maintenance.DataSource = Retrive_Data.executequery("SP_MaintenanceSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Maintenance.DataSource = Retrive_Data.executequery("SP_MaintenanceSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        #region BindCompSearch
        void BindCompSearch()
        {
            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Car_No";
            com_Search.Properties.ValueMember = "Car_ID";
        }
        #endregion
        #region BindCompIDNo
        void BindCarNo()
        {
            com_CarNo.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_CarNo.Properties.DisplayMember = "Car_No";
            com_CarNo.Properties.ValueMember = "Car_ID";
        }
        #endregion

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindCarNo();
            BindCompSearch();
            BindGridAll();


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void MaintenanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة بيان جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ عملية صيانة جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (com_CarNo.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل رقم السيارة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Maintenance_Type.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل نوع الصيانة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Maintenance_amount.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل مبلغ الصيانة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_MaintenanceInsert",
        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_CarNo.EditValue.ToString())),
        new Pararmeter("@Maintenance_Type", SqlDbType.NVarChar, (txt_Maintenance_Type.Text)),
        new Pararmeter("@Maintenance_Date", SqlDbType.Date, (Dt_Maintenance_Date.Text)),
        new Pararmeter("@Maintenance_amount", SqlDbType.Decimal, decimal.Parse(txt_Maintenance_amount.Text)));


                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindCompSearch();
                    BindCarNo();
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
                    XtraMessageBox.Show("قم بأختيار رقم السيارة من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات الصيانة ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_MaintenanceUpdate",
       new Pararmeter("@Main_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_CarNo.EditValue.ToString())),
        new Pararmeter("@Maintenance_Type", SqlDbType.NVarChar, (txt_Maintenance_Type.Text)),
        new Pararmeter("@Maintenance_Date", SqlDbType.Date, (Dt_Maintenance_Date.Text)),
        new Pararmeter("@Maintenance_amount", SqlDbType.Decimal, decimal.Parse(txt_Maintenance_amount.Text)));

                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindCarNo();
                        BindCompSearch();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار رقم السيارة اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_MaintenanceSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Main_ID"].ToString();
                        com_CarNo.Text = dt.Rows[0]["Car_No"].ToString();
                        txt_Maintenance_Type.Text = dt.Rows[0]["Maintenance_Type"].ToString();
                        Dt_Maintenance_Date.Text = dt.Rows[0]["Maintenance_Date"].ToString();
                        txt_Maintenance_amount.Text = dt.Rows[0]["Maintenance_amount"].ToString();
                        BindGridByID();
                    }
                    else
                    {
                        XtraMessageBox.Show("بيانات عداد هذة السيارة غير مسجل", "تحذير", MessageBoxButtons.OK,
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
                    XtraMessageBox.Show("قم بأختيار رقم السيارة من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذا العداد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_MaintenanceDelete",
                            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindCompSearch();
                        BindCarNo();
                        BindGridByID();
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

        private void txt_Maintenance_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }
    }
}