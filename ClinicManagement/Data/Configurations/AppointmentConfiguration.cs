using ClinicManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder
                .ToTable("Appointment");

            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .HasColumnName("AppointmentId");

            builder
                .HasOne(a => a.Doctor)
                .WithMany(u => u.AppointmentsDoc)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(a => a.Patient)
                .WithMany(u => u.AppointmentsPat)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(a => a.Hour)
                .WithMany(ah => ah.Appointments)
                .HasForeignKey(a => a.AppointmentHourId);
        }
    }
}
