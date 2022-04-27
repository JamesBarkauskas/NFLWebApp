using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFLWebApp.Data;
using NFLWebApp.Models;

namespace NFLWebApp.Pages.WideReceivers
{
    public class DeleteModel : PageModel
    {
        private readonly NFLWebApp.Data.NFLWebAppContext _context;

        public DeleteModel(NFLWebApp.Data.NFLWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WideReceiver WideReceiver { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WideReceiver = await _context.WideReceiver.FirstOrDefaultAsync(m => m.ID == id);

            if (WideReceiver == null)
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

            WideReceiver = await _context.WideReceiver.FindAsync(id);

            if (WideReceiver != null)
            {
                _context.WideReceiver.Remove(WideReceiver);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
