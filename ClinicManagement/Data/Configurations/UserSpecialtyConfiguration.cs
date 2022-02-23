using ClinicManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data.Configurations
{
    public class UserSpecialtyConfiguration : IEntityTypeConfiguration<UserSpecialty>
    {
        public void Configure(EntityTypeBuilder<UserSpecialty> builder)
        {
            builder
                .ToTable("UserSpecialty");

            builder
                .HasKey(s => s.Id);

            builder
                .Property(s => s.Id)
                .HasColumnName("UserSpecialtyId");

            builder
                .HasIndex(us => new { us.UserId, us.SpecialtyId })
                .IsUnique();
        }
    }
}