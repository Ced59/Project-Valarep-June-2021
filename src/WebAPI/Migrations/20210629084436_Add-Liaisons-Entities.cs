using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class AddLiaisonsEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carburants",
                columns: table => new
                {
                    Id_CA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeEu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carburants", x => x.Id_CA);
                });

            migrationBuilder.CreateTable(
                name: "Marque",
                columns: table => new
                {
                    Id_MA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marque", x => x.Id_MA);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_US = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_US);
                });

            migrationBuilder.CreateTable(
                name: "StationServices",
                columns: table => new
                {
                    Id_ST = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationServices", x => x.Id_ST);
                    table.ForeignKey(
                        name: "FK_StationServices_Marque_MarqueId",
                        column: x => x.MarqueId,
                        principalTable: "Marque",
                        principalColumn: "Id_MA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Releves",
                columns: table => new
                {
                    Id_RE = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    CarburantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releves", x => x.Id_RE);
                    table.ForeignKey(
                        name: "FK_Releves_Carburants_CarburantId",
                        column: x => x.CarburantId,
                        principalTable: "Carburants",
                        principalColumn: "Id_CA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Releves_StationServices_StationServiceId",
                        column: x => x.StationServiceId,
                        principalTable: "StationServices",
                        principalColumn: "Id_ST",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Releves_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id_US",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StationServiceCarburants",
                columns: table => new
                {
                    StationServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarburantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationServiceCarburants", x => new { x.CarburantId, x.StationServiceId });
                    table.ForeignKey(
                        name: "FK_StationServiceCarburants_Carburants_CarburantId",
                        column: x => x.CarburantId,
                        principalTable: "Carburants",
                        principalColumn: "Id_CA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationServiceCarburants_StationServices_StationServiceId",
                        column: x => x.StationServiceId,
                        principalTable: "StationServices",
                        principalColumn: "Id_ST",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavouritesStationsServices",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FavouriteStationsServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavouritesStationsServices", x => new { x.UserId, x.FavouriteStationsServiceId });
                    table.ForeignKey(
                        name: "FK_UserFavouritesStationsServices_StationServices_FavouriteStationsServiceId",
                        column: x => x.FavouriteStationsServiceId,
                        principalTable: "StationServices",
                        principalColumn: "Id_ST",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavouritesStationsServices_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id_US",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Releves_CarburantId",
                table: "Releves",
                column: "CarburantId");

            migrationBuilder.CreateIndex(
                name: "IX_Releves_StationServiceId",
                table: "Releves",
                column: "StationServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Releves_UserId",
                table: "Releves",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StationServiceCarburants_StationServiceId",
                table: "StationServiceCarburants",
                column: "StationServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StationServices_MarqueId",
                table: "StationServices",
                column: "MarqueId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavouritesStationsServices_FavouriteStationsServiceId",
                table: "UserFavouritesStationsServices",
                column: "FavouriteStationsServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Releves");

            migrationBuilder.DropTable(
                name: "StationServiceCarburants");

            migrationBuilder.DropTable(
                name: "UserFavouritesStationsServices");

            migrationBuilder.DropTable(
                name: "Carburants");

            migrationBuilder.DropTable(
                name: "StationServices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Marque");
        }
    }
}
