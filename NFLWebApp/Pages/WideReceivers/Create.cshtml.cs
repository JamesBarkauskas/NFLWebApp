using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NFLWebApp.Data;
using NFLWebApp.Models;

namespace NFLWebApp.Pages.WideReceivers
{
    public class CreateModel : PageModel
    {
        private readonly NFLWebApp.Data.NFLWebAppContext _context;

        public CreateModel(NFLWebApp.Data.NFLWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WideReceiver WideReceiver { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WideReceiver.Add(WideReceiver);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
