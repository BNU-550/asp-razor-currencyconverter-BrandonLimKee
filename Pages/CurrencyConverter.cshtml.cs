using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        public string FullName = "Brandon";

        [BindProperty]
        public Double GBP { get; set; }

        public const Double Dollar_Exchange = 1.3665346;

        [BindProperty]
        public Double Dollar { get; set; }

        private readonly ILogger<CurrencyConverterModel> _logger;

        public CurrencyConverterModel(ILogger<CurrencyConverterModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (GBP < 1)
            {
                ViewData["Message"] = "Please Enter An Amount To Convert";
            }
            else
            {
                Dollar = GBP * Dollar_Exchange;
                ViewData["Message"] = Math.Round(Dollar, 2);
            }
        }
    }
}