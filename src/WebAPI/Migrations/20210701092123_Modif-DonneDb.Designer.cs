﻿// <auto-generated />
using System;
using Entities.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebAPI.Migrations
{
    [DbContext(typeof(RepoContext))]
    [Migration("20210701092123_Modif-DonneDb")]
    partial class ModifDonneDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Carburant", b =>
                {
                    b.Property<Guid>("IdCa")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_CA");

                    b.Property<string>("CodeEu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StationServiceIdSt")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdCa");

                    b.HasIndex("StationServiceIdSt");

                    b.ToTable("Carburants");

                    b.HasData(
                        new
                        {
                            IdCa = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"),
                            CodeEu = "E5",
                            Libelle = "Sans plomb 98"
                        },
                        new
                        {
                            IdCa = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"),
                            CodeEu = "E10",
                            Libelle = "Sans plomb 95 - E10"
                        },
                        new
                        {
                            IdCa = new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"),
                            CodeEu = "E85",
                            Libelle = "Super éthanol E85"
                        },
                        new
                        {
                            IdCa = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"),
                            CodeEu = "B7",
                            Libelle = "Gazole"
                        },
                        new
                        {
                            IdCa = new Guid("52d0feb7-0ea6-4e85-b274-23614a35600f"),
                            CodeEu = "H2",
                            Libelle = "Hydrogène"
                        },
                        new
                        {
                            IdCa = new Guid("b056d6b3-6705-423b-87d7-ef4d1c305ec1"),
                            CodeEu = "CNG",
                            Libelle = "Gaz naturel comprimé"
                        },
                        new
                        {
                            IdCa = new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"),
                            CodeEu = "LPG",
                            Libelle = "Gaz de pétrole liquéfié"
                        },
                        new
                        {
                            IdCa = new Guid("4bfe7231-c972-4a8a-af6c-391e9b5dd3d8"),
                            CodeEu = "LNG",
                            Libelle = "Gaz naturel liquéfié"
                        });
                });

            modelBuilder.Entity("Entities.Models.Marque", b =>
                {
                    b.Property<Guid>("IdMa")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_MA");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMa");

                    b.ToTable("Marque");

                    b.HasData(
                        new
                        {
                            IdMa = new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f"),
                            Libelle = "Intermarché"
                        },
                        new
                        {
                            IdMa = new Guid("c48db78b-3860-47c9-893f-ed9546cf3f01"),
                            Libelle = "Total"
                        },
                        new
                        {
                            IdMa = new Guid("6e5a91a2-1b2b-4d9d-8114-35cd9dd027e2"),
                            Libelle = "Système U"
                        },
                        new
                        {
                            IdMa = new Guid("684a4085-9106-415f-8f85-bff839bc9859"),
                            Libelle = "Carrefour Market"
                        },
                        new
                        {
                            IdMa = new Guid("a6105698-16c4-470c-8dd9-d574317bee9b"),
                            Libelle = "Leclerc"
                        },
                        new
                        {
                            IdMa = new Guid("9809b58b-f3a4-430f-895c-9732214603dd"),
                            Libelle = "Total Access"
                        },
                        new
                        {
                            IdMa = new Guid("1d82f584-1cc0-4cd5-87f1-a6d067e29a8b"),
                            Libelle = "Avia"
                        },
                        new
                        {
                            IdMa = new Guid("95d78ab4-ef79-4707-a1e5-4aec4e1094e2"),
                            Libelle = "Indépendant sans enseigne"
                        },
                        new
                        {
                            IdMa = new Guid("d8c5e349-047c-4bb7-b9c3-a6615ffadf14"),
                            Libelle = "Carrefour Contact"
                        },
                        new
                        {
                            IdMa = new Guid("5ce08075-94d9-4514-8872-fdaf08a8ee9b"),
                            Libelle = "Esso Express"
                        },
                        new
                        {
                            IdMa = new Guid("a6514eb5-db89-49e4-b04c-8dd8aaad9bff"),
                            Libelle = "BP"
                        },
                        new
                        {
                            IdMa = new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4"),
                            Libelle = "Auchan"
                        },
                        new
                        {
                            IdMa = new Guid("ee7c9d65-14b1-47fa-a2ee-1ad183433f41"),
                            Libelle = "Carrefour"
                        },
                        new
                        {
                            IdMa = new Guid("63b76659-6e52-4840-a0f3-f373ccdb5da6"),
                            Libelle = "Autres"
                        },
                        new
                        {
                            IdMa = new Guid("5cfca887-e5ef-4836-8c96-e7787c5394e5"),
                            Libelle = "Casino"
                        },
                        new
                        {
                            IdMa = new Guid("3e13974a-84a6-414a-81dd-8057303eb361"),
                            Libelle = "Esso"
                        },
                        new
                        {
                            IdMa = new Guid("270140d7-50f9-4652-9016-3cc08880f5f6"),
                            Libelle = "Agip"
                        },
                        new
                        {
                            IdMa = new Guid("5ae0e7ce-3dcd-4140-a15c-65acbe2e869f"),
                            Libelle = "Intermarché Contact"
                        },
                        new
                        {
                            IdMa = new Guid("d6b706e1-a50b-444f-9bb9-30790ba9c638"),
                            Libelle = "Elan"
                        },
                        new
                        {
                            IdMa = new Guid("be5ce01f-540a-48b0-9898-192fbbda2510"),
                            Libelle = "Géant"
                        },
                        new
                        {
                            IdMa = new Guid("2bdbfcf0-7515-4db6-84da-d636f208e6a7"),
                            Libelle = "Dyneff"
                        },
                        new
                        {
                            IdMa = new Guid("c0d89443-e254-4dd7-98b1-e01e8b3a7204"),
                            Libelle = "Netto"
                        },
                        new
                        {
                            IdMa = new Guid("3607cc0e-c68e-4f7c-8741-476cbe51c4d6"),
                            Libelle = "Shell"
                        },
                        new
                        {
                            IdMa = new Guid("7e17f767-e7b4-4c59-8dd7-2e5bad36975d"),
                            Libelle = "Cora"
                        },
                        new
                        {
                            IdMa = new Guid("309a9d7b-764a-45b0-8653-b4a4b21f3a2a"),
                            Libelle = "Vitto"
                        },
                        new
                        {
                            IdMa = new Guid("42dd8d42-61f8-4fff-8490-d4ee558c78ec"),
                            Libelle = "Colruyt"
                        },
                        new
                        {
                            IdMa = new Guid("f6ef9a0d-e2a0-48b9-aef1-b14fe1e29036"),
                            Libelle = "Supermarché Match"
                        },
                        new
                        {
                            IdMa = new Guid("60eda7b1-07b4-4fe1-a8cf-65b3e247ec77"),
                            Libelle = "Atac"
                        },
                        new
                        {
                            IdMa = new Guid("5d476f45-6a23-4b9b-9e6d-7aa68a7f7d3e"),
                            Libelle = "Bi1"
                        },
                        new
                        {
                            IdMa = new Guid("a8156a7c-eec3-4a66-8d5a-b727aa59cbc7"),
                            Libelle = "Simply Market"
                        },
                        new
                        {
                            IdMa = new Guid("11b43387-d462-45e5-88cf-c1d6c20e04e2"),
                            Libelle = "Leader Price"
                        });
                });

            modelBuilder.Entity("Entities.Models.Releve", b =>
                {
                    b.Property<Guid>("IdRe")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_RE");

                    b.Property<Guid>("CarburantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,5)");

                    b.Property<Guid>("StationServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdRe");

                    b.HasIndex(new[] { "CarburantId" }, "IX_Releves_CarburantId");

                    b.HasIndex(new[] { "StationServiceId" }, "IX_Releves_StationServiceId");

                    b.HasIndex(new[] { "UserId" }, "IX_Releves_UserId");

                    b.ToTable("Releves");

                    b.HasData(
                        new
                        {
                            IdRe = new Guid("1da26d2c-e143-413a-b279-6b8895fb2326"),
                            CarburantId = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"),
                            Date = new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prix = 1.451m,
                            StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                            UserId = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338")
                        },
                        new
                        {
                            IdRe = new Guid("71ee6506-f614-484c-b2d9-62c375f5c500"),
                            CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"),
                            Date = new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prix = 1.751m,
                            StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                            UserId = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338")
                        },
                        new
                        {
                            IdRe = new Guid("445e3c55-706d-4765-86f4-ab89cfdbec28"),
                            CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"),
                            Date = new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Prix = 1.251m,
                            StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                            UserId = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338")
                        });
                });

            modelBuilder.Entity("Entities.Models.StationService", b =>
                {
                    b.Property<Guid>("IdSt")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_ST");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MarqueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSt");

                    b.HasIndex(new[] { "MarqueId" }, "IX_StationServices_MarqueId");

                    b.ToTable("StationServices");

                    b.HasData(
                        new
                        {
                            IdSt = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                            Adresse = "960 Avenue Jean Jaurès, 59174 La Sentinelle",
                            Latitude = "50.3453386677043",
                            Longitude = "3.479521676283144",
                            MarqueId = new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f")
                        },
                        new
                        {
                            IdSt = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                            Adresse = "59125 Trith-Saint-Léger",
                            Latitude = "50.33483671401915",
                            Longitude = "3.4815290258130953",
                            MarqueId = new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4")
                        },
                        new
                        {
                            IdSt = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"),
                            Adresse = "27 Boulevard Saly, 59300 Valenciennes",
                            Latitude = "50.35364007720023",
                            Longitude = "3.5202011928830075",
                            MarqueId = new Guid("9809b58b-f3a4-430f-895c-9732214603dd")
                        });
                });

            modelBuilder.Entity("Entities.Models.StationServiceCarburant", b =>
                {
                    b.Property<Guid>("CarburantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StationServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CarburantId", "StationServiceId");

                    b.HasIndex(new[] { "StationServiceId" }, "IX_StationServiceCarburants_StationServiceId");

                    b.ToTable("StationServiceCarburants");

                    b.HasData(
                        new
                        {
                            CarburantId = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"),
                            StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc")
                        },
                        new
                        {
                            CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"),
                            StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc")
                        },
                        new
                        {
                            CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"),
                            StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc")
                        },
                        new
                        {
                            CarburantId = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"),
                            StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0")
                        },
                        new
                        {
                            CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"),
                            StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0")
                        },
                        new
                        {
                            CarburantId = new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b"),
                            StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0")
                        },
                        new
                        {
                            CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"),
                            StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0")
                        },
                        new
                        {
                            CarburantId = new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"),
                            StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0")
                        },
                        new
                        {
                            CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"),
                            StationServiceId = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af")
                        },
                        new
                        {
                            CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"),
                            StationServiceId = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af")
                        },
                        new
                        {
                            CarburantId = new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12"),
                            StationServiceId = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af")
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("IdUs")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_US");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUs");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IdUs = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"),
                            Login = "ced@test.com",
                            Password = "test",
                            Pseudo = "Ced"
                        },
                        new
                        {
                            IdUs = new Guid("26a3a18c-56f1-4723-8052-4de25e8637b3"),
                            Login = "vince@test.com",
                            Password = "test",
                            Pseudo = "Vincent"
                        },
                        new
                        {
                            IdUs = new Guid("b68d837a-f541-428e-892a-4b854a78d755"),
                            Login = "charlotte@test.com",
                            Password = "test",
                            Pseudo = "Charlotte"
                        },
                        new
                        {
                            IdUs = new Guid("65fe75f0-8991-472b-9533-65cd78596f2e"),
                            Login = "theo@test.com",
                            Password = "test",
                            Pseudo = "Théo"
                        },
                        new
                        {
                            IdUs = new Guid("65fe75f0-8991-472b-9533-65cd78596f2f"),
                            Login = "ali@test.com",
                            Password = "test",
                            Pseudo = "Ali"
                        });
                });

            modelBuilder.Entity("Entities.Models.UserFavouritesStationsService", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FavouriteStationsServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "FavouriteStationsServiceId");

                    b.HasIndex(new[] { "FavouriteStationsServiceId" }, "IX_UserFavouritesStationsServices_FavouriteStationsServiceId");

                    b.ToTable("UserFavouritesStationsServices");
                });

            modelBuilder.Entity("Entities.Models.Carburant", b =>
                {
                    b.HasOne("Entities.Models.StationService", null)
                        .WithMany("Carburants")
                        .HasForeignKey("StationServiceIdSt");
                });

            modelBuilder.Entity("Entities.Models.Releve", b =>
                {
                    b.HasOne("Entities.Models.Carburant", "Carburant")
                        .WithMany("Releves")
                        .HasForeignKey("CarburantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.StationService", "StationService")
                        .WithMany("Releves")
                        .HasForeignKey("StationServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Releves")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carburant");

                    b.Navigation("StationService");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.StationService", b =>
                {
                    b.HasOne("Entities.Models.Marque", "Marque")
                        .WithMany("StationServices")
                        .HasForeignKey("MarqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marque");
                });

            modelBuilder.Entity("Entities.Models.StationServiceCarburant", b =>
                {
                    b.HasOne("Entities.Models.Carburant", "Carburant")
                        .WithMany("StationServiceCarburants")
                        .HasForeignKey("CarburantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.StationService", "StationService")
                        .WithMany("StationServiceCarburants")
                        .HasForeignKey("StationServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carburant");

                    b.Navigation("StationService");
                });

            modelBuilder.Entity("Entities.Models.UserFavouritesStationsService", b =>
                {
                    b.HasOne("Entities.Models.StationService", "FavouriteStationsService")
                        .WithMany("UserFavouritesStationsServices")
                        .HasForeignKey("FavouriteStationsServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("UserFavouritesStationsServices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FavouriteStationsService");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Carburant", b =>
                {
                    b.Navigation("Releves");

                    b.Navigation("StationServiceCarburants");
                });

            modelBuilder.Entity("Entities.Models.Marque", b =>
                {
                    b.Navigation("StationServices");
                });

            modelBuilder.Entity("Entities.Models.StationService", b =>
                {
                    b.Navigation("Carburants");

                    b.Navigation("Releves");

                    b.Navigation("StationServiceCarburants");

                    b.Navigation("UserFavouritesStationsServices");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("Releves");

                    b.Navigation("UserFavouritesStationsServices");
                });
#pragma warning restore 612, 618
        }
    }
}