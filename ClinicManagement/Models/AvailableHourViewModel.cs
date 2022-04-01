using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class AvailableHourViewModel
    {
        public long HourId { get; set; }
        public string Hour { get; set; }
        public bool Available { get; set; }
    }
}
