using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageApp.Data;
using RazorPageApp.Models;

namespace RazorPageApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageApp.Data.RazorPageAppContext _context;

        public IndexModel(RazorPageApp.Data.RazorPageAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
