using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP06
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string storedUsername = "user1";
        private readonly string storedPassword = "password123";
        private readonly string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }

}
