using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Model {
    public class Region :EntityBase{
        [DataType(DataType.Date)]
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public string Address { get; set; }
        public virtual List<Production> Productions { get; set; }
    }
}
