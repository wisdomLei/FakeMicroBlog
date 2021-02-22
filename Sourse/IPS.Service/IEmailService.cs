using System;
using System.Threading.Tasks;
using IPS.Models;

namespace IPS.Service {
    public interface IEmailService {
        Task<ReturnModel> SendVeriCode(string emailAddress, string veriCode);
    }
}
