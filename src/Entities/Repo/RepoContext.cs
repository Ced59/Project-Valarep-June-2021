using Entities.Configs;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repo
{
    public partial class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Carburant> Carburants { get; set; }
        public virtual DbSet<Marque> Marques { get; set; }
        public virtual DbSet<Releve> Releves { get; set; }
        public virtual DbSet<StationService> StationServices { get; set; }
        public virtual DbSet<StationServiceCarburant> StationServiceCarburants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFavouritesStationsService> UserFavouritesStationsServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Carburant>(entity =>
            {
                entity.HasKey(e => e.IdCa);

                entity.Property(e => e.IdCa)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_CA");

                entity.Property(e => e.CodeEu).IsRequired();

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<Marque>(entity =>
            {
                entity.HasKey(e => e.IdMa);

                entity.ToTable("Marque");

                entity.Property(e => e.IdMa)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_MA");

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<Releve>(entity =>
            {
                entity.HasKey(e => e.IdRe);

                entity.HasIndex(e => e.CarburantId, "IX_Releves_CarburantId");

                entity.HasIndex(e => e.StationServiceId, "IX_Releves_StationServiceId");

                entity.HasIndex(e => e.UserId, "IX_Releves_UserId");

                entity.Property(e => e.IdRe)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_RE");

                entity.Property(e => e.Prix).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Carburant)
                    .WithMany(p => p.Releves)
                    .HasForeignKey(d => d.CarburantId);

                entity.HasOne(d => d.StationService)
                    .WithMany(p => p.Releves)
                    .HasForeignKey(d => d.StationServiceId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Releves)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<StationService>(entity =>
            {
                entity.HasKey(e => e.IdSt);

                entity.HasIndex(e => e.MarqueId, "IX_StationServices_MarqueId");

                entity.Property(e => e.IdSt)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_ST");

                entity.Property(e => e.Adresse).IsRequired();

                entity.Property(e => e.Latitude).IsRequired();

                entity.Property(e => e.Longitude).IsRequired();

                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.StationServices)
                    .HasForeignKey(d => d.MarqueId);
            });

            modelBuilder.Entity<StationServiceCarburant>(entity =>
            {
                entity.HasKey(e => new { e.CarburantId, e.StationServiceId });

                entity.HasIndex(e => e.StationServiceId, "IX_StationServiceCarburants_StationServiceId");

                entity.HasOne(d => d.Carburant)
                    .WithMany(p => p.StationServiceCarburants)
                    .HasForeignKey(d => d.CarburantId);

                entity.HasOne(d => d.StationService)
                    .WithMany(p => p.StationServiceCarburants)
                    .HasForeignKey(d => d.StationServiceId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUs);

                entity.Property(e => e.IdUs)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_US");

                entity.Property(e => e.Login).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Pseudo).IsRequired();
            });

            modelBuilder.Entity<UserFavouritesStationsService>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.FavouriteStationsServiceId });

                entity.HasIndex(e => e.FavouriteStationsServiceId, "IX_UserFavouritesStationsServices_FavouriteStationsServiceId");

                entity.HasOne(d => d.FavouriteStationsService)
                    .WithMany(p => p.UserFavouritesStationsServices)
                    .HasForeignKey(d => d.FavouriteStationsServiceId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFavouritesStationsServices)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
}
}