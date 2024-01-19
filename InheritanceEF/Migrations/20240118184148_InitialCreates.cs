using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InheritanceEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Grade", "Name", "PersonType", "StudentId" },
                values: new object[] { 1, 11, "John Doe", "Student", "ABC123" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Name", "PersonType", "Subject", "TeacherId" },
                values: new object[] { 2, "Jane Smith", "Teacher", "History", "XYZ456" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2);
        }
    }
}
