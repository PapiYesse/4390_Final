using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models;

public abstract class Profile 
{
    public string FirstName { get;  set;}
    public string LastName { get;  set;}
    public string Email { get; set; }
}

public class InstructorProfile : Profile { }
public class CourseCoordinatorProfile : Profile { }
public class AdministratorProfile : Profile{ }

public class UnitAdministratorProfile : Profile{ }

public class ProgramEvaluatorProfile : Profile
{
    public string School { get; set; }
}