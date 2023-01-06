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
    public partial class SalariesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SalariesForm()
        {
            InitializeComponent();
        }


        #region BindGridByID
        void BindGridByID()
        {
            dgv_Salaries.DataSource = Retrive_Data.executequery("SP_SalariesSelectByID", CommandType.StoredProcedure,
                new Pararmeter("@Driver_ID", SqlDbType.Int, com_Search.EditValue.ToString()));
        }

        #endregion

        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_DriversFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Driver_Name";
            com_Search.Properties.ValueMember = "Driver_ID";
            com_Search.Text = "";
        }
        #endregion




        private void SalariesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void SalariesForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComboSearch();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم السائق اولاً", "تحذير", MessageBoxButtons.OK,
             MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;
                }
                else
                {
                    BindGridByID();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}