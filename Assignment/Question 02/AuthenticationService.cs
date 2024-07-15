using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question_02
{
    class BasicAuthenticationService : IAuthenticationService
    {
        private string UserName = "Abdelrahman";
        private string Password = "Aa12345";
        private string Role = "Admin";

        public bool AuthenticateUser(string Name , string Password)
        {
            if(Name == this.UserName && Password == this.Password) return true;
            return false;
        }

        public bool AuthorizeUser(string Name)
        {
            if(Name == this.UserName && Role == "Admin") return true;
            return false;
        }
    }
}
