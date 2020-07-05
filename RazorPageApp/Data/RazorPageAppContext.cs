using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageApp.Models;

namespace RazorPageApp.Data
{
    public class RazorPageAppContext : DbContext
    {
        public RazorPageAppContext (DbContextOptions<RazorPageAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageApp.Models.Movie> Movie { get; set; }
    }
}
