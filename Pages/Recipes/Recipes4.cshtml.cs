using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme4.Pages.Recipes
{
    public class Recipe4Model : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public Recipe4Model(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
