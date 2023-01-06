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
    public partial class CustAccountDataForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CustAccountDataForm()
        {
            InitializeComponent();
        }
        #region BindCombo

        void BindCombo()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CustomersFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Cust_Name";
            com_Search.Properties.ValueMember = "Cust_ID";
            //com_Search.Text = "";


        }


        #endregion


        bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (com_Search.Text != "")
                {
                    DataTable dt = Retrive_Data.executequery("SP_CustomersSelectByID", CommandType.StoredProcedure, new Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));
                    txtRemainValue.Text = dt.Rows[0]["Cust_Debit"].ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CustAccountDataForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindCombo();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void CustAccountDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            // هنا قمت بالتأكيد على المستخدم بعملية اضافة صنف جديد
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
            try
            {
                #region SureData


                if (_AddNew == false)
                {
                    XtraMessageBox.Show("من فضلك إضغط على مفتاح جديد اولاً", "تحذير", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (XtraMessageBox.Show("هل انت متأكد من حفظ عميل جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
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
                            XtraMessageBox.Show("لايوجد مبلغ متبقى على العميل", "تنبية", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                            return;

                        }
                    }
                }
                #endregion

                #region SaveData



                Retrive_Data.executenonquery("Sp_Cust_AccountInsert",
                    new Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())),
                    new Pararmeter("@Payed_Value", SqlDbType.Decimal, decimal.Parse(txtPayedValue.Text)),
                    new Pararmeter("@Date_Payed", SqlDbType.Date, Dt_Date.DateTime.Date));

                XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                _AddNew = false;
                _Valid.TextClear(this, grb_Search);
                _Valid.TextClear(this, grb_Account);
                com_Search.Select();

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}