using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjProps;
using DataLayer;
namespace BuisnessLayer
{
    public class EmpBLL
    {

        public bool empInsertBLL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();
           bool status = obj.emp_insertDAL(p);

            return status;
        }
    }
}
