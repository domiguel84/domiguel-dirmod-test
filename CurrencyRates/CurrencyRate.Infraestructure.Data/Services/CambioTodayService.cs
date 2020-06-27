using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using CurrencyRate.Infraestructure.Data.Models.CambioToday;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRate.Infraestructure.Data.Services
{
    public class CambioTodayService : IQuotationService
    {
        private readonly ICustomConfiguration _configuration;
        public CambioTodayService(ICustomConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Obtiene la cotización de una moneda utilizando el servicio de Cambio Today
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public Quote GetQuote(string source, string target)
        {
            HttpClient client = new HttpClient();
            string url = string.Format(_configuration.GetCambioTodayUrl(), source, target, 
                _configuration.GetCambioTodayKey());
            var task = client.GetStringAsync(url).GetAwaiter().GetResult();
            JsonResponse todayResponse =  JsonConvert.DeserializeObject<JsonResponse>(task);

            return new Quote { Source = source, Target = target, Value = todayResponse.Result.value };
        }
    }
}
