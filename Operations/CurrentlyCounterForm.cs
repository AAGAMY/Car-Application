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
    public partial class CurrentlyCounterForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CurrentlyCounterForm()
        {
            InitializeComponent();
        }
        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();

        #region BindCompSearch
        void BindCompSearch()
        {
            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Car_No";
            com_Search.Properties.ValueMember = "Car_ID";
            //com_Search.Text = "";

        }
        #endregion
        #region BindCompCarNo
        void BindCompCarNo()
        {
            com_CarNo.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_CarNo.Properties.DisplayMember = "Car_No";
            com_CarNo.Properties.ValueMember = "Car_ID";
            //com_Search.Text = "";

        }
        #endregion
        #region SaveData
        void SaveData()
        {
            if (lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات العداد ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrive_Data.executenonquery("SP_Currently_counterUpdate",
   new Pararmeter("@Currently_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
   new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_CarNo.EditValue.ToString())),
   new Pararmeter("@Curr_Big_Counter", SqlDbType.Int, int.Parse(txt_Big_Counter.Text)),
   new Pararmeter("@Curr_Small_Counter", SqlDbType.Int, int.Parse(txt_Small_Counter.Text)),
   new Pararmeter("@Curr_Date", SqlDbType.Date, (Dt_date.Text)));

                    XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindCompCarNo();
                    BindCompSearch();
                    return;
                }

            }

        }

        #endregion
        private void CurrentlyCounterForm_Load(object sender, EventArgs e)
        {
            BindCompSearch();
            BindCompCarNo();
            FormOpened.IsMyFormOpened = true;

        }

        private void CurrentlyCounterForm_FormClosed(object sender, FormClosedEventArgs e)
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
                lbl_Big_Mini.Text = "0";
                lbl_Small_Mini.Text = "0";
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

                    #region SaveDatainsert
                    if (txt_Big_Counter.Text == "")
                    {
                        txt_Big_Counter.Text = "0";
                    }
                    if (txt_Small_Counter.Text == "")
                    {
                        txt_Small_Counter.Text = "0";
                    }
                    Retrive_Data.executenonquery("SP_Currently_counterInsert",
        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_CarNo.EditValue.ToString())),
        new Pararmeter("@Curr_Big_Counter", SqlDbType.Int, int.Parse(txt_Big_Counter.EditValue.ToString())),
        new Pararmeter("@Curr_Small_Counter", SqlDbType.Int, int.Parse(txt_Small_Counter.Text)),
        new Pararmeter("@Curr_Date", SqlDbType.Date, (Dt_date.Text)));



                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindCompSearch();
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
                    XtraMessageBox.Show("من فضلك إختار رقم السيارة اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_Currently_counterByID", CommandType.StoredProcedure,
                        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

                    if (dt.Rows.Count > 0)
                    {

                        lbl_ID.Text = dt.Rows[0]["Currently_ID"].ToString();
                        com_CarNo.Text = dt.Rows[0]["Car_No"].ToString();
                        txt_Big_Counter.Text = dt.Rows[0]["Curr_Big_Counter"].ToString();
                        txt_Small_Counter.Text = dt.Rows[0]["Curr_Small_Counter"].ToString();
                        Dt_date.Text = dt.Rows[0]["Curr_Date"].ToString();
                        lbl_Big_Mini.Text = dt.Rows[0]["Big_Mini"].ToString();
                        lbl_Small_Mini.Text = dt.Rows[0]["Small_Mini"].ToString();

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

                #region Save With Big Counter
                if (txt_Big_Counter.Text != "0")
                {
                    if (int.Parse(txt_Big_Counter.Text) >= int.Parse(lbl_Big_Mini.Text))
                    {
                        if (XtraMessageBox.Show("القراءة الحالية للعداد الكبير وصلت الى الحد الأدني . هل تريد استكمال التعديل؟", "تنبية", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SaveData();
                        }
                    }
                    else
                    {
                        SaveData();
                    }
                }

                #endregion

                #region Save With Small Counter
                if (txt_Small_Counter.Text != "0")
                {
                    if (int.Parse(txt_Small_Counter.Text) >= int.Parse(lbl_Small_Mini.Text))
                    {
                        if (XtraMessageBox.Show("القراءة الحالية للعداد الصغير وصلت الى الحد الأدني . هل تريد استكمال التعديل؟", "تنبية", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SaveData();
                        }
                    }
                    else
                    {
                        SaveData();
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