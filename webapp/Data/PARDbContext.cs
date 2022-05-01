using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

    public class PARDbContext : DbContext
    {
        public PARDbContext (DbContextOptions<PARDbContext> options)
            : base(options)
        {
        }

        public DbSet<webapp.Models.Assessment> Assessment { get; set; }

        public DbSet<webapp.Models.AcademicYearPeriod> AcademicYearPeriod { get; set; }

        public DbSet<webapp.Models.Course> Course { get; set; }

        public DbSet<webapp.Models.CourseCoordinator> CourseCoordinator { get; set; }

        public DbSet<webapp.Models.Instructor> Instructor { get; set; }
    }
