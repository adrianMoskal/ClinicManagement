using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class User : IdentityUser
    {
        public User() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<Appointment> AppointmentsDoc { get; set; } // For Doctors

        public virtual ICollection<Appointment> AppointmentsPat { get; set; } // For Patients
    }
}
