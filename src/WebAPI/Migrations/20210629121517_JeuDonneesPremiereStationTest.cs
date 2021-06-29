using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesPremiereStationTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StationServices",
                columns: new[] { "Id_ST", "Adresse", "Latitude", "Longitude", "MarqueId" },
                values: new object[] { new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), "960 Avenue Jean Jaurès, 59174 La Sentinelle", "50.3453386677043", "3.479521676283144", new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StationServices",
                keyColumn: "Id_ST",
                keyValue: new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"));
        }
    }
}
