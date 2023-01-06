using CarApp.Forms;
using DevExpress.XtraEditors;
using RealClass_lib;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
      int nLeftRect,
      int nTopRect,
      int nRightRect,
      int nBottomRect,
      int nWidthEllipse,
      int nHeightEllipse
      );
        MainForm MF = new MainForm();
        #region Validation
        void Validation()
        {
            MF.navBarUserInfo.Enabled = false;
            MF.navBarMain_Purchases.Enabled = false;
            MF.navBarMain_Sales.Enabled = false;
            MF.navBarTransform_Shifts.Enabled = false;
            MF.navBarOverTime.Enabled = false;
            MF.navBarTransformShifts.Enabled = false;
            MF.navBarAdvances.Enabled = false;
            MF.navBarTransformAdvances.Enabled = false;
            MF.navBarCurrenCounter.Enabled = false;
            MF.navBarMaintenance.Enabled = false;
            MF.navBarVenAccount.Enabled = false;
            MF.navBarCustAccount.Enabled = false;
            MF.navBarSalaries.Enabled = false;
            MF.navBarTransSalaries.Enabled = false;
            MF.navBarInvSalaries.Enabled = false;
            MF.navBarBalance.Enabled = false;
            MF.navBarBalanceResult.Enabled = false;
            MF.navBarInvoice.Enabled = false;
            MF.navBarOffers.Enabled = false;
            MF.navBarReceipt.Enabled = false;

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gray;
        }
        public Point mouseLocation;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;

        }


        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
            else
            {
                txtPassword.isPassword = true;

            }

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User Name";
            }

            else
            {
                txtUserName.Text = txtUserName.Text;
            }
            txtPassword.isPassword = true;

        }



        private void Login_Load(object sender, EventArgs e)
        {
            mainclass.ConnString = ConfigurationManager.ConnectionStrings
            ["CarDBConnectionString"].ConnectionString;
            txtUserName.Select();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Retrive_Data.executequery($@"select [dbo].[IsAdmin]('{txtUserName.Text.Trim()}','{txtPassword.Text.Trim()}')", CommandType.Text);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "0")
                {
                    XtraMessageBox.Show("اسم المستخدم او كلمة المرور خطأ");
                    txtUserName.Select();
                    return;
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Validation();
                    MF.Show();
                    this.Hide();

                }
                else
                {
                    MF.Show();
                    this.Hide();

                }

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(13))
            {
                DataTable dt = new DataTable();
                dt = Retrive_Data.executequery($@"select [dbo].[IsAdmin]('{txtUserName.Text.Trim()}','{txtPassword.Text.Trim()}')", CommandType.Text);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() == "0")
                    {
                        XtraMessageBox.Show("اسم المستخدم او كلمة المرور خطأ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserName.Select();
                        return;
                    }
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Validation();
                        MF.Show();
                        this.Hide();

                    }
                    else
                    {
                        MF.Show();
                        this.Hide();

                    }
                }
            }
        }
    }
}
