using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models;

public class AcademicYearPeriod
{
    public int AcademicId {get; set;}
    public int Year { get; set; }
    public string Semester { get; set; }
   
}