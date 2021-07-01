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
    public class ConfigReleves : IEntityTypeConfiguration<Releve>
    {
        public void Configure(EntityTypeBuilder<Releve> builder)
        {
            builder.HasData(
                new Releve
                {
                    CarburantId = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2"),
                    Date = new DateTime(2021, 6, 28),
                    IdRe = new Guid("1da26d2c-e143-413a-b279-6b8895fb2326"),
                    Prix = (decimal)1.451,
                    UserId = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"),
                    StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc")
                },
                new Releve
                {
                    CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5"),
                    Date = new DateTime(2021, 6, 28),
                    IdRe = new Guid("71ee6506-f614-484c-b2d9-62c375f5c500"),
                    Prix = (decimal)1.751,
                    UserId = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"),
                    StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc")
                },
                new Releve
                {
                    CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3"),
                    Date = new DateTime(2021, 6, 28),
                    IdRe = new Guid("445e3c55-706d-4765-86f4-ab89cfdbec28"),
                    Prix = (decimal)1.251,
                    UserId = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"),
                    StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc")
                }
                );
        }
    }
}
