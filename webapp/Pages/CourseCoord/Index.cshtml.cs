using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Pages.CourseCoord
{
    public class IndexModel : PageModel
    {
        private readonly PARDbContext _context;

        public IndexModel(PARDbContext context)
        {
            _context = context;
        }

        public IList<CourseCoordinator> CourseCoordinator { get;set; }

        public async Task OnGetAsync()
        {
            CourseCoordinator = await _context.CourseCoordinator.ToListAsync();
        }
    }
}
