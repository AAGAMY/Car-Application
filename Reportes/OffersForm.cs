using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibraryApp.DAL;
using DevExpress.XtraEditors;
using RealClass_lib;
using System.Data.SqlClient;

namespace CarApp.Reportes
{
    public partial class OffersForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public OffersForm()
        {
            InitializeComponent();
            
        }

    bool _AddNew = false;
        Cl_Validate _Valid = new Cl_Validate();
        #region BindComSearch
        void BindComSearch()
        {
            com_Search.Properties.DataSource = Retrive_Data.executequery("SP_CarTypeFillCombo", CommandType.StoredProcedure);
            com_Search.Properties.DisplayMember = "Car_Type";
            com_Search.Properties.ValueMember = "Car_ID";
        }
        #endregion
        #region BindCompCarType
        void BindCompCarType()
        {
            Com_Car_Type.Properties.DataSource = Retrive_Data.executequery("SP_CarTypeFillCombo", CommandType.StoredProcedure);
            Com_Car_Type.Properties.DisplayMember = "Car_Type";
            Com_Car_Type.Properties.ValueMember = "Car_ID";
        }
        #endregion
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void OffersForm_Load(object sender, EventArgs e)
        {
            FormOpened.IsMyFormOpened = true;
            BindComSearch();
            BindCompCarType();

        }

        private void OffersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FormOpened.IsMyFormOpened = false;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (XtraMessageBox.Show("هل تريد أضافة عرض سعر جديد ؟", "تأكيد", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                //_Valid.TextClear(this, grb__Record);
                _Valid.TextClear(this, grb_Search);
                Com_Car_Type.Text = "";
                //txt_Offer_To.Text = "";
                txt_Shift_Go_Back.Text = "";
                txt_Shift_system.Text = "";
                
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

                if (XtraMessageBox.Show("هل انت متأكد من حفظ فاتورة جديدة؟", "تأكيد الحفظ", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData

                    if (txt_Offer_To.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل اسم الجهة المقدم اليها عرض السعر ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (Com_Car_Type.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل نوع السيارة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Shift_Go_Back.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل سعر الورديةالنهارية الذهاب والعودة ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Shift_system.Text == "")
                    {
                        XtraMessageBox.Show("من فضلك ادخل سعر نظام الورديتين ", "تنبية", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    #endregion
                    #region SaveData

                    Retrive_Data.executenonquery("SP_OffersInsert",
                new Pararmeter("@Offer_To", SqlDbType.NVarChar, txt_Offer_To.Text),
                new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(Com_Car_Type.EditValue.ToString())),
                new Pararmeter("@Shift_Go_Back", SqlDbType.Int, int.Parse(txt_Shift_Go_Back.Text)),
                new Pararmeter("@Shift_system", SqlDbType.Int, int.Parse(txt_Shift_system.Text)),
                new Pararmeter("@Notes", SqlDbType.NVarChar, txt_Notes.Text));

                    XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    _AddNew = false;
                    BindComSearch();
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
                    XtraMessageBox.Show("قم بأختيار الجهة المقدم اليها العرض من قائمة البحث حتى تتمكن من التعديل", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Data_Update
                if (lbl_ID.Text != "0")
                {
                    if (XtraMessageBox.Show("هل انت متأكد من تعديل البيانات ؟", "تأكيد التعديل", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Retrive_Data.executenonquery("SP_OffersUpdate",
                new Pararmeter("@Offer_ID", SqlDbType.Int, int.Parse(lbl_ID.Text)),
                new Pararmeter("@Offer_To", SqlDbType.NVarChar, txt_Offer_To.Text),
                new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(Com_Car_Type.EditValue.ToString())),
                new Pararmeter("@Shift_Go_Back", SqlDbType.Int, int.Parse(txt_Shift_Go_Back.Text)),
                new Pararmeter("@Shift_system", SqlDbType.Int, int.Parse(txt_Shift_system.Text)),
                new Pararmeter("@Notes", SqlDbType.NVarChar, txt_Notes.Text));


                        XtraMessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        _AddNew = false;
                        BindComSearch();
                        BindCompCarType();
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
                    XtraMessageBox.Show("من فضلك إختار اسم الجهة اولاً", "تحذير", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                    com_Search.Select();
                    return;

                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Retrive_Data.executequery("SP_OffersSearshByID", CommandType.StoredProcedure,
                        new Pararmeter("@Car_ID", SqlDbType.Int, int.Parse(com_Search.EditValue.ToString())));

                    if (dt.Rows.Count > 0)
                    {
                        lbl_ID.Text = dt.Rows[0]["Offer_ID"].ToString();
                        txt_Offer_To.Text = dt.Rows[0]["Offer_To"].ToString();
                        Com_Car_Type.Text = dt.Rows[0]["Car_Type"].ToString();
                        txt_Shift_Go_Back.Text = dt.Rows[0]["Shift_Go_Back"].ToString();
                        txt_Shift_system.Text = dt.Rows[0]["Shift_system"].ToString();
                        txt_Notes.Text = dt.Rows[0]["Notes"].ToString();

                    }
                    else
                    {
                        XtraMessageBox.Show("لايوجد بيانات مسجلة", "تحذير", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                        com_Search.Select();
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
        LibraryApp.DAL.DBConnection _con = new LibraryApp.DAL.DBConnection();

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("هل تريد طباعة عرض سعر", "امر طباعة", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _con.CMD.Connection = LibraryApp.DAL.DBConnection.CN;
                    _con.CMD.CommandType = CommandType.StoredProcedure;
                    _con.CMD.CommandText = "SP_OffersSelectMax";
                    SqlDataAdapter da = new SqlDataAdapter(_con.CMD);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "BillOffers");
                    Cry_Offers rpt = new Cry_Offers();
                    rpt.SetDataSource(ds.Tables["BillOffers"]);
                    OffersPrintForm f_Report = new OffersPrintForm();
                    f_Report.crystalReportViewer1.ReportSource = rpt;
                    f_Report.crystalReportViewer1.Refresh();
                    //f_Report.MdiParent = this;
                    f_Report.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}