using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CurrencyRate.Infraestructure.Data.Services
{
    public class CambioTodayService : IQuotationService
    {

        public async Quote GetQuote(string source, string target)
        {
            HttpClient client = new HttpClient();
            var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");

            var msg = await stringTask;
        }
    }
}
