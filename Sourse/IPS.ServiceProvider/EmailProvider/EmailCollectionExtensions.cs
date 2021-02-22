using System;
using System.Collections.Generic;
using System.Text;
using IPS.Config;
using IPS.Provider;
using IPS.Service;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection {
    public static class EmailCollectionExtensions {
        public static IServiceCollection AddEmailProvider(this IServiceCollection services) {
            services
                .AddTransient<ISmtpClient, SmtpClient>()
                .AddTransient<IEmailService, EmailProvider>();
            return services;
        }
    }
}
