using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
namespace DataLayer
{
    public class DbConn
    {
        public string db_name;
        public string db_url = @" Data Source=DESKTOP-B76AD6N\SQLEXPRESS;Initial Catalog = c_sharp; Integrated Security = True;";
        public string db_password;

        SqlConnection conn;

        public void Connect()
        {
            try
            {
                conn = new SqlConnection(db_url);
                conn.Open();

            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("##Connection Open Exception##", ex);

            }
        }

        public void Disconnect()
        {
            try
            {

                conn.Close();
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("## Connection Close Exception ##", ex);
            }
        }
        public bool UDI(string qry)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(qry, conn);
                int rows_affected = cmd.ExecuteNonQuery();//0
            
                if (rows_affected > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
               
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("## UDI ##"+ ex);
                return false;
            }



        }



       public SqlDataReader Reader(string qry)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            return rd;
        }

    







        public int GetLastId(string qry)
        {
           
         
            try
            {
                Connect();
                int id =0;
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader rd = cmd.ExecuteReader();
              
                while (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        id = rd.GetInt32(0);
                        System.Diagnostics.Debug.WriteLine("## Admin Get last Id {If} ##"+ id);
                    }

                    else
                    {
                        id = 1;
                        System.Diagnostics.Debug.WriteLine("## Admin Get last Id {Else} ##");
                    }
                }
                return id;
             
            }
           
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("## Exception ##"+ ex);
                return 0;
            }
        }

        public object SelectAll(string qry)
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(qry, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }


    }
}
