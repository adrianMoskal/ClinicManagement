﻿// <auto-generated />
using System;
using ClinicManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicManagement.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicManagement.Entities.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            Date = new DateTime(2022, 1, 31, 22, 40, 52, 951, DateTimeKind.Local).AddTicks(1384),
                            DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                            PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4"
                        },
                        new
                        {
                            AppointmentId = 2,
                            Date = new DateTime(2022, 2, 2, 22, 40, 52, 954, DateTimeKind.Local).AddTicks(3053),
                            DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                            PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4"
                        },
                        new
                        {
                            AppointmentId = 3,
                            Date = new DateTime(2022, 2, 4, 22, 40, 52, 954, DateTimeKind.Local).AddTicks(3097),
                            DoctorId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                            PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4"
                        });
                });

            modelBuilder.Entity("ClinicManagement.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b",
                            ConcurrencyStamp = "accb09ec-6f9f-4c73-a066-f4764d88b278",
                            Description = "All privileges",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "526fa4c0-f544-4ad0-9d31-0185533cdf48",
                            ConcurrencyStamp = "65c225e1-5e1e-48fa-b8ab-9dd8794b9043",
                            Description = "Person who is giving medical care",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        },
                        new
                        {
                            Id = "d428231e-4f51-4e41-913e-056f91346c16",
                            ConcurrencyStamp = "59b3eba1-eaac-442f-9ca1-a2b5a3a8e287",
                            Description = "Person who is receiving medical care",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        });
                });

            modelBuilder.Entity("ClinicManagement.Entities.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialtyId");

                    b.ToTable("Specialties");

                    b.HasData(
                        new
                        {
                            SpecialtyId = 1,
                            Name = "Allergy and immunology"
                        },
                        new
                        {
                            SpecialtyId = 2,
                            Name = "Cardiology"
                        },
                        new
                        {
                            SpecialtyId = 3,
                            Name = "Dermatology"
                        },
                        new
                        {
                            SpecialtyId = 4,
                            Name = "Endocrinology"
                        },
                        new
                        {
                            SpecialtyId = 5,
                            Name = "Family medicine"
                        },
                        new
                        {
                            SpecialtyId = 6,
                            Name = "Geriatrics"
                        },
                        new
                        {
                            SpecialtyId = 7,
                            Name = "Hematology"
                        },
                        new
                        {
                            SpecialtyId = 8,
                            Name = "Neurology"
                        },
                        new
                        {
                            SpecialtyId = 9,
                            Name = "Hematology"
                        },
                        new
                        {
                            SpecialtyId = 10,
                            Name = "Pathology"
                        },
                        new
                        {
                            SpecialtyId = 11,
                            Name = "Pediatrics"
                        },
                        new
                        {
                            SpecialtyId = 12,
                            Name = "Psychiatry"
                        },
                        new
                        {
                            SpecialtyId = 13,
                            Name = "Rheumatology"
                        },
                        new
                        {
                            SpecialtyId = 14,
                            Name = "Urology"
                        });
                });

            modelBuilder.Entity("ClinicManagement.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "f93f376e-0543-4073-aaf4-ceb2df8aac0b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                            EmailConfirmed = false,
                            FirstName = "Super",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedUserName = "SUPERUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==",
                            PhoneNumber = "111111111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                            TwoFactorEnabled = false,
                            UserName = "SuperUser"
                        },
                        new
                        {
                            Id = "40ae9fef-c94e-4823-a4da-bd1686467689",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                            EmailConfirmed = false,
                            FirstName = "Dean",
                            LastName = "Winchester",
                            LockoutEnabled = false,
                            NormalizedUserName = "DEANWINCHESTER",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==",
                            PhoneNumber = "999888777",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                            TwoFactorEnabled = false,
                            UserName = "deanWinchester"
                        },
                        new
                        {
                            Id = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                            EmailConfirmed = false,
                            FirstName = "Sam",
                            LastName = "Winchester",
                            LockoutEnabled = false,
                            NormalizedUserName = "SAMWINCHESTER",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==",
                            PhoneNumber = "789456123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                            TwoFactorEnabled = false,
                            UserName = "samWinchester"
                        },
                        new
                        {
                            Id = "80d10f83-f746-4397-a76f-fa2a216833bc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                            EmailConfirmed = false,
                            FirstName = "Castiel",
                            LastName = "Clarence",
                            LockoutEnabled = false,
                            NormalizedUserName = "CASTIELCLARENCE",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==",
                            PhoneNumber = "888567000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                            TwoFactorEnabled = false,
                            UserName = "castielClarence"
                        },
                        new
                        {
                            Id = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                            EmailConfirmed = false,
                            FirstName = "Bobby",
                            LastName = "Singer",
                            LockoutEnabled = false,
                            NormalizedUserName = "BOBBYSINGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==",
                            PhoneNumber = "555080911",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                            TwoFactorEnabled = false,
                            UserName = "bobbySinger"
                        },
                        new
                        {
                            Id = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                            EmailConfirmed = false,
                            FirstName = "Jody",
                            LastName = "Mills",
                            LockoutEnabled = false,
                            NormalizedUserName = "JODYMILLS",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==",
                            PhoneNumber = "776554112",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                            TwoFactorEnabled = false,
                            UserName = "jodyMills"
                        });
                });

            modelBuilder.Entity("ClinicManagement.Entities.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "f93f376e-0543-4073-aaf4-ceb2df8aac0b",
                            RoleId = "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b"
                        },
                        new
                        {
                            UserId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                            RoleId = "526fa4c0-f544-4ad0-9d31-0185533cdf48"
                        },
                        new
                        {
                            UserId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                            RoleId = "526fa4c0-f544-4ad0-9d31-0185533cdf48"
                        },
                        new
                        {
                            UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                            RoleId = "526fa4c0-f544-4ad0-9d31-0185533cdf48"
                        },
                        new
                        {
                            UserId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                            RoleId = "d428231e-4f51-4e41-913e-056f91346c16"
                        },
                        new
                        {
                            UserId = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                            RoleId = "d428231e-4f51-4e41-913e-056f91346c16"
                        });
                });

            modelBuilder.Entity("ClinicManagement.Entities.UserSpecialty", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "SpecialtyId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("UserSpecialties");

                    b.HasData(
                        new
                        {
                            UserId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                            SpecialtyId = 5
                        },
                        new
                        {
                            UserId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                            SpecialtyId = 5
                        },
                        new
                        {
                            UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                            SpecialtyId = 2
                        },
                        new
                        {
                            UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                            SpecialtyId = 13
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("ClinicManagement.Entities.Appointment", b =>
                {
                    b.HasOne("ClinicManagement.Entities.User", "Doctor")
                        .WithMany("AppointmentsDoc")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClinicManagement.Entities.User", "Patient")
                        .WithMany("AppointmentsPat")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicManagement.Entities.UserRole", b =>
                {
                    b.HasOne("ClinicManagement.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagement.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("ClinicManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagement.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClinicManagement.Entities.UserSpecialty", b =>
                {
                    b.HasOne("ClinicManagement.Entities.Specialty", "Specialty")
                        .WithMany("UserSpecialties")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagement.Entities.User", "Doctor")
                        .WithMany("UserSpecialties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ClinicManagement.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ClinicManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ClinicManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ClinicManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinicManagement.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ClinicManagement.Entities.Specialty", b =>
                {
                    b.Navigation("UserSpecialties");
                });

            modelBuilder.Entity("ClinicManagement.Entities.User", b =>
                {
                    b.Navigation("AppointmentsDoc");

                    b.Navigation("AppointmentsPat");

                    b.Navigation("UserRoles");

                    b.Navigation("UserSpecialties");
                });
#pragma warning restore 612, 618
        }
    }
}
