using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BonFromage.Pages
{
    public class FindUsModel : PageModel
    {
        private readonly ILogger<FindUsModel> _logger;

        public FindUsModel(ILogger<FindUsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
