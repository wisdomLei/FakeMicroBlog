using System;
using System.ComponentModel.DataAnnotations;
namespace IPS.Model {
    public class Login : SignBase {
        [MaxLength(24), MinLength(4)]
        public new string Name { get; set; }
    }
}
