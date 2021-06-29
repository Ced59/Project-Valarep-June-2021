using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesUsersCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("72daf56f-7aac-4a4e-9d01-0bf80cecf736"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_US", "Login", "Password", "Pseudo" },
                values: new object[] { new Guid("65fe75f0-8991-472b-9533-65cd78596f2f"), "ali@test.com", "test", "Ali" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("65fe75f0-8991-472b-9533-65cd78596f2f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_US", "Login", "Password", "Pseudo" },
                values: new object[] { new Guid("72daf56f-7aac-4a4e-9d01-0bf80cecf736"), "ali@test.com", "test", "Ali" });
        }
    }
}
