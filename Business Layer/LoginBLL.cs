using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using DataAccessLayer;
namespace Business_Layer
{
   public  class LoginBLL
    {
        LoginDLL login_DLL_OBJ;
        public int VALIDATE_USER_BLL(LoginProps OBJ)
        {
            System.Diagnostics.Debug.WriteLine("### FUNCTION VALIDATE_USER_BLL   ###");
            login_DLL_OBJ = new LoginDLL();
            int access_level = login_DLL_OBJ.VALIDATE_USER_DLL(OBJ);
            return access_level;
        }
    }
}
