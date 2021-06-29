using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesAddStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StationServices",
                columns: new[] { "Id_ST", "Adresse", "Latitude", "Longitude", "MarqueId" },
                values: new object[] { new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"), "59125 Trith-Saint-Léger", "50.33483671401915", "3.4815290258130953", new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4") });

            migrationBuilder.InsertData(
                table: "StationServices",
                columns: new[] { "Id_ST", "Adresse", "Latitude", "Longitude", "MarqueId" },
                values: new object[] { new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"), "27 Boulevard Saly, 59300 Valenciennes", "50.35364007720023", "3.5202011928830075", new Guid("9809b58b-f3a4-430f-895c-9732214603dd") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StationServices",
                keyColumn: "Id_ST",
                keyValue: new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"));

            migrationBuilder.DeleteData(
                table: "StationServices",
                keyColumn: "Id_ST",
                keyValue: new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"));
        }
    }
}
