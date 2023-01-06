using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LibraryApp.DAL;
using RealClass_lib;

namespace LibraryApp.DAL
{
    class DBConnection
    {
        // Srting من نوع Connection قمت بالأعلان عن متغير 
        //App.Config وهذة الجملة موجودة بداخل Reference لوضع جملة الأتصال بعد ادراجة من ConfigurationManager قمت بالنداء على 
        public static string Connection = mainclass.ConnString  ;
        //ConfigurationManager.ConnectionStrings["Library_Software.Properties.Settings.LibraryConnectionString"].ConnectionString;

        //Connection عن طريق المتغير CN الأن اصبحت جملة الأتصال بداخل المتغير
        public static SqlConnection CN = new SqlConnection(Connection);

        //للتعامل مع جمل الأستعلام CMD هنا قمت بالأعلان عن المتغير
        public SqlCommand CMD = new SqlCommand();

        // قمت بالأعلان عن كونستراكتور لفتح الأتصال بقاعدة البيانات
        public DBConnection()
        {
            //بداخل الكونستراكتور لتنفيذة عند النداء علية void قمت بتمرير اسم
            OpenConnection();
        }

        // قمت بعمل تأكد من حالة الأتصال بقاعدة البيانات واعادة فتحها اذا كانت مغلقة
        void OpenConnection()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.Open();
            }
        }
    }
}
