using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AppointmentViewModel
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DisplayName("Hour")]
        public string Hour { get; set; }

        [DisplayName("Patient")]
        public string PatientName { get; set; }

        public string PatientUserName { get; set; }

        [DisplayName("Doctor")]
        public string DoctorName { get; set; }

        public string DoctorUserName { get; set; }
    }
}
