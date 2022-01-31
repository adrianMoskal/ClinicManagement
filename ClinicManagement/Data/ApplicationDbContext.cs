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

            #region Users

            builder.Entity<User>()
                .HasData(
                new User
                {
                    Id = "f93f376e-0543-4073-aaf4-ceb2df8aac0b",
                    FirstName = "Super",
                    LastName = "User",
                    UserName = "SuperUser",
                    NormalizedUserName = "SUPERUSER",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumber = "111111111",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "40ae9fef-c94e-4823-a4da-bd1686467689",
                    FirstName = "Dean",
                    LastName = "Winchester",
                    UserName = "deanWinchester",
                    NormalizedUserName = "DEANWINCHESTER",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = deanWinchester1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumber = "999888777",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                    FirstName = "Sam",
                    LastName = "Winchester",
                    UserName = "samWinchester",
                    NormalizedUserName = "SAMWINCHESTER",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = samWinchester1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumber = "789456123",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "80d10f83-f746-4397-a76f-fa2a216833bc",
                    FirstName = "Castiel",
                    LastName = "Clarence",
                    UserName = "castielClarence",
                    NormalizedUserName = "CASTIELCLARENCE",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = castielClarence1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumber = "888567000",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                    FirstName = "Bobby",
                    LastName = "Singer",
                    UserName = "bobbySinger",
                    NormalizedUserName = "BOBBYSINGER",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumber = "555080911",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                    FirstName = "Jody",
                    LastName = "Mills",
                    UserName = "jodyMills",
                    NormalizedUserName = "JODYMILLS",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
                    SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                    ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                    PhoneNumber = "776554112",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                });

            #endregion

            #region Roles

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

            #endregion

            #region UserRoles

            builder.Entity<UserRole>()
                .HasData(
                new UserRole
                {
                    UserId = "f93f376e-0543-4073-aaf4-ceb2df8aac0b",
                    RoleId = "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b"
                },
                new UserRole
                {
                    UserId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                    RoleId = "526fa4c0-f544-4ad0-9d31-0185533cdf48"
                },
                new UserRole
                {
                    UserId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                    RoleId = "526fa4c0-f544-4ad0-9d31-0185533cdf48"
                },
                new UserRole
                {
                    UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                    RoleId = "526fa4c0-f544-4ad0-9d31-0185533cdf48"
                },
                new UserRole
                {
                    UserId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                    RoleId = "d428231e-4f51-4e41-913e-056f91346c16"
                },
                new UserRole
                {
                    UserId = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                    RoleId = "d428231e-4f51-4e41-913e-056f91346c16"
                });

            #endregion
        }
    }
}
