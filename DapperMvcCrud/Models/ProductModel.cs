using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperMvcCrud.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public int LastUserId { get; set; }
        public DateTime LastDateUpdated { get; set; }
        public CategoryModel Category { get; set; }
    }
}