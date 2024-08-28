using deneme4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace deneme4.Pages.Person
{
    public class EditModel : PageModel
    {
        private readonly DatabaseContext _ctx;

        public EditModel(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public Data.Person Person { get; set; }
        public IActionResult OnGet(int id)
        {
            var person = _ctx.Person.Find(id);
            if (person == null)
                return NotFound();

            else
                Person = person;
            return Page();


        }
        public async Task<IActionResult> OnPostAsync() { 
      

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var dbPerson = _ctx.Person.FirstOrDefault(x => x.Id == Person.Id);
                if (dbPerson == null) return NotFound();

                var anotherUserExistsWithSameMail = _ctx.Person.Any(x => x.Id != Person.Id && x.Email == Person.Email);

                if (anotherUserExistsWithSameMail)
                {
                    TempData["error"] = "Bu mail baþka bir kullanýcý tarafýndan kullanýlmaktadýr.";

                    return Page();
                }

                _ctx.Person.Update(Person);
                _ctx.SaveChanges();
                TempData["success"] = "hhhh";
                return RedirectToPage("DisplayAll");
            }
        }
    }
}
