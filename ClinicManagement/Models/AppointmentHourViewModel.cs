using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AppointmentHourViewModel
    {
        public long HourId { get; set; }
        public string Hour { get; set; }
        public bool Availability { get; set; }
    }
}
