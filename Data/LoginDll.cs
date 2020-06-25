using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Props;

namespace DataLayer
{
  public   class LoginDll
    {
        DbConn conn;
        public UserProps Validate(LoginProps Obj)
        {
            try
            {

       
            conn = new DbConn();
            string qry = "select * from users where name='" + Obj.name + "' and password='" + Obj.password + "' ";
            UserProps user_object;
            SqlDataReader rd = conn.Reader(qry);
            user_object = new UserProps();
            if (rd != null && rd.HasRows)
            {
                while (rd.Read())
                {
                    System.Diagnostics.Debug.WriteLine("## WHILE READ ##");
                    int id = rd.GetInt32(0);//id
                    string name = rd.GetString(1);//name
                    string email = rd.GetString(2);//email
                    string password = rd.GetString(3);//password
                    string mobile = rd.GetString(4);//mobile
                    int role = rd.GetInt32(5);//role
                    int status = rd.GetInt32(6);//status

                    user_object.id = id;
                    user_object.name = name;
                    user_object.email = email;
                    user_object.password = password;
                    user_object.mobile = mobile;
                    user_object.status = status;
                    user_object.role = role;
                    return user_object;
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("## ELSE  (rd != null && rd.HasRows) ##");
                return user_object;
            }
            return user_object;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("## Exception ##"+ex);
                return null;
            }
        }
          
               


                // conn.Disconnect();

            
           
        }
    }

