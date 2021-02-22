using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IPS.Config;
using Microsoft.Extensions.Options;

namespace IPS.Models {
    public class Register {
        [Required]
        [MinLength(4)]
        [MaxLength(24)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6), MaxLength(16)]
        public string Password { get; set; }

        [Required]
        public string VeriCode { get; set; }

    }
}
