using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp6
  
{

    internal class cnx
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=ZZZZ\TAHASRV;Initial Catalog=istravel;Integrated Security=True");
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static int search(string table, string id)
        {
            DataSet _ds = new DataSet();
            int c = 0;
            da = new SqlDataAdapter("select count(*) from " + table + " where Id = '" + id + "'", cn);
            da.Fill(_ds, "trouve");
            c = int.Parse(_ds.Tables["trouve"].Rows[0][0].ToString());

            return c;
        }
        public static int search4(string table, string id)
        {
            DataSet _ds = new DataSet();
            int c = 0;
            da = new SqlDataAdapter("select count(*) from " + table + " where id= '" + id + "'", cn);
            da.Fill(_ds, "trouve");
            c = int.Parse(_ds.Tables["trouve"].Rows[0][0].ToString());

            return c;
        }
    }
}