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
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<AppointmentHour> AppointmentHours { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configurations

            #region Identity

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

            #endregion

            #region Appointments

            builder.Entity<Appointment>()
                .ToTable("Appointments");

            builder.Entity<Appointment>()
                .HasKey(a => a.AppointmentId);

            builder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(u => u.AppointmentsDoc)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.AppointmentsPat)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Entity<Appointment>()
                .HasOne(a => a.Hour)
                .WithMany(ah => ah.Appointments)
                .HasForeignKey(a => a.AppointmentHourId);

            #endregion

            #region Specialties

            builder.Entity<Specialty>()
                .ToTable("Specialties");

            builder.Entity<Specialty>()
               .HasKey(a => a.SpecialtyId);

            builder.Entity<UserSpecialty>()
                .ToTable("UserSpecialties");

            builder.Entity<UserSpecialty>()
                .HasKey(us => new { us.UserId, us.SpecialtyId });

            builder.Entity<UserSpecialty>()
                .HasOne<User>(us => us.Doctor)
                .WithMany(u => u.UserSpecialties)
                .HasForeignKey(us => us.UserId);

            builder.Entity<UserSpecialty>()
                .HasOne<Specialty>(us => us.Specialty)
                .WithMany(s => s.UserSpecialties)
                .HasForeignKey(us => us.SpecialtyId);

            #endregion

            #region AppointmentHours

            builder.Entity<AppointmentHour>()
                .ToTable("AppointmentHours");

            builder.Entity<AppointmentHour>()
                .HasKey(a => a.AppointmentHourId);

            builder.Entity<AppointmentHour>()
                .HasIndex(a => a.Hour)
                .IsUnique();

            #endregion

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
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
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
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
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
                    PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
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

            #region Appointments

            builder.Entity<Appointment>()
                .HasData(
                    new Appointment
                    {
                        AppointmentId = 1,
                        PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                        DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                        AppointmentHourId = 5,
                        Date = DateTime.Now.AddDays(-5)
                    },
                    new Appointment
                    {
                        AppointmentId = 2,
                        PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                        DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                        AppointmentHourId = 2,
                        Date = DateTime.Now.AddDays(-3)
                    },
                    new Appointment
                    {
                        AppointmentId = 3,
                        PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                        DoctorId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                        AppointmentHourId = 7,
                        Date = DateTime.Now.AddDays(-1)
                    });

            #endregion

            #region Specialties

            builder.Entity<Specialty>()
                .HasData(
                    new Specialty
                    {
                        SpecialtyId = 1,
                        Name = "Allergy and immunology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 2,
                        Name = "Cardiology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 3,
                        Name = "Dermatology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 4,
                        Name = "Endocrinology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 5,
                        Name = "Family medicine"
                    },
                    new Specialty
                    {
                        SpecialtyId = 6,
                        Name = "Geriatrics"
                    },
                    new Specialty
                    {
                        SpecialtyId = 7,
                        Name = "Hematology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 8,
                        Name = "Neurology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 9,
                        Name = "Hematology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 10,
                        Name = "Pathology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 11,
                        Name = "Pediatrics"
                    },
                    new Specialty
                    {
                        SpecialtyId = 12,
                        Name = "Psychiatry"
                    },
                    new Specialty
                    {
                        SpecialtyId = 13,
                        Name = "Rheumatology"
                    },
                    new Specialty
                    {
                        SpecialtyId = 14,
                        Name = "Urology"
                    });

            #endregion

            #region UserSpecialty

            builder.Entity<UserSpecialty>()
                .HasData(
                new UserSpecialty
                {
                    UserId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                    SpecialtyId = 5
                },
                new UserSpecialty
                {
                    UserId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                    SpecialtyId = 5
                },
                new UserSpecialty
                {
                    UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                    SpecialtyId = 2
                },
                new UserSpecialty
                {
                    UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                    SpecialtyId = 13
                });

            #endregion

            #region AppointmentHours

            builder.Entity<AppointmentHour>()
                .HasData(
                    new AppointmentHour
                    {
                        AppointmentHourId = 1,
                        Hour = "8:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 2,
                        Hour = "8:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 3,
                        Hour = "9:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 4,
                        Hour = "9:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 5,
                        Hour = "10:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 6,
                        Hour = "10:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 7,
                        Hour = "11:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 8,
                        Hour = "11:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 9,
                        Hour = "12:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 10,
                        Hour = "12:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 11,
                        Hour = "13:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 12,
                        Hour = "13:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 13,
                        Hour = "14:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 14,
                        Hour = "14:30"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 15,
                        Hour = "15:00"
                    },
                    new AppointmentHour
                    {
                        AppointmentHourId = 16,
                        Hour = "15:30"
                    });

            #endregion
        }
    }
}
