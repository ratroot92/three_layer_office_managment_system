using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    class connectionSQL
    {
          String conn_string = "Data Source=DESKTOP-B76AD6N/SQLEXPRESS;Initial Catalog=c_sharp;Integrated Security=True";

        SqlConnection conn;

        public SqlConnection db_start()
        {
            conn = new SqlConnection(conn_string);
            conn.Open();
            Console.WriteLine("connection started at ");
            return conn;
        }
        public bool db_end()
        {
            conn.Close();
            return true; 
        }

        public bool UDI(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry,conn);
            int rows_affected = cmd.ExecuteNonQuery();
            if (rows_affected>0)
            {
                return true;
            }
            else
            {
                return  false;
            }


        }


       
      

    }
}
