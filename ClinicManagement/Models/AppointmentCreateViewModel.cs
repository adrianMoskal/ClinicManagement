using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AppointmentCreateViewModel
    {
        [Required]
        public string DoctorId { get; set; }

        [Required]
        public long SpecialtyId { get; set; }

        public SelectList Specialties { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public long HourId { get; set; }

        public DoctorViewModel Doctor { get; set; }

        public PatientViewModel Patient { get; set; }

        public SpecialtyViewModel Specialty { get; set; }

        public AvailableHourViewModel Hour { get; set; }
    }
}
