using Admin.Repository.DataContext;
using Admin.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZIP2Go.Admin.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly AdminDataContext _context;

        public CreateModel(AdminDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RequestHeaders RequestHeaders { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RequestHeaders.Add(RequestHeaders);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}