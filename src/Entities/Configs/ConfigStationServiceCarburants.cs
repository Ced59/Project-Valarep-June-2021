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
    class ConfigStationServiceCarburants : IEntityTypeConfiguration<StationServiceCarburant>
    {
        public void Configure(EntityTypeBuilder<StationServiceCarburant> builder)
        {
            builder.HasData(
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                    CarburantId = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                    CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("89223c2d-d43e-4c90-a33d-793e8e328cbc"),
                    CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3")
                },

                new StationServiceCarburant
                {
                    StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                    CarburantId = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                    CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                    CarburantId = new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                    CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("ed772bc2-69fd-432a-9a0c-f7f8317763c0"),
                    CarburantId = new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12")
                },


                
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"),
                    CarburantId = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"),
                    CarburantId = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3")
                },
                new StationServiceCarburant
                {
                    StationServiceId = new Guid("3ca237c2-f23b-4361-8708-d5654fb247af"),
                    CarburantId = new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12")
                }
                );
        }
    }
}
