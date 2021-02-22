using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Models {
    public class Region {
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.UtcNow;
        [Required, MaxLength(50)]
        public string Address { get; set; }
        public virtual List<Production> Productions { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
