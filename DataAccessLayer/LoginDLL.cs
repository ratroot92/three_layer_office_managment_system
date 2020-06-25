using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class LoginDLL
    {
        DbConn conn;
        public int VALIDATE_USER_DLL(LoginProps OBJ)
        {
            int access_level;
            System.Diagnostics.Debug.WriteLine("### FUNCTION VALIDATE_USER_DLL  ###");
            conn = new DbConn();
            conn.OpenConection();
            string QUERY = "SELECT * FROM users where username='"+OBJ.Username+"' and password='"+OBJ.Password+"' ";
            System.Diagnostics.Debug.WriteLine(""+QUERY);
            SqlDataReader dt= conn.DataReader(QUERY);
            if (dt.Read())
            {
                string username = dt.GetString(1);
                string password = dt.GetString(3);
                access_level = Int32.Parse(dt.GetString(5));
                System.Diagnostics.Debug.WriteLine("### USER VALIDATED   ###");
                System.Diagnostics.Debug.WriteLine("### USER ACCESS LEVEL =    ###"+access_level);
              
                conn.CloseConnection();
                return access_level;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("### USER VALIDATION FAILED   ###");
                conn.CloseConnection();
                return 500;
               
            }
          
          
        }
    }
}
