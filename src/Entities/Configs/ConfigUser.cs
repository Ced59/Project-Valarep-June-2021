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
    public class ConfigUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    IdUs = new Guid("7e1d2a85-c5ff-4b31-88cc-d4fd7e7a1338"),
                    Pseudo = "Ced",
                    Login = "ced@test.com",
                    Password = "test"
                },
                                new User
                                {
                                    IdUs = new Guid("26a3a18c-56f1-4723-8052-4de25e8637b3"),
                                    Pseudo = "Vincent",
                                    Login = "vince@test.com",
                                    Password = "test"
                                },
                                                new User
                                                {
                                                    IdUs = new Guid("b68d837a-f541-428e-892a-4b854a78d755"),
                                                    Pseudo = "Charlotte",
                                                    Login = "charlotte@test.com",
                                                    Password = "test"
                                                },
                                                                new User
                                                                {
                                                                    IdUs = new Guid("65fe75f0-8991-472b-9533-65cd78596f2e"),
                                                                    Pseudo = "Théo",
                                                                    Login = "theo@test.com",
                                                                    Password = "test"
                                                                },
                                                                                new User
                                                                                {
                                                                                    IdUs = new Guid("65fe75f0-8991-472b-9533-65cd78596f2f"),
                                                                                    Pseudo = "Ali",
                                                                                    Login = "ali@test.com",
                                                                                    Password = "test"
                                                                                }
                );
        }
    }
}
