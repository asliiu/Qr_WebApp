using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Product:BaseModel
    {
   
        public string Name { get; set; }
        public  double Price { get; set; }
        public string Image { get; set; }
        public string? Image2 { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
