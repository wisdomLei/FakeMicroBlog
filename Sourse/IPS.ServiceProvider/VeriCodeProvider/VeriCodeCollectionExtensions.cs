using System;
using System.Collections.Generic;
using System.Text;
using IPS.Provider;
using IPS.Service;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection {
    public static class VeriCodeCollectionExtensions {
        public static IServiceCollection AddVeriCodelProvider(this IServiceCollection services) {
            services
                .AddMemoryCache()
                .AddTransient<ISmtpClient, SmtpClient>()
                .AddTransient<IEmailService, EmailProvider>()
                .AddTransient<IVeriCodeService, VeriCodeProvider>();
            return services;
        }
    }
}
