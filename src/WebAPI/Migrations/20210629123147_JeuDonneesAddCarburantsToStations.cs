using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesAddCarburantsToStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StationServiceCarburants",
                columns: new[] { "CarburantId", "StationServiceId" },
                values: new object[,]
                {
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") });

            migrationBuilder.DeleteData(
                table: "StationServiceCarburants",
                keyColumns: new[] { "CarburantId", "StationServiceId" },
                keyValues: new object[] { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") });
        }
    }
}
