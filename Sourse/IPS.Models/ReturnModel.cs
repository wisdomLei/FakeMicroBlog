using System;
using System.Collections.Generic;
using System.Text;

namespace IPS.Models {
    public class ReturnModel {
        public bool Result { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
