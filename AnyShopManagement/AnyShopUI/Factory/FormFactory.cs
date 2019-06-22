using System.Windows.Forms;
using AnyShopUI.Forms;
using AnyShopManagement.ServiceFactory;
using AnyShopManagement.Interface;


namespace AnyShopUI.Factory
{
    internal static class FormFactory
    {
        internal static Form Show(string formName)
        {
            switch (formName)
            {
                case "MAIN": return new Dashboard();
                default: return new Login();
            }
        }
        
    }
}
