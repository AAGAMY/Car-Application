using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.DAL
{
    class Cl_Validate
    {
        public void TextClear(Form Frm, DevExpress.XtraEditors.GroupControl Grp)
        {
            foreach (Control item in Frm.Controls)
            {
                if (item is DevExpress.XtraEditors.GroupControl)
                {
                    foreach (Control itemGroup in Grp.Controls)
                    {
                        if (itemGroup is DevExpress.XtraEditors.TextEdit)
                        {
                            itemGroup.Text = "";

                        }
                        if (itemGroup is TextBox)
                        {
                            itemGroup.Text = "";
                        }

                    }
                }
            }
        }

    }
}
