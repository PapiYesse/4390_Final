using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models;

public class Semester
{
    public string SemesterName {get; set; }

}

public class AcademicYearPeriod
{
    public int Year { get; set; }
    public Semester Semester { get; set; }
   
}