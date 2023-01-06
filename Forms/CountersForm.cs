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
    public partial class CountersForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CountersForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindGrid
        void BindGrid()
        {

            dgv_Salaries.DataSource = Retrive_Data.executequery("SP_CountersSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Salaries.DataSource = Retrive_Data.executequery("SP_CountersSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        #region BindCompSearch
        void BindCompSearch()
        {
            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Car_No";
            com_Search.Properties.ValueMember = "Car_ID";
            //com_Search.Text = "";

        }
        #endregion
        #region BindCompIDNo
        void BindCompIDNo()
        {
            com_Car_ID_No.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_Car_ID_No.Properties.DisplayMember = "Car_No";
            com_Car_ID_No.Properties.ValueMember = "Car_ID";
            //com_Search.Text = "";

        }
        #endregion


        private void CountersForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindCompSearch();
            BindGridAll();
            BindCompIDNo();
            

        }

        private void CountersForm_FormClosed(object sender, FormClosedEventArgs e)
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
            if (XtraMessageBox.Show("هل تريد أضافة بيان جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TextClear(this, grb__Record);
                _Valid.TextClear(this, grb_Search);
                lbl_ID.Text = "0";
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ بيانات عداد جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (com_Car_ID_No.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل رقم السيارة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (txt_Big_Counter.Text == "")
                    {
                        txt_Big_Counter.Text = "0";
                    }
                    if (txt_Big_Mini.Text == "")
                    {
                        txt_Big_Mini.Text = "0";
                    }
                    if (txt_Small_Counter.Text == "")
                    {
                        txt_Small_Counter.Text = "0";
                    }
                    if (txt_Small_Mini.Text == "")
                    {
                        txt_Small_Mini.Text = "0";
                    }
                    #endregion

                    #region SaveData


                    Retrive_Data.executenonquery("SP_CountersInsert",
        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Car_ID_No.EditValue.ToString())),
        new Pararmeter("@Big_Counter", SqlDbType.Int, int.Parse(txt_Big_Counter.Text)),
        new Pararmeter("@Big_Mini", SqlDbType.Int, int.Parse(txt_Big_Mini.Text)),
        new Pararmeter("@Small_Counter", SqlDbType.Int, int.Parse(txt_Small_Counter.Text)),
        new Pararmeter("@Small_Mini", SqlDbType.Int, int.Parse(txt_Small_Mini.Text)));


                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindCompSearch();
                    BindCompIDNo();
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
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات العداد ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        Retrive_Data.executenonquery("SP_CountersUpdate",
       new Pararmeter("@Counter_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
       new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Car_ID_No.EditValue.ToString())),
       new Pararmeter("@Big_Counter", SqlDbType.Int, int.Parse(txt_Big_Counter.Text)),
       new Pararmeter("@Big_Mini", SqlDbType.Int, int.Parse(txt_Big_Mini.Text)),
       new Pararmeter("@Small_Counter", SqlDbType.Int, int.Parse(txt_Small_Counter.Text)),
       new Pararmeter("@Small_Mini", SqlDbType.Int, int.Parse(txt_Big_Mini.Text)));

                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindCompIDNo();
                        BindCompSearch();
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
                    dt = Retrive_Data.executequery("SP_CountersSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Car_ID"].ToString();
                        com_Car_ID_No.Text = dt.Rows[0]["Car_No"].ToString();
                        txt_Big_Counter.Text = dt.Rows[0]["Big_Counter"].ToString();
                        txt_Big_Mini.Text = dt.Rows[0]["Big_Mini"].ToString();
                        txt_Small_Counter.Text = dt.Rows[0]["Small_Counter"].ToString();
                        txt_Small_Mini.Text = dt.Rows[0]["Small_Mini"].ToString();
                        BindGrid();
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
                        Retrive_Data.executenonquery("SP_CountersDelete",
                            new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindCompSearch();
                        BindCompIDNo();
                        BindGridAll();
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
    }
}