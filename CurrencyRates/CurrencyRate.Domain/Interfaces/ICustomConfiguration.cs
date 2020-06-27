using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRate.Domain.Interfaces
{
    public interface ICustomConfiguration
    {
        string GetCambioTodayUrl();
        string GetCambioTodayKey();
    }
}
