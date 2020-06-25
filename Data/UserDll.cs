using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
namespace DataLayer
{
   public  class UserDll
    {
        //Db Conn
        DbConn conn;
        public bool Insert(UserProps Obj)
        {
            conn = new DbConn();
            string qry = "insert into users (name,email,password,mobile,role,status) values('"+Obj.name+"'," +
                "'" + Obj.email + "','" + Obj.password + "','" + Obj.mobile + "'," + Obj.role + "," + Obj.status + ")";
            bool status = conn.UDI(qry);
            return status;
        }
    }
}
