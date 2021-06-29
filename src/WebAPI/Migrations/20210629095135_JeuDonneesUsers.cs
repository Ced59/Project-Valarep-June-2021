using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_US", "Login", "Password", "Pseudo" },
                values: new object[,]
                {
                    { new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"), "ced@test.com", "test", "Ced" },
                    { new Guid("26a3a18c-56f1-4723-8052-4de25e8637b3"), "vince@test.com", "test", "Vincent" },
                    { new Guid("b68d837a-f541-428e-892a-4b854a78d755"), "charlotte@test.com", "test", "Charlotte" },
                    { new Guid("65fe75f0-8991-472b-9533-65cd78596f2e"), "theo@test.com", "test", "Théo" },
                    { new Guid("72daf56f-7aac-4a4e-9d01-0bf80cecf736"), "ali@test.com", "test", "Ali" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("26a3a18c-56f1-4723-8052-4de25e8637b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("65fe75f0-8991-472b-9533-65cd78596f2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("72daf56f-7aac-4a4e-9d01-0bf80cecf736"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("b68d837a-f541-428e-892a-4b854a78d755"));
        }
    }
}
