using Props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using DataLayer;
namespace Buisness
{
  public   class LoginBll
    {
        LoginDll dll_object;
        public UserProps Valdiate(LoginProps Obj)
        {
            dll_object = new LoginDll();
        UserProps user_object=  dll_object.Validate(Obj);
           return user_object;
        }
    }
}
