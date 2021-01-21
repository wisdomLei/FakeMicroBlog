using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Model {
    public class Customer : EntityBase{
        [Required, MinLength(4), MaxLength(24)]
        public override string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(6)]
        public string Password { get; set; }
        [Required]
        public string VeriCode { get; set; }
        public virtual Role Role { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
    }
}
