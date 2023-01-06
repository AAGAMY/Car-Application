using DevExpress.XtraBars;
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
    public partial class BalanceResultForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BalanceResultForm()
        {
            InitializeComponent();
        }
        #region BindGridAll
        void BindGridAll()
        {
            dgv_BalanceResult.DataSource = Retrive_Data.executequery("SP_BalanceResultSelectAll", CommandType.StoredProcedure);
        }

        #endregion
        private void BalanceResultForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindGridAll();
        }

        private void BalanceResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Dispose();
                FormOpened.IsMyFormOpened = false;
                Retrive_Data.executenonquery("SP_BalanceResultUpdate", CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }




    }
}