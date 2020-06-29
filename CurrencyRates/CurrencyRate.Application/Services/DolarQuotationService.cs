using CurrencyRate.Domain.Enums;
using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Application.Services
{
    public class DolarQuotationService : ICurrencyQuotation
    {
        private IQuotationService _quotationService;
        public DolarQuotationService(IQuotationService quotationService)
        {
            _quotationService = quotationService;
        }
        public Quote GetQuotation()
        {
            return _quotationService.GetQuote(CurrencyEnum.USD.ToString(), CurrencyEnum.ARS.ToString());
        }
    }
}
