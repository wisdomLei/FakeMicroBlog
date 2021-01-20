using System.ComponentModel.DataAnnotations;

namespace IPS.Model {
    public class DataRecord {
        public int ID { get; set; }
        [Required]
        public virtual Production Production { get; set; }
        public virtual Property Property { get; set; }
    }
}