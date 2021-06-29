using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class JeuDonneesMarqueCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marque",
                columns: new[] { "Id_MA", "Libelle" },
                values: new object[,]
                {
                    { new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f"), "Intermarché" },
                    { new Guid("5d476f45-6a23-4b9b-9e6d-7aa68a7f7d3e"), "Bi1" },
                    { new Guid("60eda7b1-07b4-4fe1-a8cf-65b3e247ec77"), "Atac" },
                    { new Guid("f6ef9a0d-e2a0-48b9-aef1-b14fe1e29036"), "Supermarché Match" },
                    { new Guid("42dd8d42-61f8-4fff-8490-d4ee558c78ec"), "Colruyt" },
                    { new Guid("309a9d7b-764a-45b0-8653-b4a4b21f3a2a"), "Vitto" },
                    { new Guid("7e17f767-e7b4-4c59-8dd7-2e5bad36975d"), "Cora" },
                    { new Guid("3607cc0e-c68e-4f7c-8741-476cbe51c4d6"), "Shell" },
                    { new Guid("c0d89443-e254-4dd7-98b1-e01e8b3a7204"), "Netto" },
                    { new Guid("2bdbfcf0-7515-4db6-84da-d636f208e6a7"), "Dyneff" },
                    { new Guid("be5ce01f-540a-48b0-9898-192fbbda2510"), "Géant" },
                    { new Guid("d6b706e1-a50b-444f-9bb9-30790ba9c638"), "Elan" },
                    { new Guid("5ae0e7ce-3dcd-4140-a15c-65acbe2e869f"), "Intermarché Contact" },
                    { new Guid("270140d7-50f9-4652-9016-3cc08880f5f6"), "Agip" },
                    { new Guid("a8156a7c-eec3-4a66-8d5a-b727aa59cbc7"), "Simply Market" },
                    { new Guid("3e13974a-84a6-414a-81dd-8057303eb361"), "Esso" },
                    { new Guid("63b76659-6e52-4840-a0f3-f373ccdb5da6"), "Autres" },
                    { new Guid("ee7c9d65-14b1-47fa-a2ee-1ad183433f41"), "Carrefour" },
                    { new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4"), "Auchan" },
                    { new Guid("a6514eb5-db89-49e4-b04c-8dd8aaad9bff"), "BP" },
                    { new Guid("5ce08075-94d9-4514-8872-fdaf08a8ee9b"), "Esso Express" },
                    { new Guid("d8c5e349-047c-4bb7-b9c3-a6615ffadf14"), "Carrefour Contact" },
                    { new Guid("95d78ab4-ef79-4707-a1e5-4aec4e1094e2"), "Indépendant sans enseigne" },
                    { new Guid("1d82f584-1cc0-4cd5-87f1-a6d067e29a8b"), "Avia" },
                    { new Guid("9809b58b-f3a4-430f-895c-9732214603dd"), "Total Access" },
                    { new Guid("a6105698-16c4-470c-8dd9-d574317bee9b"), "Leclerc" },
                    { new Guid("684a4085-9106-415f-8f85-bff839bc9859"), "Carrefour Market" },
                    { new Guid("6e5a91a2-1b2b-4d9d-8114-35cd9dd027e2"), "Système U" },
                    { new Guid("c48db78b-3860-47c9-893f-ed9546cf3f01"), "Total" },
                    { new Guid("5cfca887-e5ef-4836-8c96-e7787c5394e5"), "Casino" },
                    { new Guid("11b43387-d462-45e5-88cf-c1d6c20e04e2"), "Leader Price" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f"));

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
                keyValue: new Guid("9809b58b-f3a4-430f-895c-9732214603dd"));

            migrationBuilder.DeleteData(
                table: "Marque",
                keyColumn: "Id_MA",
                keyValue: new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4"));

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
        }
    }
}
