using System;
namespace AnyShopManagement.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public DateTime StockedDate { get; set; }
        public Item Item { get; set; }
        public int Thersold { get; set; }
    }
}
