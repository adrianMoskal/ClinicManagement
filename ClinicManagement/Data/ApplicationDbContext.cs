using ClinicManagement.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string, IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configurations

            builder.Entity<User>()
                .ToTable("Users");

            builder.Entity<Role>()
                .ToTable("Roles");

            builder.Entity<UserRole>()
                .ToTable("UserRoles")
                .HasKey(ur => new { ur.UserId, ur.RoleId});

            builder.Entity<IdentityUserClaim<string>>()
                .ToTable("UserClaims");

            builder.Entity<IdentityUserLogin<string>>()
                .ToTable("UserLogins");

            builder.Entity<IdentityRoleClaim<string>>()
                .ToTable("RoleClaims");

            builder.Entity<IdentityUserToken<string>>()
                .ToTable("UserTokens");


            // DummyData

            builder.Entity<User>()
                .HasData(new User 
                { 
                    Id = "f2430875-6f50-48b6-97e6-f9c475b602c2",
                    FirstName = "Adrian",
                    LastName = "Moskal",
                    UserName = "adrianMoskal",
                    NormalizedUserName = "ADRIANMOSKAL",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                });

            builder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b",
                        Description = "All privileges",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR",
                        ConcurrencyStamp = "accb09ec-6f9f-4c73-a066-f4764d88b278"
                    },
                    new Role
                    {
                        Id = "526fa4c0-f544-4ad0-9d31-0185533cdf48",
                        Description = "Person who is giving medical care",
                        Name = "Doctor",
                        NormalizedName = "DOCTOR",
                        ConcurrencyStamp = "65c225e1-5e1e-48fa-b8ab-9dd8794b9043"
                    },
                    new Role
                    {
                        Id = "d428231e-4f51-4e41-913e-056f91346c16",
                        Description = "Person who is receiving medical care",
                        Name = "Patient",
                        NormalizedName = "PATIENT",
                        ConcurrencyStamp = "59b3eba1-eaac-442f-9ca1-a2b5a3a8e287"
                    });

            builder.Entity<UserRole>()
                .HasData(new UserRole
                {
                    UserId = "f2430875-6f50-48b6-97e6-f9c475b602c2",
                    RoleId = "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b"
                });
        }
    }
}
