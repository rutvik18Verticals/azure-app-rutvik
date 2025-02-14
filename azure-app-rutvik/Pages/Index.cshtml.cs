using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_rutvik.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration configuration;

        public IndexModel(ILogger<IndexModel> logger,IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

        public void OnGet()
        {
            ViewData["Greeting"] = configuration["Greeting"];
        }
    }
}
