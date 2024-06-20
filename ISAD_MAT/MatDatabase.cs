using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ISAD_MAT
{
    internal class MatDatabase
    {
        public static string conStr = "Data Source=DESKTOP-E2QA4SA\\DBS; Initial Catalog=MatDB; Integrated Security=True";
        public SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;
        public void Conn()
        {
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            con = new SqlConnection(conStr);
            con.Open();
        }
    }
    
   
}
