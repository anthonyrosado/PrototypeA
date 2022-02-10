using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrototypeA.Data
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(
                new IdentityUser
                {
                    UserName = "test@tymespace.com",
                    NormalizedUserName = "TEST@TYMESPACE.COM",
                    Email = "test@tymespace.com",
                    NormalizedEmail = "TEST@TYMESPACE.COM",
                });
        }
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "AdminUser",
                    NormalizedName = "ADMINUSER"
                },
                new IdentityRole
                {
                    Name = "ServiceProvider",
                    NormalizedName = "SERVICEPROVIDER"
                },
                new IdentityRole
                {
                    Name = "SatelliteOwner",
                    NormalizedName = "SATELLITEOWNER"
                },
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );
        }
    }
}