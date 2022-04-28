using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;
using webapp.Models;

namespace webapp.Models{
    public static class seeddata{
          public static void Initialize(IServiceProvider serviceProvider)
        {
     using (var context = newPARDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<PARDbContext>>()))
{
    if(context.Instructor.Any){
        return;
    }
    List <Instructor> Instructors= new List<Instructor>{
        new Instructor{FirstName= "Jeff", LastName= "Babb"},
        new Instructor{FirstName="Kareem", LastName="Dana"},
        new Instructor{FirstName="Liang", LastName="Chen"},
        new Instructor{FirstName="Sean", LastName="Humphries"},
        new Instructor{FirstName="Katelyn", LastName="Sell"},
        new Instructor{FirstName= "Neil", LastName="Meredith"}
 };
 context.AddRange(Instructors);
 List < CourseCoordinator>  CourseCoordinators= new List<CourseCoordinator>{
    new CourseCoordinator{FirstName="Jeremiah", LastName="Roussell"},
    new CourseCoordinator{FirstName="Dawn", LastName="Sott"},
    new CourseCoordinator{FirstName="Jesse", LastName="Wallace"}

};
 context.AddRange(CourseCoordinators);
 List < Course>  courses= new List<Course>{
     new Course{CourseName="Programming Funamentals", CatalogDescription="Introduces the fundamental concepts web-oriented, structured and procedural programming. Topics include HTML, XHTML, CSS and client-side programming. Programming topics include data types, control structures, functions, arrays, an introduction to running, testing, and debugging. Introduces the presentation and usability of web interfaces.",
     Section=70, Semester="Spring", Year=2022, Course_Status="?", TotalStudents=78,},
     new Course{CourseName="Programming Funamentals", CatalogDescription="Introduces the fundamental concepts web-oriented, structured and procedural programming. Topics include HTML, XHTML, CSS and client-side programming. Programming topics include data types, control structures, functions, arrays, an introduction to running, testing, and debugging. Introduces the presentation and usability of web interfaces.",
     Section=01, Semester="Spring", Year=2022, Course_Status="?", TotalStudents=78,},
    new Course{CourseName="Programming Funamentals", CatalogDescription="Introduces the fundamental concepts web-oriented, structured and procedural programming. Topics include HTML, XHTML, CSS and client-side programming. Programming topics include data types, control structures, functions, arrays, an introduction to running, testing, and debugging. Introduces the presentation and usability of web interfaces.",
     Section=01, Semester="Fall", Year=2022, Course_Status="?", TotalStudents=72,},
     new Course{CourseName="Programming Funamentals", CatalogDescription="Introduces the fundamental concepts web-oriented, structured and procedural programming. Topics include HTML, XHTML, CSS and client-side programming. Programming topics include data types, control structures, functions, arrays, an introduction to running, testing, and debugging. Introduces the presentation and usability of web interfaces.",
     Section=70, Semester="Fall", Year=2022, Course_Status="?", TotalStudents=72},

     new Course{CourseName="Advanced Business Programming", CatalogDescription="In-depth coverage of advanced programming topics, to include client-side presentation frameworks, components, and user interface usability. Also focuses on server-side technologies such as service-oriented architecture, web services, data access, advanced API usage, state management and data-driven design.",
     Section=70, Semester="Spring", Year=2022, Course_Status="?", TotalStudents=30},
     new Course{CourseName="Advanced Business Programming", CatalogDescription="In-depth coverage of advanced programming topics, to include client-side presentation frameworks, components, and user interface usability. Also focuses on server-side technologies such as service-oriented architecture, web services, data access, advanced API usage, state management and data-driven design.",
     Section=70, Semester="Fall", Year=2022, Course_Status="?", TotalStudents=40},

     new Course{CourseName="Digital Communication and Collaboration", CatalogDescription="Theory behind and effective application of digital communications media and work flow automations across the enterprise. Technologies to be studied include blogs, portals, groupware, electronic meeting systems, document management, visualization and virtual team support",
     Section=70, Semester="Fall", Year=2022, Course_Status="?", TotalStudents=35,},
     new Course{CourseName="Digital Communication and Collaboration", CatalogDescription="Theory behind and effective application of digital communications media and work flow automations across the enterprise. Technologies to be studied include blogs, portals, groupware, electronic meeting systems, document management, visualization and virtual team support",
     Section=70, Semester="Spring", Year=2022, Course_Status="?", TotalStudents=35,},



     

 };

}


}
    }

}