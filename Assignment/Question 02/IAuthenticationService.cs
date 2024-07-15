using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question_02
{
    interface IAuthenticationService
    {
        public bool AuthenticateUser(string Name , string Password);
        public bool AuthorizeUser(string Name);
    }
}
