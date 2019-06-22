using System.Windows.Forms;
using AnyShopUI.Forms;
using AnyShopManagement.ServiceFactory;
using AnyShopManagement.Utilities;
using AnyShopManagement.Interface;

namespace AnyShopUI.Factory
{
    internal static class FormFactory
    {        
        internal static Form Show(string formName)
        {
            switch (formName)
            {
                case "LOGIN":                    
                    return new Login(ServiceFactory.CreateAndInitialize(ServiceType.Authenticate));
                case "MAIN":
                    return new Dashboard();
                default:
                    return null;
            }
        }
        
    }
}
