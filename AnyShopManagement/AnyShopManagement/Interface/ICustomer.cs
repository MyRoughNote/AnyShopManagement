using System.Collections.Generic;
using AnyShopManagement.Models;

namespace AnyShopManagement.Interface
{
    public interface ICustomer
    {
        bool AddNewCustomer(Customer customer);
        bool DeleteCustomer(Customer customerNumber);
        Customer GetCustomerInformation(Customer customerNumber);
        IEnumerable<Customer> GetAllCustomers();
    }
}
