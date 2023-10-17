using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConeXion.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeXion.Infrastructure.Data.Configuration
{
    internal class RoleConfigration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole> CreateRoles()
        {
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id="d9de7285-b674-454c-9889-5210abb8d347",
                    Name="Administrator",
                    NormalizedName="ADMINISTRATOR"
                },
                new IdentityRole()
                {
                    Id="07358494-247c-421c-8f7f-82c12be55276",
                    Name="Member",
                    NormalizedName="MEMBER"
                },
            };
            return roles;
        }
    }
}
