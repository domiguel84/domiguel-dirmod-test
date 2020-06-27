using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyRate.Application.Services;
using CurrencyRate.Domain.Interfaces;
using CurrencyRate.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CurrencyRate.Api.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class CotizacionController : ControllerBase
    {
        private readonly ILogger<CotizacionController> _logger;
        private readonly ICurrencyQuotationServiceFactory _currencyQuotationFactory;

        public CotizacionController(ILogger<CotizacionController> logger, ICurrencyQuotationServiceFactory currencyQuotationFactory)
        {
            _logger = logger;
            _currencyQuotationFactory = currencyQuotationFactory;
        }

        [HttpGet]
        [Route("cotizacion/{currency}")]
        public Quote Get(string currency)
        {
            return _currencyQuotationFactory.GetCurrencyQuotationService(currency).GetQuotation();
        }
    }
}
