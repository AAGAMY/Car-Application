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
    public partial class TransformShiftsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TransformShiftsForm()
        {
            InitializeComponent();
        }
        #region Validate
        Cl_Validate _Valid = new Cl_Validate();
        bool _AddNew = false;

        #endregion
        #region BindComboTranname
        void BindComboTranname()
        {

            com_Tranname.Properties.DataSource = Retrive_Data.executequery("SP_TransformFillComboFillCombo", CommandType.StoredProcedure);
            com_Tranname.Properties.DisplayMember = "Transform_Name";
            com_Tranname.Properties.ValueMember = "Transform_ID";
        }
        #endregion
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_TransformFillComboFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Transform_Name";
            com_Search.Properties.ValueMember = "Transform_ID";
        }
        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Transform.DataSource = Retrive_Data.executequery("SP_Transform_ShiftsSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        #region BindGridByID
        void BindGridByID()
        {

            dgv_Transform.DataSource = Retrive_Data.executequery("SP_Transform_ShiftsSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion


        private void TransformShiftsForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboTranname();
            BindGridAll();
            BindComboSearch();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void TransformShiftsForm_FormClosed(object sender, FormClosedEventArgs e)
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
                _Valid.TextClear(this, grb_Shifts);
                _Valid.TextClear(this, grb_Search);
                
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ وردية جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (com_Tranname.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم مكتب النقل ", "تنبية", MessageBoxButtons.OK,
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


                    Retrive_Data.executenonquery("SP_Transform_ShiftsInsert",
         new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Tranname.EditValue.ToString())),
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
                    XtraMessageBox.Show("قم بأختيار اسم مكتب النقل من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Shift_Quantity.Text.Trim() == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم مكتب النقل من الجدول حتى يتم التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات مكتب النقل ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        Retrive_Data.executenonquery("Sp_Transform_ShiftsUpdate",
         new Pararmeter("@Trans_Shift_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Shift_Salary", SqlDbType.Decimal, decimal.Parse(txt_Shift_Salary.Text)),
         new Pararmeter("@Shift_Quantity", SqlDbType.Int, int.Parse(txt_Shift_Quantity.Text.Trim())),
         new Pararmeter("@Shift_Date", SqlDbType.Date, Dt_date.Text));



                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                #region Delete Record
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم مكتب النقل من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات مكتب النقل ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_Transform_ShiftsDelete",
                            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Tranname.EditValue.ToString())));

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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم مكتب النقل اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_Transform_ShiftsSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Trans_Shift_ID"].ToString();
                        com_Tranname.Text = dt.Rows[0]["Transform_Name"].ToString();
                        txt_Shift_Salary.Text = dt.Rows[0]["Shift_Salary"].ToString();
                        //txt_Shift_Quantity.Text = dt.Rows[0]["Shift_Quantity"].ToString();
                        Dt_date.Text = dt.Rows[0]["Shift_Date"].ToString();

                        BindGridByID();
                    }
                    else
                    {
                        XtraMessageBox.Show("مكتب النقل هذا غير مسجل", "تحذير", MessageBoxButtons.OK,
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

        private void dgv_Transform_Click(object sender, EventArgs e)
        {
            try
            {
                com_Tranname.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Transform_Name") + "");
                txt_Shift_Salary.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_Salary") + "");
                txt_Shift_Quantity.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_Quantity") + "");
                Dt_date.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift_Date") + "");
                lbl_ID.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trans_Shift_ID") + "");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            try
            {
                #region Data_Validation
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم مكتب النقل من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
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
                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيان واحد ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {



                        Retrive_Data.executenonquery("SP_Transform_ShiftsDeleteOne",
         new Pararmeter("@Trans_Shift_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Shift_Salary", SqlDbType.Decimal, decimal.Parse(txt_Shift_Salary.Text)),
         new Pararmeter("@Shift_Quantity", SqlDbType.Int, int.Parse(txt_Shift_Quantity.Text.Trim())));



                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
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
    }
}