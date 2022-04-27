#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NFLWebApp.Models;

namespace NFLWebApp.Data
{
    public class NFLWebAppContext : DbContext
    {
        public NFLWebAppContext (DbContextOptions<NFLWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<NFLWebApp.Models.Quarterback> Quarterback { get; set; }

        public DbSet<NFLWebApp.Models.Runningback> Runningback { get; set; }

        public DbSet<NFLWebApp.Models.WideReceiver> WideReceiver { get; set; }
    }
}
