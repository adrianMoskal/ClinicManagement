using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class AppointmentHour
    {
        public int Id { get; set; }
        public string Hour { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
