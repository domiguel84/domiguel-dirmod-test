using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Domain.Models
{
    public class Quote
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public string Value { get; set; }
    }
}
