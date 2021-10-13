using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Brandon";
        }

        public void OnPost()
        {
            if(string.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "You have not entered a name";
                FullName = "Anoymous";
            }
            else
            {
                ViewData["Message"] = "Name is Registered";
            }
        }

    }
}
