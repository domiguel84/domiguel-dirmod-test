using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Domain.Interfaces
{
    public interface ICurrencyQuotationServiceFactory
    {
        ICurrencyQuotation GetCurrencyQuotationService(string currency);
    }
}
