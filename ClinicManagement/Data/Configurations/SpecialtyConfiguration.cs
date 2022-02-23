using ClinicManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data.Configurations
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder
                .ToTable("Specialty");

            builder
                .HasKey(s => s.Id);

            builder
                 .Property(s => s.Id)
                 .HasColumnName("SpecialtyId");

            builder
                .HasMany(s => s.UserSpecialties)
                .WithOne(us => us.Specialty)
                .HasForeignKey(us => us.SpecialtyId);
        }
    }
}
