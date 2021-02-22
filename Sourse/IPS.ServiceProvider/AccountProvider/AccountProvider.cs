using IPS.Config;
using IPS.Models;
using IPS.Service;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPS.Provider {
    public class AccountProvider : IAccountService {
        private readonly Messages _messages;
        private readonly IDbService<Customer> _db;
        private readonly IVeriCodeService _veriCodeService;

        public AccountProvider(IOptions<Messages> options, IDbService<Customer> db, IVeriCodeService veriCodeService) {
            _messages = options.Value;
            _db = db;
            _veriCodeService = veriCodeService;
        }

        public ReturnModel AddCustomer(bool isValid, Register register) {
            if (!isValid) {
                return new ReturnModel { Result = false, Message = _messages.ModelVerifyFaild };
            }
            if (register.VeriCode != _veriCodeService.Get(register.Email)) {
                return new ReturnModel { Result = false, Message = _messages.VeriCodeError };
            }
            var customer = _db.FirstOfDefault(c => c.Email == register.Email);
            if (customer != null) {
                return new ReturnModel { Result = false, Message = _messages.CustomerAlreadExist };
            }
            customer = new Customer() {
                Name = register.Name,
                Email = register.Email,
                Password = register.Password,
                VeriCode = register.VeriCode,
            };
            var result = _db.Add(customer);
            if (result.Result) {
                return new ReturnModel { Result = true };
            }
            else {
                return new ReturnModel { Result = false, Message = _messages.CustomerAddFilid };
            }
        }
    }
}
