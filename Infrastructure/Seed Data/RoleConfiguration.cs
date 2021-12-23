using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Seed_Data
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Name = "Operations",
                        NormalizedName = "OPERATIONS"
                    },
                    new IdentityRole
                    {
                        Name = "Store Manager",
                        NormalizedName = "STORE MANAGER"
                    },
                    new IdentityRole
                    {
                        Name = "Procurement Agent",
                        NormalizedName = "PROCUREMENT AGENT"
                    },
                    new IdentityRole
                    {
                        Name = "Sales Agent",
                        NormalizedName = "SALES AGENT"
                    },
                    new IdentityRole
                    {
                        Name = "Receptionist",
                        NormalizedName = "RECEPTIONIST"
                    },
                    new IdentityRole
                    {
                        Name = "Repair And Maintenance",
                        NormalizedName = "REPAIR AND MAINTENANCE"
                    },
                    new IdentityRole
                    {
                        Name = "Super Admin",
                        NormalizedName = "SUPER ADMIN"
                    }
                );
        }
    }
}
