using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using prjProps;
namespace DataLayer
{
    public class EmpDAL
    {
        
        public bool emp_insertDAL(EmpProps p)
        {


            MySqlCommmand cmd = new MySqlCommmand();
            string sql="INSERT INTO emp (emp,name,code,address), values ()"
            return true;
        }
    }
}
