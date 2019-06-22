using AnyShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyShopManagement.Interface
{
    interface IRepository<in TRequest,out TResponse>
    {
        bool Add(TRequest request);
        bool Delete(TRequest request);
        TResponse Get(TRequest request);
        IEnumerable<TResponse> GetAll();
    }
}
