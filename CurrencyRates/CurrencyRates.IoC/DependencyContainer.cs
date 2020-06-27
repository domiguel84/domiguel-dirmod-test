using CurrencyRate.Application.Services;
using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using CurrencyRate.Infraestructure.Data.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CurrencyRates.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CurrencyRates.Application
            services.AddScoped<ICurrencyQuotationServiceFactory, CurrencyQuotationServiceFactory>();
            services.AddScoped<ICustomConfiguration, CustomConfig>();

            //CurrencyRates.Domain.Interfaces | CurrencyRates.Infra.Data.Services
            services.AddScoped<IQuotationService, CambioTodayService>();
            

            
        }
    }
}
