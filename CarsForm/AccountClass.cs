using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars1
{
    internal class AccountClass
    {
        private string username;
        private string password;

        public AccountClass(string u, string p)
        {
            username = u;
            password = p;
        }

        public string Username { get { return username; } }
        public string Password { get { return password; } }
    }
}
