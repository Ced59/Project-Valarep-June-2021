using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configs
{
    class ConfigStationServices : IEntityTypeConfiguration<StationService>
    {
        public void Configure(EntityTypeBuilder<StationService> builder)
        {
            builder.HasData(
                new StationService
                {
                    IdSt = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                     Adresse = "960 Avenue Jean Jaurès, 59174 La Sentinelle",
                     Latitude = "50.3453386677043",
                     Longitude = "3.479521676283144",
                     MarqueId = new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f")
                },
                new StationService
                {
                    IdSt = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                    Adresse = "59125 Trith-Saint-Léger",
                    Latitude = "50.33483671401915",
                    Longitude = "3.4815290258130953",
                    MarqueId = new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4")
                },
                new StationService
                {
                    IdSt = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"),
                    Adresse = "27 Boulevard Saly, 59300 Valenciennes",
                    Latitude = "50.35364007720023",
                    Longitude = "3.5202011928830075",
                    MarqueId = new Guid("9809b58b-f3a4-430f-895c-9732214603dd")
                }
                );
        }
    }
}
