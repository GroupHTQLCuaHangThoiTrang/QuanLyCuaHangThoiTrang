using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public ProductDTO() { }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int? brand_id { get; set; }
        public int? category_id { get; set; }
        public string short_des { get; set; }
        public string full_des { get; set; }
        public double? price { get; set; }
        public double? price_discount { get; set; }
        public string avatar { get; set; }
        public int? soluong { get; set; }
    }
}
