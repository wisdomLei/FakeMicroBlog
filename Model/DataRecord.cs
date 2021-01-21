using System;
using System.ComponentModel.DataAnnotations;

namespace IPS.Model {
    public class DataRecord {
        public long ID { get; set; }
        [Required]
        public virtual Production Production { get; set; }
        public virtual Property Property { get; set; }
        public string Value { get; set; }
        public DateTime Time { get; set; } = DateTime.UtcNow;
    }
}