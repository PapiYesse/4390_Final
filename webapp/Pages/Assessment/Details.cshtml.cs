using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Pages.Assessment
{
    public class DetailsModel : PageModel
    {
        private readonly PARDbContext _context;

        public DetailsModel(PARDbContext context)
        {
            _context = context;
        }

        public Assessment Assessment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assessment = await _context.Assessment.FirstOrDefaultAsync(m => m.AssessmentId == id);

            if (Assessment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
