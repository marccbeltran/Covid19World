using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covid19World.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace covid19World.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(ApiCountryData countryApiData)
        {

            var totalData = countryApiData.BasicCallAsync();

            ViewData["countries"] = totalData.Result;


        }
    }
}
