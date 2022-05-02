using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace webapp.Models
{
    public class Course
    {
        public int CourseId {get; set;}
        [BindProperty]
        [Required]
        
        public string CourseName {get; set;}
        
         [BindProperty]
        [Required]
        public string CatalogDescription {get; set; }
        [BindProperty]
        [Required]
        public int Section {get; set;}
        public AcademicYearPeriod AcademicYearPeriod {get; set;}
        public string Course_Status {get; set;}
        public int TotalStudents {get; set; }
        public int TotalCIDM {get; set; }
        public CourseCoordinator CourseCoordinator {get; set; }
        public Instructor Instructor {get; set; }

    }
        public class CourseAssessment
    {
        public int CourseId {get; set;} // Primary Key, Foreign Key 1
        public int AssessmentId {get; set; } // Primary Key, Foreign Key 2
        public Course Course {get; set;} // Navigation property back to Course
        public Assessment Assessment {get; set;} // Navigation property back to Assessment
        
    } 
}