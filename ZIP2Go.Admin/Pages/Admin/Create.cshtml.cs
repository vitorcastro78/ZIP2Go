using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Admin.Repository.DataContext;
using Admin.Repository.Models;

namespace ZIP2Go.Admin.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly AdminDataContext _context;

        public CreateModel(AdminDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RequestHeaders RequestHeaders { get; set; } = default!;

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
