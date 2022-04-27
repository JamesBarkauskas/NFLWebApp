#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NFLWebApp.Data;
using NFLWebApp.Models;

namespace NFLWebApp.Pages.Quarterbacks
{
    public class EditModel : PageModel
    {
        private readonly NFLWebApp.Data.NFLWebAppContext _context;

        public EditModel(NFLWebApp.Data.NFLWebAppContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Quarterback).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuarterbackExists(Quarterback.ID))
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

        private bool QuarterbackExists(int id)
        {
            return _context.Quarterback.Any(e => e.ID == id);
        }
    }
}
