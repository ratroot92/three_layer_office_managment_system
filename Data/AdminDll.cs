using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class AdminDll
    {
        //Db Conn 
        DbConn conn = new DbConn();
        public bool Insert(AdminProps Obj)
        {
            string qry = "insert into Admin (id,fname,lname,email,mobile,password,status) values("+Obj.id+",'"+Obj.fname+"'," +
                "'" + Obj.lname + "','" + Obj.email + "','" + Obj.mobile + "','" + Obj.password + "'," + Obj.status + ")";
          
          bool status=  conn.UDI(qry);
            return status;
        }

        public DataTable SelectAll()
        {
            string qry = "SELECT * from Admin";

            DataTable dt = new DataTable();
            dt= (DataTable)conn.SelectAll(qry);
            return dt;
        }


        public int GetLastId()
        {
            string qry= "SELECT TOP 1 * FROM Admin ORDER BY ID DESC";
            int id= conn.GetLastId(qry);
            return id;
        }
    }
}
