using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Models {
    public class Role{
        public int ID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; } = "customer";
    }
}
