using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace football_info_project.Pages
{
    public class SpotlightModel : PageModel
    {
        private readonly ILogger<SpotlightModel> _logger;

        public SpotlightModel(ILogger<SpotlightModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
