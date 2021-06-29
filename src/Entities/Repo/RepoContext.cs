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
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Carburant> Carburants { get; set; }

        public DbSet<Marque> Marque { get; set; }

        public DbSet<Releve> Releves { get; set; }

        public DbSet<StationService> StationServices { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<StationServiceCarburant> StationServiceCarburants { get; set; }

        public DbSet<UserFavouritesStationsServices> UserFavouritesStationsServices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Releve>()
                .Property(p => p.Prix)
                .HasColumnType("decimal(18,5)");

            builder.Entity<StationServiceCarburant>().HasKey(s => new { s.CarburantId, s.StationServiceId });

            builder.Entity<UserFavouritesStationsServices>().HasKey(s => new { s.UserId, s.FavouriteStationsServiceId });

            builder.ApplyConfiguration(new ConfigUser());

            builder.ApplyConfiguration(new ConfigCarburants());

            builder.ApplyConfiguration(new ConfigMarque());
        }
    }
}