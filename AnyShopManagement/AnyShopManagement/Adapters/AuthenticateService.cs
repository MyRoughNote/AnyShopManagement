using System;
using AnyShopManagement.Interface;
using AnyShopManagement.Models;

namespace AnyShopManagement.Adapters
{
    public class AuthenticateService : IValidate
    {
        public AuthenticateRequest GetAuthenticate(AuthenticateRequest request)
        {
            throw new NotImplementedException();
        }

        public AuthenticateRequest ResetPassword(AuthenticateRequest request)
        {
            throw new NotImplementedException();
        }

        public bool Validate(AuthenticateRequest request)
        {
            if (request.UserName.Equals("Haji", StringComparison.OrdinalIgnoreCase) && request.Password.Equals("Qqq1234!"))
            {
                return true;
            }
            return false;
        }        
    }
}
