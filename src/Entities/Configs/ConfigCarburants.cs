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
    public class ConfigCarburants : IEntityTypeConfiguration<Carburant>
    {
        public void Configure(EntityTypeBuilder<Carburant> builder)
        {
            builder.HasData(
                new Carburant
                {
                    Libelle = "Sans plomb 98",
                    CodeEu = "E5",
                    IdCa = new Guid("8caad7e2-e40a-4328-95ce-74dbb8ba10b2")
                },
                new Carburant
                {
                    Libelle = "Sans plomb 95 - E10",
                    CodeEu = "E10",
                    IdCa = new Guid("3d700748-8267-43e9-9bf5-dd54a536f7c5")
                },
                new Carburant
                {
                    Libelle = "Super éthanol E85",
                    CodeEu = "E85",
                    IdCa = new Guid("e1db6bfb-4af1-4d33-b06a-072be46dd74b")
                },
                new Carburant
                {
                    Libelle = "Gazole",
                    CodeEu = "B7",
                    IdCa = new Guid("99c87086-7167-4b8d-b799-32d59dfaaac3")
                },
                new Carburant
                {
                    Libelle = "Hydrogène",
                    CodeEu = "H2",
                    IdCa = new Guid("52d0feb7-0ea6-4e85-b274-23614a35600f")
                },
                new Carburant
                {
                    Libelle = "Gaz naturel comprimé",
                    CodeEu = "CNG",
                    IdCa = new Guid("b056d6b3-6705-423b-87d7-ef4d1c305ec1")
                },
                new Carburant
                {
                    Libelle = "Gaz de pétrole liquéfié",
                    CodeEu = "LPG",
                    IdCa = new Guid("8e4431db-7fb1-4586-b61b-96d08b41ee12")
                },
                new Carburant
                {
                    Libelle = "Gaz naturel liquéfié",
                    CodeEu = "LNG",
                    IdCa = new Guid("4bfe7231-c972-4a8a-af6c-391e9b5dd3d8")
                }

                );
        }
    }
}
