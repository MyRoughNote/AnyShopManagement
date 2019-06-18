using AnyShopManagement.Models;
using System.Collections.Generic;
namespace AnyShopManagement.Interface
{
    public interface IVendor
    {
        bool AddNewVendor(Customer customer);
        bool DeleteVendor(Customer customerNumber);
        Customer GetVendorInformation(Customer customerNumber);
        IEnumerable<Customer> GetAllVendors();
    }
}
