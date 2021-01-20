using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Model {
    public class EntityBase {
        public int ID { get; set; }
        [Required]
        public virtual string Name { get; set; }
    }
}
