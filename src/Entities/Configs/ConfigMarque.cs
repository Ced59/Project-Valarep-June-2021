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
    public class ConfigMarque : IEntityTypeConfiguration<Marque>
    {
        public void Configure(EntityTypeBuilder<Marque> builder)
        {
            builder.HasData(
                new Marque
                {
                    IdMa = new Guid("3d173fb6-f8c9-47c1-bff9-d6b8c567af8f"),
                    Libelle = "Intermarché"
                },
                new Marque
                {
                    IdMa = new Guid("c48db78b-3860-47c9-893f-ed9546cf3f01"),
                    Libelle = "Total"
                },
                new Marque
                {
                    IdMa = new Guid("6e5a91a2-1b2b-4d9d-8114-35cd9dd027e2"),
                    Libelle = "Système U"
                },
                new Marque
                {
                    IdMa = new Guid("684a4085-9106-415f-8f85-bff839bc9859"),
                    Libelle = "Carrefour Market"
                },
                new Marque
                {
                    IdMa = new Guid("a6105698-16c4-470c-8dd9-d574317bee9b"),
                    Libelle = "Leclerc"
                },
                new Marque
                {
                    IdMa = new Guid("9809b58b-f3a4-430f-895c-9732214603dd"),
                    Libelle = "Total Access"
                },
                new Marque
                {
                    IdMa = new Guid("1d82f584-1cc0-4cd5-87f1-a6d067e29a8b"),
                    Libelle = "Avia"
                },
                new Marque
                {
                    IdMa = new Guid("95d78ab4-ef79-4707-a1e5-4aec4e1094e2"),
                    Libelle = "Indépendant sans enseigne"
                },
                new Marque
                {
                    IdMa = new Guid("d8c5e349-047c-4bb7-b9c3-a6615ffadf14"),
                    Libelle = "Carrefour Contact"
                },
                new Marque
                {
                    IdMa = new Guid("5ce08075-94d9-4514-8872-fdaf08a8ee9b"),
                    Libelle = "Esso Express"
                },
                new Marque
                {
                    IdMa = new Guid("a6514eb5-db89-49e4-b04c-8dd8aaad9bff"),
                    Libelle = "BP"
                },
                new Marque
                {
                    IdMa = new Guid("9a8fefeb-df33-4297-9c39-1f2190df8fe4"),
                    Libelle = "Auchan"
                },
                new Marque
                {
                    IdMa = new Guid("ee7c9d65-14b1-47fa-a2ee-1ad183433f41"),
                    Libelle = "Carrefour"
                },
                new Marque
                {
                    IdMa = new Guid("63b76659-6e52-4840-a0f3-f373ccdb5da6"),
                    Libelle = "Autres"
                },
                new Marque
                {
                    IdMa = new Guid("5cfca887-e5ef-4836-8c96-e7787c5394e5"),
                    Libelle = "Casino"
                },
                new Marque
                {
                    IdMa = new Guid("3e13974a-84a6-414a-81dd-8057303eb361"),
                    Libelle = "Esso"
                },
                new Marque
                {
                    IdMa = new Guid("270140d7-50f9-4652-9016-3cc08880f5f6"),
                    Libelle = "Agip"
                },
                new Marque
                {
                    IdMa = new Guid("5ae0e7ce-3dcd-4140-a15c-65acbe2e869f"),
                    Libelle = "Intermarché Contact"
                },
                new Marque
                {
                    IdMa = new Guid("d6b706e1-a50b-444f-9bb9-30790ba9c638"),
                    Libelle = "Elan"
                },
                new Marque
                {
                    IdMa = new Guid("be5ce01f-540a-48b0-9898-192fbbda2510"),
                    Libelle = "Géant"
                },
                new Marque
                {
                    IdMa = new Guid("2bdbfcf0-7515-4db6-84da-d636f208e6a7"),
                    Libelle = "Dyneff"
                },
                new Marque
                {
                    IdMa = new Guid("c0d89443-e254-4dd7-98b1-e01e8b3a7204"),
                    Libelle = "Netto"
                },
                new Marque
                {
                    IdMa = new Guid("3607cc0e-c68e-4f7c-8741-476cbe51c4d6"),
                    Libelle = "Shell"
                },
                new Marque
                {
                    IdMa = new Guid("7e17f767-e7b4-4c59-8dd7-2e5bad36975d"),
                    Libelle = "Cora"
                },
                new Marque
                {
                    IdMa = new Guid("309a9d7b-764a-45b0-8653-b4a4b21f3a2a"),
                    Libelle = "Vitto"
                },
                new Marque
                {
                    IdMa = new Guid("42dd8d42-61f8-4fff-8490-d4ee558c78ec"),
                    Libelle = "Colruyt"
                },
                new Marque
                {
                    IdMa = new Guid("f6ef9a0d-e2a0-48b9-aef1-b14fe1e29036"),
                    Libelle = "Supermarché Match"
                },
                new Marque
                {
                    IdMa = new Guid("60eda7b1-07b4-4fe1-a8cf-65b3e247ec77"),
                    Libelle = "Atac"
                },
                new Marque
                {
                    IdMa = new Guid("5d476f45-6a23-4b9b-9e6d-7aa68a7f7d3e"),
                    Libelle = "Bi1"
                },
                new Marque
                {
                    IdMa = new Guid("a8156a7c-eec3-4a66-8d5a-b727aa59cbc7"),
                    Libelle = "Simply Market"
                },
                new Marque
                {
                    IdMa = new Guid("11b43387-d462-45e5-88cf-c1d6c20e04e2"),
                    Libelle = "Leader Price"
                }

                );
        }
    }
}
