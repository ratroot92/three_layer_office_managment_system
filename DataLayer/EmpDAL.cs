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
            connedctionMYSQL obj_conn = new connedctionMYSQL();
            obj_conn.DbOpen();
            string qry = "INSERT INTO employee (id,name,cell,address) VAlUES(" + p.Emp_code + ",'" + p.Emp_name + "'," + p.Emp_cell + ",'" + p.Emp_address + "')";
            bool status = obj_conn.UDI(qry);
            obj_conn.DbClose();
            return status;
        }
    }
}
