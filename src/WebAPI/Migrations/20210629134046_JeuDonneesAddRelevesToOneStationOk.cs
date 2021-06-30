using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesAddRelevesToOneStationOk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Releves",
                columns: new[] { "Id_RE", "CarburantId", "Date", "Prix", "StationServiceId", "UserId" },
                values: new object[] { new Guid("1da26d2c-e143-413a-b279-6b8895fb2326"), new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.451m, new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338") });

            migrationBuilder.InsertData(
                table: "Releves",
                columns: new[] { "Id_RE", "CarburantId", "Date", "Prix", "StationServiceId", "UserId" },
                values: new object[] { new Guid("71ee6506-f614-484c-b2d9-62c375f5c500"), new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.751m, new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338") });

            migrationBuilder.InsertData(
                table: "Releves",
                columns: new[] { "Id_RE", "CarburantId", "Date", "Prix", "StationServiceId", "UserId" },
                values: new object[] { new Guid("445e3c55-706d-4765-86f4-ab89cfdbec28"), new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.251m, new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Releves",
                keyColumn: "Id_RE",
                keyValue: new Guid("1da26d2c-e143-413a-b279-6b8895fb2326"));

            migrationBuilder.DeleteData(
                table: "Releves",
                keyColumn: "Id_RE",
                keyValue: new Guid("445e3c55-706d-4765-86f4-ab89cfdbec28"));

            migrationBuilder.DeleteData(
                table: "Releves",
                keyColumn: "Id_RE",
                keyValue: new Guid("71ee6506-f614-484c-b2d9-62c375f5c500"));
        }
    }
}
