using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IPS.Models {
    public class Production {
        [Required,StringLength(11)]
        public string ID { get; set; }
        [Required,MinLength(4),MaxLength(50)]
        public string Name { get; set; }
        public virtual Region Region { get; set; }
        public virtual List<DataRecord> DataRecords { get; set; }
    }
}