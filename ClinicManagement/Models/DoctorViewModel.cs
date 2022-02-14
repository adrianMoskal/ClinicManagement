using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class DoctorViewModel
    {
        public string DoctorId { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }
        
        [DisplayName("Name")]
        public string FullName { get; set; }

        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }

        public string Specialties { get; set; }
    }
}
