using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using DataLayer;
namespace Buisness
{
   public  class UserBll
    {
        //global props object 
        UserProps user_object;
        UserDll dll_object;
        public bool Insert(UserProps Obj) {
            System.Diagnostics.Debug.WriteLine("### IN USER BLL INSERT FUNTION  ###");
            dll_object = new UserDll();
             bool status= dll_object.Insert(Obj);
             return status;
        }
    }
}
