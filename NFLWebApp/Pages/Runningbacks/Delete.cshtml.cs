using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFLWebApp.Data;
using NFLWebApp.Models;

namespace NFLWebApp.Pages.Runningbacks
{
    public class DeleteModel : PageModel
    {
        private readonly NFLWebApp.Data.NFLWebAppContext _context;

        public DeleteModel(NFLWebApp.Data.NFLWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Runningback Runningback { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Runningback = await _context.Runningback.FirstOrDefaultAsync(m => m.ID == id);

            if (Runningback == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Runningback = await _context.Runningback.FindAsync(id);

            if (Runningback != null)
            {
                _context.Runningback.Remove(Runningback);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
