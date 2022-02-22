using ClinicManagement.Entities;
using ClinicManagement.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IRepository<Appointment> Appointments;

        public IRepository<AppointmentHour> AppointmentHours;

        public IRepository<Specialty> Specialties;

        public IRepository<UserSpecialty> UserSpecialties;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
