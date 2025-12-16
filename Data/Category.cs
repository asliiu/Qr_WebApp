using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Category:BaseModel
    {
       
        public string Name { get; set; }
        public int Description { get; set; }

        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
