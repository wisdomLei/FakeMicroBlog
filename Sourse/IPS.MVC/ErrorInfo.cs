using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPS.MVC {
    public static class ErrorInfo {
        public static Dictionary<string, string> RegError { get; private set; }
        public static Dictionary<string, string> Other { get; private set; }
        public static Dictionary<string,string> LogError { get; set; }
    }
}
