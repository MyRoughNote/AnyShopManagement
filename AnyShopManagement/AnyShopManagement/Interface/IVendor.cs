using AnyShopManagement.Models;
using System.Collections.Generic;
namespace AnyShopManagement.Interface
{
    public interface IVendor
    {
        bool AddNewVendor(TRequest customer);
        bool DeleteVendor(TRequest customerNumber);
        TRequest GetVendorInformation(TRequest customerNumber);
        IEnumerable<TRequest> GetAllVendors();
    }
}
