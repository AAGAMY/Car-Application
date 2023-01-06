using DevExpress.XtraEditors;
using LibraryApp.DAL;
using RealClass_lib;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarApp.Operations
{
    public partial class AdvancesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdvancesForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();

        #region BindComboDriverName
        void BindComboDriverName()
        {

            com_Dname.Properties.DataSource = Retrive_Data.executequery("SP_DriversFillCombo", CommandType.StoredProcedure);
            com_Dname.Properties.DisplayMember = "Driver_Name";
            com_Dname.Properties.ValueMember = "Driver_ID";

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
        #region BindGrid
        void BindGrid()
        {

            dgv_Advances.DataSource = Retrive_Data.executequery("SP_AdvancesSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Advances.DataSource = Retrive_Data.executequery("SP_AdvancesSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        #region FillDriverSalary
        void FillDriverSalary()
        {
            try
            {
                if (com_Dname.EditValue.ToString() != "System.Data.DataRowView")
                {
                    com_DriverSalary.Properties.DataSource = Retrive_Data.executequery("Sp_DriverSelectSalaryByDriver_ID", CommandType.StoredProcedure,
            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())));
                    com_DriverSalary.Properties.DisplayMember = "Driver_Salary";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        private void AdvancesForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
            BindComboDriverName();
            BindGridAll();

        }

        private void AdvancesForm_FormClosed(object sender, FormClosedEventArgs e)
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
            if (XtraMessageBox.Show("هل تريد أضافة سلفـــة جديدة ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TextClear(this, grb_Search);
                _Valid.TextClear(this, grb__Record);
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ سلفة جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (com_DriverSalary.Text == "0")
                    {
                        XtraMessageBox.Show("لايوجد مرتب لهذا السائق ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (com_DriverSalary.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك اعرض مرتب السائق ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        com_DriverSalary.Select();
                        return;
                    }


                    if (com_Dname.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم السائق ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    if (txt_Advance_amount.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال مبلغ السلفة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    if (Dt_Advance_date.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال تاريخ السلفة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }

                    if (com_DriverSalary.Text != "")
                    {
                        if (double.Parse(txt_Advance_amount.Text) > double.Parse(com_DriverSalary.Text))
                        {
                            XtraMessageBox.Show("عفواً السلفة اكبر من المرتب", "تنبية", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                            com_DriverSalary.Select();
                            return;

                        }
                    }



                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_AdvancesInsert",
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())),
         new Pararmeter("@Advance_amount", SqlDbType.Int, int.Parse(txt_Advance_amount.Text)),
         new Pararmeter("@Advance_Date", SqlDbType.Date, Dt_Advance_date.Text));



                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindComboSearch();
                    BindGridAll();
                    FillDriverSalary();

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
                    dt = Retrive_Data.executequery("SP_AdvancesSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Advance_ID"].ToString();
                        com_Dname.Text = dt.Rows[0]["Driver_Name"].ToString();
                        txt_Advance_amount.Text = dt.Rows[0]["Advance_amount"].ToString();
                        Dt_Advance_date.Text = dt.Rows[0]["Advance_Date"].ToString();
                        BindGrid();
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
                        Retrive_Data.executenonquery("SP_AdvancesDelete",
                            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb__Record);
                        _Valid.TextClear(this, grb_Search);
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

        private void com_Dname_EditValueChanged(object sender, EventArgs e)
        {
            FillDriverSalary();
            
        }

        private void dgv_Advances_Click(object sender, EventArgs e)
        {
            try
            {
                com_Dname.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Driver_Name") + "");
                Dt_Advance_date.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Advance_Date") + "");
                txt_Advance_amount.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Advance_amount") + "");
                lbl_ID.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Advance_ID") + "");

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
                if (txt_Advance_amount.Text.Trim() == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم السائق من الجدول حتى يتم الحذف", "خطأ", MessageBoxButtons.OK,
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



                        Retrive_Data.executenonquery("SP_AdvancesDeleteOne",
         new Pararmeter("@Advance_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Advance_amount", SqlDbType.Int, int.Parse(txt_Advance_amount.Text)));



                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        BindGrid();
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
    }
}