using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace webapp.Models
{
    public class Assessment
    {
        public int AssessmentId {get; set;} // primary key
        [BindProperty]
        [Required]
        public int GradeA {get; set; }
        [BindProperty]
        [Required]
        public int GradeB {get; set; }
        [BindProperty]
        [Required]
        public int GradeC {get; set; }
        [BindProperty]
        [Required]
        public int GradeD {get; set; }
        [BindProperty]
        [Required]
        public int GradeF {get; set; }
        [BindProperty]
        [Required]
        public int GradeX {get; set; }
        [BindProperty]
        [Required]
        public int GradeA_CIDM {get; set; }
        [BindProperty]
        [Required]
        public int GradeB_CIDM {get; set; }
        [BindProperty]
        [Required]
        public int GradeC_CIDM {get; set; }
        [BindProperty]
        [Required]
        public int GradeD_CIDM {get; set; }
        [BindProperty]
        [Required]
        public int GradeF_CIDM {get; set; }
        [BindProperty]
        [Required]
        public int GradeX_CIDM {get; set; }
        [BindProperty]
        [Required]
        public string Modifications {get; set;}
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public string Student_Feedback {get; set;}
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public string Reflection {get; set;}
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public string Proposed_Actions {get; set;}
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public int CourseId {get; set; }
         [BindProperty]
        [Required]
        public string CourseName {get; set; }
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public Course Course {get; set; }
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public CourseCoordinator CourseCoordinator {get; set; }
        [StringLength(20, MinimumLength=3)]
         [BindProperty]
        [Required]
        public Instructor Instructor {get; set; }
    }
} 