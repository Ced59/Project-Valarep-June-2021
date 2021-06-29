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
            //builder.HasData(
            //    new Releve
            //    {
            //        e
            //    }
            //    );
        }
    }
}
