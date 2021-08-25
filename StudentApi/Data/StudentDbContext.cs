using System;
using Microsoft.EntityFrameworkCore;
using StudentLibrary;

namespace StudentApi.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().HasData(
              new
              {
                  BcitId = "A00123456",
                  FirstName = "Jim",
                  LastName = "Potter",
                  MobileNumber = "604-123-4567",
                  EmailAddress = "jim@potter.com",
                  City = "Chilliwack",
                  Specialization = "Nursing"
              },
              new
              {
                  BcitId = "A00000001",
                  FirstName = "Jane",
                  LastName = "Douglas",
                  MobileNumber = "778-123-4567",
                  EmailAddress = "jdouglas@bcit.ca",
                  City = "Vancouver",
                  Specialization = "Business"
              },
              new
              {
                  BcitId = "A00000002",
                  FirstName = "Tom",
                  LastName = "Gardner",
                  MobileNumber = "604-999-0123",
                  EmailAddress = "tgardner@bcit.ca",
                  City = "Burnaby",
                  Specialization = "Education"
              },
              new
              {
                  BcitId = "A00000003",
                  FirstName = "Ann",
                  LastName = "Lee",
                  MobileNumber = "778-999-0123",
                  EmailAddress = "alee@bcit.ca",
                  City = "Burnaby",
                  Specialization = "Biology"
              },
              new
              {
                  BcitId = "A00000004",
                  FirstName = "James",
                  LastName = "Jones",
                  MobileNumber = "604-765-4321",
                  EmailAddress = "jjones@bcit.ca",
                  City = "Richmond",
                  Specialization = "Radiology"
              },
              new
              {
                  BcitId = "A00000005",
                  FirstName = "Susan",
                  LastName = "Taylor",
                  MobileNumber = "778-765-4321",
                  EmailAddress = "staylor@bcit.ca",
                  City = "Coquitlam",
                  Specialization = "Math"
              },
              new
              {
                  BcitId = "A01234567",
                  FirstName = "Peter",
                  LastName = "White",
                  MobileNumber = "604-012-3456",
                  EmailAddress = "pwhite@bcit.ca",
                  City = "Delta",
                  Specialization = "Administration"
              },
              new
              {
                  BcitId = "A07654321",
                  FirstName = "Philip",
                  LastName = "Fox",
                  MobileNumber = "778-012-3456",
                  EmailAddress = "pfox@bcit.ca",
                  City = "Richmond",
                  Specialization = "Computer Science"
              },
              new
              {
                  BcitId = "A12345678",
                  FirstName = "Donna",
                  LastName = "Ray",
                  MobileNumber = "604-999-9999",
                  EmailAddress = "dray@bcit.ca",
                  City = "Vancouver",
                  Specialization = "Chemistry"
              }
            );
        }
    }
}
