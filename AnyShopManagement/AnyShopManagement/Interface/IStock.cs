using AnyShopManagement.Models;
using System.Collections.Generic;

namespace AnyShopManagement.Interface
{
    public interface IStock
    {
        bool AddNewStock(Stock stock);
        bool DeleteStock(Stock stockID);
        Customer GetStockInformation(Stock stockID);
        IEnumerable<Stock> GetAllStockList();
    }
}
