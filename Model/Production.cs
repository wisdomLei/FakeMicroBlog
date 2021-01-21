using System.Collections.Generic;

namespace IPS.Model {
    public class Production : EntityBase {
        public new long ID { get; set; }
        public virtual Region Region { get; set; }
        public virtual List<DataRecord> DataRecords { get; set; }
    }
}