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
    }
