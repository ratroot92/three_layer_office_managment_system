using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PrjProps;

namespace DataAccessLayer
{
    public class NisarLoginDLL
    {

        //initialize and create object of connexction class 
        // that is 
        DbConn obj_conn;
       public int NisarLogin_DLL(NisarProps obj)
        {
            string QUERY = "SELECT * FROM users where username='" + obj.username + "' and password='" + obj.password + "' ";
             obj_conn = new DbConn();
            SqlDataReader dr= obj_conn.DataReader(QUERY);
            int access_level;
            if (dr.Read())
            {
                string username = dr.GetString(1);
                string password = dr.GetString(3);
                 access_level = Int32.Parse(dr.GetString(5));
               
                System.Diagnostics.Debug.WriteLine("++++++++++++++++++++IN DLLL FUNCTION  (IF)++++++++++++++++++++");
                System.Diagnostics.Debug.WriteLine("username="+username);
                System.Diagnostics.Debug.WriteLine("password=" + password);
                System.Diagnostics.Debug.WriteLine("access-level=" + access_level);
                return access_level;//0,1
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("++++++++++++++++++++IN DLLL FUNCTION (ELSE) ++++++++++++++++++++");
                return 500;//specify
            }

           
        }
    }
}
