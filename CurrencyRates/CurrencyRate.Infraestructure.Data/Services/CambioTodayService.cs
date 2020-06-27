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

        public Quote GetQuote(string source, string target)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://api.cambio.today/v1/quotes/{0}/{1}/json?quantity=1&key=4590|qm~YLauEeoQuEayGD9954TQQUUFKyOHz", source, target);
            var task = client.GetStringAsync(url).GetAwaiter().GetResult();
            JsonResponse todayResponse =  JsonConvert.DeserializeObject<JsonResponse>(task);

            return new Quote { Source = source, Target = target, Value = todayResponse.Result.value };
        }
    }
}
