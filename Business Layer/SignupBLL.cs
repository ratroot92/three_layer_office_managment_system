using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using DataAccessLayer;
namespace Business_Layer
{
    public class SignupBLL
    {
        SignupDLL signup_DLL_OBJ;
        public int INSERT_BLL(SignupProps OBJ)
        {
            System.Diagnostics.Debug.WriteLine("### FUNCTION INSERT SIGNUP BLL  ###");
            signup_DLL_OBJ = new SignupDLL();
            int status= signup_DLL_OBJ.INSERT_DLL(OBJ);
            return status;
        }

    }
}
