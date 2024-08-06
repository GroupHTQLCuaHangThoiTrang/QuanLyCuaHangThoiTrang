using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        public CategoryDTO() { }
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string avatar { get; set; }
    }
}
