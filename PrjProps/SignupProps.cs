using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
    public class SignupProps
    {
        private int id;
        private string username;
        private string email;
        private string password;
        private string phone;
        private string access_level;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Access_level { get => access_level; set => access_level = value; }
    }
}
