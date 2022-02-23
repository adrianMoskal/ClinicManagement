using ClinicManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data.Configurations
{
    public class AppointmentHourConfiguration : IEntityTypeConfiguration<AppointmentHour>
    {
        public void Configure(EntityTypeBuilder<AppointmentHour> builder)
        {
            builder
                .ToTable("AppointmentHour");

            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .HasColumnName("AppointmentHourId");

            builder
                .HasIndex(a => a.Hour)
                .IsUnique();
        }
    }
}
