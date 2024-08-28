using deneme4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme4.Pages.Person
{
    public class CreateModel : PageModel
    {
        private readonly DatabaseContext _ctx;

        public CreateModel(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public Data.Person Person { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                if (Person == null)
                {
                    return NotFound();
                }
                else
                {
                    _ctx.Person.Add(Person);
                    _ctx.SaveChanges();
                    TempData["success"] = "hhhh";
                }
            }

            catch (Exception ex)
            {
                TempData["error"] = "not hh";
            }
            return RedirectToPage();
        }



    }
}