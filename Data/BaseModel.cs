using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }= DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
