using System;
using System.Collections.Generic;
using AnyShopManagement.Interface;
using AnyShopManagement.Models;

namespace AnyShopManagement.Adapters
{
    public class CustomerService : ICustomer
    {
        private readonly Customer customer;

        public CustomerService(Customer _customer)
        {
            customer = _customer;
        }

        public bool AddNewCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer customerNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerInformation(Customer customerNumber)
        {
            throw new NotImplementedException();
        }        
    }
}
