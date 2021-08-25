using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    BcitId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Specialization = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.BcitId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "BcitId", "City", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[,]
                {
                    { "A00123456", "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing" },
                    { "A00000001", "Vancouver", "jdouglas@bcit.ca", "Jane", "Douglas", "778-123-4567", "Business" },
                    { "A00000002", "Burnaby", "tgardner@bcit.ca", "Tom", "Gardner", "604-999-0123", "Education" },
                    { "A00000003", "Burnaby", "alee@bcit.ca", "Ann", "Lee", "778-999-0123", "Biology" },
                    { "A00000004", "Richmond", "jjones@bcit.ca", "James", "Jones", "604-765-4321", "Radiology" },
                    { "A00000005", "Coquitlam", "staylor@bcit.ca", "Susan", "Taylor", "778-765-4321", "Math" },
                    { "A01234567", "Delta", "pwhite@bcit.ca", "Peter", "White", "604-012-3456", "Administration" },
                    { "A07654321", "Richmond", "pfox@bcit.ca", "Philip", "Fox", "778-012-3456", "Computer Science" },
                    { "A12345678", "Vancouver", "dray@bcit.ca", "Donna", "Ray", "604-999-9999", "Chemistry" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
