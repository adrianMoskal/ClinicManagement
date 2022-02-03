using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AppointmentViewModel
    {
        public DateTime Date { get; set; }

        [DisplayName("Patient")]
        public string PatientName { get; set; }

        [DisplayName("Doctor")]
        public string DoctorName { get; set; }
    }
}
