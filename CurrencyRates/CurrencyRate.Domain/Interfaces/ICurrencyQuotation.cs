using CurrencyRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Domain.Interfaces
{
    public interface ICurrencyQuotation
    {
        Quote GetQuotation();
    }
}
