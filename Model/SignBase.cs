using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPS.Model {
    public class SignBase {
        [Required, MinLength(4), MaxLength(24)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(6)]
        public string Password { get; set; }
        [Required]
        public string VeriCode { get; set; }
    }
}
