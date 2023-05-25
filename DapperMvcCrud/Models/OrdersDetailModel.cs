using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperMvcCrud.Models
{
    public class OrdersDetailModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public OrderModel Order { get; set; }
        public ProductModel Product { get; set; }
    }
}