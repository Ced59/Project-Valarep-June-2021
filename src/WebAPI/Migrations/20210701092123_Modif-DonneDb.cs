using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class ModifDonneDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carburants",
                columns: new[] { "Id_CA", "CodeEu", "Libelle", "StationServiceIdSt" },
                values: new object[,]
                {
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), "E5", "Sans plomb 98", null },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), "E10", "Sans plomb 95 - E10", null },
                    { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), "E85", "Super éthanol E85", null },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), "B7", "Gazole", null },
                    { new Guid("52d0feb7-0ea6-4e85-b274-23614a35600f"), "H2", "Hydrogène", null },
                    { new Guid("b056d6b3-6705-423b-87d7-ef4d1c305ec1"), "CNG", "Gaz naturel comprimé", null },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), "LPG", "Gaz de pétrole liquéfié", null },
                    { new Guid("4bfe7231-c972-4a8a-af6c-391e9b5dd3d8"), "LNG", "Gaz naturel liquéfié", null }
                });

            migrationBuilder.InsertData(
                table: "Marque",
                columns: new[] { "Id_MA", "Libelle" },
                values: new object[,]
                {
                    { new Guid("d6b706e1-a50b-444f-9bb9-30790ba9c638"), "Elan" },
                    { new Guid("be5ce01f-540a-48b0-9898-192fbbda2510"), "Géant" },
                    { new Guid("2bdbfcf0-7515-4db6-84da-d636f208e6a7"), "Dyneff" },
                    { new Guid("c0d89443-e254-4dd7-98b1-e01e8b3a7204"), "Netto" },
                    { new Guid("3607cc0e-c68e-4f7c-8741-476cbe51c4d6"), "Shell" },
                    { new Guid("7e17f767-e7b4-4c59-8dd7-2e5bad36975d"), "Cora" },
                    { new Guid("60eda7b1-07b4-4fe1-a8cf-65b3e247ec77"), "Atac" },
                    { new Guid("42dd8d42-61f8-4fff-8490-d4ee558c78ec"), "Colruyt" },
                    { new Guid("f6ef9a0d-e2a0-48b9-aef1-b14fe1e29036"), "Supermarché Match" },
                    { new Guid("5ae0e7ce-3dcd-4140-a15c-65acbe2e869f"), "Intermarché Contact" },
                    { new Guid("5d476f45-6a23-4b9b-9e6d-7aa68a7f7d3e"), "Bi1" },
                    { new Guid("a8156a7c-eec3-4a66-8d5a-b727aa59cbc7"), "Simply Market" },
                    { new Guid("11b43387-d462-45e5-88cf-c1d6c20e04e2"), "Leader Price" },
                    { new Guid("309a9d7b-764a-45b0-8653-b4a4b21f3a2a"), "Vitto" },
                    { new Guid("270140d7-50f9-4652-9016-3cc08880f5f6"), "Agip" },
                    { new Guid("63b76659-6e52-4840-a0f3-f373ccdb5da6"), "Autres" },
                    { new Guid("5cfca887-e5ef-4836-8c96-e7787c5394e5"), "Casino" },
                    { new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f"), "Intermarché" },
                    { new Guid("c48db78b-3860-47c9-893f-ed9546cf3f01"), "Total" },
                    { new Guid("6e5a91a2-1b2b-4d9d-8114-35cd9dd027e2"), "Système U" },
                    { new Guid("684a4085-9106-415f-8f85-bff839bc9859"), "Carrefour Market" },
                    { new Guid("a6105698-16c4-470c-8dd9-d574317bee9b"), "Leclerc" },
                    { new Guid("3e13974a-84a6-414a-81dd-8057303eb361"), "Esso" },
                    { new Guid("1d82f584-1cc0-4cd5-87f1-a6d067e29a8b"), "Avia" },
                    { new Guid("9809b58b-f3a4-430f-895c-9732214603dd"), "Total Access" },
                    { new Guid("d8c5e349-047c-4bb7-b9c3-a6615ffadf14"), "Carrefour Contact" },
                    { new Guid("5ce08075-94d9-4514-8872-fdaf08a8ee9b"), "Esso Express" },
                    { new Guid("a6514eb5-db89-49e4-b04c-8dd8aaad9bff"), "BP" },
                    { new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4"), "Auchan" },
                    { new Guid("ee7c9d65-14b1-47fa-a2ee-1ad183433f41"), "Carrefour" },
                    { new Guid("95d78ab4-ef79-4707-a1e5-4aec4e1094e2"), "Indépendant sans enseigne" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_US", "Login", "Password", "Pseudo" },
                values: new object[,]
                {
                    { new Guid("65fe75f0-8991-472b-9533-65cd78596f2e"), "theo@test.com", "test", "Théo" },
                    { new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"), "ced@test.com", "test", "Ced" },
                    { new Guid("26a3a18c-56f1-4723-8052-4de25e8637b3"), "vince@test.com", "test", "Vincent" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_US", "Login", "Password", "Pseudo" },
                values: new object[] { new Guid("b68d837a-f541-428e-892a-4b854a78d755"), "charlotte@test.com", "test", "Charlotte" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_US", "Login", "Password", "Pseudo" },
                values: new object[] { new Guid("65fe75f0-8991-472b-9533-65cd78596f2f"), "ali@test.com", "test", "Ali" });

            migrationBuilder.InsertData(
                table: "StationServices",
                columns: new[] { "Id_ST", "Adresse", "Latitude", "Longitude", "MarqueId" },
                values: new object[] { new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), "960 Avenue Jean Jaurès, 59174 La Sentinelle", "50.3453386677043", "3.479521676283144", new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f") });

            migrationBuilder.InsertData(
                table: "StationServices",
                columns: new[] { "Id_ST", "Adresse", "Latitude", "Longitude", "MarqueId" },
                values: new object[] { new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"), "27 Boulevard Saly, 59300 Valenciennes", "50.35364007720023", "3.5202011928830075", new Guid("9809b58b-f3a4-430f-895c-9732214603dd") });

            migrationBuilder.InsertData(
                table: "StationServices",
                columns: new[] { "Id_ST", "Adresse", "Latitude", "Longitude", "MarqueId" },
                values: new object[] { new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"), "59125 Trith-Saint-Léger", "50.33483671401915", "3.4815290258130953", new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4") });

            migrationBuilder.InsertData(
                table: "Releves",
                columns: new[] { "Id_RE", "CarburantId", "Date", "Prix", "StationServiceId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1da26d2c-e143-413a-b279-6b8895fb2326"), new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.451m, new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338") },
                    { new Guid("71ee6506-f614-484c-b2d9-62c375f5c500"), new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.751m, new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338") },
                    { new Guid("445e3c55-706d-4765-86f4-ab89cfdbec28"), new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.251m, new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"), new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338") }
                });

            migrationBuilder.InsertData(
                table: "StationServiceCarburants",
                columns: new[] { "CarburantId", "StationServiceId" },
                values: new object[,]
                {
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc") },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("3ca237c2-f23b-4361-8708-d5654fb247af") },
                    { new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") },
                    { new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("b056d6b3-6705-423b-87d7-ef4d1c305ec1"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("11b43387-d462-45e5-88cf-c1d6c20e04e2"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("1d82f584-1cc0-4cd5-87f1-a6d067e29a8b"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("270140d7-50f9-4652-9016-3cc08880f5f6"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("2bdbfcf0-7515-4db6-84da-d636f208e6a7"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("309a9d7b-764a-45b0-8653-b4a4b21f3a2a"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("3607cc0e-c68e-4f7c-8741-476cbe51c4d6"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("3e13974a-84a6-414a-81dd-8057303eb361"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("42dd8d42-61f8-4fff-8490-d4ee558c78ec"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("5ae0e7ce-3dcd-4140-a15c-65acbe2e869f"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("5ce08075-94d9-4514-8872-fdaf08a8ee9b"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("5cfca887-e5ef-4836-8c96-e7787c5394e5"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("5d476f45-6a23-4b9b-9e6d-7aa68a7f7d3e"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("60eda7b1-07b4-4fe1-a8cf-65b3e247ec77"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("63b76659-6e52-4840-a0f3-f373ccdb5da6"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("684a4085-9106-415f-8f85-bff839bc9859"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("6e5a91a2-1b2b-4d9d-8114-35cd9dd027e2"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("7e17f767-e7b4-4c59-8dd7-2e5bad36975d"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("95d78ab4-ef79-4707-a1e5-4aec4e1094e2"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("a6105698-16c4-470c-8dd9-d574317bee9b"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("a6514eb5-db89-49e4-b04c-8dd8aaad9bff"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("a8156a7c-eec3-4a66-8d5a-b727aa59cbc7"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("be5ce01f-540a-48b0-9898-192fbbda2510"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("c0d89443-e254-4dd7-98b1-e01e8b3a7204"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("c48db78b-3860-47c9-893f-ed9546cf3f01"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("d6b706e1-a50b-444f-9bb9-30790ba9c638"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("d8c5e349-047c-4bb7-b9c3-a6615ffadf14"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("ee7c9d65-14b1-47fa-a2ee-1ad183433f41"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("f6ef9a0d-e2a0-48b9-aef1-b14fe1e29036"));

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
                keyValues: new object[] { new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"), new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0") });

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
                keyValue: new Guid("65fe75f0-8991-472b-9533-65cd78596f2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("b68d837a-f541-428e-892a-4b854a78d755"));

            migrationBuilder.DeleteData(
                table: "Carburants",
                keyColumn: "Id_CA",
                keyValue: new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"));

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
                keyValue: new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"));

            migrationBuilder.DeleteData(
                table: "StationServices",
                keyColumn: "Id_ST",
                keyValue: new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"));

            migrationBuilder.DeleteData(
                table: "StationServices",
                keyColumn: "Id_ST",
                keyValue: new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"));

            migrationBuilder.DeleteData(
                table: "StationServices",
                keyColumn: "Id_ST",
                keyValue: new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_US",
                keyValue: new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("9809b58b-f3a4-430f-895c-9732214603dd"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4"));
        }
    }
}
