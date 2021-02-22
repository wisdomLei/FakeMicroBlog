using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IPS.Models;

namespace IPS.Service {
    public interface IVeriCodeService {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        Task<ReturnModel> Send(string to);
        Task<ReturnModel> Save(string to, string veriCode);
        string Get(string to);
    }
}
