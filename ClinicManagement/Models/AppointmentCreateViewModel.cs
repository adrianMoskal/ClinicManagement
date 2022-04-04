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
        [Required(ErrorMessage = "Doctor is required")]
        public string DoctorId { get; set; }

        [Required(ErrorMessage = "Specialty")]
        public long SpecialtyId { get; set; }

        public SelectList Specialties { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Hour is required")]
        public long? HourId { get; set; }

        public DoctorViewModel Doctor { get; set; }

        public PatientViewModel Patient { get; set; }

        public SpecialtyViewModel Specialty { get; set; }

        public AvailableHourViewModel Hour { get; set; }
    }
}
