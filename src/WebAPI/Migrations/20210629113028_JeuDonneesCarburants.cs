using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesCarburants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carburants",
                columns: new[] { "Id_CA", "CodeEu", "Libelle" },
                values: new object[,]
                {
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), "E5", "Sans plomb 98" },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), "E10", "Sans plomb 95 - E10" },
                    { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), "E85", "Super éthanol E85" },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), "B7", "Gazole" },
                    { new Guid("52d0feb7-0ea6-4e85-b274-23614a35600f"), "H2", "Hydrogène" },
                    { new Guid("b056d6b3-6705-423b-87d7-ef4d1c305ec1"), "CNG", "Gaz naturel comprimé" },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), "LPG", "Gaz de pétrole liquéfié" },
                    { new Guid("4bfe7231-c972-4a8a-af6c-391e9b5dd3d8"), "LNG", "Gaz naturel liquéfié" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("4bfe7231-c972-4a8a-af6c-391e9b5dd3d8"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("52d0feb7-0ea6-4e85-b274-23614a35600f"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("b056d6b3-6705-423b-87d7-ef4d1c305ec1"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"));
        }
    }
}
