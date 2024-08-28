using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme4.Pages.Recipes
{
    public class Recipe2Model : PageModel
    {
        private readonly ILogger<Recipe2Model> _logger;

        public Recipe2Model(ILogger<Recipe2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
