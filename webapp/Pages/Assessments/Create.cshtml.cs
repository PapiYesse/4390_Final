using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using webapp.Models;

namespace webapp.Pages.Assessments
{
    public class CreateModel : PageModel
    {
        private readonly PARDbContext _context;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(PARDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
            
        }

        [BindProperty]
        public Assessment Assessment { get; set; }
        public Course Course {get; set; }
        public AcademicYearPeriod AcademicYearPeriod {get; set; }
        public SelectList CoursesDropDown {get; set;} 
        public SelectList CoordinatorDropDown {get; set;} 
        public SelectList CatalogDescriptionDropDown {get; set;}
        public SelectList YearDropDown {get; set; }
        public SelectList SemesterDropDown {get; set; }
        public SelectList InstructorDropDown {get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Assessment.Add(Assessment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
