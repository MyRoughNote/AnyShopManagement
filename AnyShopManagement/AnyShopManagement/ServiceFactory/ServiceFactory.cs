using System;
using System.Collections.Generic;
using System.Text;
using AnyShopManagement.Adapters;

namespace AnyShopManagement.ServiceFactory
{
    internal static class ServiceFactory
    {
        internal static object CreateAndInitialize(string ServiceType)
        {
            switch (ServiceType)
            {
                case "AUTHENTICATE": return new AuthenticateService();
                default: return new AuthenticateService();
            }
        }
    }
}
