﻿using FluentEmail.Core.Interfaces;
using FluentEmail.Mailgun;
using FluentEmail.SendGrid;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FluentEmailMailgunBuilderExtensions
    {
        public static FluentEmailServicesBuilder AddMailGunSender(this FluentEmailServicesBuilder builder, string domainName, string apiKey)
        {
            builder.Services.TryAdd(ServiceDescriptor.Scoped<ISender>(x => new MailgunSender(domainName, apiKey)));
            return builder;
        }
    }
}
