using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataLayer
{
    public class connedctionMYSQL
    {

        public string con_url = "server=remotemysql.com;user id=PXtIS3m02i;password=mMANpKYr0k;database=PXtIS3m02i;persistsecurityinfo=True";
         MySqlConnection conn;

        public void DbOpen()
        {
            conn = new MySqlConnection(con_url);
            conn.Open();
        }

        public void DbClose()
        {
            conn.Close();
        }

        public bool UDI(String qry)
        {
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            int rows_affected=cmd.ExecuteNonQuery();
            if(rows_affected > 0){
                return true;
            }
            else
            {
                return false;
            }
            return false;

        }





    }
}
