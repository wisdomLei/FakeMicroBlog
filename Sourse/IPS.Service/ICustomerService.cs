using IPS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPS.Service {
    public interface ICustomerService {
        List<Customer> Gets();
        void Modify(object postMessage);
        Customer FirstOrDefault(Func<Customer,bool> expression);
    }
}
