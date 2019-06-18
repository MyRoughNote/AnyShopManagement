using System;
namespace AnyShopManagement.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemCatagory { get; set; }        
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
    }
}
