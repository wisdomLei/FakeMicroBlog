using System.Collections.Generic;

namespace IPS.Model {
    public class Production :EntityBase{
        public virtual Region Region { get; set; }
        public virtual List<DataRecord> DataRecords { get; set; }
    }
}