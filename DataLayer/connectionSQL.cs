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
       public   string conn_string = '';

        SqlConnection conn;

        public SqlConnection db_start(string conn_string)
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

        public bool UDI(string qry, string conn_string)
        {
           conn=db_start(conn_string);
            SqlCommand cmd = new SqlCommand(qry, conn);
            int rows_affected = cmd.ExecuteNonQuery();\
            if (rows_affected>0)
            {
                return true;
            }
            else
            {
                return  false;
            }


        }


        public DataTable getDatatable(string qry,conn)
        {

        }
      

    }
}
