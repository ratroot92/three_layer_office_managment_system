using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using DataAccessLayer;
namespace Business_Layer
{
    public class NisarLoginBLL
    {
        //initilize Buisness class 
        NisarLoginDLL obj_of_dll = new NisarLoginDLL();

        public int  NisarLogin_BLL(NisarProps obj)
        {
            System.Diagnostics.Debug.WriteLine("+++++++++++IN BLL FUNCTION ++++++++++++++++++++");
            int access_level=obj_of_dll.NisarLogin_DLL(obj);
            //500,0,1
            //code 
            return access_level;
        }
    }
}
