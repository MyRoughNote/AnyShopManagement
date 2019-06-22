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
                case "CUSTOMER":
                    return new Customer();
                case "VENDOR":
                    return new Vendor();
                case "DAILYBOOK":
                    return new DailyBook();
                case "REPORT":
                    return new Report();
                case "INVOICE":
                    return new Invoice();
                case "STOCK":
                    return new Stock();
                default:
                    return null;
            }
        }
        
    }
}
