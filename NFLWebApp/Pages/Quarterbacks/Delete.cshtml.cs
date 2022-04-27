#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFLWebApp.Data;
using NFLWebApp.Models;

namespace NFLWebApp.Pages.Quarterbacks
{
    public class DeleteModel : PageModel
    {
        private readonly NFLWebApp.Data.NFLWebAppContext _context;

        public DeleteModel(NFLWebApp.Data.NFLWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quarterback Quarterback { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quarterback = await _context.Quarterback.FirstOrDefaultAsync(m => m.ID == id);

            if (Quarterback == null)
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

            Quarterback = await _context.Quarterback.FindAsync(id);

            if (Quarterback != null)
            {
                _context.Quarterback.Remove(Quarterback);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
