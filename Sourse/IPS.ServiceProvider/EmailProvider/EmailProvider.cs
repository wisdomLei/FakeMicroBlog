using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IPS.Models;
using IPS.Service;
using MailKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using IPS.Config;
using Microsoft.Extensions.Options;

namespace IPS.Provider {
    public class EmailProvider : IEmailService {
        private readonly ISmtpClient _client;
        private readonly ILogger _logger;
        private readonly EmailConfig _emailConfig;
        private readonly Messages _messages;

        public EmailProvider(ISmtpClient smtpClient/*, ILogger logger*/, IOptions<EmailConfig> emailConfig, IOptions<Messages> messages) {
            _client = smtpClient;
            _emailConfig = emailConfig.Value;
            _messages = messages.Value;
            //_logger = logger;
        }

        public async Task<ReturnModel> SendVeriCode(string emailAddress, string veriCode) {
            var result = new ReturnModel();
            try {
                var message = new MimeMessage {
                    Subject = nameof(veriCode),
                    Body = new BodyBuilder() { TextBody = veriCode }.ToMessageBody(),
                };
                message.To.Add(MailboxAddress.Parse(emailAddress));
                message.From.Add(MailboxAddress.Parse("leihao@bevone.com.cn"));
                _client.Connect(_emailConfig.Host, _emailConfig.Port, _emailConfig.UseSSL);
                _client.Authenticate(_emailConfig.Account, _emailConfig.Password);
                await _client.SendAsync(message);
                _client.Disconnect(true);
                result.Result = true;
            } catch (Exception e) {
                //_logger.LogInformation(e, Messages.VeriCodeSendFaild);
                result.Result = false;
                result.Message = _messages.VeriCodeSendFaild;
            }
            return result;
        }
    }
}
