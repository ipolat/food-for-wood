using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme4.Pages.Recipes
{
    public class Recipe3Model : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public Recipe3Model(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
