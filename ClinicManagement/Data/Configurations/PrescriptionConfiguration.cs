using ClinicManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data.Configurations
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder
                .ToTable("Prescription");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("PrescriptionId");

            builder
                .HasOne(p => p.Doctor)
                .WithMany(u => u.PrescriptionsDoc)
                .HasForeignKey(p => p.DoctorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(p => p.Patient)
                .WithMany(u => u.PrescriptionsPat)
                .HasForeignKey(p => p.PatientId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(p => p.Medicine)
                .WithMany(m => m.Prescriptions)
                .HasForeignKey(p => p.MedicineId);
        }
    }
}
