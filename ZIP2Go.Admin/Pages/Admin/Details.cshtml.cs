﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Admin.Repository.DataContext;
using Admin.Repository.Models;

namespace ZIP2Go.Admin.Pages.Admin
{
    public class DetailsModel : PageModel
    {
        private readonly AdminDataContext _context;

        public DetailsModel(AdminDataContext context)
        {
            _context = context;
        }

        public RequestHeaders RequestHeaders { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestheaders = await _context.RequestHeaders.FirstOrDefaultAsync(m => m.Id == id);
            if (requestheaders == null)
            {
                return NotFound();
            }
            else
            {
                RequestHeaders = requestheaders;
            }
            return Page();
        }
    }
}