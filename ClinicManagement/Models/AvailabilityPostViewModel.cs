﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AvailabilityPostViewModel
    {
        [Required]
        public string DoctorId { get; set; }

        public DoctorViewModel Doctor { get; set; }

        [Required]
        public long? SpecialtyId { get; set; }

        public SpecialtyViewModel Specialty { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Hour { get; set; }
        public AppointmentHourViewModel AppointmentHour { get; set; }
    }
}
