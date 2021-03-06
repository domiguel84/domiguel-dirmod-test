﻿using CurrencyRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRate.Domain.Interfaces
{
    public interface IQuotationService
    {
        Quote GetQuote(string source, string target);
    }
}
