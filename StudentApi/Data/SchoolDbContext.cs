using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentLibrary;

    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentLibrary.Student> Student { get; set; }
    }
