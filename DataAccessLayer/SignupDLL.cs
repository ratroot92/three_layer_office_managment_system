using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
namespace DataAccessLayer
{
    public class SignupDLL
    {
        DbConn conn;


        public int INSERT_DLL(SignupProps OBJ)
        {
            System.Diagnostics.Debug.WriteLine("### FUNCTION INSERT SIGNUP DLL  ###");
            conn = new DbConn();
            conn.OpenConection();
            string QUERY = "INSERT INTO users(username,email,password,phone,access_level)"+
                            "VALUES( '"+OBJ.Username+ "',  '" + OBJ.Email + "',  '" + OBJ.Password + "',  '" + OBJ.Phone + "',  '" + OBJ.Access_level + "')";

           int status = conn.UDI(QUERY);
           return status;
        }
    }
}
