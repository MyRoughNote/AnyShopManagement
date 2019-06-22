using System.Collections.Generic;
using AnyShopManagement.Models;

namespace AnyShopManagement.Interface
{
    public interface ICustomer
    {
        bool AddNewCustomer(TRequest customer);
        bool DeleteCustomer(TRequest customerNumber);
        TRequest GetCustomerInformation(TRequest customerNumber);
        IEnumerable<TRequest> GetAllCustomers();
    }
}
