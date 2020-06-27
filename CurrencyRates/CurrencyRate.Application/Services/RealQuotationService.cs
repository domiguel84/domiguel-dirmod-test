using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Application.Services
{
    public class RealQuotationService : ICurrencyQuotation
    {
        private IQuotationService _quotationService;
        public RealQuotationService(IQuotationService quotationService)
        {
            _quotationService = quotationService;
        }
        public Quote GetQuotation()
        {
            return _quotationService.GetQuote("BRL", "ARS");
        }
    }
}
