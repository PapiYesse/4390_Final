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
    public class DeleteModel : PageModel
    {
        private readonly PARDbContext _context;

        public DeleteModel(PARDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CourseCoordinator CourseCoordinator { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CourseCoordinator = await _context.CourseCoordinator.FirstOrDefaultAsync(m => m.CourseCoordinatorId == id);

            if (CourseCoordinator == null)
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

            CourseCoordinator = await _context.CourseCoordinator.FindAsync(id);

            if (CourseCoordinator != null)
            {
                _context.CourseCoordinator.Remove(CourseCoordinator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
