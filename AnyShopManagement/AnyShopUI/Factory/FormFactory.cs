using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyShopUI.Forms;

namespace AnyShopUI.Factory
{
    internal static class FormFactory
    {
        internal static Form Show(string formName)
        {
            switch (formName)
            {
                case "MAIN": return new Dashboard();
                default: return new Dashboard();
            }
        }
        
    }
}
