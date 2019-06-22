using System;
using System.Collections.Generic;
using System.Text;
using AnyShopManagement.Adapters;
using AnyShopManagement.Interface;

namespace AnyShopManagement.ServiceFactory
{
    public static class ServiceFactory
    {
        public static IValidate CreateAndInitialize(string ServiceType)
        {
            switch (ServiceType)
            {
                case "AUTHENTICATE": return new AuthenticateService();
                default: return new AuthenticateService();
            }
        }
    }
}
