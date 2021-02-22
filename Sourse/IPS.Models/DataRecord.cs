using System;
using System.ComponentModel.DataAnnotations;

namespace IPS.Models {
    public class DataRecord {
        public long ID { get; set; }
        public virtual Production Production { get; set; }
        public virtual Property Property { get; set; }
        public string Value { get; set; }
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.UtcNow;
    }
}