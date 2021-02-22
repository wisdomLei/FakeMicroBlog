using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Models {
    public class Customer{
        public int ID { get; set; }
        [Required, MinLength(4), MaxLength(24)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(16)]
        public string Password { get; set; }
        [Required]
        public string VeriCode { get; set; }
        public virtual Role Role { get; set; } = new Role();
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.UtcNow;
        public virtual List<Region> Regions { get; set; }
    }
}
