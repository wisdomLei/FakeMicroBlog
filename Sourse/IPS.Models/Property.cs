using System.ComponentModel.DataAnnotations;

namespace IPS.Models {
    public class Property {
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}