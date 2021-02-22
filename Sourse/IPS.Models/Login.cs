using System;
using System.ComponentModel.DataAnnotations;
namespace IPS.Models {
    public class Login{
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(16)]
        public string Password { get; set; }
        [Required]
        public string VeriCode { get; set; }
    }
}
