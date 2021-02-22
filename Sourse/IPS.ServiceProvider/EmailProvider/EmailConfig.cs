using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace IPS.Config {
    public class EmailConfig {
        public const string Default = "EmailConfig";
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
}
