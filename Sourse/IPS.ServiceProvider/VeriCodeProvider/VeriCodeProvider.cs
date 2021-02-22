using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IPS.Config;
using IPS.Models;
using IPS.Service;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace IPS.Provider {
    public class VeriCodeProvider : IVeriCodeService {
        private readonly IEmailService _emailService;
        private readonly IMemoryCache _cache;
        private readonly Messages _messages;
        public VeriCodeProvider(IEmailService emailService, IMemoryCache memoryCache,IOptions<Messages> options) {
            _emailService = emailService;
            _cache = memoryCache;
            _messages = options.Value;
        }

        public string Get(string email) {
           return _cache.Get(email).ToString();
        }

        public Task<ReturnModel> Save(string email, string veriCode) {
            try {
                var customer = _cache.Get(email);
                if (customer == null) {
                    _cache.Set(email, veriCode, DateTime.Now.AddMinutes(5));
                    return Task.FromResult(new ReturnModel() { Result = true });
                }
                else {
                    return Task.FromResult(new ReturnModel() { Result = false, Message = _messages.VeriCodeExist});
                }
            } catch (Exception) {
                return Task.FromResult(new ReturnModel() { Result = false, Message = _messages.VeriCodeSaveFaild });
            }
        }

        public async Task<ReturnModel> Send(string email) {
            var vericode = new Random().Next().ToString();
            var sentResult = await _emailService.SendVeriCode(email, vericode);
            if (sentResult.Result) {
                var saveResult = await Save(email, vericode);
                if (saveResult.Result) {
                    return new ReturnModel() { Result = true };
                }
                else {
                    return new ReturnModel() { Result = false, Message = saveResult.Message };
                }
            }
            else {
                return new ReturnModel() { Result = false, Message = sentResult.Message };
            }
        }
    }
}
