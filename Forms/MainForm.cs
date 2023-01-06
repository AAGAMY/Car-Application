using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.DAL;
using DevExpress.XtraEditors;
using RealClass_lib;
using System.Configuration;
using DevExpress.XtraBars.Helpers;
using CarApp;
using CarApp.Operations;
using CarApp.Accounts;
using Microsoft.Win32;
using CarApp.Reportes;

namespace CarApp.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public MainForm()
        {
            InitializeComponent();
            //InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);

        }


        #region ConnecionDb
        void ConnecionDb()
        {
            mainclass.ConnString = ConfigurationManager.ConnectionStrings
            ["CarDBConnectionString"].ConnectionString;
        }

        #endregion


        private void navitemDrivers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { 
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }


            DriversForm DF = new DriversForm();
            DF.MdiParent = this;
            DF.Show();

            
        }

        private void navitemComp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }


            CompaniesForm COF = new CompaniesForm();
            COF.MdiParent = this;
            COF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnecionDb();
            #region Fixed_Skin

            RegistryKey SkinName = Registry.CurrentUser.CreateSubKey(@"software\winregistry");
            if (SkinName != null)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = SkinName.GetValue("SkinName").ToString();
            }

            #endregion
        }

        private void navitemCars_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }


            CarsForm CF = new CarsForm();
            CF.MdiParent = this;
            CF.Show();

           
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }


            InvestorsForm INF = new InvestorsForm();
            INF.MdiParent = this;
            INF.Show();

        }

        private void navItems_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            ItemsForm ITF = new ItemsForm();
            ITF.MdiParent = this;
            ITF.Show();


        }

        private void navVendors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            VendorsForm VF = new VendorsForm();
            VF.MdiParent = this;
            VF.Show();

        }

        private void navBarMain_Purchases_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            PurchasesDataForm PF = new PurchasesDataForm();
            PF.MdiParent = this;
            PF.Show();
            

        }

        private void navBarVenAccount_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            VenAccountDataForm VAF = new VenAccountDataForm();
            VAF.MdiParent = this;
            VAF.Show();

        }

        private void navBarVenPopUp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            VenAccountPopUpForm VPF = new VenAccountPopUpForm();
            VPF.MdiParent = this;
            VPF.Show();

        }

        private void navCustomers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            CustomersForm CF = new CustomersForm();
            CF.MdiParent = this;
            CF.Show();

        }

        private void navBarMain_Sales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            SalesDataForm SF = new SalesDataForm();
            SF.MdiParent = this;
            SF.Show();

        }

        private void navBarCustAccount_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            CustAccountDataForm CAF = new CustAccountDataForm();
            CAF.MdiParent = this;
            CAF.Show();

        }

        private void navBarCustPopUp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            CustAccountPopUpForm CAPF = new CustAccountPopUpForm();
            CAPF.MdiParent = this;
            CAPF.Show();

        }

        private void navBarShifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            ShiftsForm SHF = new ShiftsForm();
            SHF.MdiParent = this;
            SHF.Show();

        }

        private void navBarEditShifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            AdvancesForm ADF = new AdvancesForm();
            ADF.MdiParent = this;
            ADF.Show();

        }

        private void navBarSalaries_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            SalariesForm SF = new SalariesForm();
            SF.MdiParent = this;
            SF.Show();

        }

        private void navBarInvSalaries_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            InvSalariesForm InSF = new InvSalariesForm();
            InSF.MdiParent = this;
            InSF.Show();

        }

        private void navBarCounters_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }


            CountersForm COF = new CountersForm();
            COF.MdiParent = this;
            COF.Show();
        }

        private void navBarCurrenCounter_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            CurrentlyCounterForm CCF = new CurrentlyCounterForm();
            CCF.MdiParent = this;
            CCF.Show();

        }

        private void navBarMaintenance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            MaintenanceForm MF = new MaintenanceForm();
            MF.MdiParent = this;
            MF.Show();

        }

        private void navBarTransform_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            TransformForm TF = new TransformForm();
            TF.MdiParent = this;
            TF.Show();

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            TransformShiftsForm TSHF = new TransformShiftsForm();
            TSHF.MdiParent = this;
            TSHF.Show();

        }

        private void navBarTransformAdvances_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            TransformAdvancesForm TAF = new TransformAdvancesForm();
            TAF.MdiParent = this;
            TAF.Show();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region Fixed_Skin

            RegistryKey SkinName = Registry.CurrentUser.CreateSubKey(@"software\winregistry");
            SkinName.SetValue("SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName.ToString());
            SkinName.Close();
            #endregion

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void navBarBalance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            BalanceForm BF = new BalanceForm();
            BF.MdiParent = this;
            BF.Show();

        }

        private void navBarTransSalaries_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            TransformSalaries TSF = new TransformSalaries();
            TSF.MdiParent = this;
            TSF.Show();
        }

        private void navBarBalanceResult_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }
            Retrive_Data.executenonquery("SP_BalanceResult", CommandType.StoredProcedure);
            BalanceResultForm BRF = new BalanceResultForm();
            BRF.MdiParent = this;
            BRF.Show();

            
        }

        private void NavBarInvoice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }
            InvoiceForm INF = new InvoiceForm();
            INF.MdiParent = this;
            INF.Show();
        }

        private void navBarOffers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }
            OffersForm OF = new OffersForm();
            OF.MdiParent = this;
            OF.Show();
        }

        private void navBarOverTime_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            OverTimeForm OTF = new OverTimeForm();
            OTF.MdiParent = this;
            OTF.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }
            ReceiptForm RF = new ReceiptForm();
            RF.MdiParent = this;
            RF.Show();
        }

        private void navBarUserInfo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (FormOpened.IsMyFormOpened == true)
            {
                XtraMessageBox.Show("النافذة مفتوحة بالفعل", "تحذير", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);

                return;
            }

            UserInfoForm UF = new UserInfoForm();
            UF.MdiParent = this;
            UF.Show();
        }
    }
   
}

