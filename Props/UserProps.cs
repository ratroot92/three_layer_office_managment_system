using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props
{
    public class UserProps
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public int status;//value for 1 for ative and value 0 for inactive 
        public int role;//value will be 0 for user(normal) 
                        //value will be 1 for admin 
        public  string mobile;
        public string created_at;
        public string updated_at;

    }
}
