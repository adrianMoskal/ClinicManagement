using ClinicManagement.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement.Data
{
    public class ApplicationDbSeed
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                using (var transaction = context.Database.BeginTransaction())
                {
                    AddIdentityDummyData();
                    AddSpecialtiesDummyData();
                    AddUserSpecialtiesDummyData();
                    AddAppointmentHoursDummyData();
                    AddAppointmentsDummyData();
                    AddMedicinesDummyData();
                    AddPrescriptionsDummyData();

                    transaction.Commit();
                }

                void AddIdentityDummyData()
                {
                    #region Users

                    if (!context.Users.Any())
                    {
                        context.Users.AddRange(new List<User>()
                        {
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
                            },
                            new User
                            {
                                Id = "66e3848b-4df8-4b19-85a5-5a25ff052e82",
                                FirstName = "Garth",
                                LastName = "Fitzgerald",
                                UserName = "garthFitzgerald",
                                NormalizedUserName = "GARTHFITZGERALD",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", // Password = Admin1@
                                SecurityStamp = "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD",
                                ConcurrencyStamp = "003c3d02-b420-44f2-960c-02df61764c7a",
                                PhoneNumber = "121454678",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0
                            }
                        });
                    }

                    #endregion

                    #region Roles

                    if (!context.Roles.Any())
                    {
                        context.Roles.AddRange(new List<Role>()
                        {
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
                            },
                            new Role
                            {
                                Id = "9da0b3a8-c0ba-443a-a685-a548564620df",
                                Description = "Person who prepare and dispense medicines",
                                Name = "Pharmacist",
                                NormalizedName = "PHARMACIST",
                                ConcurrencyStamp = "2e5bcfa5-bce6-409a-b045-2ebe47106e29"
                            },
                            new Role
                            {
                                Id = "a16e0545-1976-4410-bf1c-26f1dba16996",
                                Description = "Person responsible for welcoming patients",
                                Name = "Receptionist",
                                NormalizedName = "RECEPTIONIST",
                                ConcurrencyStamp = "dfed40d4-6508-45f7-bbbc-b009667a080d"
                            }
                        });
                    }

                    #endregion

                    #region UserRoles

                    if (!context.UserRoles.Any())
                    {
                        context.UserRoles.AddRange(new List<UserRole>()
                        {
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
                            },
                            new UserRole
                            {
                                UserId = "66e3848b-4df8-4b19-85a5-5a25ff052e82",
                                RoleId = "9da0b3a8-c0ba-443a-a685-a548564620df"
                            }
                        });
                    }

                    #endregion

                    context.SaveChanges();
                }

                void AddSpecialtiesDummyData()
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Specialty ON;");

                    #region Specialties

                    if (!context.Set<Specialty>().Any())
                    {
                        context.Set<Specialty>().AddRange(new List<Specialty>()
                        {
                            new Specialty
                            {
                                Id = 1,
                                Name = "Allergy and immunology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 2,
                                Name = "Cardiology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 3,
                                Name = "Dermatology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 4,
                                Name = "Endocrinology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 5,
                                Name = "Family medicine",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 6,
                                Name = "Geriatrics",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 7,
                                Name = "Hematology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 8,
                                Name = "Neurology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 9,
                                Name = "Hematology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 10,
                                Name = "Pathology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 11,
                                Name = "Pediatrics",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 12,
                                Name = "Psychiatry",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 13,
                                Name = "Rheumatology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Specialty
                            {
                                Id = 14,
                                Name = "Urology",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            }
                        });
                    }

                    #endregion

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Specialty OFF;");
                }

                void AddUserSpecialtiesDummyData()
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.UserSpecialty ON;");

                    #region UserSpecialties

                    if (!context.Set<UserSpecialty>().Any())
                    {
                        context.Set<UserSpecialty>().AddRange(new List<UserSpecialty>()
                        {
                            new UserSpecialty
                            {
                                Id = 1,
                                UserId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                SpecialtyId = 5,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new UserSpecialty
                            {
                                Id = 2,
                                UserId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                                SpecialtyId = 5,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new UserSpecialty
                            {
                                Id = 3,
                                UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                                SpecialtyId = 2,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new UserSpecialty
                            {
                                Id = 4,
                                UserId = "80d10f83-f746-4397-a76f-fa2a216833bc",
                                SpecialtyId = 13,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            }
                        });
                    }

                    #endregion

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.UserSpecialty OFF;");
                }

                void AddAppointmentHoursDummyData()
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.AppointmentHour ON;");

                    #region AppointmentHours

                    if (!context.Set<AppointmentHour>().Any())
                    {
                        context.Set<AppointmentHour>().AddRange(new List<AppointmentHour>()
                        {
                            new AppointmentHour
                            {
                                Id = 1,
                                Hour = "8:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 2,
                                Hour = "8:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 3,
                                Hour = "9:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 4,
                                Hour = "9:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 5,
                                Hour = "10:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 6,
                                Hour = "10:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 7,
                                Hour = "11:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 8,
                                Hour = "11:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 9,
                                Hour = "12:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 10,
                                Hour = "12:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 11,
                                Hour = "13:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 12,
                                Hour = "13:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 13,
                                Hour = "14:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 14,
                                Hour = "14:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 15,
                                Hour = "15:00",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new AppointmentHour
                            {
                                Id = 16,
                                Hour = "15:30",
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            }
                        });
                    }

                    #endregion

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.AppointmentHour OFF;");
                }

                void AddAppointmentsDummyData()
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Appointment ON;");

                    #region Appointments

                    if (!context.Set<Appointment>().Any())
                    {
                        context.Set<Appointment>().AddRange(new List<Appointment>()
                        {
                            new Appointment
                            {
                                Id = 1,
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                AppointmentHourId = 5,
                                Date = DateTime.Now.AddDays(-5),
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Appointment
                            {
                                Id = 2,
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                AppointmentHourId = 2,
                                Date = DateTime.Now.AddDays(-3),
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Appointment
                            {
                                Id = 3,
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                DoctorId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                                AppointmentHourId = 7,
                                Date = DateTime.Now.AddDays(-1),
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            }
                        });
                    }

                    #endregion

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Appointment OFF;");
                }

                void AddMedicinesDummyData()
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Medicine ON;");

                    #region Medicine

                    if (!context.Set<Medicine>().Any())
                    {
                        context.Set<Medicine>().AddRange(new List<Medicine>()
                        {
                            new Medicine
                            {
                                Id = 1,
                                Name = "Medicine 1",
                                Price = 11.85,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Medicine
                            {
                                Id = 2,
                                Name = "Medicine 2",
                                Price = 4.22,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Medicine
                            {
                                Id = 3,
                                Name = "Medicine 3",
                                Price = 14.87,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Medicine
                            {
                                Id = 4,
                                Name = "Medicine 4",
                                Price = 5.88,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Medicine
                            {
                                Id = 5,
                                Name = "Medicine 5",
                                Price = 9.99,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Medicine
                            {
                                Id = 6,
                                Name = "Medicine 6",
                                Price = 12.20,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            }
                        });
                    }

                    #endregion

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Medicine OFF;");
                }

                void AddPrescriptionsDummyData()
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Prescription ON;");

                    #region Prescription

                    if (!context.Set<Prescription>().Any())
                    {
                        context.Set<Prescription>().AddRange(new List<Prescription>()
                        {
                            new Prescription
                            {
                                Id = 1,
                                Description = "Prescription for headache pills",
                                IsCollected = true,
                                ExpirationDate = DateTime.Now.AddDays(4),
                                CollectedDate = DateTime.Now.AddDays(-2),
                                DoctorId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                MedicineId = 5,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Prescription
                            {
                                Id = 2,
                                Description = "Prescription for stomach ache pills",
                                IsCollected = false,
                                ExpirationDate = DateTime.Now.AddDays(7),
                                CollectedDate = null,
                                DoctorId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                MedicineId = 2,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Prescription
                            {
                                Id = 3,
                                Description = "Prescription for fever pills",
                                IsCollected = false,
                                ExpirationDate = DateTime.Now.AddDays(6),
                                CollectedDate = null,
                                DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                MedicineId = 5,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Prescription
                            {
                                Id = 4,
                                Description = "Antibiotic for angina",
                                IsCollected = false,
                                ExpirationDate = DateTime.Now.AddDays(7),
                                CollectedDate = null,
                                DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                PatientId = "cc033eab-8a7e-4c70-8a87-1aee071141a4",
                                MedicineId = 6,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Prescription
                            {
                                Id = 5,
                                Description = "Aerosol for runny nose prescription",
                                IsCollected = true,
                                ExpirationDate = DateTime.Now.AddDays(9),
                                CollectedDate = DateTime.Now.AddDays(-1),
                                DoctorId = "40ae9fef-c94e-4823-a4da-bd1686467689",
                                PatientId = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                                MedicineId = 3,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Prescription
                            {
                                Id = 6,
                                Description = "Ointment for the back pain prescription",
                                IsCollected = false,
                                ExpirationDate = DateTime.Now.AddDays(2),
                                CollectedDate = null,
                                DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                PatientId = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                                MedicineId = 4,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                            new Prescription
                            {
                                Id = 7,
                                Description = "Prescription for sore throat syrup",
                                IsCollected = false,
                                ExpirationDate = DateTime.Now.AddDays(7),
                                CollectedDate = null,
                                DoctorId = "6ca24cbc-8085-475b-8bee-b3c09575561e",
                                PatientId = "0e8f52a7-172d-41ed-bfcc-6214feec8461",
                                MedicineId = 1,
                                CreateDate = DateTime.Now,
                                ModificationDate = null
                            },
                        });
                    }

                    #endregion

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Prescription OFF;");
                }
            }
        }
        
    }
}
