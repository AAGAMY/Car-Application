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
    public partial class VenAccountPopUpForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public VenAccountPopUpForm()
        {
            InitializeComponent();
        }

        private void VenAccountPopUpForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_ShowVenAccount.DataSource = Retrive_Data.executequery("Sp_Ven_AccountSelectAll", CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            FormOpened.IsMyFormOpened = true;

        }

        private void VenAccountPopUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;



        }
    }
}