using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Pages.CourseCoord
{
    public class EditModel : PageModel
    {
        private readonly PARDbContext _context;

        public EditModel(PARDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CourseCoordinator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseCoordinatorExists(CourseCoordinator.CourseCoordinatorId))
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

        private bool CourseCoordinatorExists(int id)
        {
            return _context.CourseCoordinator.Any(e => e.CourseCoordinatorId == id);
        }
    }
}
