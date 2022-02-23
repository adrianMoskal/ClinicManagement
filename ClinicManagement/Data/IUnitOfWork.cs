using ClinicManagement.Entities;
using ClinicManagement.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<Appointment> Appointments { get; }
        IRepository<AppointmentHour> AppointmentHours { get; }
        IRepository<Specialty> Specialties { get; }
        IRepository<UserSpecialty> UserSpecialties { get; }
        void SaveChanges();
    }
}
