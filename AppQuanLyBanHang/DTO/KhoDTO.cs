using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoDTO
    {
        public KhoDTO() { }
        public int bunker_id { get; set; }
        public int? product_id { get; set; }
        public int? soluong { get; set; }
        public double? price { get; set; }
        public double? thanhtien { get; set; }
    }
}
