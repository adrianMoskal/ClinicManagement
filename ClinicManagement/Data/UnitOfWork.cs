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
            Appointments = new Repository<Appointment>(_context);
            AppointmentHours = new Repository<AppointmentHour>(_context);
            Specialties = new Repository<Specialty>(_context);
            UserSpecialties = new Repository<UserSpecialty>(_context);
        }

        public IRepository<Appointment> Appointments { get; }
        public IRepository<AppointmentHour> AppointmentHours { get; }
        public IRepository<Specialty> Specialties { get; }
        public IRepository<UserSpecialty> UserSpecialties { get; }
        public void SaveChanges()
        {
            _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
