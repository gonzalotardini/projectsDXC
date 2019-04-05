using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APMTerminals.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
