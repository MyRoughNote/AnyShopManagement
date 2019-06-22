using System;
using System.Collections.Generic;
using AnyShopManagement.Interface;
using AnyShopManagement.Models;

namespace AnyShopManagement.Adapters
{
    public class CustomerService : ICustomer
    {
        private readonly TRequest customer;

        public CustomerService(TRequest _customer)
        {
            customer = _customer;
        }

        public bool AddNewCustomer(TRequest customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(TRequest customerNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRequest> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public TRequest GetCustomerInformation(TRequest customerNumber)
        {
            throw new NotImplementedException();
        }        
    }
}
