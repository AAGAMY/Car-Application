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

namespace CarApp.Accounts
{
    public partial class VenAccountDataForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public VenAccountDataForm()
        {
            InitializeComponent();
        }
        #region BindCombo

        void BindCombo()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_VendorsFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Vendor_Name";
            com_Search.Properties.ValueMember = "Ven_ID";


        }


        #endregion

        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        private void VenAccountDataForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindCombo();

        }

        private void VenAccountDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم المورد اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_VendorsSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    txtRemainValue.Text = dt.Rows[0]["Ven_Debit"].ToString();


                }

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة سداد جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TextClear(this, grb_Search);
                _Valid.TextClear(this, grb_Account);
                com_Search.Select();
                _AddNew = true;
            }
            #endregion

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //try
            //{
                #region SureData


                if (_AddNew == false)
                {
                    XtraMessageBox.Show("من فضلك إضغط على مفتاح جديد اولاً", "تحذير", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (XtraMessageBox.Show("هل انت متأكد من حفظ مورد جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtPayedValue.Text != "")
                    {
                        if (double.Parse(txtPayedValue.Text) > double.Parse(txtRemainValue.Text))
                        {
                            XtraMessageBox.Show("عفواً المبلغ المدفوع اكبر من المبلغ المتبقي", "تنبية", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                            txtPayedValue.Select();
                            return;

                        }
                    }
                    else
                    {
                        if (txtRemainValue.Text == "0")
                        {
                            XtraMessageBox.Show("لايوجد مبلغ متبقى للمورد", "تنبية", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                            return;

                        }
                    }
                }
                #endregion

                #region SaveData



                Retrive_Data.executenonquery("Sp_Ven_AccountInsert",
                    new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
                    new Pararmeter("@Payed_Value", SqlDbType.Decimal, decimal.Parse(txtPayedValue.Text)),
                    new Pararmeter("@Payed_Date", SqlDbType.Date, Dt_Date.DateTime.Date));

                XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                _AddNew = false;
                _Valid.TextClear(this, grb_Search);
                _Valid.TextClear(this, grb_Account);
                com_Search.Select();

                #endregion

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}