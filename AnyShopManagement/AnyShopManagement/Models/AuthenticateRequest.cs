using System;
using System.Collections.Generic;
using System.Text;

namespace AnyShopManagement.Models
{
    public class AuthenticateRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
    }
}
