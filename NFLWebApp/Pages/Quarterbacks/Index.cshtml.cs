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
    public class IndexModel : PageModel
    {
        private readonly NFLWebApp.Data.NFLWebAppContext _context;

        public IndexModel(NFLWebApp.Data.NFLWebAppContext context)
        {
            _context = context;
        }

        public IList<Quarterback> Quarterback { get;set; }

        public async Task OnGetAsync()
        {
            Quarterback = await _context.Quarterback.ToListAsync();
        }
    }
}
