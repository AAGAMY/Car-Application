using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using System.Windows;
using System.Windows.Forms;
//using System.Windows.MessageBox;

namespace CarApp.Operations
{
    public partial class ShiftsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ShiftsForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_DriversFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Driver_Name";
            com_Search.Properties.ValueMember = "Driver_ID";
            com_Search.Text = "";
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
        #region BindGrid
        void BindGrid()
        {

            dgv_Shifts.DataSource = Retrive_Data.executequery("SP_ShiftsSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Shifts.DataSource = Retrive_Data.executequery("SP_ShiftsSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void ShiftsForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
            BindComboDriverName();
            BindGridAll();

        }

        private void ShiftsForm_FormClosed(object sender, FormClosedEventArgs e)
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
            if (XtraMessageBox.Show("هل تريد أضافة سائق جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TextClear(this, grb_Shifts);
                BindGridAll();
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
                    dt = Retrive_Data.executequery("SP_ShiftsSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Shift_ID"].ToString();
                        com_Dname.Text = dt.Rows[0]["Driver_Name"].ToString();
                        txt_Shift_Salary.Text = dt.Rows[0]["Shift_Salary"].ToString();
                        //txt_Shift_Quantity.Text = dt.Rows[0]["Shift_Quantity"].ToString();
                        Dt_date.Text = dt.Rows[0]["Shift_Date"].ToString();

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
                        Retrive_Data.executenonquery("SP_ShiftsDelete",
                            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb_Shifts);
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


                    if (txt_Shift_Salary.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال مبلغ الوردية", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    if (txt_Shift_Quantity.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال عدد الورديات", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;

                    }
                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_ShiftsInsert",
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Dname.EditValue.ToString())),
         new Pararmeter("@Shift_Salary", SqlDbType.Decimal, decimal.Parse(txt_Shift_Salary.Text)),
         new Pararmeter("@Shift_Quantity", SqlDbType.Int, int.Parse(txt_Shift_Quantity.Text.Trim())),
         new Pararmeter("@Shift_Date", SqlDbType.Date, Dt_date.Text));


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
                    XtraMessageBox.Show("قم بأختيار اسم السائق من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Shift_Quantity.Text.Trim() == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم السائق من الجدول حتى يتم التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion
                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذاالسائق ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        Retrive_Data.executenonquery("Sp_ShiftsUpdate",
         new Pararmeter("@Shift_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Shift_Salary", SqlDbType.Decimal, decimal.Parse(txt_Shift_Salary.Text)),
         new Pararmeter("@Shift_Quantity", SqlDbType.Int, int.Parse(txt_Shift_Quantity.Text.Trim())),
         new Pararmeter("@Shift_Date", SqlDbType.Date, Dt_date.Text));



                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        //Bindcom_CompName();
                        //BindCombo();
                        BindComboSearch();
                        BindGrid();


                    }

                }

                #endregion


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_Shifts_Click(object sender, EventArgs e)
        {
            try
            {
                com_Dname.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Driver_Name") + "");
                txt_Shift_Salary.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_Salary") + "");
                txt_Shift_Quantity.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_Quantity") + "");
                Dt_date.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_Date") + "");
                lbl_ID.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_ID") + "");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgv_Shifts_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
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
                if (txt_Shift_Quantity.Text.Trim() == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم مكتب النقل من الجدول حتى يتم الحذف", "خطأ", MessageBoxButtons.OK,
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



                        Retrive_Data.executenonquery("SP_ShiftsDeleteOne",
         new Pararmeter("@Shift_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Shift_Salary", SqlDbType.Decimal, decimal.Parse(txt_Shift_Salary.Text)),
         new Pararmeter("@Shift_Quantity", SqlDbType.Int, int.Parse(txt_Shift_Quantity.Text.Trim())));



                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        BindGrid();


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

