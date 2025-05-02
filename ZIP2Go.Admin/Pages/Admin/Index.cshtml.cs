using Admin.Repository.DataContext;
using Admin.Repository.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ZIP2Go.Admin.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly AdminDataContext _context;

        public IndexModel(AdminDataContext context)
        {
            _context = context;
        }

        public IList<RequestHeaders> RequestHeaders { get; set; } = default!;

        public async Task OnGetAsync()
        {
            RequestHeaders = await _context.RequestHeaders.ToListAsync();
        }
    }
}