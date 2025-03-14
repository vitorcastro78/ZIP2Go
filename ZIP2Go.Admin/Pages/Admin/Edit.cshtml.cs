using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Repository.DataContext;
using Admin.Repository.Models;

namespace ZIP2Go.Admin.Pages.Admin
{
    public class EditModel : PageModel
    {
        private readonly AdminDataContext _context;

        public EditModel(AdminDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RequestHeaders RequestHeaders { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestheaders =  await _context.RequestHeaders.FirstOrDefaultAsync(m => m.Id == id);
            if (requestheaders == null)
            {
                return NotFound();
            }
            RequestHeaders = requestheaders;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RequestHeaders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestHeadersExists(RequestHeaders.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RequestHeadersExists(Guid id)
        {
            return _context.RequestHeaders.Any(e => e.Id == id);
        }
    }
}
