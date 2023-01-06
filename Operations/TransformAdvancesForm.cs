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
    public partial class TransformAdvancesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TransformAdvancesForm()
        {
            InitializeComponent();
        }
        #region Validation
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #endregion
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_TransformFillComboFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Transform_Name";
            com_Search.Properties.ValueMember = "Transform_ID";
        }
        #endregion
        #region BindComboTranname
        void BindComboTranname()
        {

            com_Tranname.Properties.DataSource = Retrive_Data.executequery("SP_TransformFillComboFillCombo", CommandType.StoredProcedure);
            com_Tranname.Properties.DisplayMember = "Transform_Name";
            com_Tranname.Properties.ValueMember = "Transform_ID";
        }
        #endregion
        #region BindGridByID
        void BindGridByID()
        {

            dgv_Advances.DataSource = Retrive_Data.executequery("SP_Transform_AdvancesSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Advances.DataSource = Retrive_Data.executequery("SP_Transform_AdvancesSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        #region FillTransSalary
        void FillTransSalary()
        {
            try
            {
                if (com_Tranname.EditValue.ToString() != "System.Data.DataRowView")
                {
                    com_TransSalary.Properties.DataSource = Retrive_Data.executequery("Sp_TransformSelectSalaryByTransform_ID", CommandType.StoredProcedure,
            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Tranname.EditValue.ToString())));
                    com_TransSalary.Properties.DisplayMember = "Transform_Salary";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void TransformAdvancesForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
            BindComboTranname();
            BindGridAll();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void TransformAdvancesForm_FormClosed(object sender, FormClosedEventArgs e)
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

                    if (com_TransSalary.Text == "0")
                    {
                        XtraMessageBox.Show("لايوجد مرتب لهذا المكتب ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (com_TransSalary.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك اعرض مرتب مكتب النقل ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        com_TransSalary.Select();
                        return;
                    }


                    if (com_Tranname.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم مكتب النقل ", "تنبية", MessageBoxButtons.OK,
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

                    if (com_TransSalary.Text != "")
                    {
                        if (double.Parse(txt_Advance_amount.Text) > double.Parse(com_TransSalary.Text))
                        {
                            XtraMessageBox.Show("عفواً السلفة اكبر من المرتب", "تنبية", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                            com_TransSalary.Select();
                            return;

                        }
                    }



                    #endregion

                    #region SaveData
                    Retrive_Data.executenonquery("SP_Transform_AdvancesInsert",
         new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Tranname.EditValue.ToString())),
         new Pararmeter("@Advance_amount", SqlDbType.Int, int.Parse(txt_Advance_amount.Text)),
         new Pararmeter("@Advance_Date", SqlDbType.Date, Dt_Advance_date.Text));
                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindComboSearch();
                    BindGridAll();
                    FillTransSalary();
                    #endregion
                }
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

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات مكتب النقل هذا ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("SP_Transform_AdvancesDelete",
                            new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Tranname.EditValue.ToString())));

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
                    dt = Retrive_Data.executequery("SP_Transform_AdvancesSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Trans_Advanc_ID"].ToString();
                        com_Tranname.Text = dt.Rows[0]["Transform_Name"].ToString();
                        txt_Advance_amount.Text = dt.Rows[0]["Advance_amount"].ToString();
                        Dt_Advance_date.Text = dt.Rows[0]["Advance_Date"].ToString();
                        BindGridByID();
                    }
                    else
                    {
                        XtraMessageBox.Show("هذالمكتب غير مسجل", "تحذير", MessageBoxButtons.OK,
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

        private void com_Tranname_EditValueChanged(object sender, EventArgs e)
        {
            FillTransSalary();

        }

        private void dgv_Advances_Click(object sender, EventArgs e)
        {
            try
            {
                com_Tranname.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Transform_Name") + "");
                Dt_Advance_date.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Advance_Date") + "");
                txt_Advance_amount.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Advance_amount") + "");
                lbl_ID.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Trans_Advanc_ID") + "");

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
                    XtraMessageBox.Show("قم بأختيار اسم مكتب النقل من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Advance_amount.Text.Trim() == "")
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



                        Retrive_Data.executenonquery("SP_Transform_AdvancesDeleteOne",
         new Pararmeter("@Trans_Advanc_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
         new Pararmeter("@Transform_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
         new Pararmeter("@Advance_amount", SqlDbType.Int, int.Parse(txt_Advance_amount.Text)));



                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComboSearch();
                        BindGridByID();
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