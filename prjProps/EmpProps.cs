using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProps
{
    public class EmpProps
    {

        private String emp_code;
        private String emp_name;
        private String emp_cell;
        private String emp_address;
        public string Emp_code
        {
            get
            {
                return emp_code;
            }

            set
            {
                emp_code = value;
            }
        }

        public string Emp_name
        {
            get
            {
                return emp_name;
            }

            set
            {
                emp_name = value;
            }
        }

        public string Emp_cell
        {
            get
            {
                return emp_cell;
            }

            set
            {
                emp_cell = value;
            }
        }

        public string Emp_address
        {
            get
            {
                return emp_address;
            }

            set
            {
                emp_address = value;
            }
        }

        
    }
}
