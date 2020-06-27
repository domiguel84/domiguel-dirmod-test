using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Infraestructure.Data.Models.CambioToday
{
    public class Result
    {
        public DateTime Updated { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public float value { get; set; }
        public float quantity { get; set; }
        public float amount { get; set; }
    }
}
