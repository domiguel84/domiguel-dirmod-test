using CurrencyRate.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Application.Services
{
    public class CurrencyQuotationServiceFactory: ICurrencyQuotationServiceFactory
    {
        private readonly IQuotationService _quotationService;
        private Dictionary<string, ICurrencyQuotation> _currencyQuotationServiceDict;
        public CurrencyQuotationServiceFactory(IQuotationService quotationService)
        {
            _quotationService = quotationService;

            _currencyQuotationServiceDict = new Dictionary<string, ICurrencyQuotation>()
            {
                {"dolar", new DolarQuotationService(_quotationService) },
                { "euro", new EuroQuotationService(_quotationService)},
                { "real", new RealQuotationService(_quotationService)}
            };
        }

        public ICurrencyQuotation GetCurrencyQuotationService(string currency)
        {
            var key = currency.ToLower();
            return _currencyQuotationServiceDict[key];
        }
    }
}
