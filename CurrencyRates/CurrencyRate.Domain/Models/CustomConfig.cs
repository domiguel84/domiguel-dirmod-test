using CurrencyRate.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Domain.Models
{
    public class CustomConfig : ICustomConfiguration
    {
        private readonly IConfiguration _configuration;
        public CustomConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetCambioTodayUrl() {
            return _configuration["CambioTodayUrl"];
        }
        public string GetCambioTodayKey()
        { 
            return _configuration ["CambioTodayKey"];
        }
    }
}
