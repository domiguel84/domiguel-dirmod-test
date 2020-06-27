using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Application.Services
{
    public class EuroQuotationService : ICurrencyQuotation
    {
        private IQuotationService _quotationService;
        public EuroQuotationService(IQuotationService quotationService)
        {
            _quotationService = quotationService;
        }
        public Quote GetQuotation()
        {
            return _quotationService.GetQuote("EUR", "ARS");
        }
    }
}
