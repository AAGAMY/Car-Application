using DevExpress.XtraEditors;
using RealClass_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarApp;
using LibraryApp.DAL;
using System.IO;

namespace CarApp.Forms
{
    public partial class DriversForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DriversForm()
        {
            InitializeComponent();
        }
        #region Validate
        Cl_Validate _Valid = new Cl_Validate();
        bool _AddNew = false;

        #endregion
        #region BindCombolstLicense
        void BindCombo()
        {
            List<string> lstLicense = new List<string>();
            lstLicense.Add("رخصة اولي");
            lstLicense.Add("رخصة ثانية");
            lstLicense.Add("رخصة ثالثة");
            lstLicense.Add("رخصة خاصة");
            com_License_type.Properties.DataSource = lstLicense;
        }

        #endregion
        #region BindComboSearch
        void BindComboSearch()
        {

            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_DriversFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Driver_Name";
            com_Search.Properties.ValueMember = "Driver_ID";
            //com_Search.Text = "";
        }
        #endregion
        #region BindCompCarNo
        void BindCompCarNo()
        {
            com_CarNo.Properties.DataSource = Retrive_Data.executequery("SP_CarNoFillCombo", CommandType.StoredProcedure);
            com_CarNo.Properties.DisplayMember = "Car_No";
            com_CarNo.Properties.ValueMember = "Car_ID";
            //com_CarNo.Text = "";

        }
        #endregion
        #region Bindcom_CompName
        void Bindcom_CompName()
        {

            com_CompName.Properties.DataSource = Retrive_Data.executequery("SP_CompaniesFillCombo", CommandType.StoredProcedure);
            com_CompName.Properties.DisplayMember = "Com_Name";
            com_CompName.Properties.ValueMember = "Com_ID";
            //com_CompName.Text = "";
        }

        #endregion
        #region BindGrid
        void BindGrid()
        {

            dgv_Drivers.DataSource = Retrive_Data.executequery("SP_DriversSelectByID", CommandType.StoredProcedure,
            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

        }

        #endregion
        #region BindGridAll
        void BindGridAll()
        {
            dgv_Drivers.DataSource = Retrive_Data.executequery("SP_DriversSelectAll", CommandType.StoredProcedure);
        }

        #endregion


        private void DriversForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            
            BindCombo();
            BindComboSearch();
            Bindcom_CompName();
            BindCompCarNo();
            BindGridAll();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("من فضلك إختار اسم السائق اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_DriversSelectByID", CommandType.StoredProcedure,
                        new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));


                    lbl_ID.Text = dt.Rows[0]["Driver_ID"].ToString();
                    txt_DName.Text = dt.Rows[0]["Driver_Name"].ToString();
                    txt_Daddress.Text = dt.Rows[0]["Driver_Address"].ToString();
                    com_License_type.Text = dt.Rows[0]["License_type"].ToString();
                    txt_License_No.Text = dt.Rows[0]["License_No"].ToString();
                    Dt_Expiry_date.Text = dt.Rows[0]["Expiry_date"].ToString();
                    com_CompName.Text = dt.Rows[0]["Com_Name"].ToString();
                    com_CarNo.Text = dt.Rows[0]["Car_No"].ToString();
                    string path = Path.Combine(dt.Rows[0]["License_image"].ToString());

                    if (File.Exists(path))
                    {
                        picImage.Image = Image.FromFile(path);
                    }
                    else
                    {
                        picImage.Image = null;
                        XtraMessageBox.Show("لايوجد صورة", "تحذير", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;

                    }
                    BindGrid();
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
            if (XtraMessageBox.Show("هل تريد أضافة سائق جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //txt_itemcat.Text = "";
                //txt_itemcat.Select();
                _AddNew = true;
                _Valid.TextClear(this, grb__Record);
                picImage.Image = null;
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ عميل جديد؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_DName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم السائق ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (txt_License_No.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال رقم رخصة القيادة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (com_CompName.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك قم بإدخال إسم الشركة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;


                    }

                    if (picImage.Image == null)
                    {
                        XtraMessageBox.Show("من فضلك قم بإختيار صورة", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    #endregion

                    #region SaveData

                    string location = "img";
                    if (!Directory.Exists(location))
                        Directory.CreateDirectory(location);


                    string path = Path.Combine(location, txt_License_No.Text + ".jpg");

                    Retrive_Data.executenonquery("SP_DriversInsert",
                new Pararmeter("@Driver_Name", SqlDbType.NVarChar, txt_DName.Text),
                new Pararmeter("@Driver_Address", SqlDbType.NVarChar, txt_Daddress.Text),
                new Pararmeter("@License_type", SqlDbType.NVarChar, com_License_type.Text.Trim()),
                new Pararmeter("@License_No", SqlDbType.NVarChar, txt_License_No.Text),
                new Pararmeter("@Expiry_date", SqlDbType.Date, Dt_Expiry_date.Text),
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_CompName.EditValue.ToString())),
                new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_CarNo.EditValue.ToString())),
                new Pararmeter("@License_image", SqlDbType.NVarChar, path));
                    picImage.Image.Save(path);

                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindCombo();
                    BindComboSearch();
                    BindGridAll();

                    #endregion
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;
            

        }

        private void btnLoadimg_Click(object sender, EventArgs e)
        {
            try
            {
                #region Upload Image
                try
                {
                    OpenFileDialog op = new OpenFileDialog();
                    op.Filter = "Image File(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        picImage.Image = Image.FromFile(op.FileName);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
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
                    XtraMessageBox.Show("قم بأختيار اسم السائق من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل بيانات هذاالسائق ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        string location = "img";
                        if (!Directory.Exists(location))
                            Directory.CreateDirectory(location);
                        string path = Path.Combine(location, txt_License_No.Text + ".jpg");

                        Retrive_Data.executenonquery("SP_DriversUpdate",
                new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                new Pararmeter("@Driver_Name", SqlDbType.NVarChar, txt_DName.Text),
                new Pararmeter("@Driver_Address", SqlDbType.NVarChar, txt_Daddress.Text),
                new Pararmeter("@License_type", SqlDbType.NVarChar, com_License_type.Text.Trim()),
                new Pararmeter("@License_No", SqlDbType.NVarChar, txt_License_No.Text),
                new Pararmeter("@Expiry_date", SqlDbType.Date, Dt_Expiry_date.Text),
                new Pararmeter("@Com_ID", SqlDbType.Int, int.Parse(com_CompName.EditValue.ToString())),
                new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_CarNo.EditValue.ToString())),
                new Pararmeter("@License_image", SqlDbType.NVarChar, path));
                        if (!File.Exists(path))
                            picImage.Image.Save(path);


                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        Bindcom_CompName();
                        BindCombo();
                        BindComboSearch();
                        BindGrid();


                    }

                }

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); throw;
            }
        }

            private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                #region Delete Record
                if (com_Search.Text == "")
                {
                    XtraMessageBox.Show("قم بأختيار اسم السائق من قائمة البحث حتى تتمكن من الحذف", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                if (lbl_ID.Text != "0")
                {

                    if (XtraMessageBox.Show("هل انت متأكد من حذف بيانات هذاالسائق ؟", "تأكيد الحذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Retrive_Data.executenonquery("Sp_DriversDelete",
                            new Pararmeter("@Driver_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)));

                        XtraMessageBox.Show("تم حذف البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindCombo();
                        BindComboSearch();
                        lbl_ID.Text = "0";
                        _Valid.TextClear(this, grb__Record);
                        BindGridAll();
                        picImage.Image = null;
                    }

                }

                #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void DriversForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }
    }
}