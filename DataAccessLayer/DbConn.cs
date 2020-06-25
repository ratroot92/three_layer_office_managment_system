using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
   public  class DbConn
    {
       public string ConnectionString = @"Data Source=DESKTOP-B76AD6N\SQLEXPRESS;Initial Catalog=c_sharp;Integrated Security=True";
         SqlConnection conn;

        public SqlConnection OpenConection()
        {
            try {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                System.Diagnostics.Debug.WriteLine("###     DB CONNECTION OPENED     ###  ==  " );
                return conn;
                
            }
            catch(SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("###     DB CONNECTION EXCEPTION     ###  ==  "+ex);
                return null;
            }
            
        }


        public void CloseConnection()
        {
            conn.Close();
        }


        public int UDI(string Query_)
        {
            System.Diagnostics.Debug.WriteLine("### FUNCTION UDI FOR SIGNUP  ###");
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query_, conn);
                int status = cmd.ExecuteNonQuery();
                return status;
            }
            catch(SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("### EXCEPTION IN UDI  ###"+ex);
                return 0;
            }
            
        }


        public SqlDataReader DataReader(string Query_)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Query_, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        //custom functions 

        //get last item id from database
        public int GET_LAST_ID(string QUERY)
        {
            SqlCommand cmd = new SqlCommand(QUERY, conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    System.Diagnostics.Debug.WriteLine("ITEM TABLE LAST ROW FETECHED -- PRINTING LAST ID");
                    System.Diagnostics.Debug.WriteLine(rd.GetInt32(0));
                    int id = rd.GetInt32(0);
                    return id;
                    
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("FAILED TO FETCH LAST ROW OF ITEM TABLE ");
                    return 0;
                }
            }
            catch(SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("GET LAST ID EXCEPTION  "+ex);
                return 0;
            } 
            
        }


        public DataTable GET_ALL(string QUERY)
        {
            SqlDataAdapter da = new SqlDataAdapter(QUERY, conn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds; 
        }
    }
}

