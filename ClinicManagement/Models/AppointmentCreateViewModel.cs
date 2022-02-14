using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AppointmentCreateViewModel
    {
        public string DoctorId { get; set; }

        [DisplayName("Doctors")]
        public SelectList Doctors { get; set; }

        public int? SpecialtyId { get; set; }

        [DisplayName("Specialties")]
        public SelectList Specialties { get; set; }
    }
}
