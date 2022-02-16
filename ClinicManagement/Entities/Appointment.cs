using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string PatientId { get; set; }
        public virtual User Patient { get; set; }
        public string DoctorId { get; set; }
        public virtual User Doctor { get; set; }
        public int AppointmentHourId { get; set; }
        public virtual AppointmentHour Hour { get; set; }
        public DateTime Date { get; set; }
    }
}
